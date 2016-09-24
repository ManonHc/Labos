using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    public static class Parameter
    {
        private static int nbActivity = 10;

        public static int NbActivity
        {
            get{ return nbActivity;  }

            set {nbActivity = 10; }
        }

        public enum Eval{R = 'R', S = 'S', T= 'T'};
        


    }
}
