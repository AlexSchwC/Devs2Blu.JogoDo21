using Devs2Blu.Projeto.JogoDo21.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.Projeto.JogoDo21
{
    public partial class jnlJogoDo21 : Form
    {
        #region Props
        public int counterRodada { get; set; }
        public int randomNumberRodada { get; set; }
        public bool isGameOver { get; set; }

        Jogador player1 = new Jogador();

        Jogador computador = new Jogador();

        #endregion
        public jnlJogoDo21()
        {
            InitializeComponent();
            counterRodada = 0;
        }

        private void jnlJogoDo21_Load(object sender, EventArgs e)
        {
            txtbConsole.Text += $"Bem vindo ao Jogo do 21";
            
        }

        #region Eventos

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            isGameOver = false;
            counterRodada = 1;
            lbRodadaNumCounter.Text = $"{counterRodada}";
            btnEnviaNumeroJogador.Enabled = true;
            btnNovoJogo.Enabled = false;
            tbNumeroJogador.Enabled = true;
            txtbConsole.Text += $"\r\nNovo jogo iniciado!";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnEnviaNumeroJogador_Click(object sender, EventArgs e)
        {
            Regex re = new Regex("^[1-9]$|^0[1-9]$|^1[0-9]$|^20$");
            if (re.IsMatch(tbNumeroJogador.Text))
            {
                player1.NumeroRodada = Int32.Parse(tbNumeroJogador.Text);
                lbNumeroEscolhido.Text = $"\r\nNúmero escolhido: {player1.NumeroRodada}";
                tbNumeroJogador.Text = "";
                lbNumeroEscolhido.Visible = true;
                btnIniciarRodada.Enabled = true;
                txtbConsole.Text += $"\r\nVocê escolheu o número {player1.NumeroRodada}";
            } else
            {
                MessageBox.Show("Apenas números entre 1 e 20 são validos. Tente denovo");
            }
        }
        
        private void btnIniciarRodada_Click(object sender, EventArgs e)
        {
            btnIniciarRodada.Enabled = false;


            Random rd = new Random();
            randomNumberRodada = rd.Next(1, 20);

            computador.GeraRandomNum();

            txtbConsole.Text += $"\r\nO computador esolheu o número {computador.NumeroRodada}";
            txtbConsole.Text += $"\r\nO número randomico dessa rodada é {randomNumberRodada}";

            player1.NumRodadaSoma = player1.NumeroRodada + randomNumberRodada;
            computador.NumRodadaSoma = computador.NumeroRodada + randomNumberRodada;

            player1.CalculaPontosRodada(randomNumberRodada);
            lbPontosPlayer.Text = $"{player1.Pontuacao}";

            computador.CalculaPontosRodada(randomNumberRodada);
            lbPontosComputador.Text = $"{computador.Pontuacao}";

            lbNumeroEscolhido.Visible = false;

            FinalizarRodada(counterRodada);

            lbRodadaNumCounter.Text = $"{counterRodada}";

            if (isGameOver)
            {
                tbNumeroJogador.Enabled = false;
                btnEnviaNumeroJogador.Enabled = false;

                if (player1.Pontuacao > computador.Pontuacao)
                {
                    lbDisplayVencedor.Text = $"O Player venceu!!!";
                    lbDisplayVencedor.ForeColor = Color.Green;
                    lbDisplayVencedor.Visible = true;
                    txtbConsole.Text += $"\r\nFim do Jogo! Você vencou com {player1.Pontuacao}";
                } else if (computador.Pontuacao > player1.Pontuacao)
                {
                    lbDisplayVencedor.Text = $"O PC venceu!!!";
                    lbDisplayVencedor.ForeColor = Color.Red;
                    lbDisplayVencedor.Visible = true;
                    txtbConsole.Text += $"\r\nFim do Jogo! Você vencou com {computador.Pontuacao}";
                }
            }
        }
        #endregion

        #region Metodos

        public void Reset()
        {
            counterRodada = 0;
            lbRodadaNumCounter.Text = $"{counterRodada}";
            btnNovoJogo.Enabled = true;
            btnIniciarRodada.Enabled = false;
            btnEnviaNumeroJogador.Enabled = false;
            tbNumeroJogador.Enabled = true;
            tbResultRodada1.Text = "";
            tbResultRodada2.Text = "";
            tbResultRodada3.Text = "";
            lbDisplayVencedor.Visible = false;
            lbPontosPlayer.Text = "0";
            lbPontosComputador.Text = "0";
            txtbConsole.Text = "Jogo reiniciado!";
        }

        public void FinalizarRodada(int rodada)
        {
            switch (rodada)
            {
                case 1:
                    tbResultRodada1.Text = $"Num Player: {player1.NumeroRodada} ({player1.NumRodadaSoma}) --- Num PC: {computador.NumeroRodada} ({computador.NumRodadaSoma}) --- Random Num {randomNumberRodada}";
                    counterRodada++;
                    break;
                case 2:
                    tbResultRodada2.Text = $"Num Player: {player1.NumeroRodada} ({player1.NumRodadaSoma}) --- Num PC: {computador.NumeroRodada} ({computador.NumRodadaSoma}) --- Random Num {randomNumberRodada}";
                    counterRodada++;
                    break;
                case 3:
                    tbResultRodada3.Text = $"Num Player: {player1.NumeroRodada} ({player1.NumRodadaSoma}) --- Num PC: {computador.NumeroRodada} ({computador.NumRodadaSoma}) --- Random Num {randomNumberRodada}";
                    isGameOver = true;
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
