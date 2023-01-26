create table Trainer_Details(User_Id int PRIMARY KEY,Name VARCHAR(45), Age int ,Gender VARCHAR(MAX),EmailID VARCHAR(MAX),Password varchar(200),Contact_Number VARCHAR(10),Location VARCHAR(30),Website varchar(30));

create table Education_Details(User_Id int PRIMARY Key,Institution VARCHAR(30),Degree VARCHAR(10),Specialization VARCHAR(20),Year_Of_Passing int,CONSTRAINT [FK-Education_details] FOREIGN Key(User_Id) REFERENCES Trainer_Details(User_Id) ON DELETE CASCADE ON UPDATE CASCADE);

create table Skill_Set(User_Id int PRIMARY Key,Skill_1 VARCHAR(10),Skill_2 VARCHAR(10),Skill_3 VARCHAR(10),CONSTRAINT [FK-Skill_Set] FOREIGN KEY(User_Id) REFERENCES Trainer_Details(User_Id) ON DELETE CASCADE ON UPDATE CASCADE);

CREATE TABLE Company_Details(User_Id int PRIMARY  KEY,Company_Name varchar(30),Experience_In_Years VARCHAR(25),Position VARCHAR(25),Constraint [Fk_CompanyDetails] FOREIGN KEY(User_Id) REFERENCES Trainer_Details(User_Id) ON DELETE CASCADE ON UPDATE CASCADE);


drop table Trainer_Details;
drop table Education_Details;
drop table Company_Details;
drop table Skill_Set;

select *  from Trainer_Details;
select * from Skill_Set;
select * from Company_Details;
select * from Education_Details;

/*inserting values into Trainer_Details: */
insert into Trainer_Details(User_Id,Name,Age,Gender,EmailID,Password,Contact_Number,Location,Website)values(1,'Mounika',21,'Female','mounika@yahoo.com','mounika@123',8787656543,'Chittoor','www.mona.com');
insert into Trainer_Details(User_Id,Name,Age,Gender,EmailID,Password,Contact_Number,Location,Website)values(2,'Jessy',22,'Male','Jessy@yahoo.com','Jessy@123',9987654213,'Ongole','www.jessydance_school.com');
insert into Trainer_Details(User_Id,Name,Age,Gender,EmailID,Password,Contact_Number,Location,Website)values(3,'Ram',23,'Male','Ram@gmail.com','Ram@123',8899432165,'Bangalore','www.ramsinger.com');

/*inserting values into Skill_Set: */
insert into Skill_Set(User_Id,Skill_1,Skill_2,Skill_3)values(1,'Python','Mysql','Azure');
insert into Skill_Set(User_Id,Skill_1,Skill_2,Skill_3)values(2,'Java','oracle','cloud');
insert into Skill_Set(User_Id,Skill_1,Skill_2,Skill_3)values(3,'C#','Sql_Server','Hibernate');

/*inserting values into Company_Details: */

insert into Company_Details(User_Id,Company_Name,Experience_In_Years,Position)values(1,'CitiusTech','1-Year','Software Engineer');
insert into Company_Details(User_Id,Company_Name,Experience_In_Years,Position)values(2,'TCS','1.5-Years','Software Developer');
insert into Company_Details(User_Id,Company_Name,Experience_In_Years,Position)values(3,'Infosys','2-years','Analyst');

/*inserting values into Education_Details: */

insert into Education_Details(User_Id,Institution,Degree,Specialization,Year_Of_Passing)values(1,'Rgukt-Ongole','B-tech','ECE',2022);
insert into Education_Details(User_Id,Institution,Degree,Specialization,Year_Of_Passing)values(2,'IIT-madras','B-tech','Cs',2021);
insert into Education_Details(User_Id,Institution,Degree,Specialization,Year_Of_Passing)values(3,'IIt-Delhi','B-Tech','CS',2019);

alter table Trainer_Details Alter column User_Id Int;