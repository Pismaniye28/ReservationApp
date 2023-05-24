namespace _201635037.GUI
{
    partial class ReservationForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.lblSeatNumber = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 184);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 181);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(347, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(30, 214);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(120, 211);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(347, 20);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(30, 244);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(120, 241);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(347, 20);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Location = new System.Drawing.Point(30, 274);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(59, 13);
            this.lblMovieTitle.TabIndex = 6;
            this.lblMovieTitle.Text = "Movie Title";
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(120, 271);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(347, 20);
            this.txtMovieTitle.TabIndex = 7;
            this.txtMovieTitle.TextChanged += new System.EventHandler(this.txtMovieTitle_TextChanged);
            // 
            // lblSeatNumber
            // 
            this.lblSeatNumber.AutoSize = true;
            this.lblSeatNumber.Location = new System.Drawing.Point(30, 326);
            this.lblSeatNumber.Name = "lblSeatNumber";
            this.lblSeatNumber.Size = new System.Drawing.Size(69, 13);
            this.lblSeatNumber.TabIndex = 8;
            this.lblSeatNumber.Text = "Seat Number";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(33, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(434, 74);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(458, 108);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 48);
            this.label1.TabIndex = 12;
            this.label1.Text = "Make Your Reservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Movie ID:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 350);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(347, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Reservation Time :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(120, 298);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(347, 20);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(120, 376);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(347, 20);
            this.numericUpDown2.TabIndex = 19;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Room ID:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(473, 60);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(332, 108);
            this.listBox2.TabIndex = 22;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(120, 324);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(347, 20);
            this.numericUpDown3.TabIndex = 23;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 510);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSeatNumber);
            this.Controls.Add(this.txtMovieTitle);
            this.Controls.Add(this.lblMovieTitle);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "ReservationForm";
            this.Text = "Reservation Form";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.Label lblSeatNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}