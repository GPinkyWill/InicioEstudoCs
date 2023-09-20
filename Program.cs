using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoLingC
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 35;
            string age;
            string characterName = "Jhon Jhonson";
            string response;
            Console.WriteLine(characterName);
            Console.WriteLine(x);
            Console.WriteLine(characterName + " is " + x + " years old.");
            Console.WriteLine("Eu não...\nAcredito!\n");
            Console.WriteLine(Math.Min(3, 60));
            Console.WriteLine(Math.Round(5.6));

            Console.WriteLine(characterName.Substring(6,6));
            Console.WriteLine("Enter your Name:");
            response = Console.ReadLine();
            Console.WriteLine("Enter your Age:");
            age = Console.ReadLine();
            Console.WriteLine("Hello " + response + ", nice to meet you! I've heard you are "+ age +" years old!");
;
            Console.ReadLine();

        }
       
    }

}
