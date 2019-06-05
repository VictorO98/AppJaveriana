using Javeriana.Helpers;
using Javeriana.Models;
using Javeriana.Services.Res;
using Javeriana.Views;
using Javeriana.WebServiceResults;
using Plugin.Connectivity;
using Proyecto.Droid.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Javeriana.ViewModels
{
    public class UsuarioViewModel : Usuario
    {
        //Atributos
        Usuario usuario;
        public ServiciosRes serviciosJaveriana;
        private MensajeError mensajeError;
        
        //Constructores
        public UsuarioViewModel()
        {
            usuario = new Usuario();
            serviciosJaveriana = new ServiciosRes();
            mensajeError = new MensajeError();
            IngresarCommand = new Command(async () => await Ingresar(), () => true);
        }

        //Eventos
        public Command IngresarCommand { get; set; }

        //Métodos
        public MensajeError MensajeError
        {
            get { return mensajeError; }
            set
            {
                mensajeError = value;
                OnPropertyChanged();
            }
        }

        private async Task Ingresar()
        {
            usuario.UserName = UserName;
            usuario.Password = Password;
            MensajeError = await serviciosJaveriana.LoginCliente(usuario);
            if (mensajeError.HasError)
            {
                Application.Current.MainPage = new NavigationPage(new MenuPrincipal());
            }

        }
    }
}
