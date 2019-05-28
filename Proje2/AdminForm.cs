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
    public partial class AdminForm : Form
    {
        Form1 form1;
        LoadHotels load = new LoadHotels();
        List<Room> hotelRoom;

        public AdminForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            load.getHotels();

            loadHotels();
        }

        private void loadHotels() //listbox a isimleri yükler.
        {
            listHotel.Items.Clear();
            foreach (Hotel i in load.Hotels)
                listHotel.Items.Add(i.HotelName);
        }

        private void loadRooms()
        {
            listRooms.Items.Clear();
            foreach (Room i in hotelRoom)
                listRooms.Items.Add(i.No);
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
            //Form kapatıldığı anda ana forma geri geliyoruz.
        {
            form1.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            starBox.SelectedIndex = 0;
        }

        private void buttonGoHotel_Click(object sender, EventArgs e)
        {

            if(listHotel.SelectedIndex != -1)
                //Otele gidildiği anda kullanılacak araçlar..
            {
                hotelRoom = load.Hotels[listHotel.SelectedIndex].RoomList;
                loadRooms();
                listHotel.Visible = false;
                listRooms.Visible = true;
                goBack.Visible = true;
                panelHotelInfo.Visible = false;
                openHotel.Visible = false;
                buttonGoHotel.Visible = false;
                openRoom.Visible = true;
                panelCreateHotel.Visible = false;
                labelText.Text = listHotel.Text;
            } else
            {
                MessageBox.Show("Otel seçin.");
            } 
        }


        private void listRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçilen otelin özellikleri.
            panelReserve.Visible = true;

            labelNo.Text = hotelRoom[listRooms.SelectedIndex].No.ToString();
            labelPrice.Text = hotelRoom[listRooms.SelectedIndex].Price.ToString();
            labelFloor.Text = hotelRoom[listRooms.SelectedIndex].Floor.ToString();
            if (hotelRoom[listRooms.SelectedIndex].IsHaveJacuzzi == true)
                labelJakuzi.Text = "Evet";
            else
                labelJakuzi.Text = "Hayır";
        }


        private void listHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hotel listesi indexler değiştiği anda değişen labeller
            panelHotelInfo.Visible = true;
            labelHotelFullness.Text = "%" + load.Hotels[listHotel.SelectedIndex].Fullness.ToString();
            labelHotelStar.Text = load.Hotels[listHotel.SelectedIndex].Star.ToString();
            panelHotelInfo.Visible = true;
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            //Geri buttonuna tıklanıldığında gösterilecek araçlar.
            listHotel.Visible = true;
            listRooms.Visible = false;
            panelReserve.Visible = false;
            goBack.Visible = false;
            buttonGoHotel.Visible = true;
            openRoom.Visible = false;
            openHotel.Visible = true;
            labelText.Text = "Oteller";
            listRooms.Items.Clear();
        }

        private void openHotel_Click(object sender, EventArgs e)
        {
            //Otel aç buttonu ile paneli kullanılabilir hale getiriyoruz.
            panelCreateHotel.Visible = true;
        }

        private void createHotel_Click(object sender, EventArgs e)
        {
            //Girilen textler ile otel oluşturuyoruz.
            Hotel newHotel = null;

            if (radioButton1.Checked == true)
                newHotel = new Hotel(new List<Room>(), textBoxName.Text + " Otel", int.Parse(starBox.SelectedItem.ToString()), textBoxCity.Text);
            else if (radioButton2.Checked == true)
                newHotel = new Hostel(new List<Room>(), textBoxName.Text + " Hotel", int.Parse(starBox.SelectedItem.ToString()), textBoxCity.Text);
            else
                newHotel = new Boutique(new List<Room>(), textBoxName.Text + " Butik Otel", int.Parse(starBox.SelectedItem.ToString()), textBoxCity.Text);

            foreach (Hotel i in load.Hotels) //aynı isimde 2 otel açmayı engellemek için..
                if (i.HotelName == newHotel.HotelName)
                {
                    MessageBox.Show("Bu isimde otel zaten var.");
                    return;
                }

            load.Hotels.Add(newHotel);

            loadHotels();
            load.saveHotels();
            panelCreateHotel.Visible = false;
        }

        private void openRoom_Click(object sender, EventArgs e)
        {
            //Oda açma buttonu ile paneli etkinleştiriyoruz.
            panelCreateRoom.Visible = true;
        }

        private void createRoom_Click(object sender, EventArgs e)
        {
            //Oda oluşturma butonunu ile seçili radiobuttonlara göre özellikte oda açıyoruz..
            Room newRoom = null;
            bool jakuzi = checkBox.Checked;

            if (radioButton4.Checked == true)
                newRoom = new SingleRoom(int.Parse(textBoxFloor.Text), int.Parse(textBoxNo.Text), false, false, jakuzi, int.Parse(textBoxPrice.Text));
            else if (radioButton5.Checked == true)
                newRoom = new DoubleRoom(int.Parse(textBoxFloor.Text), int.Parse(textBoxNo.Text), false, jakuzi, false, int.Parse(textBoxPrice.Text));
            else
                newRoom = new TripleRoom(int.Parse(textBoxFloor.Text), int.Parse(textBoxNo.Text), false, jakuzi, false,  int.Parse(textBoxPrice.Text));

            foreach (Room i in hotelRoom) //aynı isimde 2 otel açmayı engellemek için.
                if (i.No == newRoom.No)
                {
                    MessageBox.Show("Bu numaralı oda zaten var.");
                    return;
                }


            load.Hotels[listHotel.SelectedIndex].RoomList.Add(newRoom);
            loadRooms();
            load.saveHotels();
            panelCreateRoom.Visible = false;
        }
    }
}
