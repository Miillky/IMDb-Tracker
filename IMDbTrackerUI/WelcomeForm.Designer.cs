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
            this.welcomeIMDbLogoImage = new System.Windows.Forms.PictureBox();
            this.welcomeLogInButton = new System.Windows.Forms.Button();
            this.welcomeSingUpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeIMDbLogoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeIMDbLogoImage
            // 
            this.welcomeIMDbLogoImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeIMDbLogoImage.BackColor = System.Drawing.Color.Transparent;
            this.welcomeIMDbLogoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.welcomeIMDbLogoImage.Image = global::IMDbTrackerUI.Properties.Resources.IMDb_black_logo;
            this.welcomeIMDbLogoImage.ImageLocation = "";
            this.welcomeIMDbLogoImage.Location = new System.Drawing.Point(45, 35);
            this.welcomeIMDbLogoImage.Margin = new System.Windows.Forms.Padding(0);
            this.welcomeIMDbLogoImage.Name = "welcomeIMDbLogoImage";
            this.welcomeIMDbLogoImage.Size = new System.Drawing.Size(300, 125);
            this.welcomeIMDbLogoImage.TabIndex = 0;
            this.welcomeIMDbLogoImage.TabStop = false;
            // 
            // welcomeLogInButton
            // 
            this.welcomeLogInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))));
            this.welcomeLogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.welcomeLogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.welcomeLogInButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLogInButton.Location = new System.Drawing.Point(45, 190);
            this.welcomeLogInButton.Margin = new System.Windows.Forms.Padding(0);
            this.welcomeLogInButton.Name = "welcomeLogInButton";
            this.welcomeLogInButton.Size = new System.Drawing.Size(300, 60);
            this.welcomeLogInButton.TabIndex = 1;
            this.welcomeLogInButton.Text = "Log in";
            this.welcomeLogInButton.UseVisualStyleBackColor = false;
            this.welcomeLogInButton.Click += new System.EventHandler(this.welcomeLogInButton_Click);
            // 
            // welcomeSingUpButton
            // 
            this.welcomeSingUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeSingUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))));
            this.welcomeSingUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.welcomeSingUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.welcomeSingUpButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeSingUpButton.Location = new System.Drawing.Point(45, 265);
            this.welcomeSingUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.welcomeSingUpButton.Name = "welcomeSingUpButton";
            this.welcomeSingUpButton.Size = new System.Drawing.Size(300, 60);
            this.welcomeSingUpButton.TabIndex = 2;
            this.welcomeSingUpButton.Text = "Sing up";
            this.welcomeSingUpButton.UseVisualStyleBackColor = false;
            this.welcomeSingUpButton.Click += new System.EventHandler(this.welcomeSingUpButton_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.welcomeSingUpButton);
            this.Controls.Add(this.welcomeLogInButton);
            this.Controls.Add(this.welcomeIMDbLogoImage);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to IMDB Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.welcomeIMDbLogoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox welcomeIMDbLogoImage;
        private System.Windows.Forms.Button welcomeLogInButton;
        private System.Windows.Forms.Button welcomeSingUpButton;
    }
}