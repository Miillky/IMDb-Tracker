namespace IMDbTrackerUI {
    partial class LogInForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.IMDbLogoImage = new System.Windows.Forms.PictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.logInPasswordLabel = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.usernameValidateErrorLabel = new System.Windows.Forms.Label();
            this.passwordValidateErrorLabel = new System.Windows.Forms.Label();
            this.ForgotPasswordLabel = new System.Windows.Forms.Label();
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
            this.IMDbLogoImage.Location = new System.Drawing.Point(40, 35);
            this.IMDbLogoImage.Margin = new System.Windows.Forms.Padding(0);
            this.IMDbLogoImage.Name = "IMDbLogoImage";
            this.IMDbLogoImage.Size = new System.Drawing.Size(300, 125);
            this.IMDbLogoImage.TabIndex = 1;
            this.IMDbLogoImage.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.userNameLabel.Location = new System.Drawing.Point(40, 185);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(106, 25);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.White;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameTextBox.Location = new System.Drawing.Point(40, 210);
            this.usernameTextBox.MaxLength = 150;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(300, 29);
            this.usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(40, 285);
            this.passwordTextBox.MaxLength = 150;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(300, 29);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // logInPasswordLabel
            // 
            this.logInPasswordLabel.AutoSize = true;
            this.logInPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.logInPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.logInPasswordLabel.Location = new System.Drawing.Point(40, 260);
            this.logInPasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.logInPasswordLabel.Name = "logInPasswordLabel";
            this.logInPasswordLabel.Size = new System.Drawing.Size(102, 25);
            this.logInPasswordLabel.TabIndex = 3;
            this.logInPasswordLabel.Text = "Password:";
            // 
            // LogInButton
            // 
            this.LogInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))));
            this.LogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogInButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.Location = new System.Drawing.Point(40, 340);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(0);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(300, 60);
            this.LogInButton.TabIndex = 3;
            this.LogInButton.Text = "Log in";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // usernameValidateErrorLabel
            // 
            this.usernameValidateErrorLabel.AutoSize = true;
            this.usernameValidateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.usernameValidateErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usernameValidateErrorLabel.Location = new System.Drawing.Point(40, 240);
            this.usernameValidateErrorLabel.Name = "usernameValidateErrorLabel";
            this.usernameValidateErrorLabel.Size = new System.Drawing.Size(123, 13);
            this.usernameValidateErrorLabel.TabIndex = 0;
            this.usernameValidateErrorLabel.Text = "usernameValidateError";
            this.usernameValidateErrorLabel.Visible = false;
            // 
            // passwordValidateErrorLabel
            // 
            this.passwordValidateErrorLabel.AutoSize = true;
            this.passwordValidateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.passwordValidateErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordValidateErrorLabel.Location = new System.Drawing.Point(40, 315);
            this.passwordValidateErrorLabel.Name = "passwordValidateErrorLabel";
            this.passwordValidateErrorLabel.Size = new System.Drawing.Size(123, 13);
            this.passwordValidateErrorLabel.TabIndex = 0;
            this.passwordValidateErrorLabel.Text = "passwordValidateError";
            this.passwordValidateErrorLabel.Visible = false;
            // 
            // ForgotPasswordLabel
            // 
            this.ForgotPasswordLabel.AutoSize = true;
            this.ForgotPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.ForgotPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPasswordLabel.Enabled = false;
            this.ForgotPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ForgotPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(108)))), ((int)(((byte)(178)))));
            this.ForgotPasswordLabel.Location = new System.Drawing.Point(240, 268);
            this.ForgotPasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            this.ForgotPasswordLabel.Size = new System.Drawing.Size(100, 13);
            this.ForgotPasswordLabel.TabIndex = 0;
            this.ForgotPasswordLabel.Text = "Forgot password?";
            this.ForgotPasswordLabel.Visible = false;
            this.ForgotPasswordLabel.Click += new System.EventHandler(this.ForgotPasswordLabel_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.ForgotPasswordLabel);
            this.Controls.Add(this.passwordValidateErrorLabel);
            this.Controls.Add(this.usernameValidateErrorLabel);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.logInPasswordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.IMDbLogoImage);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 450);
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDb Tracker - Log In";
            ((System.ComponentModel.ISupportInitialize)(this.IMDbLogoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IMDbLogoImage;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label logInPasswordLabel;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label usernameValidateErrorLabel;
        private System.Windows.Forms.Label passwordValidateErrorLabel;
        private System.Windows.Forms.Label ForgotPasswordLabel;
    }
}