using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Javeriana.Models;
using Proyecto.Droid.Models;
using Javeriana.Helpers;
using System.Collections.ObjectModel;
using System;

namespace Javeriana.Services.Res
{
    public class ServiciosRes
    {  
        //Atributos
        private readonly HttpClient client;
        private MensajeError mensajeError;

        //Constructores
        public ServiciosRes()
        {
            client = new HttpClient();
            mensajeError = new MensajeError();
        }

        //Métodos
        public async Task<MensajeError> LoginCliente(Usuario usuario)
        {
            try
            {
                Dictionary<string, string> queryParameters = new Dictionary<string, string>();
                queryParameters.Add("usu", usuario.UserName);
                queryParameters.Add("pass", usuario.Password);

                var queryString = new FormUrlEncodedContent(queryParameters);
                var url = GlobalVariables.BaseUrl + GlobalVariables.LoginUrl + queryString.ReadAsStringAsync().Result;

                var content = await client.GetStringAsync(url);
                Usuario LoginUsuario = JsonConvert.DeserializeObject<Usuario>(content);

                GlobalVariables.TokenUser = LoginUsuario.Token; 
                
                if (LoginUsuario.IsValido)
                {
                    mensajeError.Message = "Exitoso";
                    mensajeError.HasError = true;
                }
                else
                {
                    mensajeError.Message = "Credenciales No validas";
                    mensajeError.HasError = false;
                }
            }
            catch(HttpRequestException e)
            {
                mensajeError.Message = "Error de Comunicación";
                mensajeError.HasError = false;
            }

            return mensajeError;
        }

        public async Task<List<Asignatura>> getAsignaturas(string token)
        {
            string url = GlobalVariables.BaseUrl + GlobalVariables.AsignaturasUrl;
            string content = "";
            client.DefaultRequestHeaders.Add("x-t6519fdd1s5q", token);
            content = await client.GetStringAsync(url);
            List<Asignatura> asignaturas = JsonConvert.DeserializeObject<List<Asignatura>>(content);
            return asignaturas;
        }

        public async Task<List<Horario>> getHorario(string token)
        {
            string url = GlobalVariables.BaseUrl + GlobalVariables.AsignaturasUrl;
            string content = "";
            client.DefaultRequestHeaders.Add("x-t6519fdd1s5q", token);
            content = await client.GetStringAsync(url);
            List<Horario> horarios = JsonConvert.DeserializeObject<List<Horario>>(content);
            return horarios;
        }

        public async Task<List<Detalle>> getHoras(List<Horario> horarios)
        {
            List<string> dias = new List<string>();
            dias.Add("Lunes "); dias.Add("Martes "); dias.Add("Miercoles "); dias.Add("Jueves "); 
            dias.Add("Viernes "); dias.Add("Sabado "); dias.Add("Domingo "); 
            List<Detalle> aux = new List<Detalle>();
            for(int i = 0; i < horarios.Count; i++)
            {
                var modelo = new Detalle();
                modelo.Nombre = horarios[i].NombreAsignatura;
                for(int j = 0; j < horarios[i].horario.Count; j++)
                {
                    int indexDay = Int32.Parse(horarios[i].horario[j].DiaSemana);
                    modelo.FechaIn = horarios[i].horario[j].FechaIn;
                    modelo.Horas += horarios[i].horario[j].Horas + " ";
                    modelo.Salon = horarios[i].horario[j].Salon;
                    modelo.FechaFin = horarios[i].horario[j].FechaFin;
                    modelo.Docente = horarios[i].horario[j].Docente;
                    modelo.DiaSemana += dias[indexDay - 1];
                }
                aux.Add(modelo);
            }
            return aux;
        }

        public async Task<List<Libro>> getLibros(string token)
        {
            string url = GlobalVariables.BaseUrl + GlobalVariables.LibrosUrl;
            string content = "";
            client.DefaultRequestHeaders.Add("x-t6519fdd1s5q", token);
            content = await client.GetStringAsync(url);
            List<Libro> libros = JsonConvert.DeserializeObject<List<Libro>>(content);
            return libros;
        }
    }
}
