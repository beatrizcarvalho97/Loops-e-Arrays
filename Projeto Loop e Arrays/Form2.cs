﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Loop_e_Arrays
{
    public partial class Frm_Tela2 : Form
    {
        public Frm_Tela2()
        {
            InitializeComponent();
        }

        private void Rad_Contagens_CheckedChanged(object sender, EventArgs e)
        {
            Frm_Tela4 tela4 = new Frm_Tela4();
            tela4.Show();
            Hide();
        }

        private void Rad_Exemplos_CheckedChanged(object sender, EventArgs e)
        {
            Frm_Tela3 tela3 = new Frm_Tela3();
            tela3.Show();
            Hide();
        }

        private void Rad_Vetores_CheckedChanged(object sender, EventArgs e)
        {
            Frm_Tela5 tela5 = new Frm_Tela5();
            tela5.Show();
            Hide();
        }

        private void Rad_Arrays_CheckedChanged(object sender, EventArgs e)
        {
            Frm_Tela6 tela6 = new Frm_Tela6();
            tela6.Show();
            Hide();
        }
    }
}
