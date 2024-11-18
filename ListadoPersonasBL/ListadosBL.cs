using ListadoPersonasENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListadoPersonasDAL;

namespace ListadoPersonasBL
{
    public class ListadosBL
    {
        /// <summary>
        /// Función estática que llama a su contraparte en DAL, aplica las reglas de negocio oportunas y devuelve un listado en base a las reglas.
        /// </summary>
        /// <returns> Lista de Personas</returns>
        public static List<Persona> listadoPersonasBL() {
            List<Persona> listado = ListadosDAL.listadoCompletoPersonasDAL(); ;

            // TODO Comprobar si es jueves y antes o no de las 13:30
            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday && DateTime.Now.Hour < 13 && DateTime.Now.Minute < 30)
            {
                listado = listado.Take(5)
                    .ToList();
            }
            else {
                listado = listado.Skip(Math.Max(0, listado.Count - 5)).ToList();
            }

            return listado;
        }
    }
}
