using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public static class MemoryMonitor
    {
        public static void CheckCurrentProcess()
        {
            Process proc = Process.GetCurrentProcess();
            Console.WriteLine($"Allocated private memory: {FormatMemorySize(proc.PrivateMemorySize64)}");
            Console.WriteLine($"Physical memory usage: {FormatMemorySize(proc.WorkingSet64)}");
        }

        private static string FormatMemorySize(long bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            double len = bytes;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }
            return $"{len:0.##} {sizes[order]}";
        }
    }
}
