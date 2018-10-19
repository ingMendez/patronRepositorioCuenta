using RegistroCuenta.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroCuenta.UI.Consultas
{
    public partial class PrConsultas : Form
    {
     private List<Presupuesto> presupuesto = new List<Presupuesto>();

        public PrConsultas()
        {
            InitializeComponent();
        }
    
        private void PrConsultas_Load(object sender, EventArgs e)
        {
                  
        }

    }
}
