using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{
    public delegate void TickHandler();
    public delegate void AlarmHandler();

    public class Clock
    {
        public event TickHandler Tick;
        public event AlarmHandler Alarm;

        private DateTime nowTime;
        private DateTime alarmTime;

        public DateTime NowTime { get => nowTime; set => nowTime = value; }
        public DateTime AlarmTime { get => alarmTime; set => alarmTime = value; }

        public Clock()
        {
            nowTime = DateTime.Now;
        }
        public void start()
        {
            bool isAlarmed = false;
            Timer timer = new Timer(1000);
            timer.Elapsed += new ElapsedEventHandler(Ticks);
            timer.Start();
            while (true)
            {
                nowTime = DateTime.Now;
                if(nowTime >= alarmTime && !isAlarmed)
                {
                    Alarms();
                    isAlarmed = true;
                }
            }
        }
        public void Ticks(object sender, ElapsedEventArgs e)
        {
            Tick();
        }
        public void Alarms()
        {
            Alarm();
        }
    }

    public class MyClock
    {
        public Clock clock = new Clock();
        public MyClock()
        {
            clock.Tick += Clock_Tick;
            clock.Alarm += Clock_Alarm;
        }
        void Clock_Tick()
        {
            Console.WriteLine("Tick! Tack!");
        }

        void Clock_Alarm()
        {
            Console.WriteLine("Alarming");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClock myclock = new MyClock();
            myclock.clock.AlarmTime = DateTime.Now.AddSeconds(5);
            myclock.clock.start();
        }
    }
}
