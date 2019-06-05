using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Proyecto.Droid.Models
{
    public class Asignatura : INotifyPropertyChanged
    {
        //Eventos
        public event PropertyChangedEventHandler PropertyChanged;

        // Atributos
        [JsonProperty("coda")]
        private string idAsignatura;

        [JsonProperty("nom")]
        private string nombreAsignatura;

        [JsonProperty("notp")]
        private string nota;

        [JsonProperty("class_section")]
        private string grupo;

        [JsonProperty("porci")]
        private string porcentajeInasistencia;

        //Metodos
        #region Getters/Setters
            public string PorcentajeInasistencia
            {
                get { return porcentajeInasistencia; }
                set
                {
                    porcentajeInasistencia = value;
                    OnPropertyChanged();
                }
            }

            public string Grupo
            {
                get { return grupo; }
                set
                {
                    grupo = value;
                    OnPropertyChanged();
                }
            }

            public string Nota
            {
                get { return nota; }
                set
                {
                    nota = value;
                    OnPropertyChanged();
                }
            }

            public string NombreAsignatura
            {
                get { return nombreAsignatura; }
                set
                {
                    nombreAsignatura = value;
                    OnPropertyChanged();
                }
            }

            public string IdAsignaruta
            {
                get { return idAsignatura; }
                set
                {
                    idAsignatura = value;
                    OnPropertyChanged();

                }
            }
        #endregion

        public void OnPropertyChanged([CallerMemberName]string nombreAsignatura = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombreAsignatura));
        }


    }
}