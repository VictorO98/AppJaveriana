using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Proyecto.Droid.Models
{
    public class Usuario : INotifyPropertyChanged
    {
        //Atributos
        private long idUsuario;
        private string userName;
        private string password;

        //Web Service Result
        [JsonProperty("valido")]
        private bool isValido;

        [JsonProperty("nombre")]
        private string nombre;

        [JsonProperty("apellido")]
        private string apellido;

        [JsonProperty("periodo")]
        private string periodo;

        [JsonProperty("emplid")]
        private string emplid;

        [JsonProperty("x-t6519fdd1s5q")]
        private string token;


        //Métodos
        #region Getters/Setters

            public long IdUsuario
            {
                get { return idUsuario; }
                set
                {
                    idUsuario = value;
                    OnPropertyChanged();
                }
            }

            public string UserName
            {
                get { return userName; }
                set
                {
                    userName = value;
                    OnPropertyChanged();
                }
            }

            public string Password
            {
                get { return password; }
                set
                {
                    password = value;
                    OnPropertyChanged();
                }
            }

            public string Nombre
            {
                get { return nombre; }
                set
                {
                    nombre = value;
                    OnPropertyChanged();
                }
            }

            public bool IsValido
            {
                get { return isValido; }
                set
                {
                    isValido = value;
                    OnPropertyChanged();
                }
            }

            public string Token
            {
                get { return token; }
                set
                {
                    token = value;
                    OnPropertyChanged();
                }
            }

            public string Emplid
            {
                get { return emplid; }
                set
                {
                    emplid = value;
                    OnPropertyChanged();
                }
            }

            public string Periodo
            {
                get { return periodo; }
                set
                {
                    periodo = value;
                    OnPropertyChanged();
                }
            }

            public string Apellido
            {
                get { return apellido; }
                set
                {
                    apellido = value;
                    OnPropertyChanged();
                }
            }

        #endregion

        //Eventos
        public event PropertyChangedEventHandler PropertyChanged;

        //Métodos
        public void OnPropertyChanged([CallerMemberName]string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}