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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            frmSuma frms = new frmSuma();
            Suma sumar = new Suma();
            clsSuma clsSumar = new clsSuma();
            sumar.User = txtUser.Text;
            sumar.Pass = txtContra.Text;
            Boolean correc = clsSumar.entrar(sumar);
            if (correc == true)
            {
                MessageBox.Show("WELCOME");
                frms.Show();
                
                
            }
            else
            {
                MessageBox.Show("Stop");
            }
        }
    }
}
