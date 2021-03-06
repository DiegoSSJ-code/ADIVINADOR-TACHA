using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ADIVINADOR_TACHA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void op1_Clicked(object sender, EventArgs e)
        {
            instruccioneslbl.Text = " ";
            resultado_final.Text = " ";
            instruccioneslbl.Text = "Piense en el numero que quiere que le adivine.";
        }

        private void op2_Clicked(object sender, EventArgs e)
        {
            instruccioneslbl.Text = " ";
            instruccioneslbl.Text = "El numero en el que esta pensando multipliquelo por 2 ( x * 2 )";
        }

        private void op3_Clicked(object sender, EventArgs e)
        {
            instruccioneslbl.Text = " ";
            instruccioneslbl.Text = "Al resultado anterior sumale 8 ( x + 8 )";
        }

        private void op4_Clicked(object sender, EventArgs e)
        {
            instruccioneslbl.Text = " ";
            instruccioneslbl.Text = "El resultado anterior multipliquelo por 5 ( x * 5 )";
        }

        private void op5_Clicked(object sender, EventArgs e)
        {
            instruccioneslbl.Text = " ";
            instruccioneslbl.Text = "Por favor en la parte de abajo ingrese el resultado final ( x )";
        }

        private void calc_Clicked(object sender, EventArgs e)
        {
            string result;
            int resta;
            result = resultado_final.Text;
            string prin = result.Substring(0, result.Length - 1);
            string xsa = result.Remove(result.Length - 1);
            resta = Convert.ToInt32(xsa) - 4;
            DisplayAlert("ADIVINÉ!", $"El numero que estaba pensando usted es: {resta}" , "OK");
        }

        private void limp_Clicked(object sender, EventArgs e)
        {
            instruccioneslbl.Text = " ";
            resultado_final.Text = " ";
        }
    }
}
