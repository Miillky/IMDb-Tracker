
namespace IMDbTrackerUI {
    partial class ProfileForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.ShowNewPasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.ShowRepeatNewPasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.apiKeyValidateErrorLabel = new System.Windows.Forms.Label();
            this.repeatNewPasswordValidateErrorLabel = new System.Windows.Forms.Label();
            this.newPasswordValidateErrorLabel = new System.Windows.Forms.Label();
            this.emailValidateErrorLabel = new System.Windows.Forms.Label();
            this.lastNameValidateErrorLabel = new System.Windows.Forms.Label();
            this.firstNameValidateErrorLabel = new System.Windows.Forms.Label();
            this.apiKeyTextBox = new System.Windows.Forms.TextBox();
            this.apiKeyLabel = new System.Windows.Forms.Label();
            this.UpdateProfileButton = new System.Windows.Forms.Button();
            this.repeatNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.repeatNewPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.IMDbLogoImage = new System.Windows.Forms.PictureBox();
            this.ForgotPasswordLabel = new System.Windows.Forms.Label();
            this.currentPasswordValidateErrorLabel = new System.Windows.Forms.Label();
            this.currentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.currentPasswordLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IMDbLogoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowNewPasswordCheckbox
            // 
            this.ShowNewPasswordCheckbox.AutoSize = true;
            this.ShowNewPasswordCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowNewPasswordCheckbox.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.ShowNewPasswordCheckbox.Location = new System.Drawing.Point(295, 495);
            this.ShowNewPasswordCheckbox.Name = "ShowNewPasswordCheckbox";
            this.ShowNewPasswordCheckbox.Size = new System.Drawing.Size(44, 15);
            this.ShowNewPasswordCheckbox.TabIndex = 0;
            this.ShowNewPasswordCheckbox.Text = "Show";
            this.ShowNewPasswordCheckbox.UseVisualStyleBackColor = true;
            this.ShowNewPasswordCheckbox.CheckedChanged += new System.EventHandler(this.ShowNewPasswordCheckbox_CheckedChanged);
            // 
            // ShowRepeatNewPasswordCheckbox
            // 
            this.ShowRepeatNewPasswordCheckbox.AutoSize = true;
            this.ShowRepeatNewPasswordCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowRepeatNewPasswordCheckbox.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.ShowRepeatNewPasswordCheckbox.Location = new System.Drawing.Point(295, 570);
            this.ShowRepeatNewPasswordCheckbox.Name = "ShowRepeatNewPasswordCheckbox";
            this.ShowRepeatNewPasswordCheckbox.Size = new System.Drawing.Size(44, 15);
            this.ShowRepeatNewPasswordCheckbox.TabIndex = 0;
            this.ShowRepeatNewPasswordCheckbox.Text = "Show";
            this.ShowRepeatNewPasswordCheckbox.UseVisualStyleBackColor = true;
            this.ShowRepeatNewPasswordCheckbox.CheckedChanged += new System.EventHandler(this.ShowNewRepeatPasswordCheckbox_CheckedChanged);
            // 
            // apiKeyValidateErrorLabel
            // 
            this.apiKeyValidateErrorLabel.AutoSize = true;
            this.apiKeyValidateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.apiKeyValidateErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apiKeyValidateErrorLabel.Location = new System.Drawing.Point(40, 690);
            this.apiKeyValidateErrorLabel.Name = "apiKeyValidateErrorLabel";
            this.apiKeyValidateErrorLabel.Size = new System.Drawing.Size(106, 13);
            this.apiKeyValidateErrorLabel.TabIndex = 0;
            this.apiKeyValidateErrorLabel.Text = "apiKeyValidateError";
            this.apiKeyValidateErrorLabel.Visible = false;
            // 
            // repeatNewPasswordValidateErrorLabel
            // 
            this.repeatNewPasswordValidateErrorLabel.AutoSize = true;
            this.repeatNewPasswordValidateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.repeatNewPasswordValidateErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.repeatNewPasswordValidateErrorLabel.Location = new System.Drawing.Point(40, 615);
            this.repeatNewPasswordValidateErrorLabel.Name = "repeatNewPasswordValidateErrorLabel";
            this.repeatNewPasswordValidateErrorLabel.Size = new System.Drawing.Size(178, 13);
            this.repeatNewPasswordValidateErrorLabel.TabIndex = 0;
            this.repeatNewPasswordValidateErrorLabel.Text = "repeatNewPasswordValidateError";
            this.repeatNewPasswordValidateErrorLabel.Visible = false;
            // 
            // newPasswordValidateErrorLabel
            // 
            this.newPasswordValidateErrorLabel.AutoSize = true;
            this.newPasswordValidateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.newPasswordValidateErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.newPasswordValidateErrorLabel.Location = new System.Drawing.Point(40, 540);
            this.newPasswordValidateErrorLabel.Name = "newPasswordValidateErrorLabel";
            this.newPasswordValidateErrorLabel.Size = new System.Drawing.Size(144, 13);
            this.newPasswordValidateErrorLabel.TabIndex = 0;
            this.newPasswordValidateErrorLabel.Text = "newPasswordValidateError";
            this.newPasswordValidateErrorLabel.Visible = false;
            // 
            // emailValidateErrorLabel
            // 
            this.emailValidateErrorLabel.AutoSize = true;
            this.emailValidateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.emailValidateErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emailValidateErrorLabel.Location = new System.Drawing.Point(40, 390);
            this.emailValidateErrorLabel.Name = "emailValidateErrorLabel";
            this.emailValidateErrorLabel.Size = new System.Drawing.Size(100, 13);
            this.emailValidateErrorLabel.TabIndex = 0;
            this.emailValidateErrorLabel.Text = "emailValidateError";
            this.emailValidateErrorLabel.Visible = false;
            // 
            // lastNameValidateErrorLabel
            // 
            this.lastNameValidateErrorLabel.AutoSize = true;
            this.lastNameValidateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lastNameValidateErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lastNameValidateErrorLabel.Location = new System.Drawing.Point(40, 315);
            this.lastNameValidateErrorLabel.Name = "lastNameValidateErrorLabel";
            this.lastNameValidateErrorLabel.Size = new System.Drawing.Size(120, 13);
            this.lastNameValidateErrorLabel.TabIndex = 0;
            this.lastNameValidateErrorLabel.Text = "lastNameValidateError";
            this.lastNameValidateErrorLabel.Visible = false;
            // 
            // firstNameValidateErrorLabel
            // 
            this.firstNameValidateErrorLabel.AutoSize = true;
            this.firstNameValidateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.firstNameValidateErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.firstNameValidateErrorLabel.Location = new System.Drawing.Point(40, 240);
            this.firstNameValidateErrorLabel.Name = "firstNameValidateErrorLabel";
            this.firstNameValidateErrorLabel.Size = new System.Drawing.Size(122, 13);
            this.firstNameValidateErrorLabel.TabIndex = 0;
            this.firstNameValidateErrorLabel.Text = "firstNameValidateError";
            this.firstNameValidateErrorLabel.Visible = false;
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.BackColor = System.Drawing.Color.White;
            this.apiKeyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apiKeyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.apiKeyTextBox.Location = new System.Drawing.Point(40, 660);
            this.apiKeyTextBox.MaxLength = 150;
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.Size = new System.Drawing.Size(300, 29);
            this.apiKeyTextBox.TabIndex = 7;
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.BackColor = System.Drawing.Color.Transparent;
            this.apiKeyLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.apiKeyLabel.Location = new System.Drawing.Point(40, 635);
            this.apiKeyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(84, 25);
            this.apiKeyLabel.TabIndex = 0;
            this.apiKeyLabel.Text = "API key:";
            // 
            // UpdateProfileButton
            // 
            this.UpdateProfileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))));
            this.UpdateProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateProfileButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProfileButton.Location = new System.Drawing.Point(40, 720);
            this.UpdateProfileButton.Margin = new System.Windows.Forms.Padding(0);
            this.UpdateProfileButton.Name = "UpdateProfileButton";
            this.UpdateProfileButton.Size = new System.Drawing.Size(300, 60);
            this.UpdateProfileButton.TabIndex = 8;
            this.UpdateProfileButton.Text = "Update";
            this.UpdateProfileButton.UseVisualStyleBackColor = false;
            this.UpdateProfileButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // repeatNewPasswordTextBox
            // 
            this.repeatNewPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.repeatNewPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repeatNewPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.repeatNewPasswordTextBox.Location = new System.Drawing.Point(40, 585);
            this.repeatNewPasswordTextBox.MaxLength = 150;
            this.repeatNewPasswordTextBox.Name = "repeatNewPasswordTextBox";
            this.repeatNewPasswordTextBox.Size = new System.Drawing.Size(300, 29);
            this.repeatNewPasswordTextBox.TabIndex = 6;
            this.repeatNewPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // repeatNewPasswordLabel
            // 
            this.repeatNewPasswordLabel.AutoSize = true;
            this.repeatNewPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.repeatNewPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.repeatNewPasswordLabel.Location = new System.Drawing.Point(40, 558);
            this.repeatNewPasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.repeatNewPasswordLabel.Name = "repeatNewPasswordLabel";
            this.repeatNewPasswordLabel.Size = new System.Drawing.Size(210, 25);
            this.repeatNewPasswordLabel.TabIndex = 0;
            this.repeatNewPasswordLabel.Text = "Repeat new password:";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.newPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.newPasswordTextBox.Location = new System.Drawing.Point(40, 510);
            this.newPasswordTextBox.MaxLength = 150;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(300, 29);
            this.newPasswordTextBox.TabIndex = 5;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.newPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.newPasswordLabel.Location = new System.Drawing.Point(40, 485);
            this.newPasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(147, 25);
            this.newPasswordLabel.TabIndex = 0;
            this.newPasswordLabel.Text = "New password:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.White;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailTextBox.Location = new System.Drawing.Point(40, 360);
            this.emailTextBox.MaxLength = 150;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(300, 29);
            this.emailTextBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.emailLabel.Location = new System.Drawing.Point(40, 335);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(72, 25);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "E-mail:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.White;
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lastNameTextBox.Location = new System.Drawing.Point(40, 285);
            this.lastNameTextBox.MaxLength = 150;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(300, 29);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lastNameLabel.Location = new System.Drawing.Point(40, 260);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(106, 25);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.White;
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.firstNameTextBox.Location = new System.Drawing.Point(40, 210);
            this.firstNameTextBox.MaxLength = 150;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(300, 29);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.firstNameLabel.Location = new System.Drawing.Point(40, 185);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(109, 25);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First name:";
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
            this.IMDbLogoImage.TabIndex = 25;
            this.IMDbLogoImage.TabStop = false;
            // 
            // ForgotPasswordLabel
            // 
            this.ForgotPasswordLabel.AutoSize = true;
            this.ForgotPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.ForgotPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPasswordLabel.Enabled = false;
            this.ForgotPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ForgotPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(108)))), ((int)(((byte)(178)))));
            this.ForgotPasswordLabel.Location = new System.Drawing.Point(240, 420);
            this.ForgotPasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            this.ForgotPasswordLabel.Size = new System.Drawing.Size(100, 13);
            this.ForgotPasswordLabel.TabIndex = 0;
            this.ForgotPasswordLabel.Text = "Forgot password?";
            this.ForgotPasswordLabel.Visible = false;
            this.ForgotPasswordLabel.Click += new System.EventHandler(this.ForgotPasswordLabel_Click);
            // 
            // currentPasswordValidateErrorLabel
            // 
            this.currentPasswordValidateErrorLabel.AutoSize = true;
            this.currentPasswordValidateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.currentPasswordValidateErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.currentPasswordValidateErrorLabel.Location = new System.Drawing.Point(40, 465);
            this.currentPasswordValidateErrorLabel.Name = "currentPasswordValidateErrorLabel";
            this.currentPasswordValidateErrorLabel.Size = new System.Drawing.Size(159, 13);
            this.currentPasswordValidateErrorLabel.TabIndex = 0;
            this.currentPasswordValidateErrorLabel.Text = "currentPasswordValidateError";
            this.currentPasswordValidateErrorLabel.Visible = false;
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.currentPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.currentPasswordTextBox.Location = new System.Drawing.Point(40, 435);
            this.currentPasswordTextBox.MaxLength = 150;
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.Size = new System.Drawing.Size(300, 29);
            this.currentPasswordTextBox.TabIndex = 0;
            this.currentPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // currentPasswordLabel
            // 
            this.currentPasswordLabel.AutoSize = true;
            this.currentPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.currentPasswordLabel.Location = new System.Drawing.Point(40, 410);
            this.currentPasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.currentPasswordLabel.Name = "currentPasswordLabel";
            this.currentPasswordLabel.Size = new System.Drawing.Size(176, 25);
            this.currentPasswordLabel.TabIndex = 0;
            this.currentPasswordLabel.Text = "Current password:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))));
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(40, 790);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(300, 60);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(384, 861);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ForgotPasswordLabel);
            this.Controls.Add(this.currentPasswordValidateErrorLabel);
            this.Controls.Add(this.currentPasswordTextBox);
            this.Controls.Add(this.currentPasswordLabel);
            this.Controls.Add(this.ShowNewPasswordCheckbox);
            this.Controls.Add(this.ShowRepeatNewPasswordCheckbox);
            this.Controls.Add(this.apiKeyValidateErrorLabel);
            this.Controls.Add(this.repeatNewPasswordValidateErrorLabel);
            this.Controls.Add(this.newPasswordValidateErrorLabel);
            this.Controls.Add(this.emailValidateErrorLabel);
            this.Controls.Add(this.lastNameValidateErrorLabel);
            this.Controls.Add(this.firstNameValidateErrorLabel);
            this.Controls.Add(this.apiKeyTextBox);
            this.Controls.Add(this.apiKeyLabel);
            this.Controls.Add(this.UpdateProfileButton);
            this.Controls.Add(this.repeatNewPasswordTextBox);
            this.Controls.Add(this.repeatNewPasswordLabel);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.IMDbLogoImage);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 900);
            this.MinimumSize = new System.Drawing.Size(400, 850);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDb Tracker - Profile";
            ((System.ComponentModel.ISupportInitialize)(this.IMDbLogoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ShowNewPasswordCheckbox;
        private System.Windows.Forms.CheckBox ShowRepeatNewPasswordCheckbox;
        private System.Windows.Forms.Label apiKeyValidateErrorLabel;
        private System.Windows.Forms.Label repeatNewPasswordValidateErrorLabel;
        private System.Windows.Forms.Label newPasswordValidateErrorLabel;
        private System.Windows.Forms.Label emailValidateErrorLabel;
        private System.Windows.Forms.Label lastNameValidateErrorLabel;
        private System.Windows.Forms.Label firstNameValidateErrorLabel;
        private System.Windows.Forms.TextBox apiKeyTextBox;
        private System.Windows.Forms.Label apiKeyLabel;
        private System.Windows.Forms.Button UpdateProfileButton;
        private System.Windows.Forms.TextBox repeatNewPasswordTextBox;
        private System.Windows.Forms.Label repeatNewPasswordLabel;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.PictureBox IMDbLogoImage;
        private System.Windows.Forms.Label ForgotPasswordLabel;
        private System.Windows.Forms.Label currentPasswordValidateErrorLabel;
        private System.Windows.Forms.TextBox currentPasswordTextBox;
        private System.Windows.Forms.Label currentPasswordLabel;
        private System.Windows.Forms.Button DeleteButton;
    }
}