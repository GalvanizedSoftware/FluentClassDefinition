using System.Diagnostics;

namespace GalvanizedSoftware.Beethoven.DemoApp.GeneratedExample
{
  class TraceLogger : ILogger
  {
    private readonly string className;

    public TraceLogger(string className)
    {
      this.className = className;
    }

    public void LogMethod(string methodName, string parameters, string returnValue)
    {
      Trace.WriteLine($"{className}.{methodName} called with: {parameters} returned {returnValue}");
    }
  }
}
