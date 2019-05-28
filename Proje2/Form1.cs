using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Proje2
{
    public partial class Form1 : Form
    {

        AccountManagement manage = new AccountManagement(); //hesapların vb durumların yönetildiği nesne
        MainForm main = null;
        Log log = new Log(); //log nesnesi

        public string username;

        public Form1()
        {
            InitializeComponent();
            main = new MainForm(this, manage);
        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void loginUser_Click(object sender, EventArgs e) //login butonuna tıklandığında uygulanan kontrol
        {
            try
            {
                bool result = manage.loginUser(textBoxUsername.Text.ToLower());
                if (!result)
                    MessageBox.Show("Kullanıcı bulunamadı.");
                else
                {
                    username = textBoxUsername.Text;
                    this.Hide();
                    main.ShowDialog();
                }
            }
            catch(FormatException ex) //özel istisna
            {
                log.addLog(ex);
            }


        }

        private void button1_Click(object sender, EventArgs e) //Kullanıcı üye olduğunda daha önce bu adla kullanıcı olup olmadığını kontrol eden
        {                                                      //ilk olarak gerekli alanları görünür hale getirir eğer görünür ise kontrolü yapar
            if(textBoxRegister.Visible == false)    
            {
                label4.Visible = true;
                textBoxRegister.Visible = true;
            } else
            {
                if(textBoxRegister.TextLength > 4)//kullanıcı adı minimum 5 karakter olmalı
                {
                    bool result = manage.Register(textBoxRegister.Text.ToLower());
                    if (!result)
                        MessageBox.Show("Kullanıcı adı daha önce alınmış.");
                    else
                    {
                        username = textBoxRegister.Text;
                        label4.Visible = false;
                        textBoxRegister.Visible = false;
                        this.Hide();
                        main.ShowDialog();
                    }
                } else
                {
                    MessageBox.Show("Username minimum 5 karakter olmalıdır."); 
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) //gerekli bilgileri daha kullanıcı online olmadan çeker.
        {
            manage.loadTxt();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //form kapatılırken güncel bilgileri kaydeder
        {
            manage.saveTxt();
        }

        private void loginAdmin_Click(object sender, EventArgs e) ///admin olarak hesap açmak
        {
            AdminForm main = new AdminForm(this); //admin formuna form1 constructor a gönderilir
            this.Hide(); //form 1 gizlenir
            main.ShowDialog(); //admin form açılır
        }

        private void timer1_Tick(object sender, EventArgs e) //görsellik için yapılmış bir şey.
        {
            lbltxt.Left = lbltxt.Left - 1; //http://www.simplylearnprogramming.com/text-scrolling-windows-application-csharp/53
            if (lbltxt.Left + lbltxt.Width <= 0)
            {
                lbltxt.Left = this.Width;
            }
        }
    }
}
