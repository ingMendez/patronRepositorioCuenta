using RegistroCuenta.BLL;
using RegistroCuenta.DAL;
using RegistroCuenta.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace RegistroCuenta.UI.Registro
{
    public partial class RPresupuesto : Form
    {
        public RPresupuesto()
        {
            InitializeComponent();
        }
        private void LlenarComboBox()
        {
            RepositorioBase<Cuentas> CuentaRepositorio = new RepositorioBase<Cuentas>(new Contexto());
            TipoCuentacomboBox.DataSource = CuentaRepositorio.GetList(c => true);
            TipoCuentacomboBox.ValueMember = "TiposcuentaId";

        }

        private void Add_button_Click_1(object sender, EventArgs e)
        {
            List<DetallesPresupuestos> detalle = new List<DetallesPresupuestos>();

            if (DetallePresupuestodataGridView.DataSource != null)
            {
                detalle = (List<DetallesPresupuestos>)DetallePresupuestodataGridView.DataSource;
            }

            detalle.Add(new DetallesPresupuestos(
                id: 0,
                presupuestoid: (int)PresupuestoId_numericUpDown.Value,
                tipoCuentas: 10,//(int)TipoCuentacomboBox.SelectedValue,
                cuentaid: 10,//(int)CuentaidComboBox.SelectedValue,
                valor: (float)Convert.ToSingle(Valor_numericUpDown.Value)
                ));

            DetallePresupuestodataGridView.DataSource = null;
            DetallePresupuestodataGridView.DataSource = detalle;
            //  LlenarTotal();

        }

        private void TipoCuentacomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LlenarComboBox();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {

        }
    }
}
