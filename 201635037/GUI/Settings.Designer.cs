namespace _201635037.GUI
{
    partial class Settings
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
            this.LBFullMovies = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateMovie = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteMovie = new System.Windows.Forms.Button();
            this.LBFullRooms = new System.Windows.Forms.ListBox();
            this.DeleteRoom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateRoom = new System.Windows.Forms.Button();
            this.LBFullCustomer = new System.Windows.Forms.ListBox();
            this.DeleteCustomer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateCustomer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.contactNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TBTitle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TBDescription = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ShowTime = new System.Windows.Forms.DateTimePicker();
            this.releaseDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.seatNumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatNumericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            this.SuspendLayout();
            // 
            // LBFullMovies
            // 
            this.LBFullMovies.FormattingEnabled = true;
            this.LBFullMovies.Location = new System.Drawing.Point(12, 87);
            this.LBFullMovies.Name = "LBFullMovies";
            this.LBFullMovies.Size = new System.Drawing.Size(776, 108);
            this.LBFullMovies.TabIndex = 0;
            this.LBFullMovies.SelectedIndexChanged += new System.EventHandler(this.LBFullMovies_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Movies Full List";
            // 
            // CreateMovie
            // 
            this.CreateMovie.Location = new System.Drawing.Point(437, 196);
            this.CreateMovie.Name = "CreateMovie";
            this.CreateMovie.Size = new System.Drawing.Size(351, 32);
            this.CreateMovie.TabIndex = 3;
            this.CreateMovie.Text = "Create New";
            this.CreateMovie.UseVisualStyleBackColor = true;
            this.CreateMovie.Click += new System.EventHandler(this.CreateMovie_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Delete By Id";
            // 
            // DeleteMovie
            // 
            this.DeleteMovie.Location = new System.Drawing.Point(437, 248);
            this.DeleteMovie.Name = "DeleteMovie";
            this.DeleteMovie.Size = new System.Drawing.Size(348, 34);
            this.DeleteMovie.TabIndex = 6;
            this.DeleteMovie.Text = "Delete";
            this.DeleteMovie.UseVisualStyleBackColor = true;
            this.DeleteMovie.Click += new System.EventHandler(this.DeleteMovie_Click);
            // 
            // LBFullRooms
            // 
            this.LBFullRooms.FormattingEnabled = true;
            this.LBFullRooms.Location = new System.Drawing.Point(12, 288);
            this.LBFullRooms.Name = "LBFullRooms";
            this.LBFullRooms.Size = new System.Drawing.Size(776, 95);
            this.LBFullRooms.TabIndex = 7;
            this.LBFullRooms.SelectedIndexChanged += new System.EventHandler(this.LBFullRooms_SelectedIndexChanged);
            // 
            // DeleteRoom
            // 
            this.DeleteRoom.Location = new System.Drawing.Point(293, 459);
            this.DeleteRoom.Name = "DeleteRoom";
            this.DeleteRoom.Size = new System.Drawing.Size(492, 32);
            this.DeleteRoom.TabIndex = 11;
            this.DeleteRoom.Text = "Delete";
            this.DeleteRoom.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Delete By Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CreateRoom
            // 
            this.CreateRoom.Location = new System.Drawing.Point(293, 398);
            this.CreateRoom.Name = "CreateRoom";
            this.CreateRoom.Size = new System.Drawing.Size(495, 32);
            this.CreateRoom.TabIndex = 8;
            this.CreateRoom.Text = "Create New";
            this.CreateRoom.UseVisualStyleBackColor = true;
            this.CreateRoom.Click += new System.EventHandler(this.CreateRoom_Click);
            // 
            // LBFullCustomer
            // 
            this.LBFullCustomer.FormattingEnabled = true;
            this.LBFullCustomer.Location = new System.Drawing.Point(12, 517);
            this.LBFullCustomer.Name = "LBFullCustomer";
            this.LBFullCustomer.Size = new System.Drawing.Size(776, 95);
            this.LBFullCustomer.TabIndex = 12;
            this.LBFullCustomer.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.Location = new System.Drawing.Point(440, 618);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(348, 34);
            this.DeleteCustomer.TabIndex = 16;
            this.DeleteCustomer.Text = "Delete";
            this.DeleteCustomer.UseVisualStyleBackColor = true;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 615);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Delete By Id";
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Location = new System.Drawing.Point(12, 618);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(351, 32);
            this.CreateCustomer.TabIndex = 13;
            this.CreateCustomer.Text = "Create New";
            this.CreateCustomer.UseVisualStyleBackColor = true;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Customer Full List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(8, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Rooms Full List";
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(172, 13);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 35);
            this.refresh.TabIndex = 19;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "contactNum";
            // 
            // contactNum
            // 
            this.contactNum.Location = new System.Drawing.Point(12, 393);
            this.contactNum.Name = "contactNum";
            this.contactNum.Size = new System.Drawing.Size(133, 20);
            this.contactNum.TabIndex = 20;
            this.contactNum.TextChanged += new System.EventHandler(this.contactNum_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "SeatRow";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(151, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "SeatColumn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "AllSeats";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 471);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 456);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "DateBlock";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(188, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Movie ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Title";
            // 
            // TBTitle
            // 
            this.TBTitle.Location = new System.Drawing.Point(71, 198);
            this.TBTitle.Name = "TBTitle";
            this.TBTitle.Size = new System.Drawing.Size(202, 20);
            this.TBTitle.TabIndex = 32;
            this.TBTitle.TextChanged += new System.EventHandler(this.TBTitle_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 227);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Description";
            // 
            // TBDescription
            // 
            this.TBDescription.Location = new System.Drawing.Point(71, 224);
            this.TBDescription.Name = "TBDescription";
            this.TBDescription.Size = new System.Drawing.Size(202, 20);
            this.TBDescription.TabIndex = 34;
            this.TBDescription.TextChanged += new System.EventHandler(this.TBDescription_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Show Time";
            // 
            // ShowTime
            // 
            this.ShowTime.Location = new System.Drawing.Point(71, 243);
            this.ShowTime.Name = "ShowTime";
            this.ShowTime.Size = new System.Drawing.Size(170, 20);
            this.ShowTime.TabIndex = 36;
            this.ShowTime.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // releaseDate
            // 
            this.releaseDate.Location = new System.Drawing.Point(293, 248);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(111, 20);
            this.releaseDate.TabIndex = 38;
            this.releaseDate.ValueChanged += new System.EventHandler(this.releaseDate_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(290, 235);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "ReleaseDate";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(157, 398);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 40;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(154, 434);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 41;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // seatNumericUpDown3
            // 
            this.seatNumericUpDown3.Location = new System.Drawing.Point(12, 433);
            this.seatNumericUpDown3.Name = "seatNumericUpDown3";
            this.seatNumericUpDown3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.seatNumericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.seatNumericUpDown3.TabIndex = 42;
            this.seatNumericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seatNumericUpDown3.ValueChanged += new System.EventHandler(this.seatNumericUpDown3_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(188, 471);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(86, 20);
            this.numericUpDown4.TabIndex = 43;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(499, 436);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown3.TabIndex = 44;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(499, 229);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown5.TabIndex = 45;
            this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(369, 630);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown6.TabIndex = 46;
            this.numericUpDown6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(293, 212);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(86, 20);
            this.numericUpDown7.TabIndex = 48;
            this.numericUpDown7.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(293, 200);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "Room ID";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 653);
            this.Controls.Add(this.numericUpDown7);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.seatNumericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.releaseDate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ShowTime);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TBDescription);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TBTitle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.contactNum);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DeleteCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CreateCustomer);
            this.Controls.Add(this.LBFullCustomer);
            this.Controls.Add(this.DeleteRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CreateRoom);
            this.Controls.Add(this.LBFullRooms);
            this.Controls.Add(this.DeleteMovie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateMovie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBFullMovies);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatNumericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBFullMovies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateMovie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteMovie;
        private System.Windows.Forms.ListBox LBFullRooms;
        private System.Windows.Forms.Button DeleteRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateRoom;
        private System.Windows.Forms.ListBox LBFullCustomer;
        private System.Windows.Forms.Button DeleteCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox contactNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TBTitle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TBDescription;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker ShowTime;
        private System.Windows.Forms.DateTimePicker releaseDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown seatNumericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.Label label18;
    }
}