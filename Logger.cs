using System;

namespace GalvanizedSoftware.Beethoven.DemoApp.GeneratedExample
{
  internal class Logger
  {
    internal static ILogger FindLogger(string className)
    {
      return new TraceLogger(className);
    }
  }
}