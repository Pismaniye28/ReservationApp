namespace _201635037
{
    partial class ConfirmationForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.lblSeatNumber = new System.Windows.Forms.Label();
            this.lblReservationTimeLabel = new System.Windows.Forms.Label();
            this.lblReservationTime = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reservation Details";
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMovieTitle.Location = new System.Drawing.Point(12, 38);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(71, 15);
            this.lblMovieTitle.TabIndex = 1;
            this.lblMovieTitle.Text = "Movie Title: ";
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSeat.Location = new System.Drawing.Point(12, 63);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(57, 15);
            this.lblSeat.TabIndex = 2;
            this.lblSeat.Text = "Seat No.: ";
            // 
            // lblSeatNumber
            // 
            this.lblSeatNumber.AutoSize = true;
            this.lblSeatNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSeatNumber.Location = new System.Drawing.Point(74, 63);
            this.lblSeatNumber.Name = "lblSeatNumber";
            this.lblSeatNumber.Size = new System.Drawing.Size(39, 15);
            this.lblSeatNumber.TabIndex = 3;
            this.lblSeatNumber.Text = "Seat#";
            // 
            // lblReservationTimeLabel
            // 
            this.lblReservationTimeLabel.AutoSize = true;
            this.lblReservationTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReservationTimeLabel.Location = new System.Drawing.Point(12, 89);
            this.lblReservationTimeLabel.Name = "lblReservationTimeLabel";
            this.lblReservationTimeLabel.Size = new System.Drawing.Size(103, 15);
            this.lblReservationTimeLabel.TabIndex = 4;
            this.lblReservationTimeLabel.Text = "Reservation Time: ";
            // 
            // lblReservationTime
            // 
            this.lblReservationTime.AutoSize = true;
            this.lblReservationTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReservationTime.Location = new System.Drawing.Point(106, 89);
            this.lblReservationTime.Name = "lblReservationTime";
            this.lblReservationTime.Size = new System.Drawing.Size(105, 15);
            this.lblReservationTime.TabIndex = 5;
            this.lblReservationTime.Text = "Reservation Time";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOK.Location = new System.Drawing.Point(15, 117);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(199, 44);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 391);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblReservationTime);
            this.Controls.Add(this.lblReservationTimeLabel);
            this.Controls.Add(this.lblSeatNumber);
            this.Controls.Add(this.lblSeat);
            this.Controls.Add(this.lblMovieTitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Label lblSeatNumber;
        private System.Windows.Forms.Label lblReservationTimeLabel;
        private System.Windows.Forms.Label lblReservationTime;
        private System.Windows.Forms.Button btnOK;
    }
}