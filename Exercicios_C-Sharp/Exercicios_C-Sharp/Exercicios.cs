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
    public partial class Exercicios : Form
    {
        public Exercicios()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            new fmrExercicio1().Show();
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            new fmrExercicio2().Show();
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            new frmExercicio3().Show();
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            new frmExercicio4().Show();
        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            new frmExercicio5().Show();
        }

        private void Exercicios_Load(object sender, EventArgs e)
        {

        }
    }
}
