using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1___Prime_Numbers__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //code for printing prime numbers
            int x;
            Console.Write("Enter start number : ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Enter end number : ");
            for(int B = int.Parse(Console.ReadLine());
                A<=B;
                A++)
            {
                for (x=2; x<=A; x++)
                if(A%x==0)
                    {
                        break;
                    }
                if (A==x)
                {
                    Console.WriteLine(A);
                }
            }
        }
    } 
}
