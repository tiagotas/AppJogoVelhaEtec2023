using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled= false;

            if(vez == "X")
            {
                btn.Text= "X";
                vez= "O";

            } else
            {
                btn.Text = "O";
                vez = "X";
            }

            // Verificando se X ganhou na 1ª linha
            if(btn10.Text == "X" &&
               btn11.Text == "X" &&
               btn12.Text == "X") 
            {
                DisplayAlert("Parabéns", "O X Ganhou!", "OK");
                zerar();
            }

            // Verificando se X ganhou na 2ª linha
            if (btn20.Text == "X" &&
               btn21.Text == "X" &&
               btn22.Text == "X")
            {
                DisplayAlert("Parabéns", "O X Ganhou!", "OK");
                zerar();
            }

        } // Fecha Button_Clicked

        private void zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";

            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";

            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;

            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;

            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

            vez = "X";
        }

    } // Fecha classe
} // Fecha namespace
