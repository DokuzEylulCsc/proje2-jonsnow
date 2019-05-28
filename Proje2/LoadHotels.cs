using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class LoadHotels //Hazır otellerin oluşturulduğu kısım.
    {
        List<Room> listButik = new List<Room>(); //gereksiz
        List<Room> listHostel = new List<Room>(); //gereksiz
        List<Room> listHotel = new List<Room>(); //gereksiz eski çekim
        public List<Hotel> Hotels = new List<Hotel>(); // hotellerin listesi


        public LoadHotels()
        {
            getHotels();
        }

        public void getHotels() //dosyadan otelleri çeker
        {
            string stream_read = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "hotels.txt");
            Hotels = JsonConvert.DeserializeObject<List<Hotel>>(stream_read);
        }

        public void saveHotels() //otelin yeni halini kaydeder
        {
            var datas = JsonConvert.SerializeObject(Hotels);
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "hotels.txt", datas);
        }

        void fillHotels() //hazır bilgiler txt dosyasından okunmadan önce yazılmıştı.
        {

            Hotels.Add(new Boutique(listButik, "Adana Butik Otel", 2, "Adana"));
            Hotels.Add(new Hostel(listHostel, "Adana Hostel", 3, "Adana"));
            Hotels.Add(new Hotel(listHotel, "Adana Otel", 5, "Adana"));

            Hotels.Add(new Boutique(listButik, "Adıyaman Butik Otel", 2, "Adıyaman"));
            Hotels.Add(new Hostel(listHostel, "Adıyaman Hostel", 3, "Adıyaman"));
            Hotels.Add(new Hotel(listHotel, "Adıyaman Otel", 5, "Adıyaman"));

            Hotels.Add(new Boutique(listButik, "Afyon Butik Otel", 2, "Afyon"));
            Hotels.Add(new Hostel(listHostel, "Afyon Hostel", 4, "Afyon"));
            Hotels.Add(new Hotel(listHotel, "Afyon Otel", 5, "Afyon"));

            Hotels.Add(new Boutique(listButik, "Ağrı Butik Otel", 2, "Ağrı"));
            Hotels.Add(new Hostel(listHostel, "Ağrı Hostel", 3, "Ağrı"));
            Hotels.Add(new Hotel(listHotel, "Ağrı Otel", 5, "Ağrı"));

            Hotels.Add(new Boutique(listButik, "Amasya Butik Otel", 2, "Amasya"));
            Hotels.Add(new Hostel(listHostel, "Amasya Hostel", 4, "Amasya"));
            Hotels.Add(new Hotel(listHotel, "Amasya Otel", 5, "Amasya"));

            Hotels.Add(new Boutique(listButik, "Ankara Butik Otel", 2, "Ankara"));
            Hotels.Add(new Hostel(listHostel, "Ankara Hostel", 3, "Ankara"));
            Hotels.Add(new Hotel(listHotel, "Ankara Otel", 5, "Ankara"));

            Hotels.Add(new Boutique(listButik, "Antalya Butik Otel", 2, "Antalya"));
            Hotels.Add(new Hostel(listHostel, "Antalya Hostel", 3, "Antalya"));
            Hotels.Add(new Hotel(listHotel, "Antalya Otel", 5, "Antalya"));

            Hotels.Add(new Boutique(listButik, "Artvin Butik Otel", 2, "Artvin"));
            Hotels.Add(new Hostel(listHostel, "Artvin Hostel", 4, "Artvin"));
            Hotels.Add(new Hotel(listHotel, "Artvin Otel", 5, "Artvin"));

            Hotels.Add(new Boutique(listButik, "Aydın Butik Otel", 2, "Aydın"));
            Hotels.Add(new Hostel(listHostel, "Aydın Hostel", 3, "Aydın"));
            Hotels.Add(new Hotel(listHotel, "Aydın Otel", 5, "Aydın"));

            Hotels.Add(new Boutique(listButik, "Balıkesir Butik Otel", 2, "Balıkesir"));
            Hotels.Add(new Hostel(listHostel, "Balıkesir Hostel", 3, "Balıkesir"));
            Hotels.Add(new Hotel(listHotel, "Balıkesir Otel", 5, "Balıkesir"));

            Hotels.Add(new Boutique(listButik, "Bilecik Butik Otel", 2, "Bilecik"));
            Hotels.Add(new Hostel(listHostel, "Bilecik Hostel", 3, "Bilecik"));
            Hotels.Add(new Hotel(listHotel, "Bilecik Otel", 5, "Bilecik"));

            Hotels.Add(new Boutique(listButik, "Bingöl Butik Otel", 2, "Bingöl"));
            Hotels.Add(new Hostel(listHostel, "Bingöl Hostel", 4, "Bingöl"));
            Hotels.Add(new Hotel(listHotel, "Bingöl Otel", 5, "Bingöl"));

            Hotels.Add(new Boutique(listButik, "Bitlis Butik Otel", 2, "Bitlis"));
            Hotels.Add(new Hostel(listHostel, "Bitlis Hostel", 3, "Bitlis"));
            Hotels.Add(new Hotel(listHotel, "Bitlis Otel", 5, "Bitlis"));

            Hotels.Add(new Boutique(listButik, "Bolu Butik Otel", 2, "Bolu"));
            Hotels.Add(new Hostel(listHostel, "Bolu Hostel", 4, "Bolu"));
            Hotels.Add(new Hotel(listHotel, "Bolu Otel", 5, "Bolu"));

            Hotels.Add(new Boutique(listButik, "Burdur Butik Otel", 2, "Burdur"));
            Hotels.Add(new Hostel(listHostel, "Burdur Hostel", 3, "Burdur"));
            Hotels.Add(new Hotel(listHotel, "Burdur Otel", 5, "Burdur"));

            Hotels.Add(new Boutique(listButik, "Bursa Butik Otel", 2, "Bursa"));
            Hotels.Add(new Hostel(listHostel, "Bursa Hostel", 3, "Bursa"));
            Hotels.Add(new Hotel(listHotel, "Bursa Otel", 5, "Bursa"));

            Hotels.Add(new Boutique(listButik, "Çanakkale Butik Otel", 2, "Çanakkale"));
            Hotels.Add(new Hostel(listHostel, "Çanakkale Hostel", 3, "Çanakkale"));
            Hotels.Add(new Hotel(listHotel, "Çanakkale Otel", 5, "Çanakkale"));

            Hotels.Add(new Boutique(listButik, "Çankırı Butik Otel", 2, "Çankırı"));
            Hotels.Add(new Hostel(listHostel, "Çankırı Hostel", 4, "Çankırı"));
            Hotels.Add(new Hotel(listHotel, "Çankırı Otel", 5, "Çankırı"));

            Hotels.Add(new Boutique(listButik, "Çorum Butik Otel", 2, "Çorum"));
            Hotels.Add(new Hostel(listHostel, "Çorum Hostel", 3, "Çorum"));
            Hotels.Add(new Hotel(listHotel, "Çorum Otel", 5, "Çorum"));

            Hotels.Add(new Boutique(listButik, "Denizli Butik Otel", 2, "Denizli"));
            Hotels.Add(new Hostel(listHostel, "Denizli Hostel", 3, "Denizli"));
            Hotels.Add(new Hotel(listHotel, "Denizli Otel", 5, "Denizli"));

            Hotels.Add(new Boutique(listButik, "Diyarbakır Butik Otel", 2, "Diyarbakır"));
            Hotels.Add(new Hostel(listHostel, "Diyarbakır Hostel", 4, "Diyarbakır"));
            Hotels.Add(new Hotel(listHotel, "Diyarbakır Otel", 5, "Diyarbakır"));

            Hotels.Add(new Boutique(listButik, "Edirne Butik Otel", 2, "Edirne"));
            Hotels.Add(new Hostel(listHostel, "Edirne Hostel", 3, "Edirne"));
            Hotels.Add(new Hotel(listHotel, "Edirne Otel", 5, "Edirne"));

            Hotels.Add(new Boutique(listButik, "Elazığ Butik Otel", 2, "Elazığ"));
            Hotels.Add(new Hostel(listHostel, "Elazığ Hostel", 4, "Elazığ"));
            Hotels.Add(new Hotel(listHotel, "Elazığ Otel", 5, "Elazığ"));

            Hotels.Add(new Boutique(listButik, "Erzincan Butik Otel", 2, "Erzincan"));
            Hotels.Add(new Hostel(listHostel, "Erzincan Hostel", 3, "Erzincan"));
            Hotels.Add(new Hotel(listHotel, "Erzincan Otel", 5, "Erzincan"));

            Hotels.Add(new Boutique(listButik, "Erzurum Butik Otel", 2, "Erzurum"));
            Hotels.Add(new Hostel(listHostel, "Erzurum Hostel", 4, "Erzurum"));
            Hotels.Add(new Hotel(listHotel, "Erzurum Otel", 5, "Erzurum"));

            Hotels.Add(new Boutique(listButik, "Eskişehir Butik Otel", 2, "Eskişehir"));
            Hotels.Add(new Hostel(listHostel, "Eskişehir Hostel", 4, "Eskişehir"));
            Hotels.Add(new Hotel(listHotel, "Eskişehir Otel", 5, "Eskişehir"));

            Hotels.Add(new Boutique(listButik, "Gaziantep Butik Otel", 2, "Gaziantep"));
            Hotels.Add(new Hostel(listHostel, "Gaziantep Hostel", 3, "Gaziantep"));
            Hotels.Add(new Hotel(listHotel, "Gaziantep Otel", 5, "Gaziantep"));

            Hotels.Add(new Boutique(listButik, "Giresun Butik Otel", 2, "Giresun"));
            Hotels.Add(new Hostel(listHostel, "Giresun Hostel", 4, "Giresun"));
            Hotels.Add(new Hotel(listHotel, "Giresun Otel", 5, "Giresun"));

            Hotels.Add(new Boutique(listButik, "Gümüşhane Butik Otel", 2, "Gümüşhane"));
            Hotels.Add(new Hostel(listHostel, "Gümüşhane Hostel", 3, "Gümüşhane"));
            Hotels.Add(new Hotel(listHotel, "Gümüşhane Otel", 5, "Gümüşhane"));

            Hotels.Add(new Boutique(listButik, "Hakkari Butik Otel", 1, "Hakkari"));
            Hotels.Add(new Hostel(listHostel, "Hakkari Hostel", 2, "Hakkari"));
            Hotels.Add(new Hotel(listHotel, "Hakkari Otel", 3, "Hakkari"));

            Hotels.Add(new Boutique(listButik, "Hatay Butik Otel", 2, "Hatay"));
            Hotels.Add(new Hostel(listHostel, "Hatay Hostel", 3, "Hatay"));
            Hotels.Add(new Hotel(listHotel, "Hatay Otel", 5, "Hatay"));

            Hotels.Add(new Boutique(listButik, "Isparta Butik Otel", 2, "Isparta"));
            Hotels.Add(new Hostel(listHostel, "Isparta Hostel", 4, "Isparta"));
            Hotels.Add(new Hotel(listHotel, "Isparta Otel", 5, "Isparta"));

            Hotels.Add(new Boutique(listButik, "Mersin Butik Otel", 2, "Mersin"));
            Hotels.Add(new Hostel(listHostel, "Mersin Hostel", 3, "Mersin"));
            Hotels.Add(new Hotel(listHotel, "Mersin Otel", 5, "Mersin"));

            Hotels.Add(new Boutique(listButik, "İstanbul Butik Otel", 2, "İstanbul"));
            Hotels.Add(new Hostel(listHostel, "İstanbul Hostel", 4, "İstanbul"));
            Hotels.Add(new Hotel(listHotel, "İstanbul Otel", 5, "İstanbul"));

            Hotels.Add(new Boutique(listButik, "İzmir Butik Otel", 2, "İzmir"));
            Hotels.Add(new Hostel(listHostel, "İzmir Hostel", 3, "İzmir"));
            Hotels.Add(new Hotel(listHotel, "İzmir Otel", 5, "İzmir"));

            Hotels.Add(new Boutique(listButik, "Kars Butik Otel", 2, "Kars"));
            Hotels.Add(new Hostel(listHostel, "Kars Hostel", 4, "Kars"));
            Hotels.Add(new Hotel(listHotel, "Kars Otel", 5, "Kars"));

            Hotels.Add(new Boutique(listButik, "Kastamonu Butik Otel", 2, "Kastamonu"));
            Hotels.Add(new Hostel(listHostel, "Kastamonu Hostel", 3, "Kastamonu"));
            Hotels.Add(new Hotel(listHotel, "Kastamonu Otel", 5, "Kastamonu"));

            Hotels.Add(new Boutique(listButik, "Kayseri Butik Otel", 2, "Kayseri"));
            Hotels.Add(new Hostel(listHostel, "Kayseri Hostel", 3, "Kayseri"));
            Hotels.Add(new Hotel(listHotel, "Kayseri Otel", 5, "Kayseri"));

            Hotels.Add(new Boutique(listButik, "Kırklareli Butik Otel", 2, "Kırklareli"));
            Hotels.Add(new Hostel(listHostel, "Kırklareli Hostel", 3, "Kırklareli"));
            Hotels.Add(new Hotel(listHotel, "Kırklareli Otel", 5, "Kırklareli"));

            Hotels.Add(new Boutique(listButik, "Kırşehir Butik Otel", 1, "Kırşehir"));
            Hotels.Add(new Hostel(listHostel, "Kırşehir Hostel", 3, "Kırşehir"));
            Hotels.Add(new Hotel(listHotel, "Kırşehir Otel", 5, "Kırşehir"));

            Hotels.Add(new Boutique(listButik, "Kocaeli Butik Otel", 2, "Kocaeli"));
            Hotels.Add(new Hostel(listHostel, "Kocaeli Hostel", 3, "Kocaeli"));
            Hotels.Add(new Hotel(listHotel, "Kocaeli Otel", 5, "Kocaeli"));

            Hotels.Add(new Boutique(listButik, "Konya Butik Otel", 2, "Konya"));
            Hotels.Add(new Hostel(listHostel, "Konya Hostel", 3, "Konya"));
            Hotels.Add(new Hotel(listHotel, "Konya Otel", 5, "Konya"));

            Hotels.Add(new Boutique(listButik, "Kütahya Butik Otel", 2, "Kütahya"));
            Hotels.Add(new Hostel(listHostel, "Kütahya Hostel", 4, "Kütahya"));
            Hotels.Add(new Hotel(listHotel, "Kütahya Otel", 5, "Kütahya"));

            Hotels.Add(new Boutique(listButik, "Malatya Butik Otel", 1, "Malatya"));
            Hotels.Add(new Hostel(listHostel, "Malatya Hostel", 4, "Malatya"));
            Hotels.Add(new Hotel(listHotel, "Malatya Otel", 5, "Malatya"));

            Hotels.Add(new Boutique(listButik, "Manisa Butik Otel", 2, "Manisa"));
            Hotels.Add(new Hostel(listHostel, "Manisa Hostel", 3, "Manisa"));
            Hotels.Add(new Hotel(listHotel, "Manisa Otel", 5, "Manisa"));

            Hotels.Add(new Boutique(listButik, "K.maraş Butik Otel", 2, "K.maraş"));
            Hotels.Add(new Hostel(listHostel, "K.maraş Hostel", 3, "K.maraş"));
            Hotels.Add(new Hotel(listHotel, "K.maraş Otel", 5, "K.maraş"));

            Hotels.Add(new Boutique(listButik, "Mardin Butik Otel", 1, "Mardin"));
            Hotels.Add(new Hostel(listHostel, "Mardin Hostel", 4, "Mardin"));
            Hotels.Add(new Hotel(listHotel, "Mardin Otel", 5, "Mardin"));

            Hotels.Add(new Boutique(listButik, "Muğla Butik Otel", 2, "Muğla"));
            Hotels.Add(new Hostel(listHostel, "Muğla Hostel", 3, "Muğla"));
            Hotels.Add(new Hotel(listHotel, "Muğla Otel", 5, "Muğla"));

            Hotels.Add(new Boutique(listButik, "Muş Butik Otel", 2, "Muş"));
            Hotels.Add(new Hostel(listHostel, "Muş Hostel", 3, "Muş"));
            Hotels.Add(new Hotel(listHotel, "Muş Otel", 5, "Muş"));

            Hotels.Add(new Boutique(listButik, "Nevşehir Butik Otel", 1, "Nevşehir"));
            Hotels.Add(new Hostel(listHostel, "Nevşehir Hostel", 3, "Nevşehir"));
            Hotels.Add(new Hotel(listHotel, "Nevşehir Otel", 5, "Nevşehir"));

            Hotels.Add(new Boutique(listButik, "Niğde Butik Otel", 2, "Niğde"));
            Hotels.Add(new Hostel(listHostel, "Niğde Hostel", 4, "Niğde"));
            Hotels.Add(new Hotel(listHotel, "Niğde Otel", 5, "Niğde"));

            Hotels.Add(new Boutique(listButik, "Ordu Butik Otel", 2, "Ordu"));
            Hotels.Add(new Hostel(listHostel, "Ordu Hostel", 3, "Ordu"));
            Hotels.Add(new Hotel(listHotel, "Ordu Otel", 5, "Ordu"));

            Hotels.Add(new Boutique(listButik, "Rize Butik Otel", 1, "Rize"));
            Hotels.Add(new Hostel(listHostel, "Rize Hostel", 3, "Rize"));
            Hotels.Add(new Hotel(listHotel, "Rize Otel", 5, "Rize"));

            Hotels.Add(new Boutique(listButik, "Sakarya Butik Otel", 2, "Sakarya"));
            Hotels.Add(new Hostel(listHostel, "Sakarya Hostel", 3, "Sakarya"));
            Hotels.Add(new Hotel(listHotel, "Sakarya Otel", 5, "Sakarya"));

            Hotels.Add(new Boutique(listButik, "Samsun Butik Otel", 2, "Samsun"));
            Hotels.Add(new Hostel(listHostel, "Samsun Hostel", 4, "Samsun"));
            Hotels.Add(new Hotel(listHotel, "Samsun Otel", 5, "Samsun"));

            Hotels.Add(new Boutique(listButik, "Siirt Butik Otel", 2, "Siirt"));
            Hotels.Add(new Hostel(listHostel, "Siirt Hostel", 3, "Siirt"));
            Hotels.Add(new Hotel(listHotel, "Siirt Otel", 5, "Siirt"));

            Hotels.Add(new Boutique(listButik, "Sinop Butik Otel", 2, "Sinop"));
            Hotels.Add(new Hostel(listHostel, "Sinop Hostel", 4, "Sinop"));
            Hotels.Add(new Hotel(listHotel, "Sinop Otel", 5, "Sinop"));

            Hotels.Add(new Boutique(listButik, "Sivas Butik Otel", 2, "Sivas"));
            Hotels.Add(new Hostel(listHostel, "Sivas Hostel", 3, "Sivas"));
            Hotels.Add(new Hotel(listHotel, "Sivas Otel", 5, "Sivas"));

            Hotels.Add(new Boutique(listButik, "Tekirdağ Butik Otel", 2, "Tekirdağ"));
            Hotels.Add(new Hostel(listHostel, "Tekirdağ Hostel", 4, "Tekirdağ"));
            Hotels.Add(new Hotel(listHotel, "Tekirdağ Otel", 5, "Tekirdağ"));

            Hotels.Add(new Boutique(listButik, "Tokat Butik Otel", 2, "Tokat"));
            Hotels.Add(new Hostel(listHostel, "Tokat Hostel", 3, "Tokat"));
            Hotels.Add(new Hotel(listHotel, "Tokat Otel", 5, "Tokat"));

            Hotels.Add(new Boutique(listButik, "Trabzon Butik Otel", 1, "Trabzon"));
            Hotels.Add(new Hostel(listHostel, "Trabzon Hostel", 3, "Trabzon"));
            Hotels.Add(new Hotel(listHotel, "Trabzon Otel", 5, "Trabzon"));

            Hotels.Add(new Boutique(listButik, "Tunceli Butik Otel", 2, "Tunceli"));
            Hotels.Add(new Hostel(listHostel, "Tunceli Hostel", 4, "Tunceli"));
            Hotels.Add(new Hotel(listHotel, "Tunceli Otel", 5, "Tunceli"));

            Hotels.Add(new Boutique(listButik, "Şanlıurfa Butik Otel", 2, "Şanlıurfa"));
            Hotels.Add(new Hostel(listHostel, "Şanlıurfa Hostel", 3, "Şanlıurfa"));
            Hotels.Add(new Hotel(listHotel, "Şanlıurfa Otel", 5, "Şanlıurfa"));

            Hotels.Add(new Boutique(listButik, "Uşak Butik Otel", 2, "Uşak"));
            Hotels.Add(new Hostel(listHostel, "Uşak Hostel", 4, "Uşak"));
            Hotels.Add(new Hotel(listHotel, "Uşak Otel", 5, "Uşak"));

            Hotels.Add(new Boutique(listButik, "Van Butik Otel", 2, "Van"));
            Hotels.Add(new Hostel(listHostel, "Van Hostel", 3, "Van"));
            Hotels.Add(new Hotel(listHotel, "Van Otel", 5, "Van"));

            Hotels.Add(new Boutique(listButik, "Yozgat Butik Otel", 2, "Yozgat"));
            Hotels.Add(new Hostel(listHostel, "Yozgat Hostel", 3, "Yozgat"));
            Hotels.Add(new Hotel(listHotel, "Yozgat Otel", 5, "Yozgat"));

            Hotels.Add(new Boutique(listButik, "Zonguldak Butik Otel", 2, "Zonguldak"));
            Hotels.Add(new Hostel(listHostel, "Zonguldak Hostel", 3, "Zonguldak"));
            Hotels.Add(new Hotel(listHotel, "Zonguldak Otel", 5, "Zonguldak"));

            Hotels.Add(new Boutique(listButik, "Aksaray Butik Otel", 2, "Aksaray"));
            Hotels.Add(new Hostel(listHostel, "Aksaray Hostel", 3, "Aksaray"));
            Hotels.Add(new Hotel(listHotel, "Aksaray Otel", 5, "Aksaray"));

            Hotels.Add(new Boutique(listButik, "Bayburt Butik Otel", 1, "Bayburt"));
            Hotels.Add(new Hostel(listHostel, "Bayburt Hostel", 4, "Bayburt"));
            Hotels.Add(new Hotel(listHotel, "Bayburt Otel", 5, "Bayburt"));

            Hotels.Add(new Boutique(listButik, "Karaman Butik Otel", 1, "Karaman"));
            Hotels.Add(new Hostel(listHostel, "Karaman Hostel", 3, "Karaman"));
            Hotels.Add(new Hotel(listHotel, "Karaman Otel", 5, "Karaman"));

            Hotels.Add(new Boutique(listButik, "Kırıkkale Butik Otel", 2, "Kırıkkale"));
            Hotels.Add(new Hostel(listHostel, "Kırıkkale Hostel", 3, "Kırıkkale"));
            Hotels.Add(new Hotel(listHotel, "Kırıkkale Otel", 5, "Kırıkkale"));

            Hotels.Add(new Boutique(listButik, "Batman Butik Otel", 2, "Batman"));
            Hotels.Add(new Hostel(listHostel, "Batman Hostel", 3, "Batman"));
            Hotels.Add(new Hotel(listHotel, "Batman Otel", 5, "Batman"));

            Hotels.Add(new Boutique(listButik, "Şırnak Butik Otel", 2, "Şırnak"));
            Hotels.Add(new Hostel(listHostel, "Şırnak Hostel", 3, "Şırnak"));
            Hotels.Add(new Hotel(listHotel, "Şırnak Otel", 5, "Şırnak"));

            Hotels.Add(new Boutique(listButik, "Bartın Butik Otel", 1, "Bartın"));
            Hotels.Add(new Hostel(listHostel, "Bartın Hostel", 3, "Bartın"));
            Hotels.Add(new Hotel(listHotel, "Bartın Otel", 5, "Bartın"));

            Hotels.Add(new Boutique(listButik, "Ardahan Butik Otel", 2, "Ardahan"));
            Hotels.Add(new Hostel(listHostel, "Ardahan Hostel", 4, "Ardahan"));
            Hotels.Add(new Hotel(listHotel, "Ardahan Otel", 5, "Ardahan"));

            Hotels.Add(new Boutique(listButik, "Iğdır Butik Otel", 2, "Iğdır"));
            Hotels.Add(new Hostel(listHostel, "Iğdır Hostel", 3, "Iğdır"));
            Hotels.Add(new Hotel(listHotel, "Iğdır Otel", 5, "Iğdır"));

            Hotels.Add(new Boutique(listButik, "Yalova Butik Otel", 2, "Yalova"));
            Hotels.Add(new Hostel(listHostel, "Yalova Hostel", 3, "Yalova"));
            Hotels.Add(new Hotel(listHotel, "Yalova Otel", 5, "Yalova"));

            Hotels.Add(new Boutique(listButik, "Karabük Butik Otel", 2, "Karabük"));
            Hotels.Add(new Hostel(listHostel, "Karabük Hostel", 3, "Karabük"));
            Hotels.Add(new Hotel(listHotel, "Karabük Otel", 5, "Karabük"));

            Hotels.Add(new Boutique(listButik, "Kilis Butik Otel", 1, "Kilis"));
            Hotels.Add(new Hostel(listHostel, "Kilis Hostel", 4, "Kilis"));
            Hotels.Add(new Hotel(listHotel, "Kilis Otel", 5, "Kilis"));

            Hotels.Add(new Boutique(listButik, "Osmaniye Butik Otel", 2, "Osmaniye"));
            Hotels.Add(new Hostel(listHostel, "Osmaniye Hostel", 3, "Osmaniye"));
            Hotels.Add(new Hotel(listHotel, "Osmaniye Otel", 5, "Osmaniye"));

            Hotels.Add(new Boutique(listButik, "Düzce Butik Otel", 2, "Düzce"));
            Hotels.Add(new Hostel(listHostel, "Düzce Hostel", 3, "Düzce"));
            Hotels.Add(new Hotel(listHotel, "Düzce Otel", 5, "Düzce"));

        }

        void filllistButik()
        {
            listButik.Add(new SingleRoom(0, 1, false, false, false, 50));
            listButik.Add(new SingleRoom(0, 2, false, false, false, 70));
            listButik.Add(new SingleRoom(0, 3, false, true, false, 85));
            listButik.Add(new SingleRoom(0, 4, false, false, false, 95));
            listButik.Add(new DoubleRoom(1, 5, false, true, false, 110));
            listButik.Add(new DoubleRoom(1, 6, false, false, false, 50));
            listButik.Add(new DoubleRoom(1, 7, false, true, false, 32));
            listButik.Add(new DoubleRoom(1, 8, false, false, false, 45));
            listButik.Add(new DoubleRoom(2, 9, false, false, false, 50));
            listButik.Add(new DoubleRoom(2, 10, false, true, false, 150));
            listButik.Add(new DoubleRoom(2, 11, false, false, false, 38));
            listButik.Add(new DoubleRoom(2, 12, false, false, false, 50));
        }

        void filllistHostel()
        {
            listHostel.Add(new SingleRoom(0, 1, false, false, true, 200));
            listHostel.Add(new SingleRoom(0, 2, false, false, false, 110));
            listHostel.Add(new SingleRoom(0, 3, false, true, true, 105));
            listHostel.Add(new SingleRoom(0, 4, false, false, false, 120));
            listHostel.Add(new SingleRoom(1, 5, false, true, true, 110));
            listHostel.Add(new DoubleRoom(1, 6, false, false, false, 110));
            listHostel.Add(new DoubleRoom(1, 7, false, false, true, 100));
            listHostel.Add(new DoubleRoom(1, 8, false, true, false, 120));
            listHostel.Add(new DoubleRoom(2, 9, false, false, false, 50));
            listHostel.Add(new DoubleRoom(2, 10, false, false, true, 290));
            listHostel.Add(new DoubleRoom(2, 11, false, true, false, 170));
            listHostel.Add(new DoubleRoom(2, 12, false, false, false, 120));
            listHostel.Add(new DoubleRoom(3, 13, false, true, false, 150));
            listHostel.Add(new DoubleRoom(3, 14, false, false, false, 105));
            listHostel.Add(new DoubleRoom(3, 15, false, true, true, 195));
            listHostel.Add(new DoubleRoom(3, 16, false, false, false, 125));
            listHostel.Add(new TripleRoom(4, 17, false, true, true, 110));
            listHostel.Add(new TripleRoom(4, 18, false, false, false, 250));
            listHostel.Add(new TripleRoom(4, 19, false, true, true, 185));
            listHostel.Add(new TripleRoom(4, 20, false, false, false, 182));
            listHostel.Add(new TripleRoom(5, 21, false, false, false, 125));
            listHostel.Add(new TripleRoom(5, 22, false, true, true, 150));
            listHostel.Add(new TripleRoom(5, 23, false, true, false, 120));
            listHostel.Add(new TripleRoom(5, 24, false, false, false, 110));
        }

        void fillListHotel()
        {
            listHotel.Add(new SingleRoom(0, 1, false, true, true, 350));
            listHotel.Add(new SingleRoom(0, 2, false, false, false, 380));
            listHotel.Add(new SingleRoom(0, 3, false, true, true, 500));
            listHotel.Add(new SingleRoom(0, 4, false, true, false, 320));
            listHotel.Add(new SingleRoom(1, 5, false, true, true, 403));
            listHotel.Add(new DoubleRoom(1, 6, false, false, true, 320));
            listHotel.Add(new DoubleRoom(1, 7, false, false, true, 100));
            listHotel.Add(new DoubleRoom(1, 8, false, true, false, 320));
            listHotel.Add(new DoubleRoom(2, 9, false, true, false, 50));
            listHotel.Add(new DoubleRoom(2, 10, false, false, true, 290));
            listHotel.Add(new DoubleRoom(2, 11, false, true, true, 170));
            listHotel.Add(new DoubleRoom(2, 12, false, true, false, 315));
            listHotel.Add(new DoubleRoom(3, 13, false, true, false, 320));
            listHotel.Add(new DoubleRoom(3, 14, false, false, true, 105));
            listHotel.Add(new DoubleRoom(3, 15, false, true, true, 415));
            listHotel.Add(new DoubleRoom(3, 16, false, true, false, 125));
            listHotel.Add(new TripleRoom(4, 17, false, true, true, 320));
            listHotel.Add(new TripleRoom(4, 18, false, true, true, 425));
            listHotel.Add(new TripleRoom(4, 19, false, true, true, 505));
            listHotel.Add(new TripleRoom(4, 20, false, false, true, 182));
            listHotel.Add(new TripleRoom(5, 21, false, true, true, 320));
            listHotel.Add(new TripleRoom(5, 22, false, true, true, 150));
            listHotel.Add(new TripleRoom(5, 23, false, true, false, 320));
            listHotel.Add(new TripleRoom(5, 24, false, false, false, 550));
            listHotel.Add(new SingleRoom(6, 25, false, false, true, 200));
            listHotel.Add(new SingleRoom(6, 26, false, true, false, 605));
            listHotel.Add(new SingleRoom(6, 27, false, true, true, 475));
            listHotel.Add(new SingleRoom(6, 28, false, false, true, 120));
            listHotel.Add(new SingleRoom(6, 29, false, true, true, 320));
            listHotel.Add(new DoubleRoom(7, 30, false, true, false, 750));
            listHotel.Add(new DoubleRoom(7, 31, false, true, true, 320));
            listHotel.Add(new DoubleRoom(7, 32, false, true, false, 320));
            listHotel.Add(new DoubleRoom(7, 33, false, true, false, 450));
            listHotel.Add(new DoubleRoom(7, 34, false, true, true, 290));
            listHotel.Add(new DoubleRoom(8, 35, false, true, false, 320));
            listHotel.Add(new DoubleRoom(8, 36, false, false, true, 225));
            listHotel.Add(new DoubleRoom(8, 37, false, true, false, 320));
            listHotel.Add(new DoubleRoom(8, 38, false, true, false, 105));
            listHotel.Add(new DoubleRoom(8, 39, false, true, true, 225));
            listHotel.Add(new DoubleRoom(8, 40, false, true, true, 125));
            listHotel.Add(new TripleRoom(9, 41, false, true, true, 320));
            listHotel.Add(new TripleRoom(9, 42, false, false, false, 250));
            listHotel.Add(new TripleRoom(9, 43, false, true, true, 185));
            listHotel.Add(new TripleRoom(9, 44, false, false, true, 182));
            listHotel.Add(new TripleRoom(10, 45, false, true, false, 850));
            listHotel.Add(new TripleRoom(10, 46, false, true, true, 355));
            listHotel.Add(new TripleRoom(10, 47, false, true, false, 500));
            listHotel.Add(new TripleRoom(10, 48, false, false, true, 110));
            listHotel.Add(new SingleRoom(10, 49, false, false, true, 200));
            listHotel.Add(new SingleRoom(11, 50, false, true, true, 110));
            listHotel.Add(new SingleRoom(11, 51, false, true, true, 950));
            listHotel.Add(new SingleRoom(11, 52, false, false, false, 225));
            listHotel.Add(new SingleRoom(12, 53, false, true, true, 372));
            listHotel.Add(new DoubleRoom(12, 54, false, true, false, 315));
            listHotel.Add(new DoubleRoom(12, 55, false, false, true, 290));
            listHotel.Add(new DoubleRoom(12, 56, false, true, false, 120));
            listHotel.Add(new DoubleRoom(13, 57, false, false, true, 415));
            listHotel.Add(new DoubleRoom(13, 58, false, false, true, 290));
            listHotel.Add(new DoubleRoom(13, 59, false, true, false, 385));
            listHotel.Add(new DoubleRoom(13, 60, false, true, false, 120));
            listHotel.Add(new DoubleRoom(14, 61, false, true, false, 150));
            listHotel.Add(new DoubleRoom(14, 62, false, true, true, 395));
            listHotel.Add(new DoubleRoom(14, 63, false, true, true, 299));
            listHotel.Add(new DoubleRoom(14, 64, false, false, true, 125));
            listHotel.Add(new TripleRoom(15, 65, false, true, true, 110));
            listHotel.Add(new TripleRoom(15, 66, false, true, false, 250));
            listHotel.Add(new TripleRoom(15, 67, false, true, true, 285));
            listHotel.Add(new TripleRoom(15, 68, false, true, true, 382));
            listHotel.Add(new TripleRoom(16, 69, false, false, true, 125));
            listHotel.Add(new TripleRoom(16, 70, false, true, true, 225));
            listHotel.Add(new TripleRoom(16, 71, false, true, true, 385));
            listHotel.Add(new TripleRoom(16, 72, false, true, false, 850));
        }
    }
}
