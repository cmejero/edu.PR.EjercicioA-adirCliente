using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Pr.EjercicioAñadirClientes.Dtos
{
    /// <summary>
    /// Entidad reprensa el ente cuenta bancaria del banco
    /// <author>CMR-211123</author>
    /// </summary>
    internal class CuentaBancariaDtos
    {
        long idCuentaBancaria;

        string isbanCuentaBancaria="es34235234634634";

        string codigoSwitchCuentaBancaria = "CSI1SSXX";

        string FechaAltaCuentaBancaria="1-1-2023";

        string FechaBajaCuentaBancaria = "1-1-2030";

        String dniCliente="1234231423J";


        public long IdCuentaBancaria { get => idCuentaBancaria; set => idCuentaBancaria = value; }
        public string IsbanCuentaBancaria { get => isbanCuentaBancaria; set => isbanCuentaBancaria = value; }
        public string CodigoSwitchCuentaBancaria { get => codigoSwitchCuentaBancaria; set => codigoSwitchCuentaBancaria = value; }
        public string FechaAltaCuentaBancaria1 { get => FechaAltaCuentaBancaria; set => FechaAltaCuentaBancaria = value; }
        public string FechaBajaCuentaBancaria1 { get => FechaBajaCuentaBancaria; set => FechaBajaCuentaBancaria = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }

        
        public CuentaBancariaDtos(long idCuentaBancaria, string isbanCuentaBancaria, string fechaAltaCuentaBancaria, string dniCliente)
        {
            this.idCuentaBancaria = idCuentaBancaria;
            this.isbanCuentaBancaria = isbanCuentaBancaria;
            this.FechaAltaCuentaBancaria = fechaAltaCuentaBancaria;
            this.dniCliente = dniCliente;
        
        }
       
        public CuentaBancariaDtos()
        {
        }

         override
         public string ToString()
        {
            string cuentaBancariaString = "id: " + this.idCuentaBancaria +
                "ISBAN: " + this.isbanCuentaBancaria +
                "Codigo switch: " + this.codigoSwitchCuentaBancaria +
                "Fecha de alta: " + this.FechaAltaCuentaBancaria +
                "Fecha de baja: " + this.FechaBajaCuentaBancaria +
                "DNI: " + this.dniCliente;
                
            return cuentaBancariaString;


        }


    }


}

    