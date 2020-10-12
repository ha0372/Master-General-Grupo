using Calcular__Notas.Dominio;
using Calcular__Notas.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular__Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            Loguin loguiF = new Loguin();
            clsLoguin clsF = new clsLoguin();
            loguiF.Nota1 = Convert.ToDouble(value: txtR.Text);
            loguiF.Nota2 = Convert.ToDouble(value: txtR2.Text);
            loguiF.Nota3 = Convert.ToDouble(value: txtR3.Text);
            Double FinalF = clsF.cal2(loguiF);
            txtF.Text = FinalF.ToString();
            Boolean D = clsF.apro(loguiF);
            if (D == true)
            {
                MessageBox.Show("FELICIDADES USTED APROBO");
                frm.Show();
            }else
            {
                MessageBox.Show("LO SIENTO USTED REPROBO");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loguin logui1 = new Loguin();
            clsLoguin cls1 = new clsLoguin();
            logui1.Lab1 = Convert.ToDouble(value: txtLab1.Text);
            logui1.Par1 = Convert.ToDouble(value: txtPar1.Text);
            Double Final1 = cls1.cal1(logui1);
            txtR.Text = Final1.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCal2_Click(object sender, EventArgs e)
        {
            Loguin logui2 = new Loguin();
            clsLoguin cls2 = new clsLoguin();
            logui2.Lab2 = Convert.ToDouble(value: txtLab2.Text);
            logui2.Par2 = Convert.ToDouble(value: txtPar2.Text);
            Double Final2 = cls2.cal2(logui2);
            txtR2.Text = Final2.ToString();
        }

        private void btnCal3_Click(object sender, EventArgs e)
        {
            Loguin logui3 = new Loguin();
            clsLoguin cls3 = new clsLoguin();
            logui3.Lab3 = Convert.ToDouble(value: txtLab3.Text);
            logui3.Par3 = Convert.ToDouble(value: txtPar3.Text);
            Double Final3 = cls3.cal3(logui3);
            txtR3.Text = Final3.ToString();
        }
    }
}
