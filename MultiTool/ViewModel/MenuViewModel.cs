namespace MultiTool.ViewModel;

public partial class MenuViewModel : BaseViewModel
{
    private Settings settings;

    public MenuViewModel()
    {
        settings = new Settings();
    }

    [RelayCommand]
    async Task GoToSettings()
    {
        if (settings is null)
            return;

        await Shell.Current.GoToAsync(nameof(SettingsPage), true, new Dictionary<string, object>
        {
            { "Settings", settings }
        });
    }
}