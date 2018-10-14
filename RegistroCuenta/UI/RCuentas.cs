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
    public partial class RCuentas : Form
    {

        public RCuentas()
        {
            InitializeComponent();
        }

        private Cuentas LlenaClase()
        {
            Cuentas cuenta = new Cuentas();

            cuenta.CuentaId = Convert.ToInt32(CuentaIdnumericUpDown.Value);
            cuenta.Descripcion = DescripciontextBox.Text;
            cuenta.Monto = MontoNumericUpDown.Text.ToString;
            return cuenta;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CuentaIdnumericUpDown.Value);
            Cuentas cuentas = BLL.CuentaBLL.Buscar(id);
            if(cuentas != null)
            {
                DescripciontextBox.Text = cuentas.Descripcion;
              MontoNumericUpDown.Text = cuentas.Monto.ToString();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            CuentaIdnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            TipoCuentatextBox.Clear();
            MontoNumericUpDown.Clear();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Cuentas cuenta;
            bool paso = false;
            if (HayErrorres())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cuenta = LlenaClase();

            if (CuentaIdnumericUpDown.Value == 0)
            {
                paso = BLL.CuentaBLL.Guardar(cuenta);
            }
            else
            {
                paso = BLL.CuentaBLL.Modificar(LlenaClase());
            }

            if (paso)
            {
                MessageBox.Show("Guardado", "Exito",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
                MessageBox.Show("No se pudo guardar", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CuentaIdnumericUpDown.Value);

            if (BLL.CuentaBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool HayErrorres()
        {
            bool HayErrores = false;
            if (String.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                MyErrorProvider.SetError(DescripciontextBox, "Debes escribir una descricion para la cuenta");
                HayErrores = true;
            }
            if (String.IsNullOrWhiteSpace(TipoCuentatextBox.Text)){
                MyErrorProvider.SetError(TipoCuentatextBox, "debes escribi el tipo de cuentas");
                HayErrores = true;
            }

            if (String.IsNullOrWhiteSpace(MontoNumericUpDown.Text)){
                MyErrorProvider.SetError(TipoCuentatextBox, "debes escribi el monto");
                HayErrores = true;
            }
            return HayErrores;

        }
    }
}
