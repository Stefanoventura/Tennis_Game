using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        int velocidade;
        int pontuacao;
        bool Ir_Para_Cima, Ir_Para_Direita;
        int TamanhoMaximoBuffer;
        bool Flag_Encerrar;
        bool Flag_IniciouJogo;

        Thread ThreadGeraVelocidadeBola;

        List<int> BufferVelocidadeBola;
        int BufferPosicaoRaquete;

        Mutex Mutex_BufferVelocidadeBola;
        Mutex Mutex_BufferPosicaoRaquete;
        public Form1()
        {
            InitializeComponent();

            Flag_IniciouJogo = false;
        }

        void GerarVelocidadeBola()
        {
            while (Flag_Encerrar == false)
            {
                Mutex_BufferVelocidadeBola.WaitOne();
                if (BufferVelocidadeBola.Count < TamanhoMaximoBuffer)
                {
                    BufferVelocidadeBola.Add(velocidade);
                }

                Mutex_BufferVelocidadeBola.ReleaseMutex();

                Console.WriteLine(velocidade);

                Thread.Sleep(5000);
                velocidade = velocidade + 1;
                if (velocidade > 100)
                    velocidade = 10;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Flag_IniciouJogo == true)
            {
                Mutex_BufferPosicaoRaquete.WaitOne();
                BufferPosicaoRaquete = e.Y;

                Mutex_BufferPosicaoRaquete.ReleaseMutex();
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Flag_IniciouJogo = false;
            Flag_Encerrar = true;
            timerMovimentaBola.Enabled = false;
            ThreadGeraVelocidadeBola.Abort();
            Mutex_BufferPosicaoRaquete.Dispose();
            Mutex_BufferVelocidadeBola.Dispose();
            Mutex_BufferPosicaoRaquete.Close();
            Mutex_BufferVelocidadeBola.Close();
            Close();
        }

        private void TimerMovimentaBola_Tick(object sender, EventArgs e)
        {
            Mutex_BufferPosicaoRaquete.WaitOne();

            Jogador.Top = BufferPosicaoRaquete;

            Mutex_BufferPosicaoRaquete.ReleaseMutex();

            if (Imagem_Bola.Left > Jogador.Left)
            {
                timerMovimentaBola.Enabled = false;
                Flag_IniciouJogo = false;
                Flag_Encerrar = true;
                MessageBox.Show("GAME-OVER !");
            }

            if ((Imagem_Bola.Left + Imagem_Bola.Width >= Jogador.Left) && (Imagem_Bola.Left + Imagem_Bola.Width <= Jogador.Left + Jogador.Width) &&
                (Imagem_Bola.Top + Imagem_Bola.Height >= Jogador.Top) &&
                (Imagem_Bola.Top + Imagem_Bola.Height <= Jogador.Top + Jogador.Height + Imagem_Bola.Height))
            {
                Ir_Para_Direita = false;
                pontuacao += 1;
                labelPontuacao.Text = pontuacao.ToString();
            }
                Mutex_BufferVelocidadeBola.WaitOne();
                if (BufferVelocidadeBola.Count > 0)
                {
                    velocidade = (int)BufferVelocidadeBola[0];
                    BufferVelocidadeBola.RemoveAt(0);
                }

                Mutex_BufferVelocidadeBola.ReleaseMutex();

                if (Ir_Para_Direita)
                    Imagem_Bola.Left += velocidade;
                else
                    Imagem_Bola.Left -= velocidade;

                if (Ir_Para_Cima)
                    Imagem_Bola.Top += velocidade;
                else
                    Imagem_Bola.Top -= velocidade;

                if (Imagem_Bola.Top >= this.Height - Imagem_Bola.Height)
                    Ir_Para_Cima = false;

                if (Imagem_Bola.Bottom <= 0)
                    Ir_Para_Cima = true;

                if (Imagem_Bola.Left <= 0)
                    Ir_Para_Direita = true;
            
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            TamanhoMaximoBuffer = 200;

            Random rand = new Random();
            Imagem_Bola.Location = new Point(0, rand.Next(this.Height));

            Jogador.Height = 100;
            Ir_Para_Cima = true;
            Ir_Para_Direita = true;
            Flag_Encerrar = false;
            velocidade = 10;
            pontuacao = 0;

            BufferVelocidadeBola = new List<int>(TamanhoMaximoBuffer);
            BufferPosicaoRaquete = 0;

            ThreadGeraVelocidadeBola = new Thread(GerarVelocidadeBola);

            Mutex_BufferVelocidadeBola = new Mutex();
            Mutex_BufferPosicaoRaquete = new Mutex();

            ThreadGeraVelocidadeBola.Start();
            timerMovimentaBola.Enabled = true;

            Flag_IniciouJogo = true;
        }
    }
}
