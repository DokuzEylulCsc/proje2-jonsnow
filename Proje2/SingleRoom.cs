using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class SingleRoom : Room //tekli oda
    {
        private bool special; //oda özel bir oda mı

        public SingleRoom(int floor, int no, bool isFull, bool isHaveJacuzzi, bool speacial, int price) : base(floor, no, isFull, isHaveJacuzzi, price)
        { //base roomdan özelliker alınır
            this.special = speacial;
        }

        public bool Special //special get 
        {
            get { return special; }
        }
    }
}
