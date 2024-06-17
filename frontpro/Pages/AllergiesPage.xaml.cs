namespace frontpro.Pages
{
    public partial class AllergiesPage : ContentPage
    {
        public AllergiesPage()
        {
            InitializeComponent();
            BindingContext = new AllergiesViewModel();
        }

        private async void Save(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new loading());
        }
    }
}
