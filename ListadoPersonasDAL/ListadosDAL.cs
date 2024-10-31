using ListadoPersonasENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoPersonasDAL
{
    public class ListadosDAL
    {
        /// <summary>
        /// Función estática que devuelve un listado completo de las personas de un listado
        /// </summary>
        /// <returns></returns>
        public static List<Persona> listadoCompletoPersonasDAL() {
            List<Persona> listaPersonas = new List<Persona>();
            listaPersonas.Add(new Persona("Pepe", "Morilla", new DateTime(2003, 8, 11)));
            listaPersonas.Add(new Persona("Juanillo", "Kukunero", new DateTime(1996, 4, 2)));
            listaPersonas.Add(new Persona("Kike", "Montilla", new DateTime(1994, 3, 1)));
            listaPersonas.Add(new Persona("Daniela", "Diaz", new DateTime(2005, 3, 1)));
            listaPersonas.Add(new Persona("Perro", "Sanxe", new DateTime(2000, 8, 21)));
            listaPersonas.Add(new Persona("Pepe", "Morilla", new DateTime(1998, 1, 17)));

            return listaPersonas;
        }
    }
}
