﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Accauntant
    {
        public bool AskForBonus(Post post, int hours) => (int)post < hours;
    }
}
