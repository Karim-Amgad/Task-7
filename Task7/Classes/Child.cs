using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Child:Parent
    {
		#region attribute
		public int z;
		#endregion

		#region Property
		public int Z
		{
			get { return z; }
			set { z = value; }
		}
        #endregion

        #region Constructor
        public Child(int _X, int _Y, int _Z) : base(_X, _Y)
        {
            Z = _Z;
        }
        #endregion

        #region Methods
        public new int Product1()
        {
            return base.Product() * z;
        }

        public override int Product()
        {
            return base.Product() * z;
        }
        #endregion

        #region Override
        public override string ToString()
        {
            return $"{x}, {y}, {z}";
        }

        #endregion
    }
}
