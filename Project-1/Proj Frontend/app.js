const sign_in_btn = document.querySelector("#sign-in-btn");
const sign_up_btn = document.querySelector("#sign-up-btn");
const container = document.querySelector(".container");

sign_up_btn.addEventListener("click", () => {
  container.classList.add("sign-up-mode");
});

sign_in_btn.addEventListener("click", () => {
  container.classList.remove("sign-up-mode");
});
 
function Login(){
  const id=document.getElementById("sub").addEventListener('click',function(event){
    event.preventDefault();
    var email=document.getElementById("email").value;
    var password=document.getElementById("pass").value;
    fetch(`https://localhost:7031/api/Trainer/Login?EmailId=${email}&Password=${password}`,{
      method:'Get',
      headers:{
        'Content-type':'application/json',
        'EmailId':email,
      'Password':password
      }
  
    }).then(response=>{
        if(response.status===200){
          localStorage.setItem('EmailId',email);
          alert("Successfully Logged in");
          window.location.href='Education.html';
        }
        else{
          alert("Login Failed,please try again");
        }
    })
  
  });
}

// function getItems(){
  // fetch('https://localhost:7031/api/Trainer/all')
  // .then(response=>response.json())
  // .then(data=>console.log(data));
  //.catch(error=>console.error('unable to get items',error));
// }

// fetch('https://localhost:7031/api/Trainer/Delete/UserId?User_Id=2',{method:Delete"}
//      .headers('Content-type:application/json'))

function Update(){
  let user=document.getElementById("udid").value
  let nam=document.getElementById("iname").value
  let ag=document.getElementById("ag").value
  let gend=document.getElementById("g1").value
  let em=document.getElementById("e1").value
  let pas=document.getElementById("pass").value
  let cn=document.getElementById("c1").value
  let lc=document.getElementById("l1").value
  let social=document.getElementById("spf").value

  fetch(`https://localhost:7031/api/Trainer/Modify/${user}`,{
      method:"PUT",
      body:JSON.stringify({
          user_Id:user,
          name:nam,
          age:ag,
          gender:gend,
          emailId:em,
          password:pas,
          contact_Number:cn,
          location:lc,
          socialMedia_Profile:social
        }),
        headers:{
            "Content-type":"application/json;charset=UTF-8",
            
        },

  })
  .then((Response)=>{
      if(Response.status===200){
          alert("successfully updated");
          window.location.href='welcomepage.html';
      }
  })
}

function Add(){
  let nam=document.getElementById("iname").value;
  let ag=document.getElementById("ag").value;
  let gend=document.getElementById("g1").value;
  let em=document.getElementById("e1").value;
  let pas=document.getElementById("pass").value;
  let cn=document.getElementById("c1").value;
  let lc=document.getElementById("l1").value;
  let social=document.getElementById("spf").value;

  fetch(`https://localhost:7031/api/Trainer/Add`,{
      method:"POST",
      body:JSON.stringify({
          name:nam,
          age:ag,
          gender:gend,
          emailId:em,
          password:pas,
          contact_Number:cn,
          location:lc,
          socialMedia_Profile:social
        }),
        headers:{
            "Content-type":"application/json;charset=UTF-8",
            
        },

  })
  .then((Response)=>{
      if(Response.status===200){
          alert("successfully Added");
          window.location.href='welcomepage.html';
      }
      else{
        alert("wanna retry");
      }
  })
}
     
