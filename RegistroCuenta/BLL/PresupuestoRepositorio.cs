using RegistroCuenta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroCuenta.BLL
{
    public class PresupuestoRepositorio : RepositorioBase<Presupuestos>()
    {

        public override bool Guardar(Presupuestos presupuesto)
        {
            foreach (var item in presupuesto.Detalle)
            {
                this.Acumular(item.TipoEgresoId, item.Monto);
            }
            bool paso = base.Guardar(presupuesto);
            return paso;
        }

        public override Presupuestos Buscar(int id)
        {
            Presupuestos presupuesto = new Presupuestos();
            try
            {
                presupuesto = _contexto.Presupuestos.Detalle.Find(id);


            }
            return base.Buscar(id);
        }
    }
}
