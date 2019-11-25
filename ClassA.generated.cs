using System;
using System.ComponentModel;

namespace GalvanizedSoftware.Beethoven.DemoApp.GeneratedExample
{
  public class ClassA : INotifyPropertyChanged
  {
    private readonly ILogger _logger = Logger.FindLogger(nameof(ClassA));
    int backing_field_Option;
    private readonly ISetPropertyDefinition<int> import_backing_set_Option1;
    private readonly ISetPropertyDefinition<int> import_backing_set_Option2;
    private readonly ISetPropertyDefinition<int> import_backing_set_Option3;
    private readonly IMethodDefinition<string> import_backing_method_GetDiscription1;
    private readonly IMethodDefinition<string> import_backing_method_GetDiscription2;
    private readonly IMethodDefinition<string> import_backing_method_GetDiscription3;

    public ClassA()
    {
      import_backing_set_Option1 = new SkipIfEqual<int>();
      import_backing_set_Option2 = new SetProperty<int>(value => backing_field_Option = value);
      import_backing_set_Option3 = new NotifyPropertyChanged("Option", this, PropertyChanged);
      import_backing_method_GetDiscription1 = new LoggerDefinition(_logger, "GetDiscription");
      import_backing_method_GetDiscription2 = new SkipIfMethod<string>(() => Option == 0, "Nothing");
      import_backing_method_GetDiscription3 = new Return<string, string>(header => $"{header} is {Option}");
    }

    public int Option
    {
      get => backing_field_Option;
      set
      {
        if (!import_backing_set_Option1.Invoke(value))
          return;
        if (!import_backing_set_Option2.Invoke(value))
          return;
        if (!import_backing_set_Option3.Invoke(value))
          return;
      }
    }

    public string GetDiscription(string header)
    {
      string returnValue = null;
      object[] parameters = new object[] { header };
      if (!import_backing_method_GetDiscription1.Invoke(parameters, ref returnValue))
        return returnValue;
      if (!import_backing_method_GetDiscription2.Invoke(parameters, ref returnValue))
        return returnValue;
      if (!import_backing_method_GetDiscription3.Invoke(parameters, ref returnValue))
        return returnValue;
      return returnValue;
    }

    public event PropertyChangedEventHandler PropertyChanged;
  }
}
