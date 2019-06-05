using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Proyecto.Droid.Models
{
    public class Libro : INotifyPropertyChanged
    {
        [JsonProperty("codb")]
        private string idLibro;

        [JsonProperty("titu")]
        private string nombreLibro;

        [JsonProperty("stopo")]
        public string stopo;

        [JsonProperty("fecp")]
        private string fechaPedido;

        [JsonProperty("fecd")]
        private string fechaEntrega;

        [JsonProperty("mult")]
        private string multa;

        [JsonProperty("loca")]
        private string localidad;

        public event PropertyChangedEventHandler PropertyChanged;

        //Métodos
        #region Getters/Setters
        public string NombreLibro
        {
            get { return nombreLibro; }
            set { nombreLibro = value; OnPropertyChanged(); }
        }

        public string IdLibro
        {
            get { return idLibro; }
            set { idLibro = value; OnPropertyChanged(); }
        }

        public string Stopo
        {
            get { return stopo; }
            set { stopo = value; OnPropertyChanged(); }
        }

        public string FechaPedido
        {
            get { return fechaPedido; }
            set { fechaPedido = value; OnPropertyChanged(); }
        }

        public string FechaEntrega
        {
            get { return fechaEntrega; }
            set { fechaEntrega = value; OnPropertyChanged(); }
        }

        public string Multa
        {
            get { return multa; }
            set { multa = value; OnPropertyChanged(); }
        }

        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; OnPropertyChanged(); }
        }
        #endregion

        public void OnPropertyChanged([CallerMemberName]string nombreAsignatura = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombreAsignatura));
        }
    }
}