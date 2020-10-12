using Calcular__Notas.Dominio;
using Calcular__Notas.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calcular__Notas
{
    public partial class frmSuma : Form
    {
        public frmSuma()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Suma sum = new Suma();
            clsSuma clsSum = new clsSuma();
            sum.Dato1 = Convert.ToDouble(value: txtD1.Text);
            sum.Dato2 = Convert.ToDouble(value: txtD2.Text);
            Double Res = clsSum.suma(sum);
            txtRes.Text = Res.ToString();
        }
    }
}
