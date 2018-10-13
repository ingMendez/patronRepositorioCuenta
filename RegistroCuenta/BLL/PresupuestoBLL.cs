﻿using RegistroCuenta.DAL;
using RegistroCuenta.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RegistroCuenta.BLL
{
    ///<summary>
    ///En esta clase se programa toda la lógica de negocio.
    ///</summary>
    public class PresupuestoBLL
    {
        public static bool Guardar(Presupuesto presupuesto)
        {
            bool paso = false;
            // creamos una instancia del contexto para poder con la base de datos
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Presupuestos.Add(presupuesto) != null)
                {
                    foreach(var item in presupuesto.Detalle)
                    {
                        contexto.Cuenta.Find(item.CuentaId).Monto -= item.Valor;
                    }
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
        public static bool Modificar(Presupuesto presupuesto)
        {
            bool paso = false;
            // creamos una instancia del contexto para poder con la base de datos

            Contexto contexto = new Contexto();
            try
            {
                var MontoAterior = PresupuestoBLL.Buscar(presupuesto.PresupuestoId);
                foreach(var item in MontoAterior.Detalle)
                {
                    contexto.Cuenta.Find(item.CuentaId).Monto -= item.Valor;
                    if (!presupuesto.Detalle.ToList().Exists(v => v.Id == item.Id))
                    {
                        contexto.Cuenta.Find(item.CuentaId).Monto -= item.Valor;
                        item.Cuentas = null;
                        contexto.Entry(item).State = EntityState.Deleted;
                    }
                }
                /// recorrer el detalle
                foreach(var item in presupuesto.Detalle)
                {
                    //Sumar todas las cantidades cotizadas
                    contexto.Cuenta.Find(item.CuentaId).Monto += item.Valor;

                    //Muy importante indicar que pasara con la entidad del detalle
                    var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                    contexto.Entry(item).State = estado;
                }
                contexto.Entry(presupuesto).State = EntityState.Modified;
                    //System.Data.Entity.EntityState.Modified;
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
                Presupuesto presupuesto = contexto.Presupuestos.Find(id);

                foreach(var item in presupuesto.Detalle)
                {
                    var cuentas = contexto.Cuenta.Find(item.CuentaId);
                    cuentas.MontoAnterior -= item.Valor;

                }

                contexto.Presupuestos.Remove(presupuesto);
                if (contexto.SaveChanges() > 0)
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
        public static Presupuesto Buscar(int id)
        {

            Contexto contexto = new Contexto();
            Presupuesto presupuesto = new Presupuesto();
            try
            {
                presupuesto = contexto.Presupuestos.Find(id);
                if (presupuesto != null)
                {
                    //Cargar la lista en este punto porque
                    //luego de hacer Dispose() el Contexto 
                    //no sera posible leer la lista
                    presupuesto.Detalle.Count();
                    //Cargar las Descripcion
                    //Cargar el Nombre Descripcion
                    foreach (var item in presupuesto.Detalle)
                    {
                        //forzando la Descripcion y Nombres a cargarse
                        string s = item.Cuentas.Descripcion;
                        //string ss = item.TiposCuentas.Descripcion;
                    }
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return presupuesto;
        }

        public static List<Cuentas> GetList(Expression<Func<Cuentas, bool>> expression)
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
