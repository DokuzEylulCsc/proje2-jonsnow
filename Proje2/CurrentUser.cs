using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class CurrentUser : User //geçerli kullanıcı
    {
        int index;

        public CurrentUser(string username, int index) : base(username)
        {
            this.index = index;
        }

        public int Index
        {
            get { return index; }
        }

        public bool makeReservation(DateTime startDate, DateTime endDate, Hotel hotel, Room room)
        {
            bool temp = true;

            foreach (Reservation i in ReservationList)
            {
                if (i.StartDate < endDate && startDate < i.EndDate && hotel == i.Hotel && room.No == i.Room.No)
                {
                    temp = false;
                    break;
                }
            }

            if (temp)
            {
                Reservation reservation = new Reservation(startDate, endDate, hotel, room);
                ReservationList.Add(reservation);
            }

            return temp;

        }

        public void cancelReservation(Reservation reservation)
        {
            ReservationList.Remove(reservation);
        }
    }
}
