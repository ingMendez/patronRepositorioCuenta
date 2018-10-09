
    using RegistroCuenta.DAL;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;

    namespace RegistroCuenta.BLL
    {
      

            public class RepositorioBase<T> : IDisposable, IRepository<T> where T : class
            {
                internal Contexto _contexto;
                public RepositorioBase()
                {
                    _contexto = new Contexto();
                }

                public virtual T Buscar(int id)
                {
                     T entity;

                    try
                    {
                         entity = _contexto.Set<T>().Find(id);
                       

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    return entity;
                 }

                public void Dispose()
                {
                    throw new NotImplementedException();
                }

                public bool Eliminar(int id)
                {
                bool paso = false;

                try
                {
                    T Entity = _contexto.Set<T>().Find(id);
                         paso = _contexto.SaveChanges() > 0;

                }
                catch (Exception)
                {
                    throw;
                }
                return paso;
                 }

                public List<T> GetList(Expression<Func<T, bool>> expression)
                {
                  List<T> Lista = new List<T>();
                try
                {
                    Lista = _contexto.Set<T>().Where(expression).ToList();
                }
                catch (Exception)
                {
                    throw;
                }
                return Lista;

                 }

                public  virtual bool Guardar(T entity)
                {
                        bool paso = false;

                        try
                        {
                            if (_contexto.Set<T>().Add(entity) != null)
                                paso = _contexto.SaveChanges() > 0;

                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        return paso;
                    }

                public virtual bool Modificar(T entity)
                     {
                    bool paso = false;
                    try
                    {
                        _contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                        paso = _contexto.SaveChanges() > 0;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    return paso;
                  }
            public class PresupuesttoRepositorio : RepositorioBase<Presupuestos>
        {
            public override bool Guardar(Presupuestos presupuesto)
            {
                foreach(var item in presupuesto.Detalle)
                {
                    this.Acumular(item.TipoEgresoId, item.Monto);
                }
                bool paso = base.Guardar(presupuesto);
                return paso;
            }
        }
             }
                

       
    }


