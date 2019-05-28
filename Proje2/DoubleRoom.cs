using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class DoubleRoom : Room //ikili oda
    {
        private bool isFood;

        public DoubleRoom(int floor, int no, bool isFull, bool isHaveJacuzzi, bool isFood, int price) : base(floor, no, isFull, isHaveJacuzzi, price)
        {
            this.isFood = isFood;
        }

        public bool IsFood
        {
            get { return isFood; }
        }
    }
}