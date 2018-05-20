using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            //Process proc = new Process();
            //proc.StartInfo.FileName = "notepad.exe";
            //proc.Start();
            //Console.WriteLine("Запущен процесс: " + proc.ProcessName);
            //proc.WaitForExit();
            //Console.WriteLine("Процусс завершился с кодом: " + proc.ExitCode);
            //Console.WriteLine("Текущий процесс имеет имя: " + Process.GetCurrentProcess().ProcessName);
            //==================================================================
            Console.Title = "Список процессов";

            Console.WindowWidth = 40;
            Console.BufferWidth = 40;
            Process[] processes = Process.GetProcesses();
            Console.WriteLine("  {0,-28}{1,-10}", "Имя процесса: ", "PID:");
            foreach (Process p in processes)
            {
                Console.WriteLine(" {0,-28}{1,-10}", p.ProcessName, p.Id);
            }

            Console.Read();
        }
   
    }
}
