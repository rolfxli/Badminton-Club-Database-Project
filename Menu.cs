using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Badminton_Database
{
    static class Menu
    {
        static void Choices(string[] args)
        {
            Console.WriteLine("Please select an option. (Enter the Number)");
            Console.WriteLine("1. Register a Student.");
            Console.WriteLine("2. Book an Appointment");
            Console.WriteLine("3. Check and Appointment");
            Console.WriteLine("4. Update Student Information");
            Console.WriteLine("5. Quit");

            int choice = Console.Read();

            if (choice == 1)
            {
                Application.Run(new Register());
            }
            else if (choice == 2)
            {
                Application.Run(new Book());
            }
            else if (choice == 3)
            {
                Application.Run(new Check());
            }
            else if (choice == 4)
            {
                Application.Run(new Update());
            }
            else if (choice == 5)
            {
                Application.Exit();
            }
            else 
            { 
            Application.Exit(); 
            }
        }
    }

}

