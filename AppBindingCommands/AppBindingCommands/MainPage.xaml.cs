using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppBindingCommands
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();   

        }

        private void btnAtualizarInfo_Clicked(object sender, EventArgs e)
        {
            string informações = string.Empty;

            if (Application.Current.Properties.ContainsKey("AcaoInicial"))
                informações += Application.Current.Properties["AcaoInicial"];

            if(Application.Current.Properties.ContainsKey("AcaoStart"))
                informações += Application.Current.Properties["AcaoStart"];

            if(Application.Current.Properties.ContainsKey("AcaoSleep"))
                informações += Application.Current.Properties["AcaoSleep"];

            if(Application.Current.Properties.ContainsKey("AcaoResume"))
                informações += Application.Current.Properties["AcaoResume"];


            lblInformacoes.Text = informações;



        }
    }
}
