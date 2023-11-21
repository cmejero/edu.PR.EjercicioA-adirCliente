using edu.Pr.EjercicioAñadirClientes.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Pr.EjercicioAñadirClientes.Servicios
{
    /// <summary>
    /// <summary>
    /// Interfaz que declara la información que queremos que introduzca de la lista ClienteDtos.
    /// <author>CMR-211123</author>
    /// </summary>
    internal interface ClienteInterfaz
    {
        /// <summary>
        /// método que muestra al usuario la lista que queremos que complete para 
        /// crear y dar de alta un nuevo usuario.
        /// <author>CMR-211123</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaCliente(List<ClienteDtos> listaAntigua);
    }
}
