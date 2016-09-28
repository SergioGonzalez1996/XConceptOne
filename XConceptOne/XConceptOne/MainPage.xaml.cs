using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XConceptOne
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Padding = Device.OnPlatform(
                new Thickness(10, 20, 10, 10),
                new Thickness(10),
                new Thickness(10) );

            convertButton.Clicked += ConvertButton_Clicked;
        }

        private async void ConvertButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pesosEntry.Text))
            {
                await DisplayAlert("Error", "Debes ingresar un valor en Pesos", "Aceptar");
                return;
            }
            decimal pesos = decimal.Parse(pesosEntry.Text);
            decimal dollars = pesos / 2957.56M;
            decimal euros = pesos / 3292.47M;
            decimal pounds = pesos / 3934.74M;

            dollarEntry.Text = string.Format("{0:N2}", dollars);
            eurosEntry.Text = string.Format("{0:N2}", euros);
            poundsEntry.Text = string.Format("{0:N2}", pounds);
        }
    }
}
