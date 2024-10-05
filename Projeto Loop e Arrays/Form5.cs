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
    public partial class Frm_Tela5 : Form
    {
        public Frm_Tela5()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Tela2 tela2 = new Frm_Tela2();
            tela2.Show();
            Hide();
        }

        private void Frm_Tela5_Load(object sender, EventArgs e)
        {
            // Declarando um vetor de 5 elementos, com indice de 0 até 4.
            int[] vetor1 = {10,9,8,7,6};

            List_Vetor1.Items.Add("1º Vetor: " + vetor1[0]);
            List_Vetor1.Items.Add("2º Vetor: " + vetor1[1]);
            List_Vetor1.Items.Add("3º Vetor: " + vetor1[2]);
            List_Vetor1.Items.Add("4º Vetor: " + vetor1[3]);
            List_Vetor1.Items.Add("5º Vetor: " + vetor1[4]);

            // Vetor 2

            int[] vetor2 = { 60, 50, 40, 30, 20, 10 }; // Declarando um vetor com 6 elementos e indice de 0 até 5.

            List_Vetor2.Items.Clear(); // Sempre que for usar um laço de repetição, preciso utilizar o clean para limpar as list box

            for(int i = 0;i<6;i++)
            {
                List_Vetor2.Items.Add("Vetor [" + i + "] = " + vetor2[i]);
            }

            // Vetor 3

            int[] vetor3 = new int[3]; // Declarando um vetor com 3 elementos e indice de 0 a 2

            List_Vetor3.Items.Add(vetor3[0]=15);
            List_Vetor3.Items.Add(vetor3[1]=23);
            List_Vetor3.Items.Add(vetor3[2]=8);

            // Vetor 4

            int[] vetor4 = new int[3] { 5, 9, 11 }; // Declarando um vetor com 3 elementos e indice de 0 até 2.

            List_Vetor4.Items.Clear();

            for(int i = 0; i < 3; i++)
            {
                List_Vetor4.Items.Add(i + " Vetor " + vetor4[i]);
            }
        }
    }
}
