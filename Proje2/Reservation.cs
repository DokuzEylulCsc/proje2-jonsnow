using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Reservation
    {
        static int reservationCount = 0;
        int id_number; //rezervasyon numarası
        DateTime startDate, endDate; //Başlangıç ve bitiş tarihi
        Hotel hotel = null;
        Room room = null;

        public Reservation(DateTime startDate, DateTime endDate, Hotel hotel, Room room)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.hotel = hotel;
            this.room = room;
            reservationCount++;
            id_number = reservationCount;
        }

        public int ReservationCount
        {
            get { return reservationCount; }
        }

        public int Id
        {
            get { return id_number; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
        }

        public Hotel Hotel
        {
            get { return hotel; }
        }

        public Room Room
        {
            get { return room; }
        }
    }
}
