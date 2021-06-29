using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using birreria.Interfaces;
using Refit;
using Xamarin.Forms;

namespace birreria
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetBirrerie();
        }

        async void GetBirrerie()
        {
            var apiResponse = RestService.For<IBirreriaApi>("https://api.openbrewerydb.org");
            var listaBirrerie = await apiResponse.GetBirrerie();
        }
    }
}
