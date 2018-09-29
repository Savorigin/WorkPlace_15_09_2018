using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MarkException : Exception
    {
        public MarkException(string message) : base(message)
        {
        }
    }
    class Mark
    {
        private int mark;
        private const int MIN_VALUE = 1;
        private const int MAX_VALUE = 12;
        private bool IsValid(int mark)
        {
            return MIN_VALUE <= mark && mark <= MAX_VALUE;
        }
        public int Value
        {
            get { return mark; }
            set
            {
                if (IsValid(value)) mark = value;
                else throw new MarkException("Out of range[1,12]");
            }
        }

    }
    class MyLogger {
        public static void Log(Exception e) {
            using (StreamWriter sw = new StreamWriter("MarkProgram.log", true))
            {
                sw.WriteLine("Error : " + DateTime.Now + e.Message);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Mark mark = new Mark { Value = 15 };
                Console.WriteLine(mark.Value);
            }
            catch (MarkException e)
            {
                Console.WriteLine(e.Message);
                //   MyLogger.Log(e);
                NLog.LogManager.GetCurrentClassLogger().Debug(e);
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "ApplicationMark";
                    eventLog.WriteEntry("Log message example", EventLogEntryType.Information, 101, 1);
                }
                return;
            }

            Console.WriteLine("Out Main");

        }
    }
}
