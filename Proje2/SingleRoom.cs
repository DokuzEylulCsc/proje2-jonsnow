using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class SingleRoom : Room //tekli oda
    {
        private bool special;

        public SingleRoom(int floor, int no, bool isFull, bool isHaveJacuzzi, bool speacial, int price) : base(floor, no, isFull, isHaveJacuzzi, price)
        {
            this.special = speacial;
        }

        public bool Special
        {
            get { return special; }
        }
    }
}
