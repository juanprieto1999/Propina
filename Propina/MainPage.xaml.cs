using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Propina
{
    public partial class MainPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //Conversion de variables
            double total = double.Parse(Etotal.Text);
            double propina =double.Parse(Epropina.Text);
            int numeropersona = Convert.ToInt32(Enpersonas.Text);
            double respropina = (total * propina) / 100;
            double resTotal = total + respropina;
            double rsProPe = respropina / numeropersona;
            double resTolPers = resTotal / numeropersona;

            //Set De Text

            Tpropina.Detail = "$"+respropina;
            Total.Detail = "$" + resTotal; 
            Tpropinap.Detail = "$" + rsProPe;
            Ttpersona.Detail = "$" + resTolPers;



        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
