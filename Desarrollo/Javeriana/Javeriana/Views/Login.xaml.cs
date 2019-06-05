using Javeriana.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Javeriana.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        //Atributos
        UsuarioViewModel context = new UsuarioViewModel();
        
        public Login()
        {
            InitializeComponent();
            BindingContext = context;
            lblContraFun();
        }
        
        void lblContraFun()
        {
            lblContra.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() =>
                {
                    Device.OpenUri(new Uri("https://gcu.javerianacali.edu.co/GestionCuentasUsuariosPUJ/"));
                })
            });
        }
    }
}