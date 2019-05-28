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

        AccountManagement manage = new AccountManagement();
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
            //MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
            //StreamReader stream_read = new StreamReader(AppDomain.CurrentDomain.BaseDirectory+ "deneme.txt");
            //string js_data = stream_read.ReadToEnd();
            //User user = JsonConvert.DeserializeObject<User>(js_data);
            //MessageBox.Show(user.Name);
            //manage.loadTxt();
        }

        private void loginUser_Click(object sender, EventArgs e)
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
            catch(FormatException ex)
            {
                log.addLog(ex);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxRegister.Visible == false)
            {
                label4.Visible = true;
                textBoxRegister.Visible = true;
            } else
            {
                if(textBoxRegister.TextLength > 4)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            manage.loadTxt();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            manage.saveTxt();
        }

        private void loginAdmin_Click(object sender, EventArgs e)
        {
            //AccountManagement admin = new AccountManagement(true);
            AdminForm main = new AdminForm(this);
            this.Hide();
            main.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltxt.Left = lbltxt.Left - 1; //http://www.simplylearnprogramming.com/text-scrolling-windows-application-csharp/53
            if (lbltxt.Left + lbltxt.Width <= 0)
            {
                lbltxt.Left = this.Width;
            }
        }
    }
}
