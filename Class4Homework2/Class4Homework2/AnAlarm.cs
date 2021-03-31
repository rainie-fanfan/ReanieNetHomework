using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4Homework2
{
    class AnAlarm
    {
        static public string alarmtime = "1:04:00";

        //声明关于事件的委托
        public delegate void AnAlarmEventHandler(DateTime dateTime);

        //声明事件
        public event AnAlarmEventHandler Tick;//嘀嗒
        public event AnAlarmEventHandler Alarm;//响铃

        public static string ShowTime()
        {
            //DateTime myDateTime = new DateTime();
            //string output = myDateTime.ToLongTimeString();

            string output = DateTime.Now.ToString("hh:mm:ss");

            //Console.WriteLine(output);

            return output;
        }

        //编写引发事件的函数
        public void ChangeEvent(DateTime dateTime)
        {
            Tick(dateTime);
            if (dateTime.ToLongTimeString().Equals(AnAlarm.alarmtime))
            {
                Alarm(dateTime);
            }
            
        }
    }
}
