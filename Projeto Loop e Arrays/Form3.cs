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
    public partial class Frm_Tela3 : Form
    {
        public Frm_Tela3()
        {
            InitializeComponent();
        }

        int numero, contador; // Declarando as variáveis

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Tela2 tela2 = new Frm_Tela2();
            tela2.Show();
            Hide();
        }

        private void Chk_For_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_For.Checked == true) //Se fosse apenas "Chk_For.Checked" --> por padrão já significa que é igual a true; Para este item, ao ser marcado, irá habilitar a visibilidade da groupBox
            {
                Grp_Tabuada1.Visible = true; // Mostrando a tabuada 1
            }
            else
            {
                Grp_Tabuada1.Visible = false; // Não mostra a tabuada 1
            }
        }

        private void Txt_Numero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Somente números!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13) // Se o usuário pressionar a tecla enter, verifica se o Txt está vazio
            {
                if (Txt_Numero1.Text != "")
                {
                    numero = int.Parse(Txt_Numero1.Text); // A variável está recebendo o número digitado

                    List_Tabuada1.Items.Clear(); // Limpar os itens da lista

                    for (contador = 0; contador < 11; contador++) // Usando o laço
                    {
                        List_Tabuada1.Items.Add(numero + " x " + contador + " = " + contador * numero);
                    }
                }
            }
        }
        private void Chk_While_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_While.Checked)
            {
                Grp_Tabuada2.Visible = true;
            }
            else
            {
                Grp_Tabuada2.Visible = false;
            }
        }

        private void Txt_Numero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled= true;
                MessageBox.Show("Somente Números!!!", "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
            if(e.KeyChar == 13)
            {
                if(Txt_Numero2.Text != "")
                {
                    numero = int.Parse(Txt_Numero2.Text);
                    contador = 0; // Início da estrutura de repetição WHILE
                    List_Tabuada2.Items.Clear();
                    while (contador <= 10) // Outra estrutura de repetição
                    {
                        List_Tabuada2.Items.Add(contador + " X " + numero + " = " + numero*contador);
                        contador++;
                    }
                }
            }
        }
    }
}
