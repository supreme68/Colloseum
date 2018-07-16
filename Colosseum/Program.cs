using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Colosseum.Data;

namespace Colosseum
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UIcomponents.MainUI();
            }
            catch
            {
                Console.Clear();

                Console.WriteLine("!!!ERROR!!!");
                Console.WriteLine("OOPS LOOKS LIKE YOU HAVE PRESSED SOMETHING WRONG WHEN SELECTING A GLADIATOR OR TYPED WRONG VALUES WHEN CREATING ONE");
                Console.WriteLine("!!!ERROR!!!");

                Console.WriteLine();

                Main(null);
            }
        }
    }
}