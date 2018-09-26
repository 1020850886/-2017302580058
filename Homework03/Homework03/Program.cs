using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Homework03
{

    class Program
    {
        static void Main(string[] args)
        {
            Shape shape;
            Console.WriteLine("Square代表正方形 Triangle代表三角形 Roundness代表圆形 Rectangle代表长方形");
            Console.WriteLine(" 请输入形状：");

            shape = Factory.GetShape(Console.ReadLine());
            double Num1 = shape.GetNum1(Console.ReadLine());
            double Num2 = shape.GetNum1(Console.ReadLine());
            Console.WriteLine("面积大小为：");
            double area = shape.AreaCalculation(Num1,Num2);
            Console.WriteLine(area);
        }
    }
}
           /* label:;
            Regex re = new Regex("^([Roundness]{9})$");
            string a = Console.ReadLine();
            if (!re.IsMatch(a))
            {
                Console.WriteLine("错误！请在给定范围内重新输入");
                goto label;
            }*/