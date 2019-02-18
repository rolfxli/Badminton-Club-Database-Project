using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Badminton_Database
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to the Badminton Registration Database");
            Console.WriteLine("Please login using your credentials.");
            Application.Run(new Login());
        }
    }
}
