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
}
