using RegistroCuenta.DAL;
using RegistroCuenta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroCuenta.BLL
{
    public class PresupuestoRepositorio : RepositorioBase<Presupuesto>
    {
        public PresupuestoRepositorio(Contexto contexto) : base(contexto)
        {

        }
       /* public override bool Guardar(Presupuestos presupuesto)
        {
            foreach (var item in presupuesto.Detalle)
            {
                this.Acumular(item.TipoEgresoId, item.Monto);
            }
            bool paso = base.Guardar(presupuesto);
            return paso;
        }*/

        public override Presupuesto Buscar(int id)
        {
            Presupuesto presupuesto = new Presupuesto();
            try
            {
                presupuesto = _contexto.Presupuestos.Detalle.Find(id);

            }
            catch(Exception)
            {
                throw;
            }
            return base.Buscar(id);
        }
    }
}
