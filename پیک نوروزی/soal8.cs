using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace پیک_نوروزی_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, z;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            for (z = a + 1; z <= b - 1; z++)
            if (z % 5 == 0)
                Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
