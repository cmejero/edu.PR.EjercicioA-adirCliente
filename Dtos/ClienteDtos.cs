using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace edu.Pr.EjercicioAñadirClientes.Dtos
{
    /// <summary>
    /// Clase donde se encuentra la lista con la información que queremos obtener.
    /// <author>CMR-211123</author>
    /// </summary>
    internal class ClienteDtos
    {
        
        long idCliente ;

        string nombreCliente = "Juan";

        string apellidosCliente = "Garcia Gimenez";

        string dniCliente = "123874834B";

        string fechaNacimientoCliente = "1-1-2000";

        string emailCliente = "cafgsuafhia@gmail.com";

        int tlfCliente;

        string fechaAltaCliente = "20-11-2023";

        string fechaBajaCliente = "1-1-2030";       


        

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string FechaNacimientoCliente { get => fechaNacimientoCliente; set => fechaNacimientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public string FechaAltaCliente { get => fechaAltaCliente; set => fechaAltaCliente = value; }
        public string FechaBajaCliente { get => fechaBajaCliente; set => fechaBajaCliente = value; }

        public ClienteDtos(long idCliente, string nombreCliente, string apellidosCliente, string dniCliente, string fechaNacimientoCliente, string emailCliente, int tlfCliente, string fechaAltaCliente, string fechaBajaCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.dniCliente = dniCliente;
            this.fechaNacimientoCliente = fechaNacimientoCliente;
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;
            this.fechaAltaCliente = fechaAltaCliente;
            this.fechaBajaCliente = fechaBajaCliente;
        }
        /// <summary>
        /// método para la creación de un constructor vacio.
        /// <author>CMR-211123</author>
        /// </summary>
        public ClienteDtos()
        {
        }

        public string ToString()
        {
            string clienteString = "Nombre: " + this.nombreCliente +
                "Apellidos: " + this.apellidosCliente +
                "DNI: " + this.dniCliente +
                "Fecha de nacimiento: " + this.fechaNacimientoCliente +
                "Email: " + this.emailCliente +
                "Telefono:" + this.tlfCliente +
                "Fecha de alta:" + this.fechaAltaCliente;
                



                return clienteString;
        }















        


        
    }
}
