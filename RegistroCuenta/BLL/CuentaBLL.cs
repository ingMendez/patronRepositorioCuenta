using RegistroCuenta.DAL;
using RegistroCuenta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RegistroCuenta.BLL
{
    /// <summary>
    /// en la clase se programa todas la logica  de negocio
    /// </summary>
   public class CuentaBLL
    {
        ///<summary>
        ///permite guardar una entidad en la base de datos
        /// </summary>
        ///<para name ="cuenta"> una instancia de articulo</para>
        ///<returns>Retorna true si guardo o fals si no lo hizo</returns>
         public static bool Guardar(Cuentas Cuenta)
        {
            bool paso = false;
            // creamos una instancia del contexto para poder con la base de datos
            Contexto contexto = new Contexto();
            try
            {
                if(contexto.Cuenta.Add(Cuenta) != null)
                {
                    contexto.SaveChanges(); // gurdar los cambien la base de datos
                    paso = true;
                }
                contexto.Dispose(); //// para serrar la conexion
            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }
        /// <summary>
        /// Permite modificar una entidad en la base de datos
        /// </summary>
        /// <param name="cuenta"></param>
        /// <returns> retuna true si modifico y false si no </returns>
        public static bool Modificar(Cuentas cuenta)
        {
            bool paso = false;
            // creamos una instancia del contexto para poder con la base de datos

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(cuenta).State = System.Data.Entity.EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();// serrar la conexion.
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        /// <summary>
        /// permite eliminar una entidad en la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Eliminar(int id)
        {

            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Cuentas cuenta = contexto.Cuenta.Find(id);
                contexto.Cuenta.Remove(cuenta);
               if( contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
        /// <summary>
        /// permite buscar una cuenta en la entidad
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Cuentas Buscar(int id)
        { 
            
            Contexto contexto = new Contexto();
            Cuentas cuenta = new Cuentas();
            try
            {
                 cuenta = contexto.Cuenta.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return cuenta;
        }

        public static List<Cuentas> GetList(Expression<Func<Cuentas,bool>> expression)
        {
            List<Cuentas> cuenta = new List<Cuentas>();
            Contexto contexto = new Contexto();
            try
            {
                cuenta = contexto.Cuenta.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return cuenta;
        }
    }
}
