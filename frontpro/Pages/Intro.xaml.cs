namespace frontpro.Pages;

public partial class Intro : ContentPage
{
	public Intro()
	{
		InitializeComponent();
	}
    private async void startlicked(object sender, EventArgs e)
    {
      

        await Navigation.PushAsync(new SignIn1());
    }
}