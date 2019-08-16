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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int distancia, litros;
            int consumo = 12;
            int tempoDaViagem = Convert.ToInt32(txtTempoViagem.Text);
            int velocidadeMedia = Convert.ToInt32(txtVelocidadeMedia.Text);

            distancia = (velocidadeMedia * tempoDaViagem);
            litros = (distancia / consumo);

            lblVelociadeMedia.Text = $"{velocidadeMedia}";
            lblDistancia.Text = $"{distancia}";
            lblLitros.Text = $"{litros}";
            lblTempoViagem.Text = $"{tempoDaViagem}";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTempoViagem.Text = string.Empty;
            txtVelocidadeMedia.Text = string.Empty;
            lblTempoViagem.Text = string.Empty;
            lblVelociadeMedia.Text = string.Empty;
            lblLitros.Text = string.Empty;
            lblDistancia.Text = string.Empty;
        }

        private void bntMenu_Click(object sender, EventArgs e)
        {
            new Exercicios().Show();
        }
    }
}
