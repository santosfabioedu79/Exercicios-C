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
    public partial class fmrExercicio1 : Form
    {


        public fmrExercicio1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var numero = Convert.ToInt32(txtNumero.Text);
            if (numero % 2 == 0)
            {
                lblNumero.Text = $"O {numero} é número primo"; //esse resultado tem que estar no else
            }
            else
            {
                lblNumero.Text = $"O {numero} não é número primo";
            }

            //Usar o return e tirar o else, o código fica com um nó a mesmo
            //segue o exemplo
            /*
            if (numero % 2 == 0)
            {
                lblNumero.Text = $"O {numero} não é número primo";
                return;
            }
            lblNumero.Text = $"O {numero} é número primo";
            
            */
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = string.Empty;
            lblNumero.Text = string.Empty;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new Exercicios().Show();
        }
    }
}
