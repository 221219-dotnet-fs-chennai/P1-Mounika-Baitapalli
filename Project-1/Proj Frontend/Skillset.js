
//const uri='https://localhost:7031/api/';
// function getItems() {
    // const uid=document.getElementById("uid");
    // const sk1=document.getElementById("sk1");
    // const sk2=document.getElementById("sk2");
    // const sk3=document.getElementById("sk3");


    // fetch('https://localhost:7031/api/Skill/All')
    //     .then(response => response.json())
    //      .then(data => console.log(data));
        // .then(data=>_display(data));
        //.catch(error => console.log('Unable to get items.', error));
// }
   

    //  const Add={
    //      skill_1:sk1,
    //      skill_2:sk2,
    //      skill_3:sk3
       
    //  };
    //  fetch('https://localhost:7031/api/Skill/Add',{
    //     method:'POST',
    //     headers:{
    //         'Content-Type':'application/json'
    //     },
    //     body:JSON.stringify(Add)
    // })
    //     .then(res=>res.json()).then(data => console.log(data));

      


        function Update(){
            let user=document.getElementById("uid").value
            let skill1=document.getElementById("sk1").value
            let skill2=document.getElementById("sk2").value
            let skill3=document.getElementById("sk3").value

            fetch(`https://localhost:7031/api/Skill/Modify/${user}`,{
                method:"PUT",
                body:JSON.stringify({
                    user_Id:user,
                    skill_1:skill1,
                    skill_2:skill2,
                    skill_3:skill3
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
                    alert("wanna retry>");
                }
            })
        }
        function Add(){
            let skill1=document.getElementById("sk1").value;
            let skill2=document.getElementById("sk2").value;
            let skill3=document.getElementById("sk3").value;
            fetch(`https://localhost:7031/api/Skill/Add`,{
                method:"POST",
                body:JSON.stringify({
                    skill_1:skill1,
                    skill_2:skill2,
                    skill_3:skill3
                }),
                headers:{
                    'Accept': 'application/json',
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
    // fetch('https://localhost:7031/api/Skill/Add', {
    //     method: 'POST',
    //     headers: {
    //         'Accept': 'application/json',
    //         'Content-Type': 'application/json'
    //     },
    //     body: JSON.stringify(item)
    // })
    //     .then(response => response.json()).then(data=>console.log(data))
    //     .then(() => {
    //         getItems();
    //         addNameTextbox.value = '';
    //     })
        // .catch(error => console.error('Unable to add item.', error));
