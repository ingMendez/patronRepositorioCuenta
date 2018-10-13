﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RegistroCuenta.Entidades
{
   public  class DetallesPresupuestos
    {
        [Key]
        public int Id { get; set; }

        public int PresupuestoId { get; set; }

        public int CuentaId { get; set; }
        public int TiposCuentas { get; set; }

        public float Valor { get; set; }

        [ForeignKey("CuentaId")]
        public virtual Cuentas Cuentas { get; set; }

       [ForeignKey("PresupuestoId")]
        public virtual Presupuesto Presupuesto { get; set; }

        public DetallesPresupuestos()
        {
            this.Id = 0;
            this.PresupuestoId = 0;
            this.CuentaId = 0;
            this.TiposCuentas = 0;
            this.Valor = 0;
        }
        public DetallesPresupuestos(int id,int presupuestoid,int cuentaid,int tipoCuentas,float valor)
        {
            Id = id;
            PresupuestoId = presupuestoid;
            CuentaId = cuentaid;
            TiposCuentas = tipoCuentas;
            Valor = valor;
        }

        public override string ToString()
        {
            return "Cuenta:" + this.CuentaId.ToString() + ":Valor" + this.Valor;
        }


    }
}
