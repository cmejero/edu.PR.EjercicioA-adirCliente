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

        public void DarAltaCuentaBancaria (List<CuentaBancariaDtos> ListaAntiguaCB)
        {
            CuentaBancariaDtos CuentaBancaria = crearNuevaCuenta();

            ListaAntiguaCB.Add(CuentaBancaria);



        }
        /// <summary>
        /// Dar de alta una nueva cuenta bancaria asociada a un cliente
        /// <author>CMR-211123</author>
        /// </summary>
        /// <returns>Nueva cuenta bancaria con la informacion solicitada</returns>
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
