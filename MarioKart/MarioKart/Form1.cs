using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarioKart
{
    public partial class Form1 : Form
    {
        Personagem Personagem1;
        Personagem Personagem2;
        Personagem Personagem3;
        Personagem Personagem4;

        public bool vencedor;
        

        public Form1()
        {
            InitializeComponent();
            Personagem1 = new Personagem();
            Personagem2 = new Personagem();
            Personagem3 = new Personagem();
            Personagem4 = new Personagem();

            Personagem1.MeuPictureBox = p1;
            Personagem2.MeuPictureBox = p2;
            Personagem3.MeuPictureBox = p3;
            Personagem4.MeuPictureBox = p4;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Selecao_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btstart_Click(object sender, EventArgs e)
        {
            int winner;

            p1.Visible = true;
            p2.Visible = true;
            p3.Visible = true;
            p4.Visible = true;

            while (Personagem1.Correr() == false && Personagem2.Correr() == false && Personagem3.Correr() == false && Personagem4.Correr() == false)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(1);
            }
            if(Personagem1.Correr() == true)
            {
                winner = 1;
                //fazer com que a tela de vitoria apresente o personagem com msg de vitoria
            }

            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;





        }
    }
}
