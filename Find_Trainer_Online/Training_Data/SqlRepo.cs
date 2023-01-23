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


            string query = @"insert into Trainer_Details( Name, Age, Gender,EmailId,Password,Contact_Number,Location,SocialMedia_Profile) values (@Name, @Age, @Gender, @EmailId, @Password, @Contact_Number,@Location,@SocialMedia_Profile)";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@Name", details.Name);
            command.Parameters.AddWithValue("@Age", Convert.ToInt32(details.Age));
            command.Parameters.AddWithValue("@Gender", details.Gender);
            command.Parameters.AddWithValue("@EmailId", details.EmailId);
            command.Parameters.AddWithValue("@Password", details.Password);
            command.Parameters.AddWithValue("@Contact_Number", details.Contact_Number);
            command.Parameters.AddWithValue("@Location", details.Location);
            command.Parameters.AddWithValue("@SocialMedia_Profile", details.SocialMedia_Profile);
            command.ExecuteNonQuery();


            string query1 = @"insert into Skill_Set(Skill_1, Skill_2,Skill_3) values (@Skill_1, @Skill_2,@Skill_3)";
            SqlCommand command1 = new SqlCommand(query1, connection);


            command1.Parameters.AddWithValue("@Skill_1", details.Skill_1);
            command1.Parameters.AddWithValue("@Skill_2", details.Skill_2);
            command1.Parameters.AddWithValue("@Skill_3", details.Skill_3);

            command1.ExecuteNonQuery();

            string query2 = @"insert into Company_Details(Company_Name,Experience_In_Years,Position) values(@Company_Name,@Experience_In_Years, @Position)";
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
                command3.Parameters.AddWithValue("@Specialization", "Null");
            }
            else
            {
                command3.Parameters.AddWithValue("@Specialization", details.Specialization);
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
        public bool Tlogin(string EmailId)
        {
            string query1 = $"select EmailId from Trainer_Details where EmailId='{EmailId}';";
            using SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand command = new SqlCommand(query1, con);
            SqlDataReader readerfile = command.ExecuteReader();
            if (readerfile.Read())
            {
                readerfile.Close();
                Console.Write("Enter your Password: ");
                string Password = Console.ReadLine();
                string query2 = $"select Password from Trainer_Details where Password='{Password}';";
                SqlCommand Com1 = new SqlCommand(query2, con);
                using SqlDataReader readerfile1 = Com1.ExecuteReader();
                if (readerfile1.Read())
                {
                    Console.WriteLine("Successfully logged in");
                    Console.ReadLine();
                    return true;
                }
                else
                {
                    Console.WriteLine("You have entered a Wrong password");
                    readerfile1.Close();
                    return false;
                }
            }
            else
            {
                Console.WriteLine("data Not Found");
                Console.ReadLine();
                return false;
            }
        }
        public Details Get(string EmailId)
        {
            Details details = new Details();
            using SqlConnection con = new SqlConnection(connectionstring);
            con.Open();


            string query = $@" select User_Id from Trainers_Details where EmailId = '{EmailId}'; ";
            SqlCommand command1 = new SqlCommand(query, con);
            int User_Id = Convert.ToInt32(command1.ExecuteScalar());
            string query1 = $@" select * from Trainer_Details  where User_Id = '{User_Id}'; ";


            SqlCommand command2 = new SqlCommand(query1, con);
            

            SqlDataReader Readerobj1 = command2.ExecuteReader();
            while (Readerobj1.Read())
            {
                //details.User_Id = Readerobj1.GetInt32(0);
                details.Name = Readerobj1.GetString(1);
                details.Age = Readerobj1.GetInt32(2);
                details.Gender = Readerobj1.GetString(3);
                details.EmailId = Readerobj1.GetString(4);
                details.Password = Readerobj1.GetString(5);

               details.Contact_Number = Readerobj1.GetString(6);
                details.Location = Readerobj1.GetString(7);
                details.SocialMedia_Profile = Readerobj1.GetString(8);


            }
            Readerobj1.Close();


            string query2 = $@"select * from Skills where User_Id = '{User_Id}';";
            SqlCommand command3 = new SqlCommand(query2, con);
            
            SqlDataReader Readerobj2 = command3.ExecuteReader();
            while (Readerobj2.Read())
            {
                // details.User_Id = Readerobj2.GetInt32(0);
                details.Skill_1 = Readerobj2.GetString(1);
                details.Skill_2 = Readerobj2.GetString(2);
                details.Skill_3 = Readerobj2.GetString(3);
            }
            Readerobj2.Close();

           string query3 = $@"select * from Company_Details where User_Id = '{User_Id}';";
            SqlCommand command4 = new SqlCommand(query3, con);
            SqlDataReader Readerobj3 = command4.ExecuteReader();
            while (Readerobj3.Read())
            {
                //details.User_Id = Readerobj3.GetInt32(0);
                details.Company_Name = Readerobj3.GetString(1);
                details.Experience_In_Years = Readerobj3.GetString(2);
                details.Position = Readerobj3.GetString(3);

                Readerobj3.Close();

                
                string query4 = $@"select * from Education_Details where User_Id = '{User_Id}';";
                SqlCommand command5 = new SqlCommand(query4, con);
                SqlDataReader Readerobj4 = command5.ExecuteReader();
                while (Readerobj4.Read())
                {
                   // details.User_Id = Read4.GetInt32(0);
                    details.Institution = Readerobj4.GetString(1);
                    details.Degree = Readerobj4.GetString(2);
                    details.Specialization = Readerobj4.GetString(3);
                    details.Year_Of_Passing = Readerobj4.GetString(4);
                }
                Readerobj4.Close();


               

            }
            return details;
        }
    }
}



   
        


    


