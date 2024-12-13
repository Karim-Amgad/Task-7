using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Parent
    {
        #region Attributes
        private protected int x;
        private protected int y;
        #endregion

        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Constractor
        public Parent(int _X, int _Y)
        {
            x= _X;
            y= _Y;
        }
        #endregion

        #region Methods
        public virtual int Product()
        {
            return x * y;
        }
       
        #endregion

        #region Override
        public override string ToString()
        {
            return $"{x}, {y}";
        }
        #endregion
    }
}
