using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            Console.WriteLine("");
            int Num = int.Parse(Console.ReadLine());
            int Rem;
            Stack Result = new Stack();
            while (Num > 0)
            {
                Rem = Num % 2;
                Result.Push(Rem);
                Num = Num / 2;
            }
            foreach (var item in Result)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
    }
}
