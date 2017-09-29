using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 749395939, flag=0;
            
            var watch = Stopwatch.StartNew();

            for (int i = 2; i <= num1 / 2; i++)
            {
                if (num1 % 2 == 0)
                    flag = 1;

            }
            watch.Stop();
            Console.WriteLine("Logic 1: "+watch.ElapsedMilliseconds);

            var m = Math.Sqrt(num1);

            var watch1 = Stopwatch.StartNew();
            if (num1 <= 1) flag = 1;
            else if (num1 == 2) flag = 0;
            if (num1 % 2 == 0) flag = 1;
            for (int i = 3; i <= m; i += 2)
            {
                if (num1 % i == 0)
                    flag = 1;
            }
            watch1.Stop();
            Console.WriteLine("Logic 2:"+watch1.ElapsedMilliseconds);
            


            if (flag == 0)
                Console.WriteLine("a prime number."+num1);
            else
                Console.WriteLine(" not a prime number.",num1);
            Console.ReadLine();
        }
    }
}
