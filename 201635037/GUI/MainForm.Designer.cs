namespace _201635037.GUI
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
            this.LBRooms = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LBMovies = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBRooms
            // 
            this.LBRooms.FormattingEnabled = true;
            this.LBRooms.Location = new System.Drawing.Point(326, 61);
            this.LBRooms.Name = "LBRooms";
            this.LBRooms.Size = new System.Drawing.Size(257, 225);
            this.LBRooms.TabIndex = 1;
            this.LBRooms.SelectedIndexChanged += new System.EventHandler(this.LBRooms_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cinema Reservation System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Make Reservation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(12, 339);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(570, 48);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 24);
            this.button3.TabIndex = 5;
            this.button3.Text = "Get Reservation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LBMovies
            // 
            this.LBMovies.FormattingEnabled = true;
            this.LBMovies.Location = new System.Drawing.Point(13, 61);
            this.LBMovies.Name = "LBMovies";
            this.LBMovies.Size = new System.Drawing.Size(300, 225);
            this.LBMovies.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer ID :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(462, 293);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 399);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBMovies);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBRooms);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox LBRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox LBMovies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}