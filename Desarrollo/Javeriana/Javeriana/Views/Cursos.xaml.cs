using Javeriana.ViewModels;
using Proyecto.Droid.Models;
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
    public partial class Cursos : ContentPage
    {
        AsignaturaViewModel context = new AsignaturaViewModel();
        public Cursos()
        {
            InitializeComponent();
            BindingContext = context;
        }
    }
}