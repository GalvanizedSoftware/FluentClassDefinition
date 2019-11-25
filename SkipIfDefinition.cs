using System;

namespace GalvanizedSoftware.Beethoven.DemoApp.GeneratedExample
{
  internal class SkipIfMethod<T> : IMethodDefinition<string>
  {
    private Func<bool> p;
    private string v;

    public SkipIfMethod(Func<bool> p, string v)
    {
      this.p = p;
      this.v = v;
    }
  }
}