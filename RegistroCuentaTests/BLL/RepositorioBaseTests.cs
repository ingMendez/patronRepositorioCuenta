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
            TiposCuentas cuentas = new TiposCuentas();
            cuentas.TipoCuentaId = 1022;
            cuentas.Descripcion = "alejandro";
            RepositorioBase<TiposCuentas> repositorio;
            repositorio = new RepositorioBase<TiposCuentas>();
            Assert.IsTrue(repositorio.Guardar(cuentas));
        }



    }
}