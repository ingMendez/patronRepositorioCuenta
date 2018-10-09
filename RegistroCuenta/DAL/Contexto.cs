using RegistroCuenta.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

namespace RegistroCuenta.DAL
{
   public  class Contexto: DbContext
    {
        public DbSet<Cuentas> Cuentas { get; set; }
        
        public Contexto(): base("ConStr")
        {

        }
            }
}
