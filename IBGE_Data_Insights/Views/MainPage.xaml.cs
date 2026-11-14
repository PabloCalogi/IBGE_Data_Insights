using IBGE_Data_Insights.Models;
using IBGE_Data_Insights.Services;

namespace IBGE_Data_Insights.Views
{
    public partial class MainPage : ContentPage
    {
        private readonly IbgeService _ibgeService;

        public MainPage()
        {
            InitializeComponent();
            _ibgeService = new IbgeService();
            CarregarEstados();
        }

        private async void CarregarEstados()
        {
            LoadingIndicator.IsRunning = true;
            LoadingIndicator.IsVisible = true;

            var estados = await _ibgeService.GetEstadosAsync();
            EstadoPicker.ItemsSource = estados;

            LoadingIndicator.IsRunning = false;
            LoadingIndicator.IsVisible = false;
        }

        private async void OnEstadoSelecionado(object sender, EventArgs e)
        {
            if (EstadoPicker.SelectedItem is Estado estadoSelecionado)
            {
                LoadingIndicator.IsRunning = true;
                LoadingIndicator.IsVisible = true;

                var nomesMasculinos = await _ibgeService.GetNomesPorLocalidadeAsync(estadoSelecionado.id, "M");
                var nomesFemininos = await _ibgeService.GetNomesPorLocalidadeAsync(estadoSelecionado.id, "F");

                ListaHomens.ItemsSource = nomesMasculinos;
                ListaMulheres.ItemsSource = nomesFemininos;

                LoadingIndicator.IsRunning = false;
                LoadingIndicator.IsVisible = false;
            }
        }
    }
}