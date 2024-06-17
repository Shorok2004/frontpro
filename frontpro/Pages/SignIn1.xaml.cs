namespace frontpro.Pages;

public partial class SignIn1 : ContentPage
{
	public SignIn1()
	{
		InitializeComponent();
	}
	private async void onsignclicked(object sender, EventArgs e)
	{
		if(textemail.Text?.Length==0||textpassword.Text?.Length==0)
		{
			await DisplayAlert("alart ", "emai or password cannot be empty", "retry");
			return;
		}

		await Navigation.PushAsync(new WHMF());
	}
    private async void onredisterclicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Register());


    }
    private async void onforgetpasswordclicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ForgetPassword());
    }



}