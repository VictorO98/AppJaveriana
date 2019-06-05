using Javeriana.Helpers;
using Javeriana.Services.Res;
using Javeriana.Views;
using Proyecto.Droid.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Javeriana.ViewModels
{
    public class LibroViewModel :Libro
    {
        //Atributos
        List<Libro> libros;
        public ServiciosRes servicioJaveriana = new ServiciosRes();

        //Constructores
        public LibroViewModel()
        {
            this.initialConfiguration();
        }

        //Métodos
        public List<Libro> Libros
        {
            get { return libros; }
            set
            {
                libros = value;
                OnPropertyChanged();
            }
        }

        private async void initialConfiguration()
        {
            Libros = await servicioJaveriana.getLibros(GlobalVariables.TokenUser);
        }
    }
}
