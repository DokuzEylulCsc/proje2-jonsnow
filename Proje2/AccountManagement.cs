using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class AccountManagement //giriş yönetimi
    {
        UserLists list = new UserLists();

        public AccountManagement(string loginType)
        {
            if (loginType == "user")
                loginUser();
            else
                loginAdmin();
        }


        void loginUser()
        {
            
        }

        void loginAdmin()
        {

        }
    }
}
