using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEnterprise_mssql.Api.Dtos;
using WebEnterprise_mssql.Api.Models;
using WebEnterprise_mssql.Api.Repository;

//    DATE           NAME      TODO
//   4/1/2022        Ngoc      use Repo(update,delete,create,getlist) instead of linQ
//   
//=============================================================================================

namespace WebEnterprise_mssql.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")] // /api/comments
    public class CommentsController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IRepositoryWrapper repo;

        public CommentsController(
            IMapper mapper,
            UserManager<ApplicationUser> userManager,
            IRepositoryWrapper repo
        )
        {
            this.userManager = userManager;
            this.repo = repo;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("AllComments")]
        public async Task<List<ParentItemDto>> GetAllComment(string PostId)
        {
            // var listParent = await context.Comments
            //     .Where(x => x.PostId.Equals(PostId))
            //     .Where(x => x.IsChild.Equals(false))
            //     .ToListAsync();
            var listParent = await repo.Comments.GetListParentAsync(PostId);

            var resultList = new List<ParentItemDto>();
            foreach (var parent in listParent)
            {
                if (parent.IsChild.Equals(false))
                {
                    var newParent = await GetChildrenToParent(parent.CommentId.ToString());
                    var user = await userManager.FindByIdAsync(parent.userId);
                    newParent.Username = user.UserName;
                    resultList.Add(newParent);
                }
            }
            return resultList;
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBtnClick(DeleteCommentDto dto)
        {
            if (await IsPassDeadline(dto.PostId))
            {
                return BadRequest("Cannot delete comments after final closure date");
            }
            var parent = await GetChildrenToParent(dto.commentId.ToString());

            if (parent.childItems.Count().Equals(0))
            {
                try
                {
                    DeleteComment(parent.CommentId);
                }
                catch (System.Exception ex)
                {
                    return new JsonResult($"Error Message: {ex}") {StatusCode = 500};
                }
            }
            else
            {
                try
                {
                    DeleteRangeComment(parent.CommentId);
                    DeleteComment(parent.CommentId);
                }
                catch (System.Exception ex)
                {
                    return new JsonResult($"Error Message: {ex}") {StatusCode = 500};
                }
            }

            return RedirectToAction(nameof(GetAllComment), new { dto.PostId });
        }

        [HttpPut]
        public async Task<IActionResult> UpdateComment(CommentDto dto)
        {
            // var existingComment = await context.Comments
            //      .Where(x => x.CommentId == Guid.Parse(CommentDto.PreviousCommentId))
            //      .FirstOrDefaultAsync();
            var existingComment = await repo.Comments.GetComments(Guid.Parse(dto.PreviousCommentId));

            existingComment = mapper.Map<Comments>(dto);
            existingComment.LastModifiedDate = DateTimeOffset.UtcNow;

            if (await IsPassDeadline(dto.PostId))
            {
                return BadRequest("No more comment can be update to this post after final closure date");
            }
            else
            {
                try
                {
                    //context.Comments.Update(existingComment);
                    repo.Comments.Update(existingComment);
                    repo.Save();
                    return RedirectToAction(nameof(GetAllComment), new { dto.PostId });
                }
                catch (Exception ex)
                {
                    return new JsonResult($"Error Message: {ex}") {StatusCode = 500};
                }
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddCommentAsync(CommentDto dto)
        {
            var newComment = mapper.Map<Comments>(dto);
            newComment.CreatedDate = DateTimeOffset.UtcNow;

            if (await IsPassDeadline(dto.PostId))
            {
                return BadRequest("No more comment can be added to this post after final closure date");
            }
            else
            {
                try
                {
                    // await context.Comments.AddAsync(newComment);
                    repo.Comments.Create(newComment);
                    repo.Save();
                    return RedirectToAction(nameof(GetAllComment), new { dto.PostId });
                }
                catch (Exception ex)
                {
                    return new JsonResult($"Error message: {ex}") {StatusCode = 500};
                }
            }
        }

        private async Task<bool> IsPassDeadline(string postId)
        {
            var topicId = await repo.Posts
                .FindByCondition(x => x.PostId.Equals(Guid.Parse(postId)))
                .Select(x => x.TopicId)
                .FirstOrDefaultAsync();
            var finalClosureDate = await repo.Topics
                .FindByCondition(x => x.TopicId.Equals(topicId))
                .Select(x => x.FinalClosureDate)
                .FirstOrDefaultAsync();
            if (DateTimeOffset.UtcNow >= finalClosureDate)
            {
                return true;
            }
            return false;
        }

        private async void DeleteRangeComment(Guid parentId)
        {
            // var childrenCommentArray = await context.Comments.Where(x => x.ParentId.Equals(parentId)).ToArrayAsync();
            var childrenCommentArray = await repo.Comments.GetListChildrenByParentIdAsync(parentId);

            // context.Comments.RemoveRange(childrenCommentArray);
            repo.Comments.DeleteListChildren(childrenCommentArray);
            repo.Save();
        }
        private async void DeleteComment(Guid commentId)
        {
            // var existingComment = await context.Comments
            //     .Where(x => x.CommentId == commentId)
            //     .FirstOrDefaultAsync();
            var existingComment = await repo.Comments.GetComments(commentId);

            //context.Comments.Remove(existingComment);
            repo.Comments.Delete(existingComment);
            repo.Save();
        }

        private async Task<ParentItemDto> GetChildrenToParent(string ParentId)
        {
            // var parent = await context.Comments
            //     .Where(x => x.CommentId.Equals(Guid.Parse(ParentId)))
            //     .FirstOrDefaultAsync();
            var parent = await repo.Comments.GetParentByCommentIdAsync(ParentId);

            var parentDto = mapper.Map<ParentItemDto>(parent);

            // var ListChildren = await context.Comments
            //     .Where(x => x.ParentId.Equals(Guid.Parse(ParentId)))
            //     .ToListAsync();
            var ListChildren = await repo.Comments.GetListChildrenByParentIdAsync(Guid.Parse(ParentId));


            var newListChildren = new List<ChildItemDto>();
            foreach (var child in ListChildren)
            {
                var newChild = mapper.Map<ChildItemDto>(child);
                var user = await userManager.FindByIdAsync(child.userId);
                newChild.Username = user.UserName;
                newListChildren.Add(newChild);
            }
            parentDto.childItems = newListChildren;
            return parentDto;
        }
    }
}