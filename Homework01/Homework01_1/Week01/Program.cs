using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            string a = Console.ReadLine();
            Console.Write("b=");
            string b = Console.ReadLine();
            double x = Convert.ToDouble(a);
            double y = Convert.ToDouble(b);
            Console.WriteLine("a*b=" + (x * y));
        }


    }
}
