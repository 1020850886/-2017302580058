using System;
using System.Timers;

namespace Homework04_1
{
    public class TimeEventArgs : EventArgs
    {
        public DateTime NowTime;
    }
    //保存时间信息


    public delegate void TimeEventHandler(object sender, TimeEventArgs timeEventArgs);
    //声明一个委托

    public class Time
    {
        public event TimeEventHandler Alarm;//将时间Alarm与委托关联
        public void DoTime()
        {
            Console.WriteLine("请输入闹钟时间：");
            Console.WriteLine("请输入小时：");
            int timeH = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入分钟：");
            int timeM = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入秒：");
            int timeS = int.Parse(Console.ReadLine());

                label1:
                   DateTime time = DateTime.Now;
                if (time.Hour == timeH && time.Minute == timeM && time.Second == timeS)
                {
                    if (Alarm != null)//代理触发事件
                    {
                        TimeEventArgs args = new TimeEventArgs();
                        args.NowTime = DateTime.Now;
                        Alarm(this, args);
                    }
                }
                else goto label1;
           
        }
    }




}
