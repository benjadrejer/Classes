using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    public class StopWatch
    {
        private DateTime StartTime;
        private DateTime StopTime;
        private TimeSpan Duration;
        private bool isStarted = false;

        public void Start()
        {
            if(isStarted == false)
            {
                isStarted = true;
                StartTime = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("You cannot start a stopwatch twice, please stop it first");
            }

        }

        public TimeSpan Stop()
        {
            if(isStarted == true)
            {
                isStarted = false;
                StopTime = DateTime.Now;
                Duration = StopTime - StartTime;
                return Duration;
            }
            else
            {
                throw new InvalidOperationException("You must start the stopwatch before stopping it");
            }

        }
    }
}
