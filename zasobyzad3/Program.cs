using System;
using System.Diagnostics;
using System.IO;

namespace MonitoringTool
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                RecordSystemMetrics();

                CheckAndLogEvents();

                System.Threading.Thread.Sleep(5000);
            }
        }

        static void RecordSystemMetrics()
        {
            Console.WriteLine($"CPU Usage: {GetCPUUsage()}%");
            Console.WriteLine($"Memory Usage: {GetMemoryUsage()} MB");
        }

        static void CheckAndLogEvents()
        {
            if (GetMemoryUsage() > 90)
            {
                Console.WriteLine("Memory usage exceeds 90%!");
            }
        }

        static float GetCPUUsage()
        {
            return Process.GetCurrentProcess().TotalProcessorTime.Ticks / (float) Stopwatch.Frequency * 100;
        }

        static float GetMemoryUsage()
        {
            return (float)Process.GetCurrentProcess().WorkingSet64 / (1024 * 1024);
        }
    }
}