using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4Homework2
{
    class Function
    {
        public void tickSolution(DateTime dateTime)
        {
            Console.WriteLine(dateTime.ToLongTimeString());
        }

        public void alarmSolution(DateTime dateTime)
        {
            if (dateTime.ToLongTimeString().Equals(AnAlarm.alarmtime)) ;
            Console.WriteLine("Ringing!");
        }
    }
}
