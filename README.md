# XamarinFormsBindingViewModel
Bind ViewModel sample

## Pickuped code
### Page1.xaml
```xml
  ....
  <Label Text="{Binding MainText}" .... />
  <Button Text="Change model's value" Clicked="Button_Clicked" />
  ....
```

### Page1.xaml.cs
```cs
public partial class Page1 : ContentPage
{
    MyViewModel m_model = new MyViewModel();

    public Page1()
    {
        InitializeComponent();
        m_model = new MyViewModel();
        this.BindingContext = m_model; // Bind MyViewModel
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Change binding value
        m_model.MainText = "<" + m_model.MainText + ">";
    }
}
```

### MyViewModel.cs
```cs

public class MyViewModel : INotifyPropertyChanged
{
    private string mainText = "World";
    public string MainText
    {
        get{ return mainText; }
        set{ mainText = value; OnPropertyChanged("MainText"); }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string name)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
```

## Screenshot
![screenshot](https://raw.githubusercontent.com/xamarin-samples/XamarinFormsBindingViewModel/master/screenshots/screenshot.png)
