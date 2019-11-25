namespace GalvanizedSoftware.Beethoven.DemoApp.GeneratedExample
{
  internal class LoggerDefinition : IMethodDefinition<string>
  {
    private readonly ILogger logger;
    private readonly string methodName;

    public LoggerDefinition(ILogger logger, string methodName)
    {
      this.logger = logger;
      this.methodName = methodName;
    }

    public bool Invoke(object[] parameters, ref string returnValue)
    {
      logger.LogMethod(methodName, string.Join(", ", parameters), returnValue.ToString());
      return true;
    }
  }
}