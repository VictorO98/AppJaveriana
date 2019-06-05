using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Javeriana.Models
{
    public class MensajeError : INotifyPropertyChanged
    {
        //Atributos
        private string message;
        private bool hasError = false;

        public event PropertyChangedEventHandler PropertyChanged;

        //Métodos
        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                OnPropertyChanged();
            }
        }

        public bool HasError
        {
            get { return hasError; }
            set
            {
                hasError = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName]string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}
