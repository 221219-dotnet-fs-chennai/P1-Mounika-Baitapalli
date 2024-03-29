﻿using Serilog;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Xml.Linq;

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


            string query = $@" select User_Id from Trainer_Details where EmailId = '{EmailId}'; ";
            SqlCommand command1 = new SqlCommand(query, con);
            int User_Id = Convert.ToInt32(command1.ExecuteScalar());
            string query1 = $@" select * from Trainer_Details  where User_Id = '{User_Id}'; ";


            SqlCommand command2 = new SqlCommand(query1, con);


            SqlDataReader Readerobj1 = command2.ExecuteReader();
            while (Readerobj1.Read())
            {
                details.User_Id = Readerobj1.GetInt32(0);
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

            string query2 = $@"select * from Skill_Set where User_Id = '{User_Id}';";
            SqlCommand command3 = new SqlCommand(query2, con);

            SqlDataReader Readerobj2 = command3.ExecuteReader();
            while (Readerobj2.Read())
            {
                details.User_Id = Readerobj2.GetInt32(0);
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
                details.User_Id = Readerobj3.GetInt32(0);
                details.Company_Name = Readerobj3.GetString(1);
                details.Experience_In_Years = Readerobj3.GetString(2);
                details.Position = Readerobj3.GetString(3);
             }
                Readerobj3.Close();


                string query4 = $@"select * from Education_Details where User_Id = '{User_Id}';";
                SqlCommand command5 = new SqlCommand(query4, con);
                SqlDataReader Readerobj4 = command5.ExecuteReader();
                while (Readerobj4.Read())
                {
                     details.User_Id = Readerobj4.GetInt32(0);
                    details.Institution = Readerobj4.GetString(1);
                    details.Degree = Readerobj4.GetString(2);
                    details.Specialization = Readerobj4.GetString(3);
                    details.Year_Of_Passing = Readerobj4.GetString(4);
                }
                Readerobj4.Close();
            
            return details;
        }
        public void TUpdate(string tableName, string columnName, string newValue, int User_Id)
        {
            Details details = new Details();
            using SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
                if (tableName == "Trainer_Details")
                {
                    if (columnName == "Age")
                    {
                        int newvalue = Convert.ToInt32(newValue);
                        string query = $"UPDATE {tableName} SET {columnName} = '{newvalue}' WHERE User_Id = '{User_Id}'";
                        SqlCommand command1 = new SqlCommand(query, con);
                        Log.Information($"{User_Id} is this");
                        command1.ExecuteNonQuery();
                        Console.WriteLine("Data updated");
                    }
                    else
                    {
                        string query = $"UPDATE {tableName} SET {columnName} = '{newValue}' WHERE User_Id = '{User_Id}'";
                        SqlCommand command1 = new SqlCommand(query, con);
                        command1.ExecuteNonQuery();
                        Console.WriteLine("Data updated");
                    }
                }
                else
                {
                    string query = $"UPDATE {tableName} SEt {columnName} = '{newValue}' WHERE User_Id = '{User_Id}'";
                    SqlCommand command1 = new SqlCommand(query, con);
                    command1.ExecuteNonQuery();
                    Console.WriteLine("Data updated");
                }
                Console.WriteLine("The Data have been updated Successfully");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void TDelete(string column, string table, int User_Id)

        {
            Details details = new Details();
            using SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            try
            {

                if (column == "Age")
                {
                    string query = $"UPDATE {table} set {column} = 0 where user_id = '{User_Id}';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string query = $"UPDATE {table} set {column} = 'Null' where user_id = '{User_Id}';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("The Data  which you wish to delete,deleted successfully_________");
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}" + ex.Message);
            }

        }

        public List<Details> GetTrainersList()
        {
            List<Details> details = new List<Details>();
            
            using SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = $@"select User_Id , Name, Age, Gender, EmailId,Password,Contact_Number,Location,SocialMedia_Profile from Trainer_Details";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                details.Add(new Details()
                {

                    User_Id = (int)dr["User_Id"],
                    Name = (string)dr["Name"],
                    Age = (int)dr["Age"],
                    Gender = (string)dr["Gender"],
                    EmailId = (string)dr["EmailId"],
                    Password = (string)dr["Password"],
                    Contact_Number = (string)dr["Contact_Number"],
                    Location = (string)dr["Location"],
                    SocialMedia_Profile = (string)dr["SocialMedia_Profile"],

                }); ;
            }
            return details;
        }
    }
}
















