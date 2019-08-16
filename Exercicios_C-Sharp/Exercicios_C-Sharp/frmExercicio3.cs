using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_C_Sharp
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal salario = Convert.ToDecimal(txtSalario.Text);
            decimal reajuste = Convert.ToDecimal(txtPerReajuste.Text);
            decimal salarioReajustado;

            salarioReajustado = (salario + (salario * (reajuste / 100)));

            lblResultado.Text = $"O novo sálario é {salarioReajustado}";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPerReajuste.Text = string.Empty;
            txtSalario.Text = string.Empty;
            lblResultado.Text = string.Empty;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new Exercicios().Show();
        }
    }
}
