﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgramm
{
    class Program
    {
        public static int Fiboonaci(int n)
        {
            int [] fib = new int[n + 1];
            if(n==0)
            {
                return 0;
            }
            if(n==1)
            {
                return 1;
            }
            fib[0] = 0;
            fib[1] = 1;
            for(int i=2 ; i<= n ; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            return fib[n];
        }
        static void Main(string[] args)
        {
            int n;
            
            Console.Write("Δώσε μου ώς είσοδο το n : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nO "+ n +" όρος της ακολουθίας είναι f(" + n + ") = " + Fiboonaci(n));
            Console.WriteLine("\nΠάτησε Enter για τερματισμό του προγράμματος !");
            Console.ReadLine();
        }
    }
}