/* public Details GetAllTrainer(string email)
 {
     Details detail = new Details();

     SqlConnection con = new SqlConnection(connectionstring);
     con.Open();
     //List<Details> details = new List<Details>();

     try
     {

         string query = $@"Select * from Trainer_Detailes where Email = '{email}' ";
         SqlCommand command = new SqlCommand(query, con);
         SqlDataReader reader = command.ExecuteReader();

         while (reader.Read())
         {

             detail.user_id = reader.GetInt32(0);
             detail.Email = reader.GetString(2);
             detail.Full_name = reader.GetString(1);
             detail.Age = reader.GetInt32(3);
             detail.Gender = reader.GetString(4);
             detail.Mobile_number = reader.GetString(5);
             detail.Website = reader.GetString(6);
             detail.PASSWORD = reader.GetString(7);
         }
         reader.Close();


         string query1 = $"select user_id From Trainer_Detailes where Email = '{email}';";
         SqlCommand command2 = new SqlCommand(query1, con);
         int user_id = (int)command2.ExecuteScalar();

         string query2 = $@"Select * from Skills where user_id = {user_id} ";
         SqlCommand command3 = new SqlCommand(query2, con);
         SqlDataReader reader2 = command3.ExecuteReader();

         while (reader2.Read())
         {
             detail.user_id = reader2.GetInt32(0);
             detail.Skill_name = reader2.GetString(1);
             detail.Skill_Type = reader2.GetString(2);
             detail.Skill_Level = reader2.GetString(3);

         }
         reader2.Close();

         string query3 = $@"Select * from Company where user_id = {user_id} ";
         SqlCommand command4 = new SqlCommand(query3, con);
         SqlDataReader reader3 = command4.ExecuteReader();

         while (reader3.Read())
         {
             detail.user_id = reader3.GetInt32(0);
             detail.Company_name = reader3.GetString(1);
             detail.Company_type = reader3.GetString(2);
             detail.Experience = reader3.GetString(3);
             detail.Company_Description = reader3.GetString(4);
         }
         reader3.Close();

         string query4 = $@"Select * from Education_Details where user_id = {user_id} ";
         SqlCommand command5 = new SqlCommand(query4, con);
         SqlDataReader reader4 = command5.ExecuteReader();

         while (reader4.Read())
         {
             detail.user_id = reader4.GetInt32(0);
             detail.Highest_Graduation = reader4.GetString(1);
             detail.Institute = reader4.GetString(2);
             detail.Department = reader4.GetString(3);
             detail.Start_year = reader4.GetString(4);
             detail.End_year = reader4.GetString(5);
         }
         reader4.Close();
     }
     catch (SqlException ex)
     {
         System.Console.WriteLine(ex.Message);
         throw;
     }
     return detail;
 }


     /*public List<Details> GetAllTrainersDisconnected()
     {
         List<Details> details = new List<Details>();

         SqlConnection con = new SqlConnection(connectionString);

         string query5 = @"Select Trainer_Detailes.user_id, Trainer_Detailes.Full_name, Trainer_Detailes.Email, Trainer_Detailes.Age, Trainer_Detailes.Gender, 
     Trainer_Detailes.Mobile_number, Trainer_Detailes.Website, Education_Details.Highest_Graduation, Education_Details.Institute, 
     Education_Details.Department, Education_Details.Start_year, Education_Details.End_year, Skills.Skill_name, Skills.Skill_Type,Skills.Skill_Level,
     Company.Company_name, Company.Company_type, Company.Experience, Company.Company_Description From Trainer_Detailes
     join Education_Details on Trainer_Detailes.user_id = Education_Details.user_id
     join Skills on Education_Details.user_id = Skills.user_id
     join Company on Skills.user_id = Company.user_id;";

         SqlDataAdapter adapter = new SqlDataAdapter(query5, con);

         DataSet ds = new DataSet();
         adapter.Fill(ds);

         DataTable dtTrainer = ds.Tables[0];

         foreach (DataRow row in dtTrainer.Rows)
         {
             try
             {
                 details.Add(new Details()
                 {
                     user_id = (int)row["user_id"],
                     Email = (string)row["Email"],
                     Full_name = (string)row["Full_name"],
                     Age = (int)row["Age"],
                     Gender = (string)row["Gender"],
                     Mobile_number = (string)row["Mobile_number"],
                     Website = (string)row["Website"],
                     Highest_Graduation = (string)row["Highest_Graduation"],
                     Institute = (string)row["Institute"],
                     Department = (string)row["Department"],
                     Start_year = (string)row["Start_year"],
                     End_year = (string)row["End_year"],
                     Skill_name = (string)row["Skill_name"],
                     Skill_Type = (string)row["Skill_Type"],
                     Skill_Level = (string)row["Skill_Level"],
                     Company_name = (string)row["Company_name"],
                     Company_type = (string)row["Company_type"],
                     Experience = (string)row["Experience"],
                     Company_Description = (string)row["Company_Description"]
                 }); ;
             }
             catch (Exception e)
             {
                 System.Console.WriteLine(e);
             }
         }

         return details;
     }*/



















