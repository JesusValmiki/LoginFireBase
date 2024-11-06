using Prototipo_pia.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototipo_pia
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PageMain());
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
