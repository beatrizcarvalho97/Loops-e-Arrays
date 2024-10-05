namespace Projeto_Loop_e_Arrays
{
    partial class Frm_Tela7
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
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_Vetor3 = new System.Windows.Forms.Label();
            this.Lbl_Vetor2 = new System.Windows.Forms.Label();
            this.List_Vetor3 = new System.Windows.Forms.ListBox();
            this.List_Vetor2 = new System.Windows.Forms.ListBox();
            this.Lbl_DiasSemana = new System.Windows.Forms.Label();
            this.Lbl_Vetores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Location = new System.Drawing.Point(694, 63);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Voltar.TabIndex = 21;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Lbl_Vetor3
            // 
            this.Lbl_Vetor3.AutoSize = true;
            this.Lbl_Vetor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Vetor3.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Vetor3.Location = new System.Drawing.Point(445, 148);
            this.Lbl_Vetor3.Name = "Lbl_Vetor3";
            this.Lbl_Vetor3.Size = new System.Drawing.Size(148, 17);
            this.Lbl_Vetor3.TabIndex = 19;
            this.Lbl_Vetor3.Text = "Vetor 6 - Com Laço";
            // 
            // Lbl_Vetor2
            // 
            this.Lbl_Vetor2.AutoSize = true;
            this.Lbl_Vetor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Vetor2.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Vetor2.Location = new System.Drawing.Point(198, 148);
            this.Lbl_Vetor2.Name = "Lbl_Vetor2";
            this.Lbl_Vetor2.Size = new System.Drawing.Size(148, 17);
            this.Lbl_Vetor2.TabIndex = 18;
            this.Lbl_Vetor2.Text = "Vetor 5 - Sem Laço";
            this.Lbl_Vetor2.Click += new System.EventHandler(this.Lbl_Vetor2_Click);
            // 
            // List_Vetor3
            // 
            this.List_Vetor3.FormattingEnabled = true;
            this.List_Vetor3.Location = new System.Drawing.Point(448, 173);
            this.List_Vetor3.Name = "List_Vetor3";
            this.List_Vetor3.Size = new System.Drawing.Size(143, 238);
            this.List_Vetor3.TabIndex = 15;
            // 
            // List_Vetor2
            // 
            this.List_Vetor2.FormattingEnabled = true;
            this.List_Vetor2.Location = new System.Drawing.Point(201, 173);
            this.List_Vetor2.Name = "List_Vetor2";
            this.List_Vetor2.Size = new System.Drawing.Size(143, 238);
            this.List_Vetor2.TabIndex = 14;
            // 
            // Lbl_DiasSemana
            // 
            this.Lbl_DiasSemana.AutoSize = true;
            this.Lbl_DiasSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DiasSemana.Location = new System.Drawing.Point(343, 88);
            this.Lbl_DiasSemana.Name = "Lbl_DiasSemana";
            this.Lbl_DiasSemana.Size = new System.Drawing.Size(126, 17);
            this.Lbl_DiasSemana.TabIndex = 12;
            this.Lbl_DiasSemana.Text = "Dias da Semana";
            // 
            // Lbl_Vetores
            // 
            this.Lbl_Vetores.AutoSize = true;
            this.Lbl_Vetores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Vetores.Location = new System.Drawing.Point(349, 40);
            this.Lbl_Vetores.Name = "Lbl_Vetores";
            this.Lbl_Vetores.Size = new System.Drawing.Size(93, 20);
            this.Lbl_Vetores.TabIndex = 11;
            this.Lbl_Vetores.Text = "VETORES";
            // 
            // Frm_Tela7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Lbl_Vetor3);
            this.Controls.Add(this.Lbl_Vetor2);
            this.Controls.Add(this.List_Vetor3);
            this.Controls.Add(this.List_Vetor2);
            this.Controls.Add(this.Lbl_DiasSemana);
            this.Controls.Add(this.Lbl_Vetores);
            this.Name = "Frm_Tela7";
            this.Text = "Vetores - Dias da Semana";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Label Lbl_Vetor3;
        private System.Windows.Forms.Label Lbl_Vetor2;
        private System.Windows.Forms.ListBox List_Vetor3;
        private System.Windows.Forms.ListBox List_Vetor2;
        private System.Windows.Forms.Label Lbl_DiasSemana;
        private System.Windows.Forms.Label Lbl_Vetores;
    }
}