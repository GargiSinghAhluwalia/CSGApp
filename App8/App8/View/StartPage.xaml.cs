using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App8.View
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        
        private void HouseButton_Clicked(object sender, EventArgs e)
        {
            var stackCount = Navigation.NavigationStack.Count;
            Navigation.PushAsync(new HousePage());
        }

        private void FarmButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FarmPage());
        }

        
    }
    }

