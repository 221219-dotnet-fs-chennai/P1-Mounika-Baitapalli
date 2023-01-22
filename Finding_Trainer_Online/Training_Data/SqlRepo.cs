using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Trainer_Data
{
   
        public class SqlRepo : ISqlRepo
        {
            private readonly string connectionstring;

            public SqlRepo(string connectionstring)
            {
                this.connectionstring = connectionstring;
            }
            public Details Add(Details details)
            {

                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();

                
                string query = @"insert into Trainer_Details(User_Id, Name, Age, Gender,EmailId,Password,Contact_Number,Location,Website) values (@User_Id,@Name, @Age, @Gender, @EmailId, @Password, @Contact_Number,@Location,@Website)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@User_Id", details.User_Id);
                command.Parameters.AddWithValue("@Name", details.Name);
                command.Parameters.AddWithValue("@Age", Convert.ToInt32(details.Age));
                command.Parameters.AddWithValue("@Gender", details.Gender);
                command.Parameters.AddWithValue("@EmailId", details.EmailId);
                command.Parameters.AddWithValue("@Contact_Number", details.Contact_Number);
                command.Parameters.AddWithValue("@Location", details.Location);
                command.Parameters.AddWithValue("@Website", details.Website);                
                command.ExecuteNonQuery();


                string query1 = @"insert into Skill_Set(User_Id, Skill_1, Skill_2,Skill_3) values (@User_Id, @Skill_1, @Skill_2,@Skill_3)";
                SqlCommand command1 = new SqlCommand(query1, connection);

                command1.Parameters.AddWithValue("@User_Id", details.User_Id);
                command1.Parameters.AddWithValue("@Skill_1", details.Skill_1);
                command1.Parameters.AddWithValue("@Skill_2", details.Skill_2);
                command1.Parameters.AddWithValue("@Skill_3", details.Skill_3);

                command1.ExecuteNonQuery();

                string query2 = @"insert into Company_Details(User_Id,Company_Name,Experience_In_Years,Position) values(@User_Id,@Company_Name,@Experience_In_Years, @Position)";
                SqlCommand command2 = new SqlCommand(query2, connection);


               
                if (string.IsNullOrEmpty(details.Company_Name))
                {
                    command2.Parameters.AddWithValue("@Company_Name", "Null");
                }
                else
                {
                    command2.Parameters.AddWithValue("@Company_Name", details.Company_Name);
                }
                
        
                if (string.IsNullOrEmpty(details.Experience_In_Years))
                {
                    command2.Parameters.AddWithValue("@Experience_In_Years", "Null");
                }
                else
                {
                    command2.Parameters.AddWithValue("@Experience_In_Years", details.Experience_In_Years);
                }

                if (string.IsNullOrEmpty(details.Position))
                {
                    command2.Parameters.AddWithValue("@Position", "Null");
                }
                else
                {
                    command2.Parameters.AddWithValue("@Position", details.Position);
                }

                command2.ExecuteNonQuery();

                string query3 = @"insert into Education_Details( Institution, Degree, Specialization ,Year_Of_Passing) values ( @Institution, @Degree, @Specialization, @Year_Of_Passing)";
                SqlCommand command3 = new SqlCommand(query3, connection);

                
                if (string.IsNullOrEmpty(details.Institution))
                {
                    command3.Parameters.AddWithValue("@Institution", "Null");
                }
                else
                {
                    command3.Parameters.AddWithValue("@Institution", details.Institution);
                }
                if (string.IsNullOrEmpty(details.Degree))
                {
                    command3.Parameters.AddWithValue("@Degree", "Null");
                }
                else
                {
                    command3.Parameters.AddWithValue("@Degree", details.Degree);
                }
                if (string.IsNullOrEmpty(details.Specialization))
                {
                    command3.Parameters.AddWithValue("@Specialization)", "Null");
                }
                else
                {
                    command3.Parameters.AddWithValue("@Specialization)", details.Specialization);
                }
                if (string.IsNullOrEmpty(details.Year_Of_Passing))
                {
                    command3.Parameters.AddWithValue("@Year_Of_Passing", "Null");
                }
                else
                {
                    command3.Parameters.AddWithValue("@Year_Of_Passing", details.Year_Of_Passing);
                }              

                command3.ExecuteNonQuery();

                Console.WriteLine("row(s)  successfully added");
                Console.ReadLine();

                return details;
            }

        }
    }


