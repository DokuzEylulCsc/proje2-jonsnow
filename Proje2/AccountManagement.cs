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
        public void firstUser()
        {

        }
        public void updateUserList()
        {

        }
        public bool Register()
        {
            return false;
        }
        public void loadTxt()
        {
        
        }
        public void saveTxt()
        {
         
        }

    }
}
