﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleApp.Model
{
    internal class Rectangle
    {
        public int width;
        public int height;

        public int CalculateArea()
        {
            int area = width * height;
            return area;
        }
    }
}
