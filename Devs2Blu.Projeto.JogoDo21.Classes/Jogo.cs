using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.JogoDo21.Classes
{
    public class Jogo
    {
        public Int32 QuantidadeJogadores { get; set; }

        private static Int32 quantidadeJogadores = 0;
        public Int32 getQuantidadeJogadores()
        {
            return quantidadeJogadores;
        }
        public void setQuantidadeJogadores(Int32 num)
        {
            quantidadeJogadores = num;
        }
    }
}
