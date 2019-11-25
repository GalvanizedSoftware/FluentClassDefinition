using System.ComponentModel;

namespace GalvanizedSoftware.Beethoven.DemoApp.GeneratedExample
{
  internal class NotifyPropertyChanged : ISetPropertyDefinition<int>
  {
    private readonly INotifyPropertyChanged master;
    private readonly PropertyChangedEventHandler propertyChanged;
    private readonly PropertyChangedEventArgs eventArgs;

    public NotifyPropertyChanged(string propertyName, INotifyPropertyChanged master, PropertyChangedEventHandler propertyChanged)
    {
      this.master = master;
      this.propertyChanged = propertyChanged;
      eventArgs = new PropertyChangedEventArgs(propertyName);
    }

    public bool Invoke(int newValue)
    {
      propertyChanged?.Invoke(master, eventArgs);
      return true;
    }
  }
}