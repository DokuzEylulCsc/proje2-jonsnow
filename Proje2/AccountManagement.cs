using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    public class AccountManagement //giriş yönetimi
    {
        UserLists list = new UserLists();
        internal CurrentUser currentUser = null;

        public AccountManagement(bool isAdmin)
        {
            loginAdmin();
        }

        public AccountManagement()
        {

        }

        public void firstUser(string username)
            //İlk kullanıcı
        {
            list.firstUser(username);
            currentUser = list.getCurrent();
        }

        public void updateUserList(string name, string surname, string phone, int index)
            //Anlık kullanıcıyı kaybetmemek için 
        {
            list.updateUserList(name, surname, phone, index);
        }

        public bool loginUser(string username)
        {
            bool temp = list.loadCurrentUser(username);
            if (temp != false)
            {
                currentUser = list.getCurrent();
            }

            return temp;
        }

        public bool Register(string username)
            //Girilen username'i userlist e kayıt ediyoruz.
        {
            bool temp = list.addUsers(username);
            if (temp != false)
            {
                list.loadCurrentUser(username);
                currentUser = list.getCurrent();
            }

            return temp;
        }

        public void loadTxt()
            //Önceden kayıtlı kullanıcıları tutuyoruz..
        {
            list.loadTxt();
        }

        public void saveTxt()
            //Kullanıcıyı database kayıt ediyoruz.
        {
            
            list.saveTxt();
        }

        void loginAdmin()
            //Admin girişi
        {
            list.loginAdmin();
        }
    }
}
