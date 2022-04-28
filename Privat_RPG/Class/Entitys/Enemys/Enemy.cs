using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Enemy:Entity
    {
        static int probabilityOfAppearing;
        static int EXP;

        Attack[] attacks;

        public static int ProbabilityOfAppearing { get => probabilityOfAppearing; set => probabilityOfAppearing = value; }
        
    }
}
