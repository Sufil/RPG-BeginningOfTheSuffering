﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Cry:Attack
    {
        public Cry()
        {
            Name = "Weinen";
            Acc = 99;
            Dmg = 3;
            Crit = 20;
            Description = "ENTITY beginnt ohne Grund zu weinen. Das Salz schadet TARGETs weicher Haut.";
        }
    }
}
