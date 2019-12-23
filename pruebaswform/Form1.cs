using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaswform
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

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                int var1 = int.Parse(txtNum1.Text);
                int var2 = int.Parse(txtNum2.Text);
                lblResultado.Text = (var1 + var2).ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero válido");
            }
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            if (validar())
            {

                int var1 = int.Parse(txtNum1.Text);
                int var2 = int.Parse(txtNum2.Text);
                lblResultado.Text = (var1 - var2).ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero válido");
            }
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {




            if (validar())
            {
                int var1 = int.Parse(txtNum1.Text);
                int var2 = int.Parse(txtNum2.Text);
                lblResultado.Text = (var1 * var2).ToString();
            }
            else
            {

                MessageBox.Show("Ingrese un numero válido");
            }




        }

        private void LblResultado_Click(object sender, EventArgs e)
        {

        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                int var1 = int.Parse(txtNum1.Text);
                int var2 = int.Parse(txtNum2.Text);
                lblResultado.Text = (var1 / var2).ToString();
            }
            else
            {

                MessageBox.Show("Ingrese un numero válido");
            }
        }

        private void TxtNum1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNum2.Focus();
            }
        }

        private void BtnFactorial_Click(object sender, EventArgs e)
        {
            int var1 = int.Parse(txtNum1.Text);
            txtNum2.Enabled = false;
            lblResultado.Text = factorial(var1).ToString();
        }
        int factorial(int numero)
        {
            int res = 1;
            for (int x = 1; x <= numero; x++)
            {
                res = res * x;
            }
            return res;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Enabled = true;
            txtNum2.Text = "";
            lblResultado.Text = "";
        }
        private bool validar()
        {
            bool valido = false;
            if (int.TryParse(txtNum1.Text, out int res) && int.TryParse(txtNum2.Text, out int res1))
            {
                valido = true;
            }
            else
            {
                valido = false;
            }
            return valido;
        }
    }
}
