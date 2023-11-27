using edu.Pr.EjercicioAñadirClientes.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Pr.EjercicioAñadirClientes.Servicios
{
    /// <summary>
    /// implementación de CuentaBancInterfaz.
    /// <author>CMR-211123</author>
    /// </summary>
    internal class CuentaBancImplementacion : CuentaBancInterfaz
    {

        /// <summary>
        /// método que muestra al usuario la lista que queremos que complete para 
        /// crear y dar de alta una nueva cuenta.
        /// <author>CMR-211123</author>
        /// </summary>
        /// <param name="ListaAntiguaCB"></param>
        public void DarAltaCuentaBancaria (List<CuentaBancariaDtos> ListaAntiguaCB)
        {
            CuentaBancariaDtos CuentaBancaria = crearNuevaCuenta();

            ListaAntiguaCB.Add(CuentaBancaria);



        }
        /// <summary>
        /// Método donde creamos una nueva cuenta bancaria.
        /// <author>CMR-211123</author>
        /// </summary>
        /// <returns></returns>
        private CuentaBancariaDtos crearNuevaCuenta()
        {

            CuentaBancariaDtos NuevaCuentaBancaria = new CuentaBancariaDtos();

            Console.WriteLine("Introduza el id: ");
            NuevaCuentaBancaria.IdCuentaBancaria = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduza ISBAN: ");
            NuevaCuentaBancaria.IsbanCuentaBancaria = Console.ReadLine();
           
            Console.WriteLine("Introduza Fecha de alta: ");
            NuevaCuentaBancaria.FechaAltaCuentaBancaria1 = Console.ReadLine(); ;

            Console.WriteLine("Introduza DNI: ");
            NuevaCuentaBancaria.DniCliente = Console.ReadLine();

            
            return NuevaCuentaBancaria;


        }

    }
}
