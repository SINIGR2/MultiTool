namespace MultiTool.View;

public partial class MainPage : ContentPage
{
	public MainPage(MenuViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}