using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.JogoDo21.Classes
{
    public class Jogador
    {
        public Int32 Id { get; set; }
        public Int32 Pontuacao { get; set; }
        public Int32 NumeroRodada { get; set; }
        public Int32 NumRodadaSoma { get; set; }
        public Jogador()
        {
            QuantidadeJogadores = 1;
            Id = getQuantidadeJogadores();
            Pontuacao = 0;
        }
        public void CalculaPontosRodada(int randomNum)
        {
            int soma = NumeroRodada + randomNum;

            switch (soma)
            {
                case 7:
                    Pontuacao += 10;
                    break;
                case 14:
                    Pontuacao += 20;
                    break;
                case 21:
                    Pontuacao += 30;
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Pontuacao += 1;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    Pontuacao += 5;
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    Pontuacao += 6;
                    break;
                default:
                    break;
            }

        }
        public void ResetJogador()
        {
            Pontuacao = 0;
            NumeroRodada = 0;
            NumRodadaSoma = 0;
        }
    }
}
