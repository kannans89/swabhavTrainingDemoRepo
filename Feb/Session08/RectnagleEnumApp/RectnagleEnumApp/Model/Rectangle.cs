﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace RectnagleEnumApp.Model
{
    internal class Rectangle
    {
        private readonly int _width;
        private readonly int _height;
        private  ColorOption  _color;
        private BorderOption _border;

        public Rectangle(int width, int height, ColorOption color)
        {
            _width = ValidateSide( width);
            _height = ValidateSide(height);
            _color = color;
            _border = BorderOption.SINGLE;
        }

        public Rectangle(int width, int height, ColorOption color,BorderOption border)
        {
            _width = ValidateSide(width);
            _height = ValidateSide(height);
            _color = color;
            _border = border;
        }


        private int ValidateSide(int side) {
            if (side > 100)
                return 100;
            else if (side < 0)
                return 1;
            else
                return side;
        }
       
        public int CalculateArea()
        {
            return _width * _height;
        }

        public int Width {
            get { 
              return _width;
            }
        }

        public int Height {
            get {
                return _height;
            }
        }

        public ColorOption Color {
            get {
                return _color;
            }
            set { 
              _color= value;
            }
        }
        
        public BorderOption Border {
            get {
                return _border;
            }
        }
       

       

    }
}
