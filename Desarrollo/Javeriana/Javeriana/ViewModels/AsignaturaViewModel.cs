using Javeriana.Helpers;
using Javeriana.Services;
using Javeriana.Services.Res;
using Javeriana.Views;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Proyecto.Droid.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Javeriana.ViewModels
{
    public class AsignaturaViewModel : Asignatura
    {
        //Atributos
        private List<Asignatura> asignaturas;
        public ServiciosRes serviciosJaveriana = new ServiciosRes();

        //Constructores
        public AsignaturaViewModel()
        {
            this.initialConfiguration();
        }

        //Métodos
        public List<Asignatura> Asignaturas
        {
            get { return asignaturas; }
            set
            {
                asignaturas = value;
                OnPropertyChanged();
            }
        }

        private async void initialConfiguration()
        {
            Asignaturas = await serviciosJaveriana.getAsignaturas(GlobalVariables.TokenUser);
        }

    }
}
