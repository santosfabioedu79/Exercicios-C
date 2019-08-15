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
                MessageBox.Show($"O {numero} é número primo");
            }
            else
            {
                MessageBox.Show($"O {numero} não é número primo");
            }
        }
    }
}
