using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace پیک_نوروزی_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, z;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                z = a;
                a = b;
                b = z;
            }
            if (a > c)
            {
                z = a;
                a = c;
                c = z;
            }
            if (b > c)
            {
                z = b;
                b = c;
                c = z;
            }
            Console.WriteLine(a + "<" + b + "<" + c);
            Console.ReadLine();
        }
    }
}
