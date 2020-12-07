
namespace IMDbTrackerUI {
    partial class ResetPasswordForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            this.PasswordResetButton = new System.Windows.Forms.Button();
            this.IMDbLogoImage = new System.Windows.Forms.PictureBox();
            this.ShowPasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.ShowRepeatPasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.repeatPasswordValidateErrorLabel = new System.Windows.Forms.Label();
            this.passwordValidateErrorLabel = new System.Windows.Forms.Label();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IMDbLogoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordResetButton
            // 
            this.PasswordResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))));
            this.PasswordResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PasswordResetButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordResetButton.Location = new System.Drawing.Point(40, 340);
            this.PasswordResetButton.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordResetButton.Name = "PasswordResetButton";
            this.PasswordResetButton.Size = new System.Drawing.Size(300, 60);
            this.PasswordResetButton.TabIndex = 3;
            this.PasswordResetButton.Text = "Reset password";
            this.PasswordResetButton.UseVisualStyleBackColor = false;
            this.PasswordResetButton.Click += new System.EventHandler(this.PasswordResetButton_Click);
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
            this.IMDbLogoImage.TabIndex = 10;
            this.IMDbLogoImage.TabStop = false;
            // 
            // ShowPasswordCheckbox
            // 
            this.ShowPasswordCheckbox.AutoSize = true;
            this.ShowPasswordCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowPasswordCheckbox.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.ShowPasswordCheckbox.Location = new System.Drawing.Point(295, 195);
            this.ShowPasswordCheckbox.Name = "ShowPasswordCheckbox";
            this.ShowPasswordCheckbox.Size = new System.Drawing.Size(44, 15);
            this.ShowPasswordCheckbox.TabIndex = 0;
            this.ShowPasswordCheckbox.Text = "Show";
            this.ShowPasswordCheckbox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckbox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckbox_CheckedChanged);
            // 
            // ShowRepeatPasswordCheckbox
            // 
            this.ShowRepeatPasswordCheckbox.AutoSize = true;
            this.ShowRepeatPasswordCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowRepeatPasswordCheckbox.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.ShowRepeatPasswordCheckbox.Location = new System.Drawing.Point(295, 270);
            this.ShowRepeatPasswordCheckbox.Name = "ShowRepeatPasswordCheckbox";
            this.ShowRepeatPasswordCheckbox.Size = new System.Drawing.Size(44, 15);
            this.ShowRepeatPasswordCheckbox.TabIndex = 0;
            this.ShowRepeatPasswordCheckbox.Text = "Show";
            this.ShowRepeatPasswordCheckbox.UseVisualStyleBackColor = true;
            this.ShowRepeatPasswordCheckbox.CheckedChanged += new System.EventHandler(this.ShowRepeatPasswordCheckbox_CheckedChanged);
            // 
            // repeatPasswordValidateErrorLabel
            // 
            this.repeatPasswordValidateErrorLabel.AutoSize = true;
            this.repeatPasswordValidateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.repeatPasswordValidateErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.repeatPasswordValidateErrorLabel.Location = new System.Drawing.Point(40, 315);
            this.repeatPasswordValidateErrorLabel.Name = "repeatPasswordValidateErrorLabel";
            this.repeatPasswordValidateErrorLabel.Size = new System.Drawing.Size(155, 13);
            this.repeatPasswordValidateErrorLabel.TabIndex = 0;
            this.repeatPasswordValidateErrorLabel.Text = "repeatPasswordValidateError";
            this.repeatPasswordValidateErrorLabel.Visible = false;
            // 
            // passwordValidateErrorLabel
            // 
            this.passwordValidateErrorLabel.AutoSize = true;
            this.passwordValidateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.passwordValidateErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordValidateErrorLabel.Location = new System.Drawing.Point(40, 240);
            this.passwordValidateErrorLabel.Name = "passwordValidateErrorLabel";
            this.passwordValidateErrorLabel.Size = new System.Drawing.Size(123, 13);
            this.passwordValidateErrorLabel.TabIndex = 0;
            this.passwordValidateErrorLabel.Text = "passwordValidateError";
            this.passwordValidateErrorLabel.Visible = false;
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.repeatPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repeatPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(40, 285);
            this.repeatPasswordTextBox.MaxLength = 150;
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(300, 29);
            this.repeatPasswordTextBox.TabIndex = 2;
            this.repeatPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.repeatPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.repeatPasswordLabel.Location = new System.Drawing.Point(40, 260);
            this.repeatPasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(163, 25);
            this.repeatPasswordLabel.TabIndex = 0;
            this.repeatPasswordLabel.Text = "Repeat password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(40, 210);
            this.passwordTextBox.MaxLength = 150;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(300, 29);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.Location = new System.Drawing.Point(40, 185);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(102, 25);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password:";
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.ShowPasswordCheckbox);
            this.Controls.Add(this.ShowRepeatPasswordCheckbox);
            this.Controls.Add(this.repeatPasswordValidateErrorLabel);
            this.Controls.Add(this.passwordValidateErrorLabel);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.PasswordResetButton);
            this.Controls.Add(this.IMDbLogoImage);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 450);
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "ResetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDb Tracker - Password Reset";
            ((System.ComponentModel.ISupportInitialize)(this.IMDbLogoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PasswordResetButton;
        private System.Windows.Forms.PictureBox IMDbLogoImage;
        private System.Windows.Forms.CheckBox ShowPasswordCheckbox;
        private System.Windows.Forms.CheckBox ShowRepeatPasswordCheckbox;
        private System.Windows.Forms.Label repeatPasswordValidateErrorLabel;
        private System.Windows.Forms.Label passwordValidateErrorLabel;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
    }
}