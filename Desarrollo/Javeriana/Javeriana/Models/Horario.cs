using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Javeriana.Models
{ 
    public class Detalle : INotifyPropertyChanged
    {
        private string nombre;

        [JsonProperty("feci")]
        private string fechaIn;

        [JsonProperty("hora")]
        private string horas;

        [JsonProperty("saln")]
        private string salon;

        [JsonProperty("fecf")]
        private string fechaFin;

        [JsonProperty("doc")]
        private string docente;

        [JsonProperty("dia")]
        private string diaSemana;

        //Métodos
        #region Getters/Setters

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; OnPropertyChanged(); }
            }

            public string DiaSemana
            {
                get { return diaSemana; }
                set { diaSemana = value;
                OnPropertyChanged();
                    }
            }

            public string FechaIn
            {
                get { return fechaIn; }
                set { fechaIn = value; OnPropertyChanged(); }
            }

            public string Horas
            {
                get { return horas; }
                set { horas = value; OnPropertyChanged(); }
            }

            public string FechaFin
            {
                get { return fechaFin; }
                set { fechaFin = value; OnPropertyChanged(); }
            }

            public string Salon
            {
                get { return salon; }
                set { salon = value; OnPropertyChanged(); }
            }

            public string Docente
            {
                get { return docente; }
                set { docente = value; OnPropertyChanged(); }
            }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        public void OnPropertyChanged([CallerMemberName]string nombreAsignatura = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombreAsignatura));
        }
    }

    public class Horario : INotifyPropertyChanged
    {
        [JsonProperty("nom")]
        private string nombreAsignatura;

        [JsonProperty("horario")]
        public List<Detalle> horario { get; set; }

        public string NombreAsignatura
        {
            get { return nombreAsignatura; }
            set { nombreAsignatura = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string nombreAsignatura = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombreAsignatura));
        }
    }
}
