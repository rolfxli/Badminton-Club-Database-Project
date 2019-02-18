using System;
using System.Windows.Input;

namespace Badminton_Database
{
    public class Check
    {
        public void Lookup()
        {
            Console.WriteLine("First Name: ");
            var First_Name = Console.Read();

            Console.WriteLine("Last Name: ");
            var Last_Name = Console.Read();

            SqlConnection conn = new SqlConnection("Data Source = (local); Database=TestingMSDN;Integrated Security=SSPI;");
            conn.Open();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand());

            ICommand.CommandText = "SELECT bookings WHERE @fn = bookings.fn AND @ln = bookings.ln";
           
        }
    }
}