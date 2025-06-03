namespace ariasJEvDos;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void IrAChistes(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ChistesPage));
    }

    private async void IrAAbout(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AboutPage));
    }
}
