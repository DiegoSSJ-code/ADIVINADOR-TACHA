using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ADIVINADOR_TACHA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void paso1_Clicked(object sender, EventArgs e)
        {
            instruccioneslbl2.Text = "Piense en el dia de su fehca ade nacimieno. (12 de enero = 12)";
        }

        private void paso2_Clicked(object sender, EventArgs e)
        {
            instruccioneslbl2.Text = "Ahora multiplicalo por 20 ( x * 20 )";
        }

        private void paso3_Clicked(object sender, EventArgs e)
        {
            instruccioneslbl2.Text = "Al resultado anterior sumale 73 ( x + 73 )";
        }

        private void paso4_Clicked(object sender, EventArgs e)
        {
            instruccioneslbl2.Text = "El resultado anterior multipliquelo por 5 ( x * 5 )";
        }

        private void paso5_Clicked(object sender, EventArgs e)
        {
            instruccioneslbl2.Text = "Al resultado anterior sumale la fecha del mes de su cumpleaños (12 de enero = 1)";
        }

        private void paso6_Clicked(object sender, EventArgs e)
        {
            instruccioneslbl2.Text = "Por favor ingrese el resultado final abajo";
        }

        private void calcular_Clicked(object sender, EventArgs e)
        {
          
            int result, resta;
            string resultado, dia, mes;
            result = int.Parse(resultado_final2.Text);
            resta = result - 365;
            resultado = Convert.ToString(resta);
            char dia1 = resultado[0];
            char dia2 = resultado[1];
            char mes1 = resultado[2];
            char mes2 = resultado[3];
            dia = string.Concat(dia1, dia2);
            mes = string.Concat(mes1, mes2);
            DisplayAlert("ADIVINÉ!", $"El dia que nacio es {dia} de {mes}", "OK");
        }

        private void limpiar_Clicked(object sender, EventArgs e)
        {
            instruccioneslbl2.Text = "";
            resultado_final2.Text = "";
        }
    }
}