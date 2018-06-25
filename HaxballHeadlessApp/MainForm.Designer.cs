namespace HaxballHeadlessApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.roomUrlLink = new System.Windows.Forms.LinkLabel();
            this.textBox_RoomName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_BotName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_CreateRoom = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.textBox_MaxPlayers = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_Public = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_roomPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_WinnerStays = new System.Windows.Forms.CheckBox();
            this.textBox_ScoreLimit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_TimeLimit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_OverrideGeoLoc = new System.Windows.Forms.CheckBox();
            this.label_GeoCode = new System.Windows.Forms.Label();
            this.textBox_GeoCode = new System.Windows.Forms.TextBox();
            this.textBox_GeoLong = new System.Windows.Forms.TextBox();
            this.label_GeoLong = new System.Windows.Forms.Label();
            this.textBox_GeoLat = new System.Windows.Forms.TextBox();
            this.label_GeoLat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roomUrlLink
            // 
            this.roomUrlLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomUrlLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.roomUrlLink.Location = new System.Drawing.Point(37, 277);
            this.roomUrlLink.Name = "roomUrlLink";
            this.roomUrlLink.Size = new System.Drawing.Size(360, 61);
            this.roomUrlLink.TabIndex = 1;
            this.roomUrlLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RoomUrlLink_LinkClicked);
            // 
            // textBox_RoomName
            // 
            this.textBox_RoomName.Location = new System.Drawing.Point(110, 42);
            this.textBox_RoomName.Name = "textBox_RoomName";
            this.textBox_RoomName.Size = new System.Drawing.Size(100, 20);
            this.textBox_RoomName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room Name:";
            // 
            // textBox_BotName
            // 
            this.textBox_BotName.Location = new System.Drawing.Point(110, 68);
            this.textBox_BotName.Name = "textBox_BotName";
            this.textBox_BotName.Size = new System.Drawing.Size(100, 20);
            this.textBox_BotName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bot Name:";
            // 
            // button_CreateRoom
            // 
            this.button_CreateRoom.Location = new System.Drawing.Point(41, 218);
            this.button_CreateRoom.Name = "button_CreateRoom";
            this.button_CreateRoom.Size = new System.Drawing.Size(169, 23);
            this.button_CreateRoom.TabIndex = 4;
            this.button_CreateRoom.Text = "Create Room";
            this.button_CreateRoom.UseVisualStyleBackColor = true;
            this.button_CreateRoom.Click += new System.EventHandler(this.Button_CreateRoom_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(228, 218);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(169, 23);
            this.button_Stop.TabIndex = 4;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // textBox_MaxPlayers
            // 
            this.textBox_MaxPlayers.Location = new System.Drawing.Point(110, 94);
            this.textBox_MaxPlayers.Name = "textBox_MaxPlayers";
            this.textBox_MaxPlayers.Size = new System.Drawing.Size(100, 20);
            this.textBox_MaxPlayers.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Max Players:";
            // 
            // checkBox_Public
            // 
            this.checkBox_Public.AutoSize = true;
            this.checkBox_Public.Location = new System.Drawing.Point(228, 44);
            this.checkBox_Public.Name = "checkBox_Public";
            this.checkBox_Public.Size = new System.Drawing.Size(55, 17);
            this.checkBox_Public.TabIndex = 5;
            this.checkBox_Public.Text = "Public";
            this.checkBox_Public.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(41, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 2);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // textBox_roomPassword
            // 
            this.textBox_roomPassword.Location = new System.Drawing.Point(297, 94);
            this.textBox_roomPassword.Name = "textBox_roomPassword";
            this.textBox_roomPassword.PasswordChar = '*';
            this.textBox_roomPassword.Size = new System.Drawing.Size(100, 20);
            this.textBox_roomPassword.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password:";
            // 
            // checkBox_WinnerStays
            // 
            this.checkBox_WinnerStays.AutoSize = true;
            this.checkBox_WinnerStays.Location = new System.Drawing.Point(297, 44);
            this.checkBox_WinnerStays.Name = "checkBox_WinnerStays";
            this.checkBox_WinnerStays.Size = new System.Drawing.Size(89, 17);
            this.checkBox_WinnerStays.TabIndex = 5;
            this.checkBox_WinnerStays.Text = "Winner Stays";
            this.checkBox_WinnerStays.UseVisualStyleBackColor = true;
            this.checkBox_WinnerStays.CheckedChanged += new System.EventHandler(this.CheckBox_WinnerStays_CheckedChanged);
            // 
            // textBox_ScoreLimit
            // 
            this.textBox_ScoreLimit.Location = new System.Drawing.Point(110, 120);
            this.textBox_ScoreLimit.Name = "textBox_ScoreLimit";
            this.textBox_ScoreLimit.Size = new System.Drawing.Size(100, 20);
            this.textBox_ScoreLimit.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Score Limit:";
            // 
            // textBox_TimeLimit
            // 
            this.textBox_TimeLimit.Location = new System.Drawing.Point(297, 120);
            this.textBox_TimeLimit.Name = "textBox_TimeLimit";
            this.textBox_TimeLimit.Size = new System.Drawing.Size(100, 20);
            this.textBox_TimeLimit.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Time Limit:";
            // 
            // checkBox_OverrideGeoLoc
            // 
            this.checkBox_OverrideGeoLoc.AutoSize = true;
            this.checkBox_OverrideGeoLoc.Location = new System.Drawing.Point(40, 156);
            this.checkBox_OverrideGeoLoc.Name = "checkBox_OverrideGeoLoc";
            this.checkBox_OverrideGeoLoc.Size = new System.Drawing.Size(133, 17);
            this.checkBox_OverrideGeoLoc.TabIndex = 7;
            this.checkBox_OverrideGeoLoc.Text = "Override Geo Location";
            this.checkBox_OverrideGeoLoc.UseVisualStyleBackColor = true;
            this.checkBox_OverrideGeoLoc.CheckedChanged += new System.EventHandler(this.CheckBox_OverrideGeoLoc_CheckedChanged);
            // 
            // label_GeoCode
            // 
            this.label_GeoCode.AutoSize = true;
            this.label_GeoCode.Location = new System.Drawing.Point(225, 157);
            this.label_GeoCode.Name = "label_GeoCode";
            this.label_GeoCode.Size = new System.Drawing.Size(58, 13);
            this.label_GeoCode.TabIndex = 9;
            this.label_GeoCode.Text = "Geo Code:";
            // 
            // textBox_GeoCode
            // 
            this.textBox_GeoCode.Location = new System.Drawing.Point(297, 154);
            this.textBox_GeoCode.Name = "textBox_GeoCode";
            this.textBox_GeoCode.Size = new System.Drawing.Size(100, 20);
            this.textBox_GeoCode.TabIndex = 8;
            // 
            // textBox_GeoLong
            // 
            this.textBox_GeoLong.Location = new System.Drawing.Point(297, 177);
            this.textBox_GeoLong.Name = "textBox_GeoLong";
            this.textBox_GeoLong.Size = new System.Drawing.Size(100, 20);
            this.textBox_GeoLong.TabIndex = 8;
            // 
            // label_GeoLong
            // 
            this.label_GeoLong.AutoSize = true;
            this.label_GeoLong.Location = new System.Drawing.Point(225, 180);
            this.label_GeoLong.Name = "label_GeoLong";
            this.label_GeoLong.Size = new System.Drawing.Size(57, 13);
            this.label_GeoLong.TabIndex = 9;
            this.label_GeoLong.Text = "Geo Long:";
            // 
            // textBox_GeoLat
            // 
            this.textBox_GeoLat.Location = new System.Drawing.Point(110, 177);
            this.textBox_GeoLat.Name = "textBox_GeoLat";
            this.textBox_GeoLat.Size = new System.Drawing.Size(100, 20);
            this.textBox_GeoLat.TabIndex = 8;
            // 
            // label_GeoLat
            // 
            this.label_GeoLat.AutoSize = true;
            this.label_GeoLat.Location = new System.Drawing.Point(38, 180);
            this.label_GeoLat.Name = "label_GeoLat";
            this.label_GeoLat.Size = new System.Drawing.Size(48, 13);
            this.label_GeoLat.TabIndex = 9;
            this.label_GeoLat.Text = "Geo Lat:";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(41, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(356, 2);
            this.label11.TabIndex = 6;
            this.label11.Text = "label4";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(40, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(356, 2);
            this.label12.TabIndex = 6;
            this.label12.Text = "label4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 384);
            this.Controls.Add(this.label_GeoLat);
            this.Controls.Add(this.label_GeoLong);
            this.Controls.Add(this.label_GeoCode);
            this.Controls.Add(this.textBox_GeoLat);
            this.Controls.Add(this.textBox_GeoLong);
            this.Controls.Add(this.textBox_GeoCode);
            this.Controls.Add(this.checkBox_OverrideGeoLoc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox_WinnerStays);
            this.Controls.Add(this.checkBox_Public);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_CreateRoom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_roomPassword);
            this.Controls.Add(this.textBox_TimeLimit);
            this.Controls.Add(this.textBox_ScoreLimit);
            this.Controls.Add(this.textBox_MaxPlayers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_BotName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_RoomName);
            this.Controls.Add(this.roomUrlLink);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Parameterizable Haxball Bot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel roomUrlLink;
        private System.Windows.Forms.TextBox textBox_RoomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_BotName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_CreateRoom;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.TextBox textBox_MaxPlayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_Public;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_roomPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_WinnerStays;
        private System.Windows.Forms.TextBox textBox_ScoreLimit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_TimeLimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_OverrideGeoLoc;
        private System.Windows.Forms.Label label_GeoCode;
        private System.Windows.Forms.TextBox textBox_GeoCode;
        private System.Windows.Forms.TextBox textBox_GeoLong;
        private System.Windows.Forms.Label label_GeoLong;
        private System.Windows.Forms.TextBox textBox_GeoLat;
        private System.Windows.Forms.Label label_GeoLat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

