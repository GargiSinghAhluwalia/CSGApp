using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App8.View
{
    public partial class HousePage : ContentPage
    {
        public HousePage()
        {
            InitializeComponent();
        }
        private void WaterQualityButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WaterQualityPage1());
        }

        private void AirQualityButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AirQualityPage1());
        }
    }
}
