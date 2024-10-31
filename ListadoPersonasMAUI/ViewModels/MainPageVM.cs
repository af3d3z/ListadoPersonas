using ListadoPersonasENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoPersonasMAUI.ViewModels
{
    internal class MainPageVM
    {
        #region Propiedades
        private List<Persona> _listadoPersonas;

        public List<Persona> ListadoPersonas { get {
                _listadoPersonas = ListadoPersonasBL.ListadosBL.listadoPersonasBL();
                return _listadoPersonas; 
            } }
        #endregion

    }
}
