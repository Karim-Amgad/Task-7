using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Interfaces
{
    internal interface IMovable
    {
        #region Methods
        public void Move();
        #endregion

    }
    class car : IMovable
    {
        #region Methods
        public void Move()
        {
            Console.WriteLine("It's movable");
        }
        #endregion

    }
}
