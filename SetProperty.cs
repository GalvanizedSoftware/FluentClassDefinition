using System;

namespace GalvanizedSoftware.Beethoven.DemoApp.GeneratedExample
{
  internal class SetProperty<T> : ISetPropertyDefinition<int>
  {
    private readonly Action<int> setValue;

    public SetProperty(Action<int> setValue)
    {
      this.setValue = setValue;
    }

    public bool Invoke(int newValue)
    {
      setValue(newValue);
      return true;
    }
  }
}