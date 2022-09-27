using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proberen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal givenNumber = 0;
            Console.Write(" Give a number: ");
            givenNumber = decimal.Parse(Console.ReadLine());
           
            decimal geteldNumber = givenNumber + 15;
            
            decimal vermenigvuldigdNumber = geteldNumber * 2;
            decimal afgetrokkenNumber = vermenigvuldigdNumber - 4;
            decimal divideNumber = afgetrokkenNumber / 2;
            Console.WriteLine($"The different between given number and laste result is:{divideNumber-givenNumber}");

           // Console.OutputEncoding = Encoding.UTF8;
           // Console.Write("give een nummer: ");
            //decimal price = decimal.Parse(Console.ReadLine());
           // Console.WriteLine(price);
            //Console.WriteLine($"price is equal to {price,0:C2}");
            Console.ReadLine();


        }
    }
}
