function Add(){
    let abc=document.getElementById("trainerdetails");
    abc.addEventListener('click',(e)=>{
        e.preventDefault()
    })

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