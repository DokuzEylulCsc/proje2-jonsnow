using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Hotel //otel sınıfı
    {
        List<Room> roomList = new List<Room>();
        string hotelName, city; //Otel adi
        int star; // otelin yıldız sayısı
        int fullness = 0;

        public Hotel(List<Room> roomList, string hotelName, int star, string city)
        {
            this.roomList = roomList;
            this.hotelName = hotelName;
            this.star = star;
            this.city = city;
        }




        public string HotelName
        {
            get { return hotelName; }
        }

        public string City
        {
            get { return city; }
        }

        public List<Room> RoomList
        {
            get { return roomList; }
        }

        public int Star
        {
            get { return star; }
        }

        public int Fullness
        {
            get { return fullness; }
            set { fullness = value; }
        }
    }
}
