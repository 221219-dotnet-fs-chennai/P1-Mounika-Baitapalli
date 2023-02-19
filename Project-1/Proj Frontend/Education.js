// function getItems(){
    fetch('https://localhost:7031/api/Education/All')
    .then(res=>res.json())
    .then(data=>console.log(data));
    //.catch(error=>console.error('unable to get items.',error));
        
    // }

    function Update(){
        let user=document.getElementById("usd").value
        let instit=document.getElementById("i1").value
        let deg=document.getElementById("d1").value
        let specia=document.getElementById("s1").value
        let year=document.getElementById("y1").value

        fetch(`https://localhost:7031/api/Education/modify/${user}`,{
            method:"PUT",
            body:JSON.stringify({
                user_Id:user,
                institution:instit,
                degree:deg,
                specialization:specia,
                year_Of_Passing:year
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
            else{
                alert("try again");
            }
        })
    }

    function Add(){
        let instit=document.getElementById("i1").value;
        let deg=document.getElementById("d1").value;
        let specia=document.getElementById("s1").value;
        let year=document.getElementById("y1").value;
        fetch(`https://localhost:7031/api/Education/Add`,{
            method:"POST",
            body:JSON.stringify({
                institution:instit,
                degree:deg,
                specialization:specia,
                year_Of_Passing:year
            }),
            headers:{
                'Accept': 'application/json',
                "Content-type":"application/json;charset=UTF-8",
                
            },
    
        })
        .then((Response)=>{
            if(Response.status===200){
                alert("successfully added");
                window.location.href='welcomepage.html';
            }
            else{
                   alert("Retry?");
            }
        })
    }

