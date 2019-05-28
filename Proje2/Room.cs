using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Room //base oda
    {
        int floor, no, price; // ücret vb propslar
        bool isFull, isHaveJacuzzi; //dolu yada jakuzi boolları

        public Room(int floor, int no, bool isFull, bool isHaveJacuzzi, int price) //constructor
        {
            this.floor = floor;
            this.no = no;
            this.isFull = isFull;
            this.isHaveJacuzzi = isHaveJacuzzi;
            this.price = price;
        }

        public int Floor //propsların get ve setleri
        {
            get { return floor; }
        }

        public int No
        {
            get { return no; }
        }

        public bool IsFull
        {
            get { return isFull; }
        }

        public bool IsHaveJacuzzi
        {
            get { return isHaveJacuzzi; }
        }

        public int Price
        {
            get { return price; }
        }
    }
}
