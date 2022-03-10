using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebEnterprise_mssql.Models 
{
    public record Posts
    {   
        [KeyAttribute]
        public Guid id { get; set; }
        public string title { get; set; }
        public string Desc { get; set; }
        public string content { get; set; }
        public DateTimeOffset createdDate { get; set; }
        public DateTimeOffset LastModifiedDate { get; set; }
        public int ViewsCount { get; set; } 

        
        
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("Posts")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        public Guid? CatogoriesId { get; set; }
        public virtual Categories Categories { get; set; }

        public Guid? SubmissionsId { get; set; }
        public virtual Submissions Submissions { get; set; }

        public Guid? ViewsId { get; set; }
        public virtual Views Views { get; set; }

        public ICollection<Comments> Comments { get; set; }
        public ICollection<FilesPath> filesPaths { get; set; }
    }
}

    // ID_IDEA int,
    // TITLE NVARCHAR(100),
    // DESCRIPTION NVARCHAR(100),
    // CONTENT NVARCHAR(100),
    // CREATED_DATE NVARCHAR(100),
    // LAST_MODIFIED_DATE DATETIME,
    // VIEW_COUNT INT,
    // USER_ID INT,
    // CATEGORY_ID INT,
    // SUBMISSION_ID INT