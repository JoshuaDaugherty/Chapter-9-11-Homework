namespace Reservation
{
    partial class frmReservation
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
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNights = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblPriceNight = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPriceNights = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Location = new System.Drawing.Point(89, 82);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(84, 20);
            this.lblArrival.TabIndex = 0;
            this.lblArrival.Text = "Arrival Day";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(89, 220);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(87, 20);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Total Price:";
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Location = new System.Drawing.Point(89, 174);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(132, 20);
            this.lblNights.TabIndex = 2;
            this.lblNights.Text = "Number of Nights";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(89, 126);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(124, 20);
            this.lblDeparture.TabIndex = 3;
            this.lblDeparture.Text = "Departure Date:";
            // 
            // lblPriceNight
            // 
            this.lblPriceNight.AutoSize = true;
            this.lblPriceNight.Location = new System.Drawing.Point(89, 265);
            this.lblPriceNight.Name = "lblPriceNight";
            this.lblPriceNight.Size = new System.Drawing.Size(113, 20);
            this.lblPriceNight.TabIndex = 4;
            this.lblPriceNight.Text = "Price Per Night";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(301, 82);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(122, 26);
            this.txtDay.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(301, 217);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(122, 26);
            this.txtPrice.TabIndex = 6;
            // 
            // txtPriceNights
            // 
            this.txtPriceNights.Location = new System.Drawing.Point(301, 265);
            this.txtPriceNights.Name = "txtPriceNights";
            this.txtPriceNights.ReadOnly = true;
            this.txtPriceNights.Size = new System.Drawing.Size(122, 26);
            this.txtPriceNights.TabIndex = 7;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(301, 168);
            this.txtNights.Name = "txtNights";
            this.txtNights.ReadOnly = true;
            this.txtNights.Size = new System.Drawing.Size(122, 26);
            this.txtNights.TabIndex = 8;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(301, 126);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(122, 26);
            this.txtDate.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(93, 301);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(83, 44);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(93, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 44);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtPriceNights);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.lblPriceNight);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.lblNights);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblArrival);
            this.Name = "frmReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblPriceNight;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPriceNights;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

