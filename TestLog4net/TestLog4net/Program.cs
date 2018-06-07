using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLog4net
{
    class Program
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger("ErrorLogger");

        static void Main(string[] args)
        {

            try
            {
                // 可以在AssemblyInfo.ca裡加上 
                // [assembly: log4net.Config.XmlConfigurator(Watch = true)]
                // 或是在程式初始像是  App.xaml.cs
                log4net.Config.XmlConfigurator.Configure();

                log4net.ILog smtpLog = log4net.LogManager.GetLogger("ErrorLogger");
                smtpLog.Error("TESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTTESTTTTTTTT");


                return;

                log4net.ILog log = log4net.LogManager.GetLogger("ErrorLogger");

                //add 5 MB to log, to test the rolling effect,
                //that is if you set max count of store log files is 5,
                //max size is 10 MB  

                //then if a log name is XXLog.txt and it is > 10 MB
                //it'll write current log content to XXLog.txt
                //and old content XXLog.txt.1

                //and if there is 
                //XXLog.txt XXLog.txt.1 XXLog.txt.2 XXLog.txt.3 XXLog.txt.4 XXLog.txt.5

                // and the current XXLog.txt is > 10MB again,
                //then the oldest XXLog.txt.5    will  be deleted
                //and all the current files will be move by 1 
                // 1->2 2->3 ...
                // and a new  XXLog.txt  will produce and log thw newest log 

                for (int i = 0; i < 50000; i++)
                {
                    log.Error("This is an error test");
                }



            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            


        }
    }
}
