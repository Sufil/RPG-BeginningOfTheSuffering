using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Enemy:Entity
    {
        int probabilityOfAppearing;
        int exp;

        Attack[] possibleAttacks;
        int amountAttacks;
        Attack[] attacks;
        
        public  int ProbabilityOfAppearing { get => probabilityOfAppearing; set => probabilityOfAppearing = value; }
        public  int Exp { get => exp; set => exp = value; }

        public virtual int selectAttack()
        {
            Random random = new Random();
            return random.Next(0, amountAttacks);  
        }
        
    }
}
