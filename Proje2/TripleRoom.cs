using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class TripleRoom : Room //üçlü oda
    {
        private bool isSpecialPool;

        public TripleRoom(int floor, int no, bool isFull, bool isHaveJacuzzi, bool isSpecialPool, int price) : base(floor, no, isFull, isHaveJacuzzi, price)
        {
            this.isSpecialPool = isSpecialPool;
        }
        // Üçlü oda class'ı
        public bool IsSpecialPool
        {
            get { return isSpecialPool; }
        }
    }
}
