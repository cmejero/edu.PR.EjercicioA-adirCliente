using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Pr.EjercicioAñadirClientes.Servicios
{
    /// <summary>
    ///  implementación de MenuInterfaz.
    ///  <author>CMR-211123</author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {

        /// <summary>
        /// método que muestra el menú de selección al usuario.
        /// <author>CMR-211123</author>
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion()
        {

            int opcionIntroducida;

            Console.WriteLine("#####################");
            Console.WriteLine("0. Cerrar aplicación");
            Console.WriteLine("1. Añadir cliente");
            Console.WriteLine("2. Añadir cuenta bancaria");
            Console.WriteLine("#####################");
            Console.WriteLine("Seleccione una opción");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;

        }
    }
}
