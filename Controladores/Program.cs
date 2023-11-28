using edu.Pr.EjercicioAñadirClientes.Dtos;
using edu.Pr.EjercicioAñadirClientes.Servicios;

namespace edu.Pr.EjercicioAñadirClientes.Controladores
{
    /// <summary>
    /// Clase principal de la aplicaión.
    /// <author>CMR-211123</author>
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Método main de la aplicación, es el núcleo procedimental.
        /// <author>CMR-211123</author>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<ClienteDtos> listaCLiente = new List<ClienteDtos>();
            List<CuentaBancariaDtos> ListaCuentaBancaria = new List<CuentaBancariaDtos>();
            
            MenuInterfaz mi = new MenuImplementacion();
           ClienteInterfaz oi = new ClienteImplementacion();
            CuentaBancInterfaz ci = new CuentaBancImplementacion();
                

            
            bool cerrarMenu = false;
         
            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenuYSeleccion();
                Console.WriteLine(opcionSeleccionada);
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se ejecuta caso 0");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - ALTA NUEVO CLIENTE");
                        oi.darAltaCliente(listaCLiente);
                        break;

                    case 2:
                        Console.WriteLine("[INFO] - ALTA NUEVA CUENTA BANCARIA");
                        ci.DarAltaCuentaBancaria(ListaCuentaBancaria);
                        break;
                    case 3:
                        Console.WriteLine("[INFO] - ELIMINAR UN CLIENTE");
                        oi.eliminarCliente(listaCLiente);
                        break;
                    case 4:
                        Console.WriteLine("[INFO] - ELIMINAR UN CLIENTE");
                        oi.eliminarCliente(listaCLiente);
                        break;

                    default:
                        Console.WriteLine("[INFO] - Esta opción no coincide con ninguna");
                        break;
                }
            }

        }
        
    }
}
//Asignar valor a cliente, buscar usuario con ese DNI y modificar nombre a los usuarios con ese DNI.
/*  foreach (clienteDtos cliente in listaClientes){      <--solo se dedica a mirar la lista
 *  if(cliente.DNI == "382478426J"){                     <--se dedica a buscar atributos (== no es el metodo para igualar 
 *                                                          strings --> equals) si no es string SI sería == */
