using edu.Pr.EjercicioAñadirClientes.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Pr.EjercicioAñadirClientes.Servicios
{
    /// <summary>
    /// implementación de ClienteInterfaz.
    /// <author>CMR-211123</author>
    /// </summary>
    internal class ClienteImplementacion : ClienteInterfaz
    {

        /// <summary>
        /// método que muestra al usuario la lista que queremos que complete para 
        /// crear y dar de alta un nuevo usuario.
        /// <author>CMR-211123</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaCliente(List<ClienteDtos> listaAntigua) 
        {
            ClienteDtos cliente = crearNuevoCLiente();

            listaAntigua.Add(cliente);

        }
        /// <summary>
        /// Método donde creamos un nuevo usuario.
        /// <author>CMR-211123</author>
        /// </summary>
        /// <returns></returns>
        private ClienteDtos crearNuevoCLiente()
        {
            ClienteDtos nuevoCliente = new ClienteDtos();

            Console.WriteLine("Introduza el id: ");
            nuevoCliente.IdCliente= Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduza nombre: ");
            nuevoCliente.NombreCliente = Console.ReadLine();

            Console.WriteLine("Introduza apellidos: ");
            nuevoCliente.ApellidosCliente = Console.ReadLine();

            Console.WriteLine("Introduza DNI: ");
            nuevoCliente.DniCliente = Console.ReadLine();

            Console.WriteLine("Introduza fecha de nacimiento: ");
            nuevoCliente.FechaNacimientoCliente = Console.ReadLine();

            Console.WriteLine("Introduza email: ");
            nuevoCliente.EmailCliente = Console.ReadLine();

            Console.WriteLine("Introduza número de telefono: ");
            nuevoCliente.TlfCliente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduza número fecha de alta: ");
            nuevoCliente.FechaAltaCliente = Console.ReadLine();



            return nuevoCliente;

        }
    }
}
