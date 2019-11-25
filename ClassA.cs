class ClassA : INotifyPropertyChanged
{
  ILogger _logger = Logger.FindLogger(nameof(ClassA));

  int Option
  {
    get;
    set
      .SkipIfSame()
      .Set()
      .NotifyPropertyChanged();
  }

  string GetDiscription(string header)
    .Log(_logger, nameof(GetDiscription), header)
    .SkipIf<string>( () => Option == 0, "Nothing")
    .Return<string>($"{header] is {Option}")

  event PropertyChangedEventHandler PropertyChanged;
}
