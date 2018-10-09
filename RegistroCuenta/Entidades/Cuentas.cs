using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RegistroCuenta.Entidades
{
    public class Cuentas
    {
        [Key]
        public int CuentaId { get; set; }
        public string Descripcion { get; set; }

        public Cuentas(int Cuentas,string escripcion)
        {
            CuentaId = Cuentas;
            Descripcion = Descripcion;
        }
        public Cuentas()
        {
            CuentaId = 0;
            Descripcion = string.Empty;

        }


    }
}
