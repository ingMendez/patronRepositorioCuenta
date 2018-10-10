﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RegistroCuenta.Entidades
{
    class DetallesPresupuestos
    {
        [Key]
        public int Id { get; set; }

        public int PresupuestoId { get; set; }

        public int CuentaId { get; set; }

        public float Valor { get; set; }

        [ForeignKey("CuentaId")]
        public virtual Cuentas cuentas { get; set; }

       /* [ForeignKey("PresupuestoId")]
        public virtual Presupuestos presupuesto { get; set; }*/

        public DetallesPresupuestos()
        {
            this.Id = 0;
            this.PresupuestoId = 0;
            this.CuentaId = 0;
            this.Valor = 0;
        }
        public DetallesPresupuestos(int id,int presupuestoid,int cuentaid,float valor)
        {
            Id = id;
            PresupuestoId = presupuestoid;
            CuentaId = cuentaid;
            Valor = valor;
        }

        public override string ToString()
        {
            return "Cuenta:" + this.CuentaId.ToString() + ":Valor" + this.Valor;
        }


    }
}
