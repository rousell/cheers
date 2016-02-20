using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name;
            Console.Clear();
            Console.Write("\nWhat is your name?");
            name = Console.ReadLine();
            Console.Write(name);
            Console.Write("\nPress any KEY to close the console.");
            Console.ReadKey();
        }
    }
}
