namespace Exercicios_C_Sharp
{
    partial class frmExercicio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTempoViagem = new System.Windows.Forms.TextBox();
            this.txtVelocidadeMedia = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVelociadeMedia = new System.Windows.Forms.Label();
            this.lblTempoViagem = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.bntMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exercicio 4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe o tempo gasto na viagem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Informe a velocidade média";
            // 
            // txtTempoViagem
            // 
            this.txtTempoViagem.Location = new System.Drawing.Point(183, 46);
            this.txtTempoViagem.Name = "txtTempoViagem";
            this.txtTempoViagem.Size = new System.Drawing.Size(100, 20);
            this.txtTempoViagem.TabIndex = 3;
            // 
            // txtVelocidadeMedia
            // 
            this.txtVelocidadeMedia.Location = new System.Drawing.Point(183, 86);
            this.txtVelocidadeMedia.Name = "txtVelocidadeMedia";
            this.txtVelocidadeMedia.Size = new System.Drawing.Size(100, 20);
            this.txtVelocidadeMedia.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(46, 129);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(19, 173);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(92, 13);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Velocidade Média";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tempo da viagem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Distancia Percorrida";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quantidade de litros consumidos";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblVelociadeMedia
            // 
            this.lblVelociadeMedia.AutoSize = true;
            this.lblVelociadeMedia.Location = new System.Drawing.Point(187, 173);
            this.lblVelociadeMedia.Name = "lblVelociadeMedia";
            this.lblVelociadeMedia.Size = new System.Drawing.Size(0, 13);
            this.lblVelociadeMedia.TabIndex = 10;
            // 
            // lblTempoViagem
            // 
            this.lblTempoViagem.AutoSize = true;
            this.lblTempoViagem.Location = new System.Drawing.Point(188, 199);
            this.lblTempoViagem.Name = "lblTempoViagem";
            this.lblTempoViagem.Size = new System.Drawing.Size(0, 13);
            this.lblTempoViagem.TabIndex = 11;
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(188, 225);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(0, 13);
            this.lblDistancia.TabIndex = 12;
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(188, 249);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(0, 13);
            this.lblLitros.TabIndex = 13;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(155, 129);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // bntMenu
            // 
            this.bntMenu.Location = new System.Drawing.Point(12, 280);
            this.bntMenu.Name = "bntMenu";
            this.bntMenu.Size = new System.Drawing.Size(75, 23);
            this.bntMenu.TabIndex = 15;
            this.bntMenu.Text = "Menu";
            this.bntMenu.UseVisualStyleBackColor = true;
            this.bntMenu.Click += new System.EventHandler(this.bntMenu_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 315);
            this.Controls.Add(this.bntMenu);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblTempoViagem);
            this.Controls.Add(this.lblVelociadeMedia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtVelocidadeMedia);
            this.Controls.Add(this.txtTempoViagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmExercicio4";
            this.Text = "Exercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTempoViagem;
        private System.Windows.Forms.TextBox txtVelocidadeMedia;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVelociadeMedia;
        private System.Windows.Forms.Label lblTempoViagem;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button bntMenu;
    }
}