function Delete(){
    let user=document.getElementById("usd").value;
    let nam=document.getElementById("iname").value;
    let ag=document.getElementById("ag").value;
    let gend=document.getElementById("g1").value;
    let em=document.getElementById("e1").value;
    let pas=document.getElementById("pass").value;
    let cn=document.getElementById("c1").value;
    let lc=document.getElementById("l1").value;
    let social=document.getElementById("spf").value;
    let ins=document.getElementById("i2").value;
    let degr=document.getElementById("d2").value;
    let spe=document.getElementById("s2").value;
    let year=document.getElementById("y2").value;
    let skill1=document.getElementById("sk1").value;
    let skill2=document.getElementById("sk2").value;
    let skill3=document.getElementById("sk3").value;
    let company=document.getElementById("c1").value;
    let exp=document.getElementById("e1").value;
    let pos=document.getElementById("p1").value;
    fetch(`https://localhost:7031/api/Trainer/Delete/UserId?User_Id=${user}`,{
        method:"Delete",body:Json.stringify({
            user_Id:user,
            name:nam,
            age:ag,
            gender:gend,
            emailId:em,
            password:pas,
            contact_Number:cn,
            location:lc,
            socialMedia_Profile:social,
            institution:ins,
            degree:degr,
            specialization:spe,
            year_Of_Passing:year,
            skill_1:skill1,
            skill_2:skill2,
            skill_3:skill3,
            company_Name:company,
            experience_In_Years:exp,
            position:pos,
        }).then((Response)=>{
            if(Response.status===200){
                alert("successfully deleted");
                window.location.href='welcome.html';
            }
            else{
                alert("Wanna Retry?");
            }
        })
    })
}