using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MarioKart
{
    internal class Personagem
    {
        public int PontoInicial = 40; //posicao x do desenho (vertical)
        public int LarguraDaPista = 1090; //linha de chegada
        public PictureBox MeuPictureBox = null;
        public int localizacao = 0;
        public Random MeuRandom;
        public bool Correr()
        {
            //mover para frente de 1 a 4 espaços aleatoriamente
            //retorna true se ganhou a corrida
            int correu;
            MeuRandom = new Random();
            correu = MeuRandom.Next(0, 10); // gera numero aleatorio entre 0 e 4
            correu = (correu * MeuRandom.Next(0, 2)) % 5;
            correu = (correu * Convert.ToInt32(System.DateTime.Now.Millisecond) % 50);
            correu = (correu % 8) + 1;
            System.Threading.Thread.Sleep((Convert.ToInt32(System.DateTime.Now.Millisecond)) % 8);

            Point p = MeuPictureBox.Location; // point é da biblioteca drwing
            p.X += correu;
            MeuPictureBox.Location = p;

            if(p.X >= LarguraDaPista)
                return true;
            else
                return false;


        }
        public void VoltarPosicaoInicial()
        {
            Point p = this.MeuPictureBox.Location;
            p.X = PontoInicial;
            this.MeuPictureBox.Location = p;

        }
    }
}
