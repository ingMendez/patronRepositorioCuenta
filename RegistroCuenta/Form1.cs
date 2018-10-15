using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using RegistroCuenta.UI;
using System.Windows.Forms;
using RegistroCuenta.Entidades;
using RegistroCuenta.UI.Registro;

namespace RegistroCuenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RPresupuesto r = new RPresupuesto();
            r.ShowDialog();
          

        }

       
    }
}
