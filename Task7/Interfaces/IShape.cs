using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Interfaces
{
    internal interface IShape
    {
        #region Property & Attribute
        public double Area { get;}

        void Draw();

        public void PrintDetails()
        {
            Console.WriteLine("The system is good");
        }
        #endregion
    }

    public class Circle : IShape
    {
        #region Properties & Attributes
        double radius { get; set; }
        #endregion

        #region Methods
        public Circle (double _radius)
        {
            radius = _radius;

        }
        public double Area
        {
            get { return radius * radius * 3.14156; }
        }

        public void Draw()
        {
            Console.WriteLine($"The area is{Area}");
        }
        #endregion
        
    }
}
