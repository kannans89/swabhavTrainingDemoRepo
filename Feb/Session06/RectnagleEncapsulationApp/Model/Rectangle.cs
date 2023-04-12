using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectnagleEncapsulationApp.Model
{
    internal class Rectangle
    {
        private int _width;
        private int _height;
        private string _color;

        public int CalculateArea()
        {
            return _width * _height;
        }

        public void SetColor(string pcolor) {
            if (pcolor == "red" || pcolor == "blue" || pcolor == "green")
                _color = pcolor;
            else
                _color = "red";
        
        }

        public string GetColor() { 
           return _color;
        }

        public void SetWidth(int pwidth)
        {
            if (pwidth > 100)
                _width = 100;
            else if (pwidth < 0)
                _width = 1;
            else
                _width = pwidth;
        }
        public int GetWidth()
        {
            return _width;
        }

        public void SetHeight(int pheight) {
            if (pheight > 100)
                _height = 100;
            else if (pheight < 1)
                _height = 1;
            else
                _height = pheight;
        }

        public int GetHeight() { 
         return _height;
        }
       
    }
}
