﻿using System;
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
            string dob;
            Console.Clear();
            Console.Write("\nWhat is your name?");
            name = Console.ReadLine();
            Console.Write("\nWhat's your Birthday?");
            dob = Console.ReadLine();
            DateTime dtdob = DateTimeOffset.Parse(dob).UtcDateTime;
            DateTime today = DateTime.UtcNow;
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
            var days = today - dtdob;
            var years = today.Year - dtdob.Year;
            var dayscalc = days.Days - (years*365);
            if (dayscalc < 0)
            {
                dayscalc = -dayscalc;
            } 
            else
            {
                dayscalc = 365 - dayscalc;
            }
            Console.WriteLine("Your Birthday is " + dayscalc + " days away!");
            Console.Write("\nPress any KEY to close the console.");
            Console.ReadKey();
        }
    }
}
