using System;

namespace GalvanizedSoftware.Beethoven.DemoApp.GeneratedExample
{
  internal class Return<TParameter, TReturn> : IMethodDefinition<TReturn>
  {
    private readonly Func<TParameter, TReturn> preturnFunc;

    public Return(Func<TParameter, TReturn> preturnFunc)
    {
      this.preturnFunc = preturnFunc;
    }

    public bool Invoke(object[] parameters, ref TReturn returnValue)
    {
      returnValue = preturnFunc((TParameter)parameters[0]);
      return true;
    }
  }
}