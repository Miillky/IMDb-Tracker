namespace IMDbTrackerUI {
    partial class WelcomeForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.IMDbLogoImage = new System.Windows.Forms.PictureBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IMDbLogoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // IMDbLogoImage
            // 
            this.IMDbLogoImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IMDbLogoImage.BackColor = System.Drawing.Color.Transparent;
            this.IMDbLogoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IMDbLogoImage.Image = global::IMDbTrackerUI.Properties.Resources.IMDb_black_logo;
            this.IMDbLogoImage.ImageLocation = "";
            this.IMDbLogoImage.Location = new System.Drawing.Point(45, 35);
            this.IMDbLogoImage.Margin = new System.Windows.Forms.Padding(0);
            this.IMDbLogoImage.Name = "IMDbLogoImage";
            this.IMDbLogoImage.Size = new System.Drawing.Size(300, 125);
            this.IMDbLogoImage.TabIndex = 0;
            this.IMDbLogoImage.TabStop = false;
            // 
            // logInButton
            // 
            this.logInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))));
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logInButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(45, 190);
            this.logInButton.Margin = new System.Windows.Forms.Padding(0);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(300, 60);
            this.logInButton.TabIndex = 1;
            this.logInButton.Text = "Log in";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))));
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(45, 265);
            this.registerButton.Margin = new System.Windows.Forms.Padding(0);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(300, 60);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.IMDbLogoImage);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDb Tracker - Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.IMDbLogoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox IMDbLogoImage;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button registerButton;
    }
}