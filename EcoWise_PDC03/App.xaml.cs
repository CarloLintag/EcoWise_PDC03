using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcoWise_PDC03.View;

namespace EcoWise_PDC03
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
