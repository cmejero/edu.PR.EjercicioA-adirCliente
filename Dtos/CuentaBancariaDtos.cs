using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Pr.EjercicioAñadirClientes.Dtos
{
    /// <summary>
    /// Clase donde se encuentra la lista con la información que queremos obtener.
    /// <author>CMR-211123</author>
    /// </summary>
    internal class CuentaBancariaDtos
    {
        long idCuentaBancaria;

        string isbanCuentaBancaria;

        string codigoSwitchCuentaBancaria = "CSI1SSXX";

        string FechaAltaCuentaBancaria;

        string FechaBajaCuentaBancaria = "1-1-2030";

        String dniCuentaBancaria;


        public long IdCuentaBancaria { get => idCuentaBancaria; set => idCuentaBancaria = value; }
        public string IsbanCuentaBancaria { get => isbanCuentaBancaria; set => isbanCuentaBancaria = value; }
        public string CodigoSwitchCuentaBancaria { get => codigoSwitchCuentaBancaria; set => codigoSwitchCuentaBancaria = value; }
        public string FechaAltaCuentaBancaria1 { get => FechaAltaCuentaBancaria; set => FechaAltaCuentaBancaria = value; }
        public string FechaBajaCuentaBancaria1 { get => FechaBajaCuentaBancaria; set => FechaBajaCuentaBancaria = value; }
        public string DniCuentaBancaria { get => dniCuentaBancaria; set => dniCuentaBancaria = value; }

        /// <summary>
        /// 
        /// <author>CMR-211123</author>
        /// </summary>
        /// <param name="idCuentaBancaria"></param>
        /// <param name="isbanCuentaBancaria"></param>
        /// <param name="codigoSwitchCuentaBancaria"></param>
        /// <param name="fechaAltaCuentaBancaria"></param>
        /// <param name="fechaBajaCuentaBancaria"></param>
        /// <param name="dniCuentaBancaria"></param>
        public CuentaBancariaDtos(long idCuentaBancaria, string isbanCuentaBancaria, string codigoSwitchCuentaBancaria, string fechaAltaCuentaBancaria, string fechaBajaCuentaBancaria, string dniCuentaBancaria)
        {
            this.idCuentaBancaria = idCuentaBancaria;
            this.isbanCuentaBancaria = isbanCuentaBancaria;
            this.codigoSwitchCuentaBancaria = codigoSwitchCuentaBancaria;
            this.FechaAltaCuentaBancaria = fechaAltaCuentaBancaria;
            this.FechaBajaCuentaBancaria = fechaBajaCuentaBancaria;
            this.dniCuentaBancaria = dniCuentaBancaria;
        
        }
        /// <summary>
        /// método para la creación de un constructor vacio.
        /// <author>CMR-211123</author>
        /// </summary>
        public CuentaBancariaDtos()
        {
        }

        /// <summary>
        /// 
        /// <author>CMR-211123</author>
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            string cuentaBancariaString = "id: " + this.idCuentaBancaria +
                "ISBAN: " + this.isbanCuentaBancaria +
                "Codigo switch: " + this.codigoSwitchCuentaBancaria +
                "Fecha de alta: " + this.FechaAltaCuentaBancaria +
                "DNI: " + this.dniCuentaBancaria;
                
            return cuentaBancariaString;


        }


    }


}

    