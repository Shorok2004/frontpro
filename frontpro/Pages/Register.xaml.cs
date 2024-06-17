namespace frontpro.Pages;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}
    private async void redisterbutton_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WHMF());



    }
}