using AppCadernoVirtual.Terceiro;
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
    public partial class TerceiroPage : ContentPage
    {
        public TerceiroPage()
        {
            InitializeComponent();
        }

        private void Button_3Port(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesTerceiro());
        }

        private void Button_3Mat(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MatematicaTerceiro());
        }

        private void Button_3Geo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeografiaTerceiro());
        }

        private void Button_3Hist(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistoriaTerceiro());
        }

        private void Button_3Bio(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BiologiaTerceiro());
        }

        private void Button_3Edu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EduFisicaTerceiro());
        }

        private void Button_3Fil(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilosofiaTerceiro());
        }

        private void Button_3Fis(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FisicaTerceiro());
        }


        private void Button_3Qui(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuimicaTerceiro());
        }

        private void Button_3Ing(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesTerceiro());
        }

        private void Button_3Socio(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SociologiaTerceiro());
        }

        private void Button_QualTeste(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QualTSTerceiro());
        }

        private void Button_3Web(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PWebTerceiro());
        }

        private void Button_Internet(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InternetTerceiro());
        }

        private void Button_3Mob(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MobileTerceiro());
        }
        private void Button_TCC(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TCC());
        }
    }
}
