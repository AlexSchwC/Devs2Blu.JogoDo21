using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.JogoDo21.Classes
{
    public class Utils
    {
        public Int32 GeraRandomNum(Int32 min, Int32 max)
        {
            Random rd = new Random();
            return rd.Next(min, max);
        }
    }
}
