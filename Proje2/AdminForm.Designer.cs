namespace Proje2
{
    partial class AdminForm
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
            this.panelUser = new System.Windows.Forms.Panel();
            this.openRoom = new System.Windows.Forms.Button();
            this.listRooms = new System.Windows.Forms.ListBox();
            this.goBack = new System.Windows.Forms.Button();
            this.buttonGoHotel = new System.Windows.Forms.Button();
            this.listHotel = new System.Windows.Forms.ListBox();
            this.openHotel = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.panelHotelInfo = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.labelHotelStar = new System.Windows.Forms.Label();
            this.labelHotelFullness = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelReserve = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.labelJakuzi = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelNo = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panelCreateHotel = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.createHotel = new System.Windows.Forms.Button();
            this.starBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCreateRoom = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.createRoom = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNo = new System.Windows.Forms.TextBox();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.panelUser.SuspendLayout();
            this.panelHotelInfo.SuspendLayout();
            this.panelReserve.SuspendLayout();
            this.panelCreateHotel.SuspendLayout();
            this.panelCreateRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.panelCreateRoom);
            this.panelUser.Controls.Add(this.panelCreateHotel);
            this.panelUser.Controls.Add(this.panelHotelInfo);
            this.panelUser.Controls.Add(this.openRoom);
            this.panelUser.Controls.Add(this.listRooms);
            this.panelUser.Controls.Add(this.goBack);
            this.panelUser.Controls.Add(this.buttonGoHotel);
            this.panelUser.Controls.Add(this.listHotel);
            this.panelUser.Controls.Add(this.openHotel);
            this.panelUser.Controls.Add(this.labelText);
            this.panelUser.Controls.Add(this.panelReserve);
            this.panelUser.Location = new System.Drawing.Point(47, 47);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(1050, 489);
            this.panelUser.TabIndex = 19;
            // 
            // openRoom
            // 
            this.openRoom.Location = new System.Drawing.Point(358, 155);
            this.openRoom.Name = "openRoom";
            this.openRoom.Size = new System.Drawing.Size(153, 23);
            this.openRoom.TabIndex = 27;
            this.openRoom.Text = "Oda Aç";
            this.openRoom.UseVisualStyleBackColor = true;
            this.openRoom.Visible = false;
            this.openRoom.Click += new System.EventHandler(this.openRoom_Click);
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
            // listHotel
            // 
            this.listHotel.FormattingEnabled = true;
            this.listHotel.Location = new System.Drawing.Point(80, 25);
            this.listHotel.Name = "listHotel";
            this.listHotel.Size = new System.Drawing.Size(243, 394);
            this.listHotel.TabIndex = 0;
            this.listHotel.SelectedIndexChanged += new System.EventHandler(this.listHotel_SelectedIndexChanged);
            // 
            // openHotel
            // 
            this.openHotel.Location = new System.Drawing.Point(358, 116);
            this.openHotel.Name = "openHotel";
            this.openHotel.Size = new System.Drawing.Size(153, 23);
            this.openHotel.TabIndex = 2;
            this.openHotel.Text = "Otel Aç";
            this.openHotel.UseVisualStyleBackColor = true;
            this.openHotel.Click += new System.EventHandler(this.openHotel_Click);
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
            // panelHotelInfo
            // 
            this.panelHotelInfo.Controls.Add(this.label10);
            this.panelHotelInfo.Controls.Add(this.labelHotelStar);
            this.panelHotelInfo.Controls.Add(this.labelHotelFullness);
            this.panelHotelInfo.Controls.Add(this.label4);
            this.panelHotelInfo.Location = new System.Drawing.Point(368, 198);
            this.panelHotelInfo.Name = "panelHotelInfo";
            this.panelHotelInfo.Size = new System.Drawing.Size(134, 62);
            this.panelHotelInfo.TabIndex = 28;
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
            // panelReserve
            // 
            this.panelReserve.Controls.Add(this.label19);
            this.panelReserve.Controls.Add(this.labelJakuzi);
            this.panelReserve.Controls.Add(this.labelPrice);
            this.panelReserve.Controls.Add(this.label22);
            this.panelReserve.Controls.Add(this.label15);
            this.panelReserve.Controls.Add(this.labelNo);
            this.panelReserve.Controls.Add(this.labelFloor);
            this.panelReserve.Controls.Add(this.label18);
            this.panelReserve.Location = new System.Drawing.Point(343, 184);
            this.panelReserve.Name = "panelReserve";
            this.panelReserve.Size = new System.Drawing.Size(200, 90);
            this.panelReserve.TabIndex = 29;
            this.panelReserve.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(109, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "Jakuzi:";
            // 
            // labelJakuzi
            // 
            this.labelJakuzi.AutoSize = true;
            this.labelJakuzi.Location = new System.Drawing.Point(150, 49);
            this.labelJakuzi.Name = "labelJakuzi";
            this.labelJakuzi.Size = new System.Drawing.Size(31, 13);
            this.labelJakuzi.TabIndex = 25;
            this.labelJakuzi.Text = "Hayır";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(139, 23);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(13, 13);
            this.labelPrice.TabIndex = 24;
            this.labelPrice.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(109, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 23;
            this.label22.Text = "Ücret:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "No:";
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.Location = new System.Drawing.Point(56, 49);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(13, 13);
            this.labelNo.TabIndex = 7;
            this.labelNo.Text = "0";
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Location = new System.Drawing.Point(56, 23);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(13, 13);
            this.labelFloor.TabIndex = 6;
            this.labelFloor.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Kat:";
            // 
            // panelCreateHotel
            // 
            this.panelCreateHotel.Controls.Add(this.label3);
            this.panelCreateHotel.Controls.Add(this.starBox);
            this.panelCreateHotel.Controls.Add(this.createHotel);
            this.panelCreateHotel.Controls.Add(this.radioButton3);
            this.panelCreateHotel.Controls.Add(this.radioButton2);
            this.panelCreateHotel.Controls.Add(this.radioButton1);
            this.panelCreateHotel.Controls.Add(this.label1);
            this.panelCreateHotel.Controls.Add(this.label2);
            this.panelCreateHotel.Controls.Add(this.textBoxCity);
            this.panelCreateHotel.Controls.Add(this.textBoxName);
            this.panelCreateHotel.Location = new System.Drawing.Point(343, 294);
            this.panelCreateHotel.Name = "panelCreateHotel";
            this.panelCreateHotel.Size = new System.Drawing.Size(200, 144);
            this.panelCreateHotel.TabIndex = 30;
            this.panelCreateHotel.Visible = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(52, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(52, 26);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Şehir: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "İsim: ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 81);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hotel";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(68, 81);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.Text = "Hostel";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(121, 81);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 17);
            this.radioButton3.TabIndex = 35;
            this.radioButton3.Text = "Boutique";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // createHotel
            // 
            this.createHotel.Location = new System.Drawing.Point(25, 102);
            this.createHotel.Name = "createHotel";
            this.createHotel.Size = new System.Drawing.Size(153, 23);
            this.createHotel.TabIndex = 31;
            this.createHotel.Text = "Aç";
            this.createHotel.UseVisualStyleBackColor = true;
            this.createHotel.Click += new System.EventHandler(this.createHotel_Click);
            // 
            // starBox
            // 
            this.starBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.starBox.FormattingEnabled = true;
            this.starBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.starBox.Location = new System.Drawing.Point(52, 52);
            this.starBox.Name = "starBox";
            this.starBox.Size = new System.Drawing.Size(100, 21);
            this.starBox.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Yıldız:";
            // 
            // panelCreateRoom
            // 
            this.panelCreateRoom.Controls.Add(this.radioButton4);
            this.panelCreateRoom.Controls.Add(this.radioButton5);
            this.panelCreateRoom.Controls.Add(this.checkBox);
            this.panelCreateRoom.Controls.Add(this.radioButton6);
            this.panelCreateRoom.Controls.Add(this.textBoxPrice);
            this.panelCreateRoom.Controls.Add(this.label5);
            this.panelCreateRoom.Controls.Add(this.createRoom);
            this.panelCreateRoom.Controls.Add(this.label6);
            this.panelCreateRoom.Controls.Add(this.label7);
            this.panelCreateRoom.Controls.Add(this.textBoxNo);
            this.panelCreateRoom.Controls.Add(this.textBoxFloor);
            this.panelCreateRoom.Location = new System.Drawing.Point(343, 280);
            this.panelCreateRoom.Name = "panelCreateRoom";
            this.panelCreateRoom.Size = new System.Drawing.Size(224, 144);
            this.panelCreateRoom.TabIndex = 37;
            this.panelCreateRoom.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ücret:";
            // 
            // createRoom
            // 
            this.createRoom.Location = new System.Drawing.Point(25, 105);
            this.createRoom.Name = "createRoom";
            this.createRoom.Size = new System.Drawing.Size(153, 23);
            this.createRoom.TabIndex = 31;
            this.createRoom.Text = "Aç";
            this.createRoom.UseVisualStyleBackColor = true;
            this.createRoom.Click += new System.EventHandler(this.createRoom_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Kat:";
            // 
            // textBoxNo
            // 
            this.textBoxNo.Location = new System.Drawing.Point(52, 26);
            this.textBoxNo.Name = "textBoxNo";
            this.textBoxNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxNo.TabIndex = 1;
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Location = new System.Drawing.Point(52, 3);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(100, 20);
            this.textBoxFloor.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(52, 52);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 37;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(158, 29);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(56, 17);
            this.checkBox.TabIndex = 38;
            this.checkBox.Text = "Jakuzi";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(22, 81);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(48, 17);
            this.radioButton4.TabIndex = 39;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Tekli";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(77, 81);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(40, 17);
            this.radioButton5.TabIndex = 38;
            this.radioButton5.Text = "İkili";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(123, 82);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(47, 17);
            this.radioButton6.TabIndex = 37;
            this.radioButton6.Text = "Üçlü";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 686);
            this.Controls.Add(this.panelUser);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelHotelInfo.ResumeLayout(false);
            this.panelHotelInfo.PerformLayout();
            this.panelReserve.ResumeLayout(false);
            this.panelReserve.PerformLayout();
            this.panelCreateHotel.ResumeLayout(false);
            this.panelCreateHotel.PerformLayout();
            this.panelCreateRoom.ResumeLayout(false);
            this.panelCreateRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.ListBox listRooms;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Button buttonGoHotel;
        private System.Windows.Forms.ListBox listHotel;
        private System.Windows.Forms.Button openHotel;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button openRoom;
        private System.Windows.Forms.Panel panelHotelInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelHotelStar;
        private System.Windows.Forms.Label labelHotelFullness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelReserve;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelJakuzi;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panelCreateHotel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox starBox;
        private System.Windows.Forms.Button createHotel;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Panel panelCreateRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNo;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
    }
}