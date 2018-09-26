using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03
{
    //所有子类共同的父类
    abstract class Shape
    {
        public double GetNum1(string arg)
        {
            double Num1 = double.Parse(arg);
            return Num1;
        }
        public double GetNum2(string arg)
        {
            double Num2 = double.Parse(arg);
            return Num2;
        }

        public abstract double AreaCalculation(double num1 ,double num2 );
    }

    //正方形
    class Square : Shape
    {
        override public double AreaCalculation(double num1,double num2)
        {
            double area = num1*num2;
            return area;
        }

    }

    //三角形
    class Triangle : Shape
    {
        override public double AreaCalculation(double num1, double num2)
        {
            double area = num1 * num2 * 0.5;
            return area;
        }

    }


    //圆形
    class Roundness : Shape
    {
        override public double AreaCalculation(double num1, double num2)
        {
            double area = num1 * num2 * 3.14;
            return area;
        }

    }

    //长方形
    class Rectangle : Shape
    {
        override public double AreaCalculation(double num1, double num2)
        {
            double area = num1 * num2 ;
            return area;
        }

    }

    //工厂类
    class Factory
    {
        public static Shape GetShape(String arg)
        {
            Shape shape = null;
            switch (arg)
            {
                case "Square":
                    shape = new Square();
                    Console.WriteLine("请重复输入两次边长:");
                    break;
                case "Triangle":
                    shape = new Triangle();
                    Console.WriteLine("请分别输入底和高:");
                    break;
                case "Roundness":
                    shape = new Roundness();
                    Console.WriteLine("请输入两次半径:");
                    break;
                case "Rectangle":
                    shape = new Rectangle();
                    Console.WriteLine("请分别输入长和宽:");
                    break;
            }
            return shape;
        }
    }
}
