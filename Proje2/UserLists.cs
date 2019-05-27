using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class UserLists //üyelerin tutulduğu liste
    {
        List<User> list = new List<User>();
        User currentUser = null;

        public bool loadCurrentUser(string username)
        {
            if (list.Count == 0)
                return false;

            foreach (User i in list)
            {
                if (i.Username == username)
                {
                    currentUser = i;
                    return true;
                }
                else
                    return false;
            }

            return false;
        }

        public void addUsers(string username)
        {
            list.Add(new User(username));
        }
        public void loadTxt()
        {

        }

        public void saveTxt()
        {

        }
        public void loginAdmin()
        {

        }

    }

}
