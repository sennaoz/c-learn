using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Giraffe

{
    class Program
    {
        static void Main(string[] args)
        {

            string phrase = "Acedemy";
            char grade = 'A';  //tek tırnak char oldugunda
            int age = 15;
            double gpa = 3.5;  // float double decimal ayrıntıya doğru gider
            bool isMale = true;

            Console.WriteLine(phrase);
            Console.WriteLine(grade);
            Console.WriteLine(age);
            Console.WriteLine(gpa);
            Console.WriteLine(isMale);

            Console.ReadLine();
        }

    }
}