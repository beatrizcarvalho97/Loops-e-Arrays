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
    public partial class Frm_Abertura : Form
    {
        public Frm_Abertura()
        {
            InitializeComponent();
        }

        private void Frm_Abertura_Load(object sender, EventArgs e)
        {
            Wmp_Video.URL = "Vinheta.mp4"; //Buscando o vídeo 
            Wmp_Video.uiMode = "None"; // Remoção dos botões do média player
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Timer1.Start(); //Iniciando o tempo
            Timer1.Stop(); //Parar o tempo
            Frm_Tela2 tela2 = new Frm_Tela2(); // Instanciando o objeto 'Tela2'
            tela2.Show(); //Chamando o objeto 'Tela2', desta maneira, irá aparecer a tela 2
            Hide();
        }
    }
}
