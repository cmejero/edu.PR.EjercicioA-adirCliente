using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Pr.EjercicioAñadirClientes.Servicios
{

    /// <summary>
    /// Interfaz que declara la opciones para la selección del usuario
    ///  /// <author>CMR-211123</author>
    /// </summary>
    internal interface MenuInterfaz
    {

        /// <summary>
        /// método que muestra el menú de selección al usuario.
        /// <author>CMR-211123</author>
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();

        public string pedirDNI();
    }
}
