namespace ariasJEvDos;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(ChistesPage), typeof(ChistesPage));
        Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
    }
}
