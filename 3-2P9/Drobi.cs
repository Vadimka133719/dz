using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Drobi
    {
        int chislitel;
        int znaminatel;
        public Drobi(int chisl, int znam)
        {
            chislitel = chisl;
            znaminatel = znam;

        }
        public Drobi(int chislo)
        {
            chislitel = chislo;
            znaminatel = 1;
        }
        public Drobi(int celoe, int chislit, int znamen)
        {
            chislitel = celoe * znamen + chislit;
            znaminatel = znamen;
        }
        public double ToDouble()
        {
            return (double)(chislitel) / znaminatel;
        }
        public static Drobi operator *(Drobi odin, Drobi dva)
        {
            return new Drobi(odin.chislitel * dva.chislitel, odin.znaminatel * dva.znaminatel);

        }
        public bool Znak
        {
            get
            {
                bool a = chislitel >= 0;
                bool b = znaminatel >= 0;
                return a == b;

            }
        }
        public delegate void pofi(Drobi ofd, int znah);
    }
}