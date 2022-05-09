using AppCadernoVirtual.Selecao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCadernoVirtual
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Primeiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroPage());
        }

        private void Button_Segundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoPage());
        }

        private void Button_Terceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroPage());
        }
    }
}
