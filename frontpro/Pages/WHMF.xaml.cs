namespace frontpro.Pages;
using Microsoft.Maui.Controls;
using System.Reflection;

public partial class WHMF : ContentPage
{
    

    public WHMF()
	{
        InitializeComponent();
	}

   

    public object Gender { get; private set; }

        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            // Handle the submit button click event here
            // Retrieve values from heightEntry, weightEntry, and GenderPicker
            var height = heightEntry.Value;
            var weight = weightEntry.Value;
            var nationality = GenderPicker.SelectedItem as string;
            await Navigation.PushAsync(new AllergiesPage());

            // Perform further processing or validation
            // For example, display an alert with the entered data
            _ = DisplayAlert("Submitted", $"Height: {height} cm, Weight: {weight} kg, Gender: {Gender}", "OK");
        }
    }
