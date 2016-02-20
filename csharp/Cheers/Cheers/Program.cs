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
            for (int i = 1; i <= name.Length; i++)
            {
                var lowerName = name.ToLower(); 
                var vowelarray = new char[] { 'h','a','l','f','n','o','r','s','e','m','i','x'};
                if (vowelarray.Contains(lowerName[i-1])) {
                    Console.WriteLine("Give me an .. " + lowerName[i - 1]);
                }  else {
                    Console.WriteLine("Give me a .. " + lowerName[i - 1]);
                }
            }
            Console.WriteLine(name.ToUpper() + " is... GRAND!");
            Console.Write("\nPress any KEY to close the console.");
            Console.ReadKey();
        }
    }
}
