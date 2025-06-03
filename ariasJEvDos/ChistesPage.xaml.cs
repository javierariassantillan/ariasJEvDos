using System.Net.Http.Json;

namespace ariasJEvDos;

public partial class ChistesPage : ContentPage
{
    HttpClient client = new HttpClient();

    public ChistesPage()
    {
        InitializeComponent();
        CargarChiste();
    }

    private async void CargarChiste()
    {
        try
        {
            var chiste = await client.GetFromJsonAsync<Joke>("https://official-joke-api.appspot.com/random_joke");
            lblChiste.Text = $"{chiste.setup}\n\n{chiste.punchline}";
        }
        catch
        {
            lblChiste.Text = "No se pudo cargar el chiste.";
        }
    }

    private void OtroChiste(object sender, EventArgs e)
    {
        CargarChiste();
    }

    public class Joke
    {
        public string type { get; set; }
        public string setup { get; set; }
        public string punchline { get; set; }
        public int id { get; set; }
    }
}
