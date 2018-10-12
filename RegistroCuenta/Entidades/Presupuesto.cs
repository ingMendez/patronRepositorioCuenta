using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RegistroCuenta.Entidades
{
   public class Presupuesto
    {
        [Key]
        public int PresupuestoId { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(100)]
       public string Descripcion { get; set; }
      //  [foreign]
        public float Monto { get; set; }

        public virtual List<DetallesPresupuestos> Detalle { get;set; }

        public Presupuesto()
        {
            this.Detalle = new List<DetallesPresupuestos>();
        }

        public void agregarDetalle(int id,int PresupuestoId,int CuentaId,float Valor)
        {
            this.Detalle.Add(new DetallesPresupuestos(id, PresupuestoId, CuentaId, Valor));
        }

        

    }
}
