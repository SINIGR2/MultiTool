namespace MultiTool.Model;

public class Properties
{
    public Properties(string title)
    {
        PageTitle = title;
    }

    public string PageTitle { get; }
    public int DeviceAddress { get; set; }
    public string PortName { get; set; }
    public int PortSpeed { get; set; }
    public int Timeout { get; set; }
}
