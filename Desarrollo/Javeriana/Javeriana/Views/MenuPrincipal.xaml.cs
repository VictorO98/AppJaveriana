using Javeriana.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Javeriana.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : ContentPage
    {
        //Atributos
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Open_Asignatura(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cursos());
        }

        private void Open_Horario(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Horarios());
        }

        private void Open_Libros(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Biblioteca());
        }

        private void Open_Noticias(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Noticias());
        }
    }
}