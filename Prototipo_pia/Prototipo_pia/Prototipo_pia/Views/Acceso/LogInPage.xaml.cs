using Prototipo_pia.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototipo_pia.Views.Acceso
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPage : ContentPage
    {
        public LogInPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(Navigation);
        }

        //private async void Ingresar_Clicked(object sender, EventArgs e)
        //{
        //    string username = TxtUsuario.Text;
        //    string password = TxtPassword.Text;

        //    if(IsValideDate(username,password))
        //    {
        //        await DisplayAlert("Logrado", "Inicio Exitoso", "Ok");

        //        await Navigation.PushAsync(new MenuPrincipalPage());
        //    }
        //    else
        //    {
        //        await DisplayAlert("Error", "Datos Incorrectos", "Ok");
        //    }
        //}

        //private bool IsValideDate(string username, string password)
        //{
        //    return username == "1" && password == "1234";
        //}
    }
}