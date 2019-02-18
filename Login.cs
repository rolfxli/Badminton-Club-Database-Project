using System;


namespace Badminton_Database
{
    public class Login
    {
        public Login()
        {
            Console.Write("Username: ");
            var username = Console.Read();
            Console.Write("Password: ");
            var password = Console.Read();
        }
        public bool Verifier(string username, string password);
        {
        bool success = false;
        SqlConnection conn = new SqlConnection("Data Source = (local); Database=TestingMSDN;Integrated Security=SSPI;");
        conn.Open();
        string sql = "SELECT Authorized.Password FROM Authorization_Table WHERE Authorized.User = @username";
        using (SqlConnection conn = new SqlConnection(connString))

        SqlCommand cmd = new SqlCommand(sql, conn);
    cmd.Parameters.AddWithValue("@password", 1);
        try
        {
            conn.Open();
            temp_pass = (int) cmd.ExecuteScalar();
        if (temp_pass = password)
    
    success = true;
    connection.Close();

}
        catch (Exception)
        {
            Console.WriteLine(Exception."User not recognized.");
    success = false;
        }
    return success;
    }

    protected void Verified()
{
    if (Verifier == true)
    {
        Application.Run(new Menu);
    }
    else
    {
        Application.Exit();
    }
}
}