﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MarioKart
{
    public partial class Form1 : Form
    {
        //CONTADOR REGRESSIVO
        int regressivo = 3;

        //TEMPO CORRIDA
        int mm, ss, ff = 0; //variaveis minutos segundos e milisegundos
        


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

        private async void btstart_Click(object sender, EventArgs e)
        {
            btstart.Enabled = false;
            //Pequeno delay após apertar start. 
            await Task.Delay(1500);

            //CONTADOR NA TELA
            Contagem.Visible = true;
            timer1.Enabled = true;
            Contagem.Text = Convert.ToString(regressivo);           
           
            string nome1, nome2, nome3, nome4, winner;
            winner = "";

            //DEFININDO A SELECAO DE PERSONAGEM
            nome1 = Convert.ToString(comboBox1.SelectedItem);
            nome2 = Convert.ToString(comboBox2.SelectedItem);
            nome3 = Convert.ToString(comboBox3.SelectedItem);
            nome4 = Convert.ToString(comboBox4.SelectedItem);

            lblp1.Text = nome1;
            lbl2.Text = nome2;
            lbl3.Text = nome3;
            lbl4.Text = nome4;

            //CARREGANDO IMG DEPOIS DA SELEÇÃO

            p1.Load(@"D:\Jonathan\Documents\CORRIDA\img\personagens\" + nome1 +".png");
            p2.Load(@"D:\Jonathan\Documents\CORRIDA\img\personagens\" + nome2 + ".png");
            p3.Load(@"D:\Jonathan\Documents\CORRIDA\img\personagens\" + nome3 + ".png");
            p4.Load(@"D:\Jonathan\Documents\CORRIDA\img\personagens\" + nome4 + ".png");


            //DESABILITANDO TELA DE VENCEDOR
            groupBox1.Visible = false;

            //DESABILITANDO TELA DE SELECAO
            pictureBox3.Visible = false;
            Gruposelecao.Visible = false;
         
            //DEIXANDO OS PERSONAGENS VISIVEIS AO INICIAR A CORRIDA
            p1.Visible = true;
            p2.Visible = true;
            p3.Visible = true;
            p4.Visible = true;

            //DESABILITANDO A SELEÇÃO DE PERSONAGENS DURANTE A CORRIDA
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;



            //COMECANDO CORRIDA

            //TEMPO DE CORRIDA
            await Task.Delay(4000);
            timer2.Enabled = true;
            timer2.Start();



            while (Personagem1.Correr() == false && Personagem2.Correr() == false && Personagem3.Correr() == false && Personagem4.Correr() == false)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(1);
            }
            if(Personagem1.Correr() == true)
            {
                
                lblvencedor.Text = nome1; //nome do vencedor na tela
                winner = nome1;
            }
            else if(Personagem2.Correr() == true)
            {
                
                lblvencedor.Text = nome2; //nome do vencedor na tela
                winner = nome2;
            }
            else if(Personagem3.Correr() == true)
            {
                 
                lblvencedor.Text = nome3; //nome do vencedor na tela
                winner = nome3;
            }
            else if(Personagem4.Correr() == true)
            {
                
                lblvencedor.Text = nome4; //nome do vencedor na tela
                winner = nome4;
            }

            timer2.Stop();

            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;

            picwinner.Load(url: @"D:\Jonathan\Documents\CORRIDA\img\personagens\"
                                + winner
                                + ".png");


            //HABILITANDO TELA DE VENCEDOR
            groupBox1.Visible = true;

        }

        private void btreiniciar_Click(object sender, EventArgs e)
        {
            //reiniciando valor do cronometro
            timer2.Dispose();
            mm = 0;
            ss = 0;
            ff = 0;
            lbltempo.Text = $"0{mm}:0{ss}:{ff}";

            //REABILITANDO A SELECAO DE PERSONAGEM
            Gruposelecao.Visible = true;
            pictureBox3.Visible = true;
            btstart.Enabled = true;

            //RESETANDO NOMES SELECIONADOS
            lblp1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";

            //DESABILITANDO TELA DE VENCEDOR
            groupBox1.Visible = false;

            //CONTADOR REINICIADO
            regressivo = 3; 

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void Contagem_Click(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bandeira.Visible = false;
     
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void lblvencedor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //CONDICOES DE INCREMENTO DO CRONOMETRO
            ff++;
            if (ff == 10)
            {
                    ss++; 
                    ff = 0;
            } else if (ss == 60)

            {
                mm++;
                ss = 0;
            }
            lbltempo.Text = $"0{mm}:{ss}:0{ff}";
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private async void timer1_Tick_1(object sender, EventArgs e)
        {
            regressivo = regressivo - 1;
            Contagem.Text = Convert.ToString(regressivo);
            if(regressivo == 0 ) 
            {
                timer1.Enabled = false;
                bandeira.Visible = true;
                Contagem.Visible = false;

                await Task.Delay(2000);
                bandeira.Visible = false;


            }
        }
    }
}
