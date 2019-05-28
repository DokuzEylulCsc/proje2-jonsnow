using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class UserLists //üyelerin tutulduğu liste
    {
        List<User> list = new List<User>(); //kullanıcıların tutulduğu liste
        CurrentUser currentUser = null; // geçerli kullanıcı


        public CurrentUser getCurrent() //geçerli kullanıcıyı verir
        {
            return currentUser;
        }

        public void firstUser(string username) //eğer kullanıcı yoksa daha önce hata vermemesi için yapıldı.
        {
            currentUser = new CurrentUser(list[0].Username, 0);
        }

        public void updateUserList(string name, string surname, string phone, int index) //kullanıcı bilgilerini güncelleyen fonksiyon
        {
            User temp = list[index];
            temp.Name = name;
            temp.Surname = surname;
            temp.PhoneNumber = phone;

            list[index] = temp;
        }

        public bool loadCurrentUser(string username) //geçerli kullanıcıyı username ile bulup currentuser a atayan fonksiyon.
        {
            int index = 0;                           //aynı zamanda kullanıcının rezervasyonları kontrol edip eski yada yeni olduğuna bakar.


            if (list.Count == 0) //yoksa false
                return false;

            foreach (User i in list)
            {
                if (i.Username == username) //bulduysa atar
                {
                    currentUser = new CurrentUser(i.Username, index);
                    currentUser.Name = i.Name;
                    currentUser.Surname = i.Surname;
                    currentUser.PhoneNumber = i.PhoneNumber;

                    foreach (Reservation a in i.ReservationList) //listeleri ayrıştırır
                    {
                        if ((a.EndDate - DateTime.Now).TotalHours > 0)
                            currentUser.ReservationList.Add(a);
                        else
                            currentUser.HistoryReserve.Add(a);
                    }

                    return true;
                }

                index++; //lazım olur diye eklenmişti
            }

            return false;
        }

        public bool addUsers(string username) //yeni kullanıcı ekleme
        {
            bool possible = true;

            if (list.Count == 0) //bosşa direk ekler
            {
                list.Add(new User(username));
                return true;
            }

            foreach (User i in list) //daha önce var mı diye bakar
            {
                if (i.Username == username)
                {
                    possible = false;
                }
            }

            if (possible)
                list.Add(new User(username));


            return possible;
        }

        public void loadTxt() //datas txt ten kullanıcıların tüm bilgilerini okuyup deserialize edip listeye atayan fonksiyon.
        {
            string stream_read = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "datas.txt");

            if (stream_read.Length > 10)
                list = JsonConvert.DeserializeObject<List<User>>(stream_read); //newtonsoft.json kullanılmıştır.



        }

        public void saveTxt() // uygulama kapanırken yada istendiği zaman bilgileri serialize edip txt ye kaydeder.
        {
            var datas = JsonConvert.SerializeObject(list);
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "datas.txt", datas);
        }

        public void loginAdmin() //admin olarak giriş fonksiyonu
        {       
            list.Clear();
            var datas = JsonConvert.SerializeObject(list);
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "admin.txt", datas);
        }

    }
}
