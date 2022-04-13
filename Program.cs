using System;
using System.Configuration;
using System.Diagnostics;

namespace TraceSwitchDoesNotWork
{
  // exactly as in docs:
  // https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.traceswitch?view=net-6.0
  class Program
  {
 
    private static TraceSwitch appSwitch = new TraceSwitch("mySwitch",
      "Switch in config file");

    static void Main(string[] args)
    {
      Console.WriteLine(ConfigurationManager.AppSettings["Something"]); // prints hello, correct
      Console.WriteLine(appSwitch.Level.ToString()); // prints Off, WRONG! Off means 0.
    }
  }
}