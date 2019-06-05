using Javeriana.Helpers;
using Javeriana.Models;
using Javeriana.Services.Res;
using Javeriana.Views;
using Proyecto.Droid.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Javeriana.ViewModels
{
    public class HorarioViewModel : Horario
    {
        //Atributos
        private List<Horario> horarios;
        private List<Detalle> detallesHoras;
        public ServiciosRes servicioJaveriana = new ServiciosRes();

        //Constructores
        public HorarioViewModel()
        {
            this.initialConfiguration();
        }

        //Métodos
        public List<Horario> Horarios
        {
            get { return horarios; }
            set
            {
                horarios = value;
                OnPropertyChanged();
            }
        }

        public List<Detalle> DetallesHoras
        {
            get { return detallesHoras; }
            set
            {
                detallesHoras = value;
                OnPropertyChanged();
            }
        }

        private async void initialConfiguration()
        {
            Horarios = await servicioJaveriana.getHorario(GlobalVariables.TokenUser);
            DetallesHoras = await servicioJaveriana.getHoras(Horarios);
            //Console.WriteLine("LIsta de horarios : " + Horarios.)
        }
    }
}