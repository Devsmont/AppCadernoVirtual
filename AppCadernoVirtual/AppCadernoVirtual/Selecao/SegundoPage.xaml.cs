using AppCadernoVirtual.Segundo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirtual.Selecao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegundoPage : ContentPage
    {
        public SegundoPage()
        {
            InitializeComponent();
        }

        private void Button_2Port(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesSegundo());
        }

        private void Button_2Mat(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MatematicaSegundo());
        }

        private void Button_2Geo(object sender, EventArgs e)
        {
           Navigation.PushAsync(new GeografiaSegundo());
        }

        private void Button_2Hist(object sender, EventArgs e)
        {
           Navigation.PushAsync(new HistoriaSegundo());
        }

        private void Button_2Bio(object sender, EventArgs e)
        {
           Navigation.PushAsync(new BiologiaSegundo());
        }

        private void Button_2Edu(object sender, EventArgs e)
        {
           Navigation.PushAsync(new EduFisicaSegundo());
        }

        private void Button_2Fil(object sender, EventArgs e)
        {
           Navigation.PushAsync(new FilosofiaSegundo());
        }

        private void Button_2Fis(object sender, EventArgs e)
        {
           Navigation.PushAsync(new FisicaSegundo());
        }

        private void Button_Eti(object sender, EventArgs e)
        {
           Navigation.PushAsync(new EticaSegundo());
        }

        private void Button_2Qui(object sender, EventArgs e)
        {
           Navigation.PushAsync(new QuimicaSegundo());
        }

        private void Button_2Ing(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesSegundo());
        }

        private void Button_2Socio(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SociologiaSegundo());
        }

        private void Button_2BD(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BDSegundo());
        }

        private void Button_2Web(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProgWebSegundo());
        }

        private void Button_SisEmb(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SistEmbarcadosSegundo());
        }

        private void Button_Mob(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MobileSegundo());
        }
    }
}