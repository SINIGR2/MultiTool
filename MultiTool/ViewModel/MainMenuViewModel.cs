namespace MultiTool.ViewModel;

public partial class MainMenuViewModel : BaseViewModel
{
    public ObservableCollection<MainMenuItem> MainMenu { get; } = new();

    private Properties properties;

    public MainMenuViewModel()
    {
        Title = "MultiTool";
        properties = new Properties("Настройки");
        CreateMenu();
    }

    [RelayCommand]
    async Task GoToSelectedPage(MainMenuItem mainMenu)
    {
        if (mainMenu is null)
            return;

        switch (mainMenu.Name)
        {
            case nameof(Properties):
                await Shell.Current.GoToAsync(nameof(PropertiesPage), true, new Dictionary<string, object>
                {
                    { "Properties", properties }
                });
                break;
        }
    }

    private void CreateMenu()
    {
        MainMenu.Add(new MainMenuItem()
        {
            Title = "Конфигуратор Modbus",
            Icon = "",
            Name = ""
        });

        MainMenu.Add(new MainMenuItem()
        {
            Title = "Подключения",
            Icon = "",
            Name = ""
        });

        MainMenu.Add(new MainMenuItem()
        {
            Title = "Настройки",
            Icon = "",
            Name = nameof(Properties)
        });
    }
}