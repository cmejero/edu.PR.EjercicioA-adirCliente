using edu.Pr.EjercicioAñadirClientes.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Pr.EjercicioAñadirClientes.Servicios
{
    /// <summary>
    /// Catálogo de metodos orientados a la cuenta bancaria.
    /// <author>CMR-211123</author>
    /// </summary>
    internal interface CuentaBancInterfaz
    {
        /// <summary>
        /// dar de alta una nueva cuenta bancaria asociada a un cliente
        /// <author>CMR-211123</author>
        /// </summary>
        /// <param name="ListaAntiguaCB"> Lista de cuentas existente</param>
        public void DarAltaCuentaBancaria(List<CuentaBancariaDtos> ListaAntiguaCB);
    }
}
