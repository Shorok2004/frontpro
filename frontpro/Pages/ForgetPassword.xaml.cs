namespace frontpro.Pages;

public partial class ForgetPassword : ContentPage
{
	public ForgetPassword()
	{
		InitializeComponent();
	}
    private async void ResetPasswordButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ForgetPassword());



    }
}