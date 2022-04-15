import React,{useState} from "react";
import "./ModalDepartmentIdea.css";



function ModalDepartmentIdea({ setOpenModalDepartmentIdea ,data }) {
  const [feadback,setfeadback]=useState('')

  const Approcepost = () => {
    var myHeaders = new Headers();
    myHeaders.append("Authorization", "Bearer " + localStorage.getItem("accessToken"));
    myHeaders.append("Content-Type", "application/json");

    var raw = JSON.stringify({
      "postId": data.postId,
      "feedback": feadback,
      "isApproved": true
    });
    var requestOptions = {
      method: 'POST',
      headers: myHeaders,
      body: raw,
      redirect: 'follow'
    };

    fetch("https://localhost:5001/api/Posts/QACfeedback", requestOptions)
      .then(response => response.text())
      .then(result => {
        console.log(result)
      alert('Approve success')
    })
      .catch(error => console.log('error', error));
  }
  return (
    <div className="modalBackground">
      <div className="modalPostContainer">
        <div className="titleCloseBtn">
          <a className="xbtn" onClick={() => {setOpenModalDepartmentIdea(false);}} > X </a>
        </div>
        <header>
        <link href='https://unpkg.com/boxicons@2.1.2/css/boxicons.min.css' rel='stylesheet'/>
        <div className="header_posts">
        <i className='bx bx-user-circle icon'></i>
            <div className="userposts_name">
                <span className="name_userposts">{data.username}</span>
                <div className='day'>
                    <div className='day-sumit' type = "date" >{data.createdDate}</div>
                </div>
            </div>   
        </div>
        </header>
        <div className="Category">
        <span className="TopicName">{data.categoryId}</span>
        </div>
        <div className="TitlePost">
        <p className="TopicName">Title : {data.title}</p>
        
        </div>
        {/* <div className="ex1">This is title</div> */}
        <div className="Content">
        <span className="TopicName">Content : {data.content}</span>
        </div>
        <div className="Desc">
        <span className="TopicName">Description : {data.desc}</span>
        
        
        <div className='showselectModal'>
            <select name="show" id="showid">
                <option value="Default">Choose your type of comments</option>
                <option value="Public">Public</option>
                <option value="Anonymously">Anonymously</option>
            </select>
            </div>
        </div>

        <div className="Modalfooter">
        <button className="SubmitBtn" onClick={Approcepost}>Approve</button>
          <button className="cancelBtn" onClick={() => {setOpenModalDepartmentIdea(false);}} id="cancelBtn">Reject</button>
        </div>

        {/* <div className="modaltitle">TERMS AND POLICIES</div> */}
        <div className="modalInput">
            <textarea  className="Commentbox" value={feadback} onChange={e => setfeadback(e.target.value)}>Write your comments here...</textarea>
        </div>

        
        
        
      </div>
    // </div>
  );
}

export default ModalDepartmentIdea;