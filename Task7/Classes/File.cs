using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7.Interfaces;

namespace Task7
{
    internal class File : IReadable, IWritable
    {
        #region Methods
        public void Read()
        {
            Console.WriteLine("It's readable");
        }

        public void Write()
        {
            Console.WriteLine("It's writable");
        }
        #endregion

    }
}
