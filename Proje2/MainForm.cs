using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2
{
    public partial class MainForm : Form
    {
        private readonly Form1 form1;
        private readonly AccountManagement manage;
        private CurrentUser user = null;
        LoadHotels hotels = new LoadHotels();
        List<Room> hotelRoom;
        Log log = new Log(); //log nesnesi

        public MainForm(Form1 Form1, AccountManagement Manage) //https://stackoverflow.com/questions/7517232/how-to-access-one-object-from-another-form-in-c
        {
            InitializeComponent();
            form1 = Form1;
            manage = Manage;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBoxName.Text = null;
            textBoxSurname.Text = null;
            textBoxPhone.Text = null;
            hotels.saveHotels();
            listReserve.Items.Clear();
            form1.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            user = manage.currentUser;
            WindowState = FormWindowState.Maximized;

            if(user != null)
            {
                labelUsername.Text = user.Username;
                textBoxName.Text = user.Name;
                textBoxSurname.Text = user.Surname;
                textBoxPhone.Text = user.PhoneNumber;

                updateReserveList();
            }
            

            

            foreach(Hotel i in hotels.Hotels)
            {
                listHotel.Items.Add(i.HotelName);
            }
            
        }

        private void listHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelHotelFullness.Text = "%" + hotels.Hotels[listHotel.SelectedIndex].Fullness.ToString();
            labelHotelStar.Text = hotels.Hotels[listHotel.SelectedIndex].Star.ToString();
            panelHotelInfo.Visible = true;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if(user == null)
            {
                manage.firstUser(form1.username);
                user = manage.currentUser;
            }

            user.Name = textBoxName.Text;
            user.Surname = textBoxSurname.Text;
            user.PhoneNumber = textBoxPhone.Text;

            manage.updateUserList(textBoxName.Text, textBoxSurname.Text, textBoxPhone.Text, user.Index);
        }

        private void buttonGoHotel_Click(object sender, EventArgs e)
        {
            if(listHotel.SelectedIndex != -1)
            {
                hotelRoom = hotels.Hotels[listHotel.SelectedIndex].RoomList;

                foreach(Room i in hotelRoom)
                {
                    listRooms.Items.Add(i.No);
                }

                goBack.Visible = true;
                listHotel.Visible = false;
                listRooms.Visible = true;
                buttonGoHotel.Visible = false;
                labelText.Text = listHotel.Text;
            }
            else
            {
                MessageBox.Show("Otel seçin.");
            }

        }

        private void listRooms_SelectedIndexChanged(object sender, EventArgs e)
        {

            panelReserve.Visible = true;

            labelNo.Text = hotelRoom[listRooms.SelectedIndex].No.ToString();
            labelPrice.Text = hotelRoom[listRooms.SelectedIndex].Price.ToString();
            labelFloor.Text = hotelRoom[listRooms.SelectedIndex].Floor.ToString();
            if (hotelRoom[listRooms.SelectedIndex].IsHaveJacuzzi == true)
                labelJakuzi.Text = "Evet";
            else
                labelJakuzi.Text = "Hayır";
        }

        private void panelUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void goBack_Click(object sender, EventArgs e)
        {
            listHotel.Visible = true;
            listRooms.Visible = false;
            panelReserve.Visible = false;
            goBack.Visible = false;
            buttonGoHotel.Visible = true;
            labelText.Text = "Oteller";
            listRooms.Items.Clear();
        }

        private void buttonMakeReserve_Click(object sender, EventArgs e)
        {
            Room room;
            DateTime dateStart;
            DateTime dateEnd;
            

            if (radioButton1.Enabled == true) //radiobuttona göre oda tiplerinin doldurulması
                room = new SingleRoom(hotelRoom[listRooms.SelectedIndex].Floor
                    ,hotelRoom[listRooms.SelectedIndex].No, hotelRoom[listRooms.SelectedIndex].IsFull
                    ,hotelRoom[listRooms.SelectedIndex].IsHaveJacuzzi, false
                    ,hotelRoom[listRooms.SelectedIndex].Price
                    );
            else if(radioButton2.Enabled == true)
                room = new DoubleRoom(hotelRoom[listRooms.SelectedIndex].Floor
                    , hotelRoom[listRooms.SelectedIndex].No, hotelRoom[listRooms.SelectedIndex].IsFull
                    , hotelRoom[listRooms.SelectedIndex].IsHaveJacuzzi, false
                    , hotelRoom[listRooms.SelectedIndex].Price
                    );
            else
                room = new TripleRoom(hotelRoom[listRooms.SelectedIndex].Floor
                    , hotelRoom[listRooms.SelectedIndex].No, hotelRoom[listRooms.SelectedIndex].IsFull
                    , hotelRoom[listRooms.SelectedIndex].IsHaveJacuzzi, false
                    , hotelRoom[listRooms.SelectedIndex].Price
                    );

            try
            {
                bool tempBool = false;

                dateStart = DateTime.Parse(textBoxStart.Text);
                dateEnd = DateTime.Parse(textBoxEnd.Text);
                if((dateEnd - dateStart).TotalHours > 0 //bitiş tarihi başlangıçtan büyük olmalı
                    && (dateEnd - DateTime.Now).TotalHours > 0 //bitiş ve başlangıç tarihi şuandan büyük olmalı.
                    && (dateStart - DateTime.Now).TotalHours > 0 &&
                    hotels.Hotels[listHotel.SelectedIndex].Fullness < 100 ) //Otel dolu olmamalı.
                {                                                 
                    tempBool = user.makeReservation(dateStart, dateEnd, hotels.Hotels[listHotel.SelectedIndex], room);
                    if (tempBool)
                    {
                        hotels.Hotels[listHotel.SelectedIndex].Fullness++;
                        labelHotelFullness.Text = hotels.Hotels[listHotel.SelectedIndex].Fullness.ToString();
                        updateReserveList();
                    }
                    else
                        MessageBox.Show("Geçerli tarihte oda dolu.");
                }
                else
                {
                    MessageBox.Show("Tarihler aynı, günümüzden eski ya da başlangıç bitişten büyük olamaz.");
                }

                
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Tarihi uygun formatta yazınız.");
                log.addLog(ex);
            }

        }

        private void updateReserveList()
        {
            listReserve.Items.Clear();
            listHistory.Items.Clear();
            foreach (Reservation i in user.ReservationList)
            {
                listReserve.Items.Add(i.StartDate.ToString("dd/M/yyyy") + " - " + i.EndDate.ToString("dd/M/yyyy")
                    + " - " + i.Hotel.HotelName + " - Rezervasyon numarası: " + i.Id + " - Ücret: " + i.Room.Price); //listeye okunur hale getirilir.
            }

            foreach(Reservation i in user.HistoryReserve)
            {
                listHistory.Items.Add(i.StartDate.ToString("dd/M/yyyy") + " - " + i.EndDate.ToString("dd/M/yyyy")
                    + " - " + i.Hotel.HotelName + " - Rezervasyon numarası: " + i.Id + " - Ücret: " + i.Room.Price); //geçmiş rezervasyonlar yüklenir.
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listReserve.SelectedIndex != -1)
            {
                user.cancelReservation(user.ReservationList[listReserve.SelectedIndex]);
                updateReserveList();
                hotels.Hotels[listHotel.SelectedIndex].Fullness--;
                labelHotelFullness.Text = hotels.Hotels[listHotel.SelectedIndex].Fullness.ToString();
            }
            else
            {
                MessageBox.Show("Rezervasyon seçin.");
            }
        }
    }
}
