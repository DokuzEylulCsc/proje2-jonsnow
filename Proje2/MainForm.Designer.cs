namespace Proje2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listHotel = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.listReserve = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.listRooms = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.goBack = new System.Windows.Forms.Button();
            this.buttonGoHotel = new System.Windows.Forms.Button();
            this.panelReserve = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.labelJakuzi = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelNo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.buttonMakeReserve = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelHotelInfo = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.labelHotelStar = new System.Windows.Forms.Label();
            this.labelHotelFullness = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listHistory = new System.Windows.Forms.ListBox();
            this.panelInfo.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panelReserve.SuspendLayout();
            this.panelHotelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listHotel
            // 
            this.listHotel.FormattingEnabled = true;
            this.listHotel.Location = new System.Drawing.Point(80, 25);
            this.listHotel.Name = "listHotel";
            this.listHotel.Size = new System.Drawing.Size(243, 394);
            this.listHotel.TabIndex = 0;
            this.listHotel.SelectedIndexChanged += new System.EventHandler(this.listHotel_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Rezervasyon İptal ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(35, 177);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(132, 23);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "Bilgileri Güncelle";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(186, 9);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(37, 13);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "Oteller";
            // 
            // listReserve
            // 
            this.listReserve.FormattingEnabled = true;
            this.listReserve.HorizontalScrollbar = true;
            this.listReserve.Location = new System.Drawing.Point(539, 25);
            this.listReserve.Name = "listReserve";
            this.listReserve.Size = new System.Drawing.Size(456, 394);
            this.listReserve.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rezervasyonlarım";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "<-";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(76, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(76, 94);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 10;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(76, 139);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 11;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(73, 11);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 12;
            this.labelUsername.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Surname: ";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelInfo.Controls.Add(this.textBoxSurname);
            this.panelInfo.Controls.Add(this.label7);
            this.panelInfo.Controls.Add(this.textBoxName);
            this.panelInfo.Controls.Add(this.label6);
            this.panelInfo.Controls.Add(this.textBoxPhone);
            this.panelInfo.Controls.Add(this.label5);
            this.panelInfo.Controls.Add(this.buttonInfo);
            this.panelInfo.Controls.Add(this.labelUsername);
            this.panelInfo.Location = new System.Drawing.Point(1099, 23);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(200, 218);
            this.panelInfo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(513, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "->";
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.listRooms);
            this.panelUser.Controls.Add(this.label14);
            this.panelUser.Controls.Add(this.goBack);
            this.panelUser.Controls.Add(this.buttonGoHotel);
            this.panelUser.Controls.Add(this.panelReserve);
            this.panelUser.Controls.Add(this.label9);
            this.panelUser.Controls.Add(this.panelHotelInfo);
            this.panelUser.Controls.Add(this.listReserve);
            this.panelUser.Controls.Add(this.listHotel);
            this.panelUser.Controls.Add(this.label3);
            this.panelUser.Controls.Add(this.button2);
            this.panelUser.Controls.Add(this.label2);
            this.panelUser.Controls.Add(this.labelText);
            this.panelUser.Location = new System.Drawing.Point(43, 23);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(1050, 489);
            this.panelUser.TabIndex = 18;
            this.panelUser.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUser_Paint);
            // 
            // listRooms
            // 
            this.listRooms.FormattingEnabled = true;
            this.listRooms.Location = new System.Drawing.Point(80, 25);
            this.listRooms.Name = "listRooms";
            this.listRooms.Size = new System.Drawing.Size(243, 394);
            this.listRooms.TabIndex = 25;
            this.listRooms.Visible = false;
            this.listRooms.SelectedIndexChanged += new System.EventHandler(this.listRooms_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(336, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "<-";
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(356, 25);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 23);
            this.goBack.TabIndex = 23;
            this.goBack.Text = "Geri";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Visible = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // buttonGoHotel
            // 
            this.buttonGoHotel.Location = new System.Drawing.Point(358, 70);
            this.buttonGoHotel.Name = "buttonGoHotel";
            this.buttonGoHotel.Size = new System.Drawing.Size(153, 23);
            this.buttonGoHotel.TabIndex = 21;
            this.buttonGoHotel.Text = "Otele Git";
            this.buttonGoHotel.UseVisualStyleBackColor = true;
            this.buttonGoHotel.Click += new System.EventHandler(this.buttonGoHotel_Click);
            // 
            // panelReserve
            // 
            this.panelReserve.Controls.Add(this.radioButton3);
            this.panelReserve.Controls.Add(this.radioButton2);
            this.panelReserve.Controls.Add(this.radioButton1);
            this.panelReserve.Controls.Add(this.label19);
            this.panelReserve.Controls.Add(this.labelJakuzi);
            this.panelReserve.Controls.Add(this.labelPrice);
            this.panelReserve.Controls.Add(this.label22);
            this.panelReserve.Controls.Add(this.label15);
            this.panelReserve.Controls.Add(this.label12);
            this.panelReserve.Controls.Add(this.labelNo);
            this.panelReserve.Controls.Add(this.label11);
            this.panelReserve.Controls.Add(this.labelFloor);
            this.panelReserve.Controls.Add(this.buttonMakeReserve);
            this.panelReserve.Controls.Add(this.label18);
            this.panelReserve.Controls.Add(this.textBoxEnd);
            this.panelReserve.Controls.Add(this.textBoxStart);
            this.panelReserve.Location = new System.Drawing.Point(332, 224);
            this.panelReserve.Name = "panelReserve";
            this.panelReserve.Size = new System.Drawing.Size(200, 247);
            this.panelReserve.TabIndex = 19;
            this.panelReserve.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(136, 177);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 17);
            this.radioButton3.TabIndex = 29;
            this.radioButton3.Text = "Üçlü";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(80, 177);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(40, 17);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.Text = "İkili";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 177);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tekli";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(114, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "Jakuzi:";
            // 
            // labelJakuzi
            // 
            this.labelJakuzi.AutoSize = true;
            this.labelJakuzi.Location = new System.Drawing.Point(155, 134);
            this.labelJakuzi.Name = "labelJakuzi";
            this.labelJakuzi.Size = new System.Drawing.Size(31, 13);
            this.labelJakuzi.TabIndex = 25;
            this.labelJakuzi.Text = "Hayır";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(144, 108);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(13, 13);
            this.labelPrice.TabIndex = 24;
            this.labelPrice.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(114, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 23;
            this.label22.Text = "Ücret:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "No:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Bitiş Tarihi:";
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.Location = new System.Drawing.Point(61, 134);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(13, 13);
            this.labelNo.TabIndex = 7;
            this.labelNo.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Başlangıç Tarihi:";
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Location = new System.Drawing.Point(61, 108);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(13, 13);
            this.labelFloor.TabIndex = 6;
            this.labelFloor.Text = "0";
            // 
            // buttonMakeReserve
            // 
            this.buttonMakeReserve.Location = new System.Drawing.Point(26, 205);
            this.buttonMakeReserve.Name = "buttonMakeReserve";
            this.buttonMakeReserve.Size = new System.Drawing.Size(153, 23);
            this.buttonMakeReserve.TabIndex = 21;
            this.buttonMakeReserve.Text = "Rezervasyon Yap";
            this.buttonMakeReserve.UseVisualStyleBackColor = true;
            this.buttonMakeReserve.Click += new System.EventHandler(this.buttonMakeReserve_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Kat:";
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(96, 71);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnd.TabIndex = 1;
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(96, 27);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(517, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "->";
            // 
            // panelHotelInfo
            // 
            this.panelHotelInfo.Controls.Add(this.label10);
            this.panelHotelInfo.Controls.Add(this.labelHotelStar);
            this.panelHotelInfo.Controls.Add(this.labelHotelFullness);
            this.panelHotelInfo.Controls.Add(this.label4);
            this.panelHotelInfo.Location = new System.Drawing.Point(366, 156);
            this.panelHotelInfo.Name = "panelHotelInfo";
            this.panelHotelInfo.Size = new System.Drawing.Size(134, 62);
            this.panelHotelInfo.TabIndex = 19;
            this.panelHotelInfo.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Yıldız:";
            // 
            // labelHotelStar
            // 
            this.labelHotelStar.AutoSize = true;
            this.labelHotelStar.Location = new System.Drawing.Point(80, 38);
            this.labelHotelStar.Name = "labelHotelStar";
            this.labelHotelStar.Size = new System.Drawing.Size(13, 13);
            this.labelHotelStar.TabIndex = 3;
            this.labelHotelStar.Text = "0";
            // 
            // labelHotelFullness
            // 
            this.labelHotelFullness.AutoSize = true;
            this.labelHotelFullness.Location = new System.Drawing.Point(80, 12);
            this.labelHotelFullness.Name = "labelHotelFullness";
            this.labelHotelFullness.Size = new System.Drawing.Size(21, 13);
            this.labelHotelFullness.TabIndex = 1;
            this.labelHotelFullness.Text = "%0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doluluk: ";
            // 
            // listHistory
            // 
            this.listHistory.Enabled = false;
            this.listHistory.FormattingEnabled = true;
            this.listHistory.HorizontalScrollbar = true;
            this.listHistory.Location = new System.Drawing.Point(1099, 247);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(456, 394);
            this.listHistory.TabIndex = 26;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 665);
            this.Controls.Add(this.listHistory);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelInfo);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelReserve.ResumeLayout(false);
            this.panelReserve.PerformLayout();
            this.panelHotelInfo.ResumeLayout(false);
            this.panelHotelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listHotel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.ListBox listReserve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelHotelInfo;
        private System.Windows.Forms.Label labelHotelStar;
        private System.Windows.Forms.Label labelHotelFullness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelReserve;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonMakeReserve;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Button buttonGoHotel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelJakuzi;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox listRooms;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listHistory;
    }
}