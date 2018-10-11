using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroCuenta.BLL;
using RegistroCuenta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroCuenta.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Cuentas cuentas = new Cuentas();
            cuentas.CuentaId = 1002;
            cuentas.Descripcion = "William";
            RepositorioBase<Cuentas> repositorio;
            repositorio = new RepositorioBase<Cuentas>();
            Assert.IsTrue(repositorio.Guardar(cuentas));
        }



    }
}