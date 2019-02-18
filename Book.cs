using System;
using System.Windows.Input;

namespace Badminton_Database
{
    public class Book
    {
        public void BA()
        {
            Console.WriteLine("First Name: ");
            var First_Name = Console.Read();

            Console.WriteLine("Last Name: ");
            var Last_Name = Console.Read();

            // eventually will add more booking options, default standard book

            SqlConnection conn = new SqlConnection("Data Source = (local); Database=TestingMSDN;Integrated Security=SSPI;");
            conn.Open();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand()) ;

            ICommand.CommandText = "INSERT INTO bookings VALUES (@fn, @ln)";

        }
    }
}