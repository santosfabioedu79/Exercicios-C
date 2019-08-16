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
    public partial class fmrExercicio2 : Form
    {
        public fmrExercicio2()
        {
            InitializeComponent();


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var valor1 = Convert.ToInt32(txtNumero1.Text);
            var valor2 = Convert.ToInt32(txtNumero2.Text);
            int x; //Colocar um nome mais intuitivo por ex: int resultado

            x = ((valor1 * 9) / (87 - valor2));

            lblPrimo.Text = $"O Resultado é: {x}";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            lblPrimo.Text = string.Empty;
        }

        private void bntMenu_Click(object sender, EventArgs e)
        {
            new Exercicios().Show();
        }
    }
}