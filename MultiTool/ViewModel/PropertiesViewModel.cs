namespace MultiTool.ViewModel;

//[QueryProperty(nameof(Properties), "Properties")]
public partial class PropertiesViewModel : ObservableObject
{
    public PropertiesViewModel()
    {
        properties = new Properties("Настройки");
    }

    [ObservableProperty] private Properties properties;
}