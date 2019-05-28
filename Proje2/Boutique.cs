using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Boutique : Hotel
    {
        public Boutique(List<Room> roomList, string hostelName, int star, string city) : base(roomList, hostelName, star, city)
        {

        }
    }
}
