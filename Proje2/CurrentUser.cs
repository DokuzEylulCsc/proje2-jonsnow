using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class CurrentUser : User //geçerli kullanıcı
    {
        public CurrentUser(string username) : base(username)
        {

        }
        public bool makeReservation()
        {
            return false;
        }
        public void cancelReservation()
        {

        }

    }
}
