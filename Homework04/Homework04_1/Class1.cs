using System;

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

            DateTime time = DateTime.Now;
            Console.WriteLine("请输入闹钟时间：");
            DateTime time1 = Console.ReadLine();
            if (time == time1)
            {
                if (Alarm != null)//代理触发事件
                {
                   TimeEventArgs args = new TimeEventArgs();
                   args.NowTime = DateTime.Now.Hour;
                   Alarm(this, args);
                }
            }
           
        }
    }




}
