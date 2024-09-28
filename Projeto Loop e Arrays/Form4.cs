using System;
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
    public partial class Frm_Tela4 : Form
    {
        public Frm_Tela4()
        {
            InitializeComponent();
        }

        int numero, contador;

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Tela2 tela2 = new Frm_Tela2();
            tela2.Show();
            Hide();
        }

        private void Txt_Contagem1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Somente números!!!","Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);

                if(e.KeyChar == 13)
                {
                    if(Txt_Contagem1.Text != "")
                    {
                        numero = int.Parse(Txt_Contagem1.Text);
                        List_Contagem1.Items.Clear();

                    for(contador = 0; contador <= numero;contador++)
                        {
                            List_Contagem1.Items.Add(contador);
                        }
                    }
                }
            }
        }
    }
}
