using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Currency
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Double currencyInDollars = Double.Parse(dollarCurrency.Text);

            Double currencyInRupees = currencyInDollars * 69.79;

            
            convertedCurrency.Text = currencyInRupees.ToString();

        }
    }
}
