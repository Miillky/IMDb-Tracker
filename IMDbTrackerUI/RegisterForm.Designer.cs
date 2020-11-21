namespace IMDbTrackerUI {
    partial class RegisterForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.IMDbLogoImage = new System.Windows.Forms.PictureBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.apiKeyTextBox = new System.Windows.Forms.TextBox();
            this.apiKeyLabel = new System.Windows.Forms.Label();
            this.usernameValidateErrorLabel = new System.Windows.Forms.Label();
            this.firstNameValidateErrorLabel = new System.Windows.Forms.Label();
            this.lastNameValidateErrorLabel = new System.Windows.Forms.Label();
            this.emailValidateErrorLabel = new System.Windows.Forms.Label();
            this.passwordValidateErrorLabel = new System.Windows.Forms.Label();
            this.repeatPasswordValidateErrorLabel = new System.Windows.Forms.Label();
            this.apiKeyValidateErrorLabel = new System.Windows.Forms.Label();
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
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.Color.White;
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.userNameTextBox.Location = new System.Drawing.Point(40, 210);
            this.userNameTextBox.MaxLength = 150;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(300, 29);
            this.userNameTextBox.TabIndex = 1;
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
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.White;
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.firstNameTextBox.Location = new System.Drawing.Point(40, 285);
            this.firstNameTextBox.MaxLength = 150;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(300, 29);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.firstNameLabel.Location = new System.Drawing.Point(40, 260);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(109, 25);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.White;
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lastNameTextBox.Location = new System.Drawing.Point(40, 360);
            this.lastNameTextBox.MaxLength = 150;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(300, 29);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lastNameLabel.Location = new System.Drawing.Point(40, 335);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(106, 25);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last name:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.White;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailTextBox.Location = new System.Drawing.Point(40, 435);
            this.emailTextBox.MaxLength = 150;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(300, 29);
            this.emailTextBox.TabIndex = 4;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.emailLabel.Location = new System.Drawing.Point(40, 410);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(72, 25);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "E-mail:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(40, 510);
            this.passwordTextBox.MaxLength = 150;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(300, 29);
            this.passwordTextBox.TabIndex = 5;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.Location = new System.Drawing.Point(40, 485);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(102, 25);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password:";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.repeatPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repeatPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(40, 585);
            this.repeatPasswordTextBox.MaxLength = 150;
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(300, 29);
            this.repeatPasswordTextBox.TabIndex = 6;
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.repeatPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.repeatPasswordLabel.Location = new System.Drawing.Point(40, 560);
            this.repeatPasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(163, 25);
            this.repeatPasswordLabel.TabIndex = 0;
            this.repeatPasswordLabel.Text = "Repeat password";
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
            this.registerButton.Location = new System.Drawing.Point(45, 720);
            this.registerButton.Margin = new System.Windows.Forms.Padding(0);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(300, 60);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
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
            this.apiKeyLabel.Size = new System.Drawing.Size(79, 25);
            this.apiKeyLabel.TabIndex = 8;
            this.apiKeyLabel.Text = "API key";
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
            // firstNameValidateErrorLabel
            // 
            this.firstNameValidateErrorLabel.AutoSize = true;
            this.firstNameValidateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.firstNameValidateErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.firstNameValidateErrorLabel.Location = new System.Drawing.Point(40, 315);
            this.firstNameValidateErrorLabel.Name = "firstNameValidateErrorLabel";
            this.firstNameValidateErrorLabel.Size = new System.Drawing.Size(122, 13);
            this.firstNameValidateErrorLabel.TabIndex = 0;
            this.firstNameValidateErrorLabel.Text = "firstNameValidateError";
            this.firstNameValidateErrorLabel.Visible = false;
            // 
            // lastNameValidateErrorLabel
            // 
            this.lastNameValidateErrorLabel.AutoSize = true;
            this.lastNameValidateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lastNameValidateErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lastNameValidateErrorLabel.Location = new System.Drawing.Point(40, 390);
            this.lastNameValidateErrorLabel.Name = "lastNameValidateErrorLabel";
            this.lastNameValidateErrorLabel.Size = new System.Drawing.Size(120, 13);
            this.lastNameValidateErrorLabel.TabIndex = 0;
            this.lastNameValidateErrorLabel.Text = "lastNameValidateError";
            this.lastNameValidateErrorLabel.Visible = false;
            // 
            // emailValidateErrorLabel
            // 
            this.emailValidateErrorLabel.AutoSize = true;
            this.emailValidateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.emailValidateErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emailValidateErrorLabel.Location = new System.Drawing.Point(40, 465);
            this.emailValidateErrorLabel.Name = "emailValidateErrorLabel";
            this.emailValidateErrorLabel.Size = new System.Drawing.Size(100, 13);
            this.emailValidateErrorLabel.TabIndex = 0;
            this.emailValidateErrorLabel.Text = "emailValidateError";
            this.emailValidateErrorLabel.Visible = false;
            // 
            // passwordValidateErrorLabel
            // 
            this.passwordValidateErrorLabel.AutoSize = true;
            this.passwordValidateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.passwordValidateErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordValidateErrorLabel.Location = new System.Drawing.Point(40, 540);
            this.passwordValidateErrorLabel.Name = "passwordValidateErrorLabel";
            this.passwordValidateErrorLabel.Size = new System.Drawing.Size(123, 13);
            this.passwordValidateErrorLabel.TabIndex = 0;
            this.passwordValidateErrorLabel.Text = "passwordValidateError";
            this.passwordValidateErrorLabel.Visible = false;
            // 
            // repeatPasswordValidateErrorLabel
            // 
            this.repeatPasswordValidateErrorLabel.AutoSize = true;
            this.repeatPasswordValidateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.repeatPasswordValidateErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.repeatPasswordValidateErrorLabel.Location = new System.Drawing.Point(40, 615);
            this.repeatPasswordValidateErrorLabel.Name = "repeatPasswordValidateErrorLabel";
            this.repeatPasswordValidateErrorLabel.Size = new System.Drawing.Size(155, 13);
            this.repeatPasswordValidateErrorLabel.TabIndex = 0;
            this.repeatPasswordValidateErrorLabel.Text = "repeatPasswordValidateError";
            this.repeatPasswordValidateErrorLabel.Visible = false;
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
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(384, 811);
            this.Controls.Add(this.apiKeyValidateErrorLabel);
            this.Controls.Add(this.repeatPasswordValidateErrorLabel);
            this.Controls.Add(this.passwordValidateErrorLabel);
            this.Controls.Add(this.emailValidateErrorLabel);
            this.Controls.Add(this.lastNameValidateErrorLabel);
            this.Controls.Add(this.firstNameValidateErrorLabel);
            this.Controls.Add(this.usernameValidateErrorLabel);
            this.Controls.Add(this.apiKeyTextBox);
            this.Controls.Add(this.apiKeyLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.IMDbLogoImage);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 850);
            this.MinimumSize = new System.Drawing.Size(400, 850);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDb Tracker - Register";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IMDbLogoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IMDbLogoImage;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox apiKeyTextBox;
        private System.Windows.Forms.Label apiKeyLabel;
        private System.Windows.Forms.Label usernameValidateErrorLabel;
        private System.Windows.Forms.Label firstNameValidateErrorLabel;
        private System.Windows.Forms.Label lastNameValidateErrorLabel;
        private System.Windows.Forms.Label emailValidateErrorLabel;
        private System.Windows.Forms.Label passwordValidateErrorLabel;
        private System.Windows.Forms.Label repeatPasswordValidateErrorLabel;
        private System.Windows.Forms.Label apiKeyValidateErrorLabel;
    }
}