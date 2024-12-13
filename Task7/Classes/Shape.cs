using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7;

namespace Task7
{
    internal abstract class Shape
    {
        #region Methods
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }

        public abstract void CalculateArea(int _Length, int _Width);
        #endregion


    }
    class rectangle : Shape
    {
        #region Properties & Attributes
        public int Length { get; set; }
        public int Width { get; set; }
        #endregion

        #region Methods
        public override void CalculateArea(int Length, int Width)
        {
            Console.WriteLine($"The area is {Length * Width}");
        }
        public override void Draw()
        {
           Console.WriteLine("We are drawing a rectangle");
        }
        #endregion

    }
}

