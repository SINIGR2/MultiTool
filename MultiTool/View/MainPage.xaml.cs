namespace MultiTool.View;

public partial class MainPage : ContentPage
{
	public MainPage(MainMenuViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}