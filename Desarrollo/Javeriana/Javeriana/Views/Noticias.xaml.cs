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
    public partial class Noticias : ContentPage
    {
        //Atributos
        NoticiaViewModel contextNoticia = new NoticiaViewModel();
        public Noticias()
        {
            InitializeComponent();
            BindingContext = contextNoticia;
        }
    }
}