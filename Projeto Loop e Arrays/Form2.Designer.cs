namespace Projeto_Loop_e_Arrays
{
    partial class Frm_Tela2
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Rad_Exemplos = new System.Windows.Forms.RadioButton();
            this.Rad_Contagens = new System.Windows.Forms.RadioButton();
            this.Rad_Vetores = new System.Windows.Forms.RadioButton();
            this.Rad_Arrays = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(266, 97);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(268, 26);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Estruturas de Repetição";
            // 
            // Rad_Exemplos
            // 
            this.Rad_Exemplos.AutoSize = true;
            this.Rad_Exemplos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Exemplos.Location = new System.Drawing.Point(362, 140);
            this.Rad_Exemplos.Name = "Rad_Exemplos";
            this.Rad_Exemplos.Size = new System.Drawing.Size(96, 24);
            this.Rad_Exemplos.TabIndex = 1;
            this.Rad_Exemplos.Text = "Exemplos";
            this.Rad_Exemplos.UseVisualStyleBackColor = true;
            this.Rad_Exemplos.CheckedChanged += new System.EventHandler(this.Rad_Exemplos_CheckedChanged);
            // 
            // Rad_Contagens
            // 
            this.Rad_Contagens.AutoSize = true;
            this.Rad_Contagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Contagens.Location = new System.Drawing.Point(362, 184);
            this.Rad_Contagens.Name = "Rad_Contagens";
            this.Rad_Contagens.Size = new System.Drawing.Size(105, 24);
            this.Rad_Contagens.TabIndex = 2;
            this.Rad_Contagens.Text = "Contagens";
            this.Rad_Contagens.UseVisualStyleBackColor = true;
            this.Rad_Contagens.CheckedChanged += new System.EventHandler(this.Rad_Contagens_CheckedChanged);
            // 
            // Rad_Vetores
            // 
            this.Rad_Vetores.AutoSize = true;
            this.Rad_Vetores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Vetores.Location = new System.Drawing.Point(362, 234);
            this.Rad_Vetores.Name = "Rad_Vetores";
            this.Rad_Vetores.Size = new System.Drawing.Size(83, 24);
            this.Rad_Vetores.TabIndex = 3;
            this.Rad_Vetores.TabStop = true;
            this.Rad_Vetores.Text = "Vetores";
            this.Rad_Vetores.UseVisualStyleBackColor = true;
            this.Rad_Vetores.CheckedChanged += new System.EventHandler(this.Rad_Vetores_CheckedChanged);
            // 
            // Rad_Arrays
            // 
            this.Rad_Arrays.AutoSize = true;
            this.Rad_Arrays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Arrays.Location = new System.Drawing.Point(362, 278);
            this.Rad_Arrays.Name = "Rad_Arrays";
            this.Rad_Arrays.Size = new System.Drawing.Size(72, 24);
            this.Rad_Arrays.TabIndex = 4;
            this.Rad_Arrays.TabStop = true;
            this.Rad_Arrays.Text = "Arrays";
            this.Rad_Arrays.UseVisualStyleBackColor = true;
            this.Rad_Arrays.CheckedChanged += new System.EventHandler(this.Rad_Arrays_CheckedChanged);
            // 
            // Frm_Tela2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rad_Arrays);
            this.Controls.Add(this.Rad_Vetores);
            this.Controls.Add(this.Rad_Contagens);
            this.Controls.Add(this.Rad_Exemplos);
            this.Controls.Add(this.Lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Tela2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.RadioButton Rad_Exemplos;
        private System.Windows.Forms.RadioButton Rad_Contagens;
        private System.Windows.Forms.RadioButton Rad_Vetores;
        private System.Windows.Forms.RadioButton Rad_Arrays;
    }
}