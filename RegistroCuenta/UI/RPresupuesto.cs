using RegistroCuenta.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroCuenta.UI
{
    public partial class RPresupuesto : Form
    {
        public RPresupuesto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ventana_button_Click(object sender, EventArgs e)
        {

        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            List<DetallesPresupuestos> detalle = new List<DetallesPresupuestos>();

            if(DetallePresupuestodataGridView.DataSource != null)
            {
                detalle = (List < DetallesPresupuestos >) DetallePresupuestodataGridView.DataSource;
            }

            detalle.Add( new DetallesPresupuestos(
                id: 0,
                presupuestoid:(int)PresupuestoId_numericUpDown.Value,
                tipoCuentas:(int)TipoCuentacomboBox.SelectedValue,
                cuentaid:    10,//(int)CuentaidComboBox.SelectedValue,
                valor:       10// (float)Convert.ToSingle(Valor_numericUpDown.Value)
                ));

            DetallePresupuestodataGridView.DataSource = null;
            DetallePresupuestodataGridView.DataSource = detalle;
          //  LlenarTotal();

        }
    }
}
