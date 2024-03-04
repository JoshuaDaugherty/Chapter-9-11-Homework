namespace SearchNames
{
    partial class frmSearchNames
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnFirstName = new System.Windows.Forms.Button();
            this.btnLastName = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.ddlFirstName = new System.Windows.Forms.ComboBox();
            this.ddlLastName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(140, 80);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(100, 23);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(436, 80);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFirstName
            // 
            this.btnFirstName.Location = new System.Drawing.Point(140, 175);
            this.btnFirstName.Name = "btnFirstName";
            this.btnFirstName.Size = new System.Drawing.Size(121, 66);
            this.btnFirstName.TabIndex = 4;
            this.btnFirstName.Text = "Search By First";
            this.btnFirstName.UseVisualStyleBackColor = true;
            this.btnFirstName.Click += new System.EventHandler(this.btnFirstName_Click);
            // 
            // btnLastName
            // 
            this.btnLastName.Location = new System.Drawing.Point(440, 175);
            this.btnLastName.Name = "btnLastName";
            this.btnLastName.Size = new System.Drawing.Size(121, 66);
            this.btnLastName.TabIndex = 5;
            this.btnLastName.Text = "Search By Last";
            this.btnLastName.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(140, 279);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(400, 129);
            this.lblResult.TabIndex = 6;
            // 
            // ddlFirstName
            // 
            this.ddlFirstName.FormattingEnabled = true;
            this.ddlFirstName.Location = new System.Drawing.Point(140, 124);
            this.ddlFirstName.Name = "ddlFirstName";
            this.ddlFirstName.Size = new System.Drawing.Size(121, 28);
            this.ddlFirstName.TabIndex = 7;
            // 
            // ddlLastName
            // 
            this.ddlLastName.FormattingEnabled = true;
            this.ddlLastName.Location = new System.Drawing.Point(440, 124);
            this.ddlLastName.Name = "ddlLastName";
            this.ddlLastName.Size = new System.Drawing.Size(121, 28);
            this.ddlLastName.TabIndex = 8;
            // 
            // frmSearchNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ddlLastName);
            this.Controls.Add(this.ddlFirstName);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnLastName);
            this.Controls.Add(this.btnFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "frmSearchNames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Name";
            this.Load += new System.EventHandler(this.frmSearchNames_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnFirstName;
        private System.Windows.Forms.Button btnLastName;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox ddlFirstName;
        private System.Windows.Forms.ComboBox ddlLastName;
    }
}

