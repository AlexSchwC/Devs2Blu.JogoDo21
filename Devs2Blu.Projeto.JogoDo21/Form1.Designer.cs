namespace Devs2Blu.Projeto.JogoDo21
{
    partial class jnlJogoDo21
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grbPlayer = new System.Windows.Forms.GroupBox();
            this.lbNumeroEscolhido = new System.Windows.Forms.Label();
            this.btnEnviaNumeroJogador = new System.Windows.Forms.Button();
            this.tbNumeroJogador = new System.Windows.Forms.TextBox();
            this.lbPontosPlayer = new System.Windows.Forms.Label();
            this.lbPontuacaoPlayer = new System.Windows.Forms.Label();
            this.grbComputador = new System.Windows.Forms.GroupBox();
            this.lbPontosComputador = new System.Windows.Forms.Label();
            this.lbPontuacaoComputador = new System.Windows.Forms.Label();
            this.btnIniciarRodada = new System.Windows.Forms.Button();
            this.lbRodada = new System.Windows.Forms.Label();
            this.lbRodadaNumCounter = new System.Windows.Forms.Label();
            this.gbPlacar = new System.Windows.Forms.GroupBox();
            this.lbRodada3 = new System.Windows.Forms.Label();
            this.lbRodada2 = new System.Windows.Forms.Label();
            this.lbRodada1 = new System.Windows.Forms.Label();
            this.tbResultRodada3 = new System.Windows.Forms.TextBox();
            this.tbResultRodada2 = new System.Windows.Forms.TextBox();
            this.tbResultRodada1 = new System.Windows.Forms.TextBox();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.lbDisplayVencedor = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtbConsole = new System.Windows.Forms.TextBox();
            this.grbPlayer.SuspendLayout();
            this.grbComputador.SuspendLayout();
            this.gbPlacar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogo do 21";
            // 
            // grbPlayer
            // 
            this.grbPlayer.Controls.Add(this.lbNumeroEscolhido);
            this.grbPlayer.Controls.Add(this.btnEnviaNumeroJogador);
            this.grbPlayer.Controls.Add(this.tbNumeroJogador);
            this.grbPlayer.Controls.Add(this.lbPontosPlayer);
            this.grbPlayer.Controls.Add(this.lbPontuacaoPlayer);
            this.grbPlayer.Location = new System.Drawing.Point(19, 170);
            this.grbPlayer.Name = "grbPlayer";
            this.grbPlayer.Size = new System.Drawing.Size(262, 187);
            this.grbPlayer.TabIndex = 1;
            this.grbPlayer.TabStop = false;
            this.grbPlayer.Text = "Player";
            // 
            // lbNumeroEscolhido
            // 
            this.lbNumeroEscolhido.AutoSize = true;
            this.lbNumeroEscolhido.Location = new System.Drawing.Point(17, 118);
            this.lbNumeroEscolhido.Name = "lbNumeroEscolhido";
            this.lbNumeroEscolhido.Size = new System.Drawing.Size(62, 13);
            this.lbNumeroEscolhido.TabIndex = 5;
            this.lbNumeroEscolhido.Text = "placeholder";
            this.lbNumeroEscolhido.Visible = false;
            // 
            // btnEnviaNumeroJogador
            // 
            this.btnEnviaNumeroJogador.Enabled = false;
            this.btnEnviaNumeroJogador.Location = new System.Drawing.Point(127, 95);
            this.btnEnviaNumeroJogador.Name = "btnEnviaNumeroJogador";
            this.btnEnviaNumeroJogador.Size = new System.Drawing.Size(67, 20);
            this.btnEnviaNumeroJogador.TabIndex = 4;
            this.btnEnviaNumeroJogador.Text = "Dale";
            this.btnEnviaNumeroJogador.UseVisualStyleBackColor = true;
            // 
            // tbNumeroJogador
            // 
            this.tbNumeroJogador.Enabled = false;
            this.tbNumeroJogador.Location = new System.Drawing.Point(20, 95);
            this.tbNumeroJogador.Name = "tbNumeroJogador";
            this.tbNumeroJogador.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroJogador.TabIndex = 3;
            // 
            // lbPontosPlayer
            // 
            this.lbPontosPlayer.AutoSize = true;
            this.lbPontosPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPontosPlayer.Location = new System.Drawing.Point(122, 26);
            this.lbPontosPlayer.Name = "lbPontosPlayer";
            this.lbPontosPlayer.Size = new System.Drawing.Size(20, 24);
            this.lbPontosPlayer.TabIndex = 1;
            this.lbPontosPlayer.Text = "0";
            // 
            // lbPontuacaoPlayer
            // 
            this.lbPontuacaoPlayer.AutoSize = true;
            this.lbPontuacaoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPontuacaoPlayer.Location = new System.Drawing.Point(16, 26);
            this.lbPontuacaoPlayer.Name = "lbPontuacaoPlayer";
            this.lbPontuacaoPlayer.Size = new System.Drawing.Size(110, 24);
            this.lbPontuacaoPlayer.TabIndex = 0;
            this.lbPontuacaoPlayer.Text = "Pontuação: ";
            // 
            // grbComputador
            // 
            this.grbComputador.Controls.Add(this.lbPontosComputador);
            this.grbComputador.Controls.Add(this.lbPontuacaoComputador);
            this.grbComputador.Location = new System.Drawing.Point(775, 170);
            this.grbComputador.Name = "grbComputador";
            this.grbComputador.Size = new System.Drawing.Size(262, 187);
            this.grbComputador.TabIndex = 2;
            this.grbComputador.TabStop = false;
            this.grbComputador.Text = "Computer";
            // 
            // lbPontosComputador
            // 
            this.lbPontosComputador.AutoSize = true;
            this.lbPontosComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPontosComputador.Location = new System.Drawing.Point(122, 26);
            this.lbPontosComputador.Name = "lbPontosComputador";
            this.lbPontosComputador.Size = new System.Drawing.Size(20, 24);
            this.lbPontosComputador.TabIndex = 3;
            this.lbPontosComputador.Text = "0";
            // 
            // lbPontuacaoComputador
            // 
            this.lbPontuacaoComputador.AutoSize = true;
            this.lbPontuacaoComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPontuacaoComputador.Location = new System.Drawing.Point(16, 26);
            this.lbPontuacaoComputador.Name = "lbPontuacaoComputador";
            this.lbPontuacaoComputador.Size = new System.Drawing.Size(110, 24);
            this.lbPontuacaoComputador.TabIndex = 2;
            this.lbPontuacaoComputador.Text = "Pontuação: ";
            // 
            // btnIniciarRodada
            // 
            this.btnIniciarRodada.Enabled = false;
            this.btnIniciarRodada.Location = new System.Drawing.Point(19, 128);
            this.btnIniciarRodada.Name = "btnIniciarRodada";
            this.btnIniciarRodada.Size = new System.Drawing.Size(96, 23);
            this.btnIniciarRodada.TabIndex = 3;
            this.btnIniciarRodada.Text = "Jogar Rodada";
            this.btnIniciarRodada.UseVisualStyleBackColor = true;
            // 
            // lbRodada
            // 
            this.lbRodada.AutoSize = true;
            this.lbRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRodada.Location = new System.Drawing.Point(16, 110);
            this.lbRodada.Name = "lbRodada";
            this.lbRodada.Size = new System.Drawing.Size(66, 17);
            this.lbRodada.TabIndex = 5;
            this.lbRodada.Text = "Rodada: ";
            // 
            // lbRodadaNumCounter
            // 
            this.lbRodadaNumCounter.AutoSize = true;
            this.lbRodadaNumCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRodadaNumCounter.Location = new System.Drawing.Point(76, 105);
            this.lbRodadaNumCounter.Name = "lbRodadaNumCounter";
            this.lbRodadaNumCounter.Size = new System.Drawing.Size(20, 24);
            this.lbRodadaNumCounter.TabIndex = 5;
            this.lbRodadaNumCounter.Text = "0";
            // 
            // gbPlacar
            // 
            this.gbPlacar.Controls.Add(this.lbRodada3);
            this.gbPlacar.Controls.Add(this.lbRodada2);
            this.gbPlacar.Controls.Add(this.lbRodada1);
            this.gbPlacar.Controls.Add(this.tbResultRodada3);
            this.gbPlacar.Controls.Add(this.tbResultRodada2);
            this.gbPlacar.Controls.Add(this.tbResultRodada1);
            this.gbPlacar.Location = new System.Drawing.Point(336, 45);
            this.gbPlacar.Name = "gbPlacar";
            this.gbPlacar.Size = new System.Drawing.Size(384, 191);
            this.gbPlacar.TabIndex = 6;
            this.gbPlacar.TabStop = false;
            this.gbPlacar.Text = "Placar";
            // 
            // lbRodada3
            // 
            this.lbRodada3.AutoSize = true;
            this.lbRodada3.Location = new System.Drawing.Point(19, 126);
            this.lbRodada3.Name = "lbRodada3";
            this.lbRodada3.Size = new System.Drawing.Size(110, 13);
            this.lbRodada3.TabIndex = 5;
            this.lbRodada3.Text = "Resultados Rodada 3";
            // 
            // lbRodada2
            // 
            this.lbRodada2.AutoSize = true;
            this.lbRodada2.Location = new System.Drawing.Point(19, 77);
            this.lbRodada2.Name = "lbRodada2";
            this.lbRodada2.Size = new System.Drawing.Size(110, 13);
            this.lbRodada2.TabIndex = 4;
            this.lbRodada2.Text = "Resultados Rodada 2";
            // 
            // lbRodada1
            // 
            this.lbRodada1.AutoSize = true;
            this.lbRodada1.Location = new System.Drawing.Point(19, 28);
            this.lbRodada1.Name = "lbRodada1";
            this.lbRodada1.Size = new System.Drawing.Size(110, 13);
            this.lbRodada1.TabIndex = 3;
            this.lbRodada1.Text = "Resultados Rodada 1";
            // 
            // tbResultRodada3
            // 
            this.tbResultRodada3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbResultRodada3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbResultRodada3.Location = new System.Drawing.Point(21, 139);
            this.tbResultRodada3.Multiline = true;
            this.tbResultRodada3.Name = "tbResultRodada3";
            this.tbResultRodada3.ReadOnly = true;
            this.tbResultRodada3.Size = new System.Drawing.Size(342, 20);
            this.tbResultRodada3.TabIndex = 2;
            this.tbResultRodada3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbResultRodada2
            // 
            this.tbResultRodada2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbResultRodada2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbResultRodada2.Location = new System.Drawing.Point(21, 90);
            this.tbResultRodada2.Multiline = true;
            this.tbResultRodada2.Name = "tbResultRodada2";
            this.tbResultRodada2.ReadOnly = true;
            this.tbResultRodada2.Size = new System.Drawing.Size(342, 20);
            this.tbResultRodada2.TabIndex = 1;
            this.tbResultRodada2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbResultRodada1
            // 
            this.tbResultRodada1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbResultRodada1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbResultRodada1.Location = new System.Drawing.Point(21, 41);
            this.tbResultRodada1.Multiline = true;
            this.tbResultRodada1.Name = "tbResultRodada1";
            this.tbResultRodada1.ReadOnly = true;
            this.tbResultRodada1.Size = new System.Drawing.Size(342, 20);
            this.tbResultRodada1.TabIndex = 0;
            this.tbResultRodada1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.Location = new System.Drawing.Point(19, 60);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(96, 23);
            this.btnNovoJogo.TabIndex = 7;
            this.btnNovoJogo.Text = "Novo Jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = true;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // lbDisplayVencedor
            // 
            this.lbDisplayVencedor.AutoSize = true;
            this.lbDisplayVencedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplayVencedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDisplayVencedor.Location = new System.Drawing.Point(327, 306);
            this.lbDisplayVencedor.Name = "lbDisplayVencedor";
            this.lbDisplayVencedor.Size = new System.Drawing.Size(246, 51);
            this.lbDisplayVencedor.TabIndex = 8;
            this.lbDisplayVencedor.Text = "placeholder";
            this.lbDisplayVencedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDisplayVencedor.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(121, 60);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // txtbConsole
            // 
            this.txtbConsole.Enabled = false;
            this.txtbConsole.Location = new System.Drawing.Point(19, 373);
            this.txtbConsole.Multiline = true;
            this.txtbConsole.Name = "txtbConsole";
            this.txtbConsole.ReadOnly = true;
            this.txtbConsole.Size = new System.Drawing.Size(1018, 122);
            this.txtbConsole.TabIndex = 6;
            // 
            // jnlJogoDo21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1059, 514);
            this.Controls.Add(this.txtbConsole);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbDisplayVencedor);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.gbPlacar);
            this.Controls.Add(this.lbRodadaNumCounter);
            this.Controls.Add(this.lbRodada);
            this.Controls.Add(this.btnIniciarRodada);
            this.Controls.Add(this.grbComputador);
            this.Controls.Add(this.grbPlayer);
            this.Controls.Add(this.label1);
            this.Name = "jnlJogoDo21";
            this.Text = "       ";
            this.Load += new System.EventHandler(this.jnlJogoDo21_Load);
            this.grbPlayer.ResumeLayout(false);
            this.grbPlayer.PerformLayout();
            this.grbComputador.ResumeLayout(false);
            this.grbComputador.PerformLayout();
            this.gbPlacar.ResumeLayout(false);
            this.gbPlacar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbPlayer;
        private System.Windows.Forms.Button btnEnviaNumeroJogador;
        private System.Windows.Forms.TextBox tbNumeroJogador;
        private System.Windows.Forms.Label lbPontosPlayer;
        private System.Windows.Forms.Label lbPontuacaoPlayer;
        private System.Windows.Forms.GroupBox grbComputador;
        private System.Windows.Forms.Label lbPontosComputador;
        private System.Windows.Forms.Label lbPontuacaoComputador;
        private System.Windows.Forms.Button btnIniciarRodada;
        private System.Windows.Forms.Label lbRodada;
        private System.Windows.Forms.Label lbRodadaNumCounter;
        private System.Windows.Forms.GroupBox gbPlacar;
        private System.Windows.Forms.Label lbRodada3;
        private System.Windows.Forms.Label lbRodada2;
        private System.Windows.Forms.Label lbRodada1;
        private System.Windows.Forms.TextBox tbResultRodada3;
        private System.Windows.Forms.TextBox tbResultRodada2;
        private System.Windows.Forms.TextBox tbResultRodada1;
        private System.Windows.Forms.Button btnNovoJogo;
        private System.Windows.Forms.Label lbDisplayVencedor;
        private System.Windows.Forms.Label lbNumeroEscolhido;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtbConsole;
    }
}

