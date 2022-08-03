namespace MultiTool;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(PropertiesPage), typeof(PropertiesPage));
	}
}
