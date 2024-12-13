using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7.Interfaces;

namespace Task7
{
    public class Rectangle : IShape
    {
        #region Attributes & Properties
        double Length { get; set; }
        double Width { get; set; }
        #endregion

        #region Constructor
        public Rectangle(double _length, double _width)
        {
            Length = _length;
            Width = _width;
        }
        #endregion

        #region Methods
        public double Area
        {
            get { return Length * Width; }
        }

        public void Draw()
        {
            Console.WriteLine($"The length is {Length} and Width is {Width}");
        }
        
        #endregion
    }
}
