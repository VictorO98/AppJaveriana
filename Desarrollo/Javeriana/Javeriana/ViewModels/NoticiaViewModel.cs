using Javeriana.Models;
using Javeriana.Services.Res;
using Javeriana.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Javeriana.ViewModels
{
    public class NoticiaViewModel : Noticia
    {
        //Atributos
        Noticia noticia;
        private ObservableCollection<Noticia> noticias;
        public ServiciosRes noticiaRest;

        //Constructores
        public NoticiaViewModel()
        {
            noticia = new Noticia();
            noticiaRest = new ServiciosRes();
            ListarNotCommand = new Command(async () => await listar(), () => true);
            detalleCommand = new Command(async () => await detalle(), () => true);
        }

        //Eventos
        public Command ListarNotCommand { get; set; }
        public Command detalleCommand { get; set; }

        //Métodos
        private async Task listar()
        {
            //Application.Current.MainPage = new NavigationPage(new Noticias());
            Console.WriteLine("Entro al noticia");

        }

        private async Task detalle()
        {

        }
    }
}
