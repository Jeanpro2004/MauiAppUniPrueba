using RodriguezCalvaRualesMAUIUniWay.ViewModels;

namespace RodriguezCalvaRualesMAUIUniWay.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = new ProfileViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Recargar datos del usuario al aparecer
            if (BindingContext is ProfileViewModel viewModel)
            {
                await viewModel.LoadUserData();
            }
        }

        private async void OnExportDataClicked(object sender, EventArgs e)
        {
            try
            {
                if (BindingContext is ProfileViewModel viewModel)
                {
                    var confirm = await DisplayAlert("Exportar Datos",
                        "�Quieres exportar todos tus datos de UniWay?",
                        "Exportar", "Cancelar");

                    if (confirm)
                    {
                        // Aqu� se implementar�a la exportaci�n
                        await DisplayAlert("Exportaci�n",
                            "Funcionalidad de exportaci�n estar� disponible pr�ximamente", "OK");
                    }
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Error exportando datos: {ex.Message}", "OK");
            }
        }

        private async void OnViewStatsClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Estad�sticas",
                "Panel de estad�sticas estar� disponible pr�ximamente", "OK");
        }
    }
}