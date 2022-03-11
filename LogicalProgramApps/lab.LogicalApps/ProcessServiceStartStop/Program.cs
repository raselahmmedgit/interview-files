using System;
using System.Diagnostics;
using System.Linq;

namespace ProcessServiceStartStop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Windows Process/Service Start Stop");

            //string processName = "Redis";
            //string processName = "redis-server";
            string processName = "redis-server.exe";

            #region Start

            //Process p = new Process();
            //p.StartInfo.UseShellExecute = true;
            //p.StartInfo.FileName = processName;
            //p.Start();

            //ProcessStartInfo info = new ProcessStartInfo(processName);
            //info.UseShellExecute = true;
            //info.Verb = "runas";
            //Process.Start(info);

            //Process.Start(processName);

            string startcommand = "/c net start Redis";
            string stopcommand = "/c net stop Redis";

            ProcessStartInfo pi = new ProcessStartInfo();
            pi.FileName = "cmd.exe";
            pi.Arguments = startcommand;
            pi.UseShellExecute = false;
            pi.CreateNoWindow = true;
            pi.Verb = "runas";

            Process p = new Process();
            p.StartInfo = pi;
            p.Start();

            Console.WriteLine("Start...");

            #endregion

            #region Stop

            var processes = Process.GetProcesses();
            var redisProcess = Process.GetProcesses().FirstOrDefault(x => x.ProcessName.Contains(processName));
            if (redisProcess != null)
            {
                int id = redisProcess.Id;
                string name = redisProcess.ProcessName;
                //redisProcess?.Kill();
            }

            Console.WriteLine("Stop...");

            #endregion

            Console.ReadLine();
        }
    }
}
