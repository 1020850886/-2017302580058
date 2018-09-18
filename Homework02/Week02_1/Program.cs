using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Week02_1
{
    public class Class1 {
        static void T1()//用“埃氏筛法”求2~100以内的素数
        {
            Console.WriteLine("2-100以内素数为：");
            int[] arr = new int[99];
            for (int i = 0; i < 99; i++)
            {
                arr[i] = i + 2;
            }
            for (int i = 2; i < 10; i++)
            {
                for (int j=0;j<99;j++){
                    if (arr[j] % i == 0 && arr[j]>i) arr[j] = 0;
                }
            }
            for (int i = 0; i < 99; i++)
            {
                if (arr[i]!=0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
    }


        static void T2()//求质因数
            {
            label2:;
                Console.WriteLine("请输入一个数：");
            Regex re = new Regex(@"^\d+$");
            string a = Console.ReadLine();
            if (!re.IsMatch(a))
            {
                Console.WriteLine("对不起，您输入的不是数字,请重新输入：");
                goto label2;
            }
                double x = double.Parse(a);
            Console.Write("其质因数为：");
                for (int i = 2; i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                                goto outer;
                        }
                        Console.Write(i+" ");
                    }
                    outer:;
                }
            Console.WriteLine();
            }

        static void T3()
        {
            Console.WriteLine("请输入数字(用回车键分割):");
            double[] arr = new double[10];
            for(int i = 0; i < 10; i++)
            {
                label1:;
               string a=Console.ReadLine();
                Regex re = new Regex(@"^\d+$");
                if (!re.IsMatch(a))
                {
                    Console.WriteLine("对不起，您输入的不是数字,请重新输入：");
                    goto label1;
                }
                    double x = double.Parse(a);
                arr[i] = x;
            }

            int m = 0;
            for (int i= 0;i<arr.Length-1;i++)
            {
                if (arr[m] < arr[i + 1]) m = i+1;
            }
            Console.WriteLine("最大值为："+arr[m]);

            int n = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[n] > arr[i + 1]) n = i + 1;
            }
            Console.WriteLine("最小值为：" + arr[n]);

            double sum = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("和为：" + sum);

            Console.WriteLine("平均值为" + (sum / arr.Length));

        }


            static void Main(string[] args)
            {
            Class1.T1();//用“埃氏筛法”求2~100以内的素数
            Class1.T2();//求质因数
            Class1.T3();//最大、最小、平均，和
            }

    }
}
