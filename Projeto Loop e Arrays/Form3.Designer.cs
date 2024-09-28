namespace Projeto_Loop_e_Arrays
{
    partial class Frm_Tela3
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
            this.Chk_For = new System.Windows.Forms.CheckBox();
            this.Grp_Tabuada1 = new System.Windows.Forms.GroupBox();
            this.List_Tabuada1 = new System.Windows.Forms.ListBox();
            this.Lbl_Numero1 = new System.Windows.Forms.Label();
            this.Txt_Numero1 = new System.Windows.Forms.TextBox();
            this.Chk_While = new System.Windows.Forms.CheckBox();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Grp_Tabuada2 = new System.Windows.Forms.GroupBox();
            this.List_Tabuada2 = new System.Windows.Forms.ListBox();
            this.Lbl_Numero2 = new System.Windows.Forms.Label();
            this.Txt_Numero2 = new System.Windows.Forms.TextBox();
            this.Grp_Tabuada1.SuspendLayout();
            this.Grp_Tabuada2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chk_For
            // 
            this.Chk_For.AutoSize = true;
            this.Chk_For.Location = new System.Drawing.Point(56, 32);
            this.Chk_For.Name = "Chk_For";
            this.Chk_For.Size = new System.Drawing.Size(48, 17);
            this.Chk_For.TabIndex = 0;
            this.Chk_For.Text = "FOR";
            this.Chk_For.UseVisualStyleBackColor = true;
            this.Chk_For.CheckedChanged += new System.EventHandler(this.Chk_For_CheckedChanged);
            // 
            // Grp_Tabuada1
            // 
            this.Grp_Tabuada1.Controls.Add(this.List_Tabuada1);
            this.Grp_Tabuada1.Controls.Add(this.Lbl_Numero1);
            this.Grp_Tabuada1.Controls.Add(this.Txt_Numero1);
            this.Grp_Tabuada1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_Tabuada1.ForeColor = System.Drawing.Color.Red;
            this.Grp_Tabuada1.Location = new System.Drawing.Point(38, 69);
            this.Grp_Tabuada1.Name = "Grp_Tabuada1";
            this.Grp_Tabuada1.Size = new System.Drawing.Size(218, 286);
            this.Grp_Tabuada1.TabIndex = 1;
            this.Grp_Tabuada1.TabStop = false;
            this.Grp_Tabuada1.Text = "Tabuada 1";
            this.Grp_Tabuada1.Visible = false;
            // 
            // List_Tabuada1
            // 
            this.List_Tabuada1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_Tabuada1.FormattingEnabled = true;
            this.List_Tabuada1.Location = new System.Drawing.Point(22, 72);
            this.List_Tabuada1.Name = "List_Tabuada1";
            this.List_Tabuada1.Size = new System.Drawing.Size(174, 199);
            this.List_Tabuada1.TabIndex = 2;
            // 
            // Lbl_Numero1
            // 
            this.Lbl_Numero1.AutoSize = true;
            this.Lbl_Numero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numero1.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Numero1.Location = new System.Drawing.Point(10, 40);
            this.Lbl_Numero1.Name = "Lbl_Numero1";
            this.Lbl_Numero1.Size = new System.Drawing.Size(92, 13);
            this.Lbl_Numero1.TabIndex = 1;
            this.Lbl_Numero1.Text = "Digite um número:";
            // 
            // Txt_Numero1
            // 
            this.Txt_Numero1.Location = new System.Drawing.Point(108, 37);
            this.Txt_Numero1.Name = "Txt_Numero1";
            this.Txt_Numero1.Size = new System.Drawing.Size(100, 20);
            this.Txt_Numero1.TabIndex = 0;
            this.Txt_Numero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Numero1_KeyPress);
            // 
            // Chk_While
            // 
            this.Chk_While.AutoSize = true;
            this.Chk_While.Location = new System.Drawing.Point(284, 32);
            this.Chk_While.Name = "Chk_While";
            this.Chk_While.Size = new System.Drawing.Size(61, 17);
            this.Chk_While.TabIndex = 3;
            this.Chk_While.Text = "WHILE";
            this.Chk_While.UseVisualStyleBackColor = true;
            this.Chk_While.CheckedChanged += new System.EventHandler(this.Chk_While_CheckedChanged);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Location = new System.Drawing.Point(645, 61);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Voltar.TabIndex = 5;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Grp_Tabuada2
            // 
            this.Grp_Tabuada2.Controls.Add(this.List_Tabuada2);
            this.Grp_Tabuada2.Controls.Add(this.Lbl_Numero2);
            this.Grp_Tabuada2.Controls.Add(this.Txt_Numero2);
            this.Grp_Tabuada2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_Tabuada2.ForeColor = System.Drawing.Color.Blue;
            this.Grp_Tabuada2.Location = new System.Drawing.Point(284, 69);
            this.Grp_Tabuada2.Name = "Grp_Tabuada2";
            this.Grp_Tabuada2.Size = new System.Drawing.Size(218, 286);
            this.Grp_Tabuada2.TabIndex = 3;
            this.Grp_Tabuada2.TabStop = false;
            this.Grp_Tabuada2.Text = "Tabuada 2";
            this.Grp_Tabuada2.Visible = false;
            // 
            // List_Tabuada2
            // 
            this.List_Tabuada2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_Tabuada2.FormattingEnabled = true;
            this.List_Tabuada2.Location = new System.Drawing.Point(22, 72);
            this.List_Tabuada2.Name = "List_Tabuada2";
            this.List_Tabuada2.Size = new System.Drawing.Size(174, 199);
            this.List_Tabuada2.TabIndex = 2;
            // 
            // Lbl_Numero2
            // 
            this.Lbl_Numero2.AutoSize = true;
            this.Lbl_Numero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numero2.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Numero2.Location = new System.Drawing.Point(10, 40);
            this.Lbl_Numero2.Name = "Lbl_Numero2";
            this.Lbl_Numero2.Size = new System.Drawing.Size(92, 13);
            this.Lbl_Numero2.TabIndex = 1;
            this.Lbl_Numero2.Text = "Digite um número:";
            // 
            // Txt_Numero2
            // 
            this.Txt_Numero2.Location = new System.Drawing.Point(108, 40);
            this.Txt_Numero2.Name = "Txt_Numero2";
            this.Txt_Numero2.Size = new System.Drawing.Size(100, 20);
            this.Txt_Numero2.TabIndex = 0;
            this.Txt_Numero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Numero2_KeyPress);
            // 
            // Frm_Tela3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Grp_Tabuada2);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Chk_While);
            this.Controls.Add(this.Grp_Tabuada1);
            this.Controls.Add(this.Chk_For);
            this.Name = "Frm_Tela3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplos";
            this.Grp_Tabuada1.ResumeLayout(false);
            this.Grp_Tabuada1.PerformLayout();
            this.Grp_Tabuada2.ResumeLayout(false);
            this.Grp_Tabuada2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Chk_For;
        private System.Windows.Forms.GroupBox Grp_Tabuada1;
        private System.Windows.Forms.ListBox List_Tabuada1;
        private System.Windows.Forms.Label Lbl_Numero1;
        private System.Windows.Forms.TextBox Txt_Numero1;
        private System.Windows.Forms.CheckBox Chk_While;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.GroupBox Grp_Tabuada2;
        private System.Windows.Forms.ListBox List_Tabuada2;
        private System.Windows.Forms.Label Lbl_Numero2;
        private System.Windows.Forms.TextBox Txt_Numero2;
    }
}