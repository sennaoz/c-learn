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
     
            Console.Write("enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("choice process:(+ , -  , / , * ,  :)");
            string process = Console.ReadLine();

            if (process == "+")
                Console.WriteLine(num1 + "+" + num2 + "=" + num1 + num2);
            if (process == "-")
                Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));
            if (process == "/")
                Console.WriteLine(num1 + "/" + num2 + "=" + num1 / num2);

            if (process == "*")
                Console.WriteLine(num1 + "*" + num2 + "=" + num1 * num2);



            Console.ReadLine();
        }

     }

}

