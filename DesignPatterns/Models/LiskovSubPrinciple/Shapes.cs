using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.LiskovSubPrinciple
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"Width: {Width}, Height: {Height}";
        }
    }

    public class Square : Rectangle
    {

        public Square(int sideLength) : base(sideLength, sideLength)
        {

        }
        public override int Width
        {
            set { base.Width = base.Height = value; }

        }

        public override int Height
        {
            set { base.Width = base.Height = value; }

        }

        public override string ToString()
        {
            return $"Square Width: {Width} - Square Height: {Height}";
        }
    }
}
