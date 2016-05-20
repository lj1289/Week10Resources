using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week10Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********We Can Code IT resources*********\n\n");
            List<string> menu = new List<string>();
            menu.Add("1. View Student Account");
            menu.Add("2. View Available Resources");
            menu.Add("3. Check Out Item");
            menu.Add("4. Check In Item");
            menu.Add("6. Exit");

            bool looptyLoop = true;
            while (looptyLoop)
            {
                viewMenu(menu);
                Console.Write("Please make a selection: ");
                int num = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (num)
                {
                    case 1:
                        Console.WriteLine("");
                        break;
                }              
            }

        }
        static void viewMenu(List<string> menu)
        {
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }
            
        } 
         
    }
}
