namespace MultiTool.View;

public partial class PropertiesPage : ContentPage
{
	public PropertiesPage(PropertiesViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}