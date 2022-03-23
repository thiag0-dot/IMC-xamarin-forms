using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace imc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e) 
        {
            //Variaveis
            double altura = Convert.ToDouble(txt_altura.Text);
            double peso = Convert.ToDouble(txt_peso.Text);
            double imc = peso / (altura * altura);


            //---------------vendo qual o seu imc----------------------
            if (imc < 18.5 & imc == 18.5)
            {
                DisplayAlert("VAI COME! voce esta abaixo do peso:", "Seu imc é de: " + imc.ToString("F2"), "ok");
            }
            else if (imc > 18.6 & imc < 24.9)
            {
                DisplayAlert("voce esta com o peso normal PARABENS:", "Seu imc é de: " + imc.ToString("F2"), "ok");
            }
            else if (imc > 25 & imc< 29.9)
            {
                DisplayAlert("CUIDADO! voce esta com obesidade classe I:", "Seu imc é de: " + imc.ToString("F2"), "ok");
            }
            else if (imc > 35 & imc< 39.9)
            {
                DisplayAlert("CUIDADO! voce esta com obesidade classe II:", "Seu imc é de: " + imc.ToString("F2"), "ok");
            }
            else if (imc > 40) 
            {
                DisplayAlert("VOCE JA PODE PARTICIPAR DO QUILOS MORTAIS! voce esta com obesidade classe III: ", "Seu imc é de: " + imc.ToString("F2"), "ok");
            }
            else 
            {
                DisplayAlert("ERRO", "ERRO", "ok");
            }


        }

    }
}
