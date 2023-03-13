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
        // Variável vez para controlar de quem é a vez
        // de jogar. Foi declarada como propriedade da classe
        // para poder ser alterada a partir de qualquer
        // método: Button_Clicked() e zerar()
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            /* Informa ao C# qual foi o botão que disparou
             * o evento. Criamos uma variável chamada btn
             * do tipo Button que irá armazenar o valor da
             * variável sender que foi promovida a Button. 
             */
            Button btn = (Button)sender;

            // Desabilitamos o botão que foi clicado.
            btn.IsEnabled= false;

            // Se a vez for do X, definimos o botão como X
            // e alteramos o valor da variável vez para que
            // no próximo clique marque como O
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

        /**
         * Método para zerar o jogo. Trocamos o valor de todos
         * os botões para vazio, reabilitamos os botões e
         * voltamos o valor da variável vez para X
         */ 
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

        } // Fecha o método para zerar

    } // Fecha classe
} // Fecha namespace
