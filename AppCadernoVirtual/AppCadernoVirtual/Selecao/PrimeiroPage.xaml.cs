using AppCadernoVirtual.Primeiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirtual
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimeiroPage : ContentPage 
    {
        public PrimeiroPage()
        {
            InitializeComponent(); 
        }

        // Criação de uma variavel Button, que retorna  ao Clicked, a sua resposta, nesse caso, redirecionando
        // o usuario para uma outra tela
        private void Button_1Port(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro()); // codigo para redirecionar o usuario
        }

        private void Button_1Mat(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MatematicaPrimeiro());
        }

        private void Button_1Geo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeografiaPrimeiro());
        }

        private void Button_1Hist(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistoriaPrimeiro());
        }

        private void Button_1Bio(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BiologiaPrimeiro());
        }

        private void Button_1Edu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EduFisicaPrimeiro());
        }

        private void Button_1Filo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilosofiaPrimeiro());
        }

        private void Button_1Fisi(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FisicaPrimeiro());
        }

        private void Button_1Arte(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArtePrimeiro());
        }

        private void Button_1Quim(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuimicaPrimeiro());
        }

        private void Button_1Ing(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesPrimeiro());
        }

        private void Button_Analise(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AnalisePrimeiro());
        }

        private void Button_1ProgWeb(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProgwebPrimeiro());
        }

        private void Button_1BD(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BDPrimeiro());
        }

        private void Button_Des(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DesignPrimeiro());
        }

        private void Button_FundInfo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FundInfoPrimeiro());
        }

        private void Button_Log(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LogeProg());
        }
    }
}