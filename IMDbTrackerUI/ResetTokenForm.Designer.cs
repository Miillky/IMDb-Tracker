
namespace IMDbTrackerUI {
    partial class ResetTokenForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetTokenForm));
            this.resetTokenValidateErrorLabel = new System.Windows.Forms.Label();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.resetTokenTextBox = new System.Windows.Forms.TextBox();
            this.resetTokenLabel = new System.Windows.Forms.Label();
            this.IMDbLogoImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IMDbLogoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // resetTokenValidateErrorLabel
            // 
            this.resetTokenValidateErrorLabel.AutoSize = true;
            this.resetTokenValidateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.resetTokenValidateErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetTokenValidateErrorLabel.Location = new System.Drawing.Point(40, 240);
            this.resetTokenValidateErrorLabel.Name = "resetTokenValidateErrorLabel";
            this.resetTokenValidateErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.resetTokenValidateErrorLabel.TabIndex = 0;
            this.resetTokenValidateErrorLabel.Text = "resetKeyValidateError";
            this.resetTokenValidateErrorLabel.Visible = false;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))));
            this.ChangePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangePasswordButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordButton.Location = new System.Drawing.Point(40, 280);
            this.ChangePasswordButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(300, 60);
            this.ChangePasswordButton.TabIndex = 2;
            this.ChangePasswordButton.Text = "Change password";
            this.ChangePasswordButton.UseVisualStyleBackColor = false;
            this.ChangePasswordButton.Click += new System.EventHandler(this.PasswordResetButton_Click);
            // 
            // resetTokenTextBox
            // 
            this.resetTokenTextBox.BackColor = System.Drawing.Color.White;
            this.resetTokenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resetTokenTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.resetTokenTextBox.Location = new System.Drawing.Point(40, 210);
            this.resetTokenTextBox.MaxLength = 150;
            this.resetTokenTextBox.Name = "resetTokenTextBox";
            this.resetTokenTextBox.Size = new System.Drawing.Size(300, 29);
            this.resetTokenTextBox.TabIndex = 1;
            // 
            // resetTokenLabel
            // 
            this.resetTokenLabel.AutoSize = true;
            this.resetTokenLabel.BackColor = System.Drawing.Color.Transparent;
            this.resetTokenLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.resetTokenLabel.Location = new System.Drawing.Point(40, 185);
            this.resetTokenLabel.Margin = new System.Windows.Forms.Padding(0);
            this.resetTokenLabel.Name = "resetTokenLabel";
            this.resetTokenLabel.Size = new System.Drawing.Size(121, 25);
            this.resetTokenLabel.TabIndex = 0;
            this.resetTokenLabel.Text = "Reset token:";
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
            // ResetTokenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.resetTokenValidateErrorLabel);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.resetTokenTextBox);
            this.Controls.Add(this.resetTokenLabel);
            this.Controls.Add(this.IMDbLogoImage);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "ResetTokenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDb Tracker - Reset Password Token";
            ((System.ComponentModel.ISupportInitialize)(this.IMDbLogoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label resetTokenValidateErrorLabel;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.TextBox resetTokenTextBox;
        private System.Windows.Forms.Label resetTokenLabel;
        private System.Windows.Forms.PictureBox IMDbLogoImage;
    }
}