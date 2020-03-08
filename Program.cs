using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno("Jim", "Business", 2.8);
            Aluno b = new Aluno("Pam", "Art", 3.6);

            Console.WriteLine(a.HasHonors());
            Console.WriteLine(b.HasHonors());


        }
    }
}
