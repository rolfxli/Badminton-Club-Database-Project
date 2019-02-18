using System;
using System.Windows.Input;

namespace Badminton_Database
{
    public class Register
    {
        public void Register_Action()
        {
            Console.WriteLine("First Name: ");
            var First_Name = Console.Read();

            Console.WriteLine("Last Name: ");
            var Last_Name = Console.Read();

            Console.WriteLine("Age: ");
            int Age = Console.Read();

            Console.WriteLine("Level: ");
            int Level = Console.Read();

            Console.WriteLine("Phone Number: ");
            var Phone = Console.Read();

            SqlConnection conn = new SqlConnection("Data Source = (local); Database=TestingMSDN;Integrated Security=SSPI;");
            conn.Open();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand());

            ICommand.CommandText = "INSERT INTO students VALUES (@fn, @ln, @a, @lvl, @phn)";

            command.Parameters.AddWithValue("@fn", First_Name);
            command.Parameters.AddWithValue("@ln", Last_Name);
            command.Parameters.AddWithValue("@a", Age);
            command.Parameters.AddWithValue("@lvl", Level);
            command.Parameters.AddWithValue("@phn", Phone);


            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

        }
    }
}