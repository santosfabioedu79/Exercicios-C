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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var nomeFuncionario = Convert.ToString(txtNome.Text);
            decimal salario = Convert.ToDecimal(txtSalario.Text);
            decimal vendas = Convert.ToDecimal(txtTotalVendas.Text);
            decimal salarioTotal, totalComissao;

            totalComissao = ((vendas * 10) / 100);
            salarioTotal = (salario + totalComissao);

            lblResultado.Text = $"O salário do {nomeFuncionario} este mês é {salarioTotal:C}";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtSalario.Text = string.Empty;
            txtTotalVendas.Text = string.Empty;
            lblResultado.Text = string.Empty;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new Exercicios().Show();
        }
    }
}
