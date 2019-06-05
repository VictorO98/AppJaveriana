using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Javeriana.Models
{
    public class Cuerpo : INotifyPropertyChanged
    {
        //Eventos
        public event PropertyChangedEventHandler PropertyChanged;

        //Atributos
        [JsonProperty("nid")]
        private string idNoticia;

        [JsonProperty("Publicado")]
        private string publicado;

        [JsonProperty("path")]
        private string path;

        [JsonProperty("tittle")]
        private string title;

        [JsonProperty("field_image_box")]
        private string image;

        [JsonProperty("body")]
        private string body;

        //Métodos
        #region Getters/Setters
            public string Body
            {
                get { return body; }
                set
                {
                    body = value;
                    OnPropertyChanged();
                }
            }

            public string Image
            {
                get { return image; }
                set
                {
                    image = value;
                    OnPropertyChanged();
                }
            }

            public string Title
            {
                get { return title; }
                set
                {
                    title = value;
                    OnPropertyChanged();
                }
            }

            public string Path
            {
                get { return path; }
                set
                {
                    path = value;
                    OnPropertyChanged();
                }
            }

            public string Publicado
            {
                get { return publicado; }
                set
                {
                    publicado = value;
                    OnPropertyChanged();
                }
            }

            public string IdNoticia
            {
                get { return idNoticia; }
                set
                {
                    idNoticia = value;
                    OnPropertyChanged();
                }
            }
        #endregion

        public void OnPropertyChanged([CallerMemberName]string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

    }
    public class Noticia : INotifyPropertyChanged
    {
        //Eventos
        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("rows")]
        public List<Cuerpo> detallesNoticias { get; set; }

        public void OnPropertyChanged([CallerMemberName]string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

    }
}
