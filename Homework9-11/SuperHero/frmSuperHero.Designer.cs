namespace SuperHero
{
    partial class frmSuperHero
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
            this.ddlSuperHero = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAlterEgo = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.pbSuperHero = new System.Windows.Forms.PictureBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuperHero)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlSuperHero
            // 
            this.ddlSuperHero.FormattingEnabled = true;
            this.ddlSuperHero.Location = new System.Drawing.Point(56, 60);
            this.ddlSuperHero.Name = "ddlSuperHero";
            this.ddlSuperHero.Size = new System.Drawing.Size(184, 28);
            this.ddlSuperHero.TabIndex = 0;
            this.ddlSuperHero.SelectedIndexChanged += new System.EventHandler(this.ddlSuperHero_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(52, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(188, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblAlterEgo
            // 
            this.lblAlterEgo.Location = new System.Drawing.Point(52, 157);
            this.lblAlterEgo.Name = "lblAlterEgo";
            this.lblAlterEgo.Size = new System.Drawing.Size(188, 23);
            this.lblAlterEgo.TabIndex = 2;
            this.lblAlterEgo.Text = "Alter Ego:";
            // 
            // lblBio
            // 
            this.lblBio.Location = new System.Drawing.Point(52, 200);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(188, 186);
            this.lblBio.TabIndex = 3;
            this.lblBio.Text = "Bio";
            // 
            // pbSuperHero
            // 
            this.pbSuperHero.Location = new System.Drawing.Point(339, 60);
            this.pbSuperHero.Name = "pbSuperHero";
            this.pbSuperHero.Size = new System.Drawing.Size(243, 265);
            this.pbSuperHero.TabIndex = 4;
            this.pbSuperHero.TabStop = false;
            // 
            // lblUrl
            // 
            this.lblUrl.Location = new System.Drawing.Point(335, 345);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(247, 23);
            this.lblUrl.TabIndex = 5;
            this.lblUrl.Text = "Url:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(339, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(449, 383);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmSuperHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.pbSuperHero);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.lblAlterEgo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.ddlSuperHero);
            this.Name = "frmSuperHero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Hero";
            this.Load += new System.EventHandler(this.frmSuperHero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSuperHero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlSuperHero;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAlterEgo;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.PictureBox pbSuperHero;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

