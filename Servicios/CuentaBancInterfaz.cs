using edu.Pr.EjercicioAñadirClientes.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Pr.EjercicioAñadirClientes.Servicios
{
    /// <summary>
    /// Interfaz que declara la información que queremos que introduzca de la lista cuentaBancariaDtos
    /// <author>CMR-211123</author>
    /// </summary>
    internal interface CuentaBancInterfaz
    {
        /// <summary>
        /// método que muestra al usuario la lista que queremos que complete para 
        /// crear y dar de alta una nueva cuenta.
        /// <author>CMR-211123</author>
        /// </summary>
        /// <param name="ListaAntiguaCB"></param>
        public void DarAltaCuentaBancaria(List<CuentaBancariaDtos> ListaAntiguaCB);
    }
}
