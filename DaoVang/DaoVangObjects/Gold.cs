﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoVangObjects
{
    [Serializable]
    public class Gold : SquareBlock
    {
        public Gold(int size, int xLocation, int yLocation) : base(size, 1, xLocation, yLocation)
        {
        }
    }
}
