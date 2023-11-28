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
            Console.WriteLine("1. Alta cliente");
            Console.WriteLine("2. Alta cuenta bancaria");
            Console.WriteLine("3. Modificar cliente");
            Console.WriteLine("3. Eliminar cliente");
            Console.WriteLine("3. Ver cliente");
            Console.WriteLine("#####################");
            Console.WriteLine("Seleccione una opción");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;

        }

        public string pedirDNI()
        {
            Console.WriteLine("Indica el DNI del cliente: ");
            string dniCliente = Console.ReadLine();
            return dniCliente;
        }
    }
}
