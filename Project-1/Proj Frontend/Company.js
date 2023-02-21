// function getItems(){
    fetch('https://localhost:7031/api/Company/All')
    .then(res=>res.json())
    .then(data=>console.log(data))
    
        

    
    // .catch(error=>console.error('unable to get items',error));
// 

function Update(){
    let user=document.getElementById("usid").value
    let company=document.getElementById("c1").value
    let exp=document.getElementById("e1").value
    let pos=document.getElementById("p1").value

    fetch(`https://localhost:7031/api/Company/Modify/${user}`,{
        method:"PUT",
        body:JSON.stringify({
            user_Id:user,
            company_Name:company,
            experience_In_Years:exp,
            position:pos
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
    let company=document.getElementById("c1").value
    let exp=document.getElementById("e1").value
    let pos=document.getElementById("p1").value

    fetch(`https://localhost:7031/api/Company/Add`,{
        method:"POST",
        body:JSON.stringify({
            company_Name:company,
            experience_In_Years:exp,
            position:pos
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
            alert("wanna retry?");
        }
    })
}
