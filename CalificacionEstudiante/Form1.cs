using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalificacionEstudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            if (txtnota1.Text == "" || txtnota2.Text == "" || txtnota3.Text == "" || txtnota4.Text == "")
            {
                MessageBox.Show("Todos los campos debe estar diligenciado", "Mensaje de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {

                double nota1, nota2, nota3, nota4, suma, resultado;
                nota1 = double.Parse(txtnota1.Text);
                nota2 = double.Parse(txtnota2.Text);
                nota3 = double.Parse(txtnota3.Text);
                nota4 = double.Parse(txtnota4.Text);

                suma = nota1 + nota2 + nota3 + nota4;

                resultado = suma / 4;

                lblresultado.Text = Convert.ToString(resultado);

                label6.Visible = true;
                lblresultado.Visible = true;

            }



        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtnota1.Text = String.Empty;
            txtnota2.Text = String.Empty;
            txtnota3.Text = String.Empty;
            txtnota4.Text = String.Empty;
            label6.Visible = false;
            lblresultado.Visible = false;
            txtnota1.Focus();
        }
    }
}
