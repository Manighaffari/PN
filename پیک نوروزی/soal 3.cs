using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace پیک_نوروزی_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, t1, t2;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            t1 = c - b;
            t2 = b - a;
            if (t1 == t2)
                Console.WriteLine("yes!");
            else
                Console.WriteLine("no!");
            Console.ReadLine();
        }
    }
}
