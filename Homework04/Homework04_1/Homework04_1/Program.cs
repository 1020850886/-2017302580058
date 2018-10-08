using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = new Time();
            time.Alarm += ShowTime;
            time.DoTime();
        }
        static void ShowTime(object sender , TimeEventArgs timeEventArgs)
        {
            Console.WriteLine("时间到了！");
        }
    }
}
