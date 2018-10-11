using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroCuenta.Entidades
{
    public class TiposCuentas
    {
       public int TipoCuentaId { get; set; }
        public string Descripcion { get; set; }

        public TiposCuentas()
        {

        }
        public TiposCuentas(int tipoCuenta,string descripcion)
        {
            TipoCuentaId = tipoCuenta;
            Descripcion = descripcion;
        }
    }

}
