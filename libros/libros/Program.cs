﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libros
{
    class Program
    {
        static void Main(string[] args)
        {

            IColeccionable biblioteca = new Libro();

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        Thread.Sleep(10000);
        stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);

        }
    }
}
