using Proyecto.Droid.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Javeriana.Services
{
    public class AsignaturaService
    {
        //Atributos
        public ObservableCollection<Asignatura> asignaturas { get; set; }

        //Constructor
        public AsignaturaService()
        {
            if(asignaturas == null)
            {
                asignaturas = new ObservableCollection<Asignatura>();
            }
        }

        //Métodos
        public ObservableCollection<Asignatura> Consultar()
        {
            return asignaturas;
        }

        public void Guardar(Asignatura asignatura)
        {
            asignaturas.Add(asignatura);
        }
        
        public void Modificar(Asignatura modelo)
        {
            for(int i = 0; i < asignaturas.Count; i++)
            {
                if(asignaturas[i].IdAsignaruta == modelo.IdAsignaruta)
                {
                    asignaturas[i] = modelo;
                }
            }
        }

        public void Eliminar(string idAsignatura)
        {
            Asignatura modelo = asignaturas.FirstOrDefault(p => p.IdAsignaruta == idAsignatura);
            asignaturas.Remove(modelo);
        }
    }
}
