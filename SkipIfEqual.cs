namespace GalvanizedSoftware.Beethoven.DemoApp.GeneratedExample
{
  internal class SkipIfEqual<T> : ISetPropertyDefinition<T>
  {
    private T oldValue;

    public bool Invoke(T newValue)
    {
      if (newValue == null)
      {
        if (oldValue == null)
          return false;
      }
      else if (newValue.Equals(oldValue))
        return false;
      oldValue = newValue;
      return true;
    }
  }
}
