using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch_Exercise.Classes
{
    public class Stopwatch
    {
        private static DateTime _startTime;
        private static DateTime _endTime;
        private static bool _isRunning = false;

        public void StopwatchMain()
        {
            Console.WriteLine("_____ WELCOME TO THE STOPWATCH APPLICATION _____");
            Console.WriteLine("Press S to start and Q to Stop:");
            Console.Write("(Type S or Q)");

            while (true)
            {
                var input = Console.ReadLine();

                if (input.ToLower() == "s")
                {
                    Start();
                }
                else if (input.ToLower() == "q")
                {
                    Stop();
                    break;  
                }
            }

            //BASIC STOPWATCH APPLICATION IS READY> NEED TO ADD LOGIC TO START AND STOP WATCH MULTIPLE TIMES

        } 

        public static void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is already running");
            }

            _isRunning = true;
            _startTime = DateTime.Now;
            Console.WriteLine("Stopwatch has started");
        }

        public static void Stop()
        {
            if(!_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is not running currently");
            }

            _isRunning = false;
            _endTime = DateTime.Now;
            TimeSpan timespan = _endTime - _startTime;
            Console.WriteLine("Stopwatch has stopped. Duration {0} seconds", timespan.TotalSeconds);
        }
    }
}
