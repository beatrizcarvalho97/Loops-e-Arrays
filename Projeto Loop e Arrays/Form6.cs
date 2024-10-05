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
    public partial class Frm_Tela6 : Form
    {
        public Frm_Tela6()
        {
            InitializeComponent();
        }

        private void Frm_Tela6_Load(object sender, EventArgs e)
        {
            // Matriz 1

            int[,] matriz1 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } }; // Declarando uma matriz bidirecional de 5 elementos (ela sempre considera o parzinho um único elemento)
            List_Matriz1.Items.Add("matriz [0,0] = " + matriz1[0,0]); // Mostrando cada elemento da matriz
            List_Matriz1.Items.Add("matriz [0,1] = " + matriz1[0,1]);
            List_Matriz1.Items.Add("matriz [1,0] = " + matriz1[1,0]);
            List_Matriz1.Items.Add("matriz [1,1] = " + matriz1[1,1]);
            List_Matriz1.Items.Add("matriz [2,0] = " + matriz1[2,0]);
            List_Matriz1.Items.Add("matriz [2,1] = " + matriz1[2,1]);
            List_Matriz1.Items.Add("matriz [3,0] = " + matriz1[3,0]);
            List_Matriz1.Items.Add("matriz [3,1] = " + matriz1[3,1]);
            List_Matriz1.Items.Add("matriz [4,0] = " + matriz1[4,0]);
            List_Matriz1.Items.Add("matriz [4,1] = " + matriz1[4,1]);

            // Matriz 2

            string[,] matriz2 = { { "S" },{ "E" },{ "N" },{ "A" },{ "C" } };
            List_Matriz2.Items.Add("Matriz [0,0] = " + matriz2[0, 0]);
            List_Matriz2.Items.Add("Matriz [0,1] = " + matriz2[0, 1]);
            List_Matriz2.Items.Add("Matriz [0,2] = " + matriz2[0, 2]);
            List_Matriz2.Items.Add("Matriz [0,3] = " + matriz2[0, 3]);
            List_Matriz2.Items.Add("Matriz [0,4] = " + matriz2[0, 4]);

            /* Outra maneira de construir uma matriz
             
            string [,] matriz2 = new string [1,5]; // Declaração da matriz
            
            List_Matriz2.Items.Add(matriz2[0,0] + "S");
            List_Matriz2.Items.Add(matriz2[0,1] + "E");
            List_Matriz2.Items.Add(matriz2[0,2] + "N");
            List_Matriz2.Items.Add(matriz2[0,3] + "A");
            List_Matriz2.Items.Add(matriz2[0,4] + "C");

             */
        }
    }
}