namespace Exercicios_C_Sharp
{
    partial class Exercicios
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
            this.btnExercicio1 = new System.Windows.Forms.Button();
            this.btnExercicio2 = new System.Windows.Forms.Button();
            this.btnExercicio3 = new System.Windows.Forms.Button();
            this.btnExercicio4 = new System.Windows.Forms.Button();
            this.btnExercicio5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exercicios de C#";
            this.label1.UseWaitCursor = true;
            // 
            // btnExercicio1
            // 
            this.btnExercicio1.Location = new System.Drawing.Point(85, 60);
            this.btnExercicio1.Name = "btnExercicio1";
            this.btnExercicio1.Size = new System.Drawing.Size(164, 23);
            this.btnExercicio1.TabIndex = 1;
            this.btnExercicio1.Text = "Exercicio 1";
            this.btnExercicio1.UseVisualStyleBackColor = true;
            this.btnExercicio1.Click += new System.EventHandler(this.btnExercicio1_Click);
            // 
            // btnExercicio2
            // 
            this.btnExercicio2.Location = new System.Drawing.Point(85, 102);
            this.btnExercicio2.Name = "btnExercicio2";
            this.btnExercicio2.Size = new System.Drawing.Size(164, 23);
            this.btnExercicio2.TabIndex = 2;
            this.btnExercicio2.Text = "Exercicio 2";
            this.btnExercicio2.UseVisualStyleBackColor = true;
            this.btnExercicio2.Click += new System.EventHandler(this.btnExercicio2_Click);
            // 
            // btnExercicio3
            // 
            this.btnExercicio3.Location = new System.Drawing.Point(85, 150);
            this.btnExercicio3.Name = "btnExercicio3";
            this.btnExercicio3.Size = new System.Drawing.Size(164, 23);
            this.btnExercicio3.TabIndex = 3;
            this.btnExercicio3.Text = "Exercicio 3";
            this.btnExercicio3.UseVisualStyleBackColor = true;
            this.btnExercicio3.Click += new System.EventHandler(this.btnExercicio3_Click);
            // 
            // btnExercicio4
            // 
            this.btnExercicio4.Location = new System.Drawing.Point(85, 195);
            this.btnExercicio4.Name = "btnExercicio4";
            this.btnExercicio4.Size = new System.Drawing.Size(164, 23);
            this.btnExercicio4.TabIndex = 4;
            this.btnExercicio4.Text = "Exercicio 4";
            this.btnExercicio4.UseVisualStyleBackColor = true;
            this.btnExercicio4.Click += new System.EventHandler(this.btnExercicio4_Click);
            // 
            // btnExercicio5
            // 
            this.btnExercicio5.Location = new System.Drawing.Point(85, 241);
            this.btnExercicio5.Name = "btnExercicio5";
            this.btnExercicio5.Size = new System.Drawing.Size(164, 23);
            this.btnExercicio5.TabIndex = 5;
            this.btnExercicio5.Text = "Exercicio 5";
            this.btnExercicio5.UseVisualStyleBackColor = true;
            this.btnExercicio5.Click += new System.EventHandler(this.btnExercicio5_Click);
            // 
            // Exercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 292);
            this.Controls.Add(this.btnExercicio5);
            this.Controls.Add(this.btnExercicio4);
            this.Controls.Add(this.btnExercicio3);
            this.Controls.Add(this.btnExercicio2);
            this.Controls.Add(this.btnExercicio1);
            this.Controls.Add(this.label1);
            this.Name = "Exercicios";
            this.Text = "Exercicios";
            this.Load += new System.EventHandler(this.Exercicios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExercicio1;
        private System.Windows.Forms.Button btnExercicio2;
        private System.Windows.Forms.Button btnExercicio3;
        private System.Windows.Forms.Button btnExercicio4;
        private System.Windows.Forms.Button btnExercicio5;
    }
}