using System;
using System.IO;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;

namespace logg
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("logfile.txt")));

            Trace.AutoFlush = true;

            

            Debug.WriteLine("Debug is watching");
            Trace.WriteLine("hello, Trace is watching");

            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json",
            optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var ts = new TraceSwitch(
                displayName: "PacktSwitch",
                    description: "This switch is set via a JSON config.");

            configuration.GetSection("PacktSwitch").Bind(ts);

            Trace.WriteLineIf(ts.TraceError, "Trace error");
            Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace information");
            Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");   

            //call AreaOfSquare() here
            AreaOfSquare(10);
        }
        static void AreaOfSquare(int number){
            Console.WriteLine($"Result is {number * number}");
        }
    }
}
