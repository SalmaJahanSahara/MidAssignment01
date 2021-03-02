using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidAssignment01
{
    class Program
    {
        private string option;
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option\n1.Add Account: \n2.Delete Account: \n3.Transaction: \n4.Account Details:\n");
            //string option = Console.ReadLine();
            string option = Convert.ToString(Console.ReadLine());
        }
    }
}
