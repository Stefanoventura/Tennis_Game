namespace Game
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Imagem_Bola = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPontuacao = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Jogador = new System.Windows.Forms.PictureBox();
            this.timerMovimentaBola = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Imagem_Bola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jogador)).BeginInit();
            this.SuspendLayout();
            // 
            // Imagem_Bola
            // 
            this.Imagem_Bola.BackColor = System.Drawing.Color.Transparent;
            this.Imagem_Bola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Imagem_Bola.Image = global::Game.Properties.Resources.BolaTenis;
            this.Imagem_Bola.Location = new System.Drawing.Point(573, 335);
            this.Imagem_Bola.Name = "Imagem_Bola";
            this.Imagem_Bola.Size = new System.Drawing.Size(43, 38);
            this.Imagem_Bola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagem_Bola.TabIndex = 0;
            this.Imagem_Bola.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Game.Properties.Resources.Play;
            this.pictureBox2.Location = new System.Drawing.Point(2, 391);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "PONTUAÇÃO:";
            // 
            // labelPontuacao
            // 
            this.labelPontuacao.AutoSize = true;
            this.labelPontuacao.BackColor = System.Drawing.Color.Transparent;
            this.labelPontuacao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPontuacao.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPontuacao.Location = new System.Drawing.Point(121, 9);
            this.labelPontuacao.Name = "labelPontuacao";
            this.labelPontuacao.Size = new System.Drawing.Size(48, 16);
            this.labelPontuacao.TabIndex = 4;
            this.labelPontuacao.Text = "--------";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::Game.Properties.Resources.Stop;
            this.pictureBox3.Location = new System.Drawing.Point(72, 391);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // Jogador
            // 
            this.Jogador.BackColor = System.Drawing.Color.Transparent;
            this.Jogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Jogador.Image = global::Game.Properties.Resources.jogador;
            this.Jogador.Location = new System.Drawing.Point(631, 273);
            this.Jogador.Name = "Jogador";
            this.Jogador.Size = new System.Drawing.Size(157, 165);
            this.Jogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Jogador.TabIndex = 6;
            this.Jogador.TabStop = false;
            // 
            // timerMovimentaBola
            // 
            this.timerMovimentaBola.Interval = 10;
            this.timerMovimentaBola.Tick += new System.EventHandler(this.TimerMovimentaBola_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Game.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Jogador);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelPontuacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Imagem_Bola);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tenis";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Imagem_Bola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jogador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Imagem_Bola;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPontuacao;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Jogador;
        private System.Windows.Forms.Timer timerMovimentaBola;
    }
}

