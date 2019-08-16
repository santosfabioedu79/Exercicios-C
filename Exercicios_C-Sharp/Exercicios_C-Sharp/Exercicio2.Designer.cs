namespace Exercicios_C_Sharp
{
    partial class fmrExercicio2
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblPrimo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.bntMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe um número inteiro";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(181, 21);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe outro número inteiro";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(181, 58);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(65, 108);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(27, 157);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 5;
            // 
            // lblPrimo
            // 
            this.lblPrimo.AutoSize = true;
            this.lblPrimo.Location = new System.Drawing.Point(27, 156);
            this.lblPrimo.Name = "lblPrimo";
            this.lblPrimo.Size = new System.Drawing.Size(0, 13);
            this.lblPrimo.TabIndex = 6;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(181, 108);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // bntMenu
            // 
            this.bntMenu.Location = new System.Drawing.Point(12, 196);
            this.bntMenu.Name = "bntMenu";
            this.bntMenu.Size = new System.Drawing.Size(75, 23);
            this.bntMenu.TabIndex = 8;
            this.bntMenu.Text = "Menu";
            this.bntMenu.UseVisualStyleBackColor = true;
            this.bntMenu.Click += new System.EventHandler(this.bntMenu_Click);
            // 
            // fmrExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 231);
            this.Controls.Add(this.bntMenu);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblPrimo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label1);
            this.Name = "fmrExercicio2";
            this.Text = "Exercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPrimo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button bntMenu;
    }
}