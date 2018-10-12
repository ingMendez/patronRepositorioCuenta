using RegistroCuenta.DAL;
using RegistroCuenta.Entidades;
using System;
using System.Linq;

namespace RegistroCuenta.BLL
{
    public class PresupuestoRepositorio : RepositorioBase<Presupuesto>
    {
      

       /* public override bool Guardar(Presupuesto presupuesto)
        {
            foreach (var item in presupuesto.Detalle)
            {
                this.Acumular(item.TipoId,item.Monto);
            }
            bool paso = base.Guardar(presupuesto);

            return paso;
        }*/

        public override Presupuesto Buscar(int id)
        {
            Presupuesto presupuesto = new Presupuesto();
            try
            {
                presupuesto = _contexto.Presupuestos.Find(id);
                presupuesto.Detalle.Count();

                foreach( var item in presupuesto.Detalle)
                {
                    int pre = item.Cuentas.CuentaId;
                    string p = item.Presupuesto.Descripcion;
                    
              

                }
                _contexto.Dispose();

            }
            catch(Exception)
            {
                throw;
            }

            return presupuesto;
        }
    }
}
