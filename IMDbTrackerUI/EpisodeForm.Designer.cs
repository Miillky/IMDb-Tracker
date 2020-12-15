
namespace IMDbTrackerUI {
    partial class EpisodeForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EpisodeForm));
            this.episodeTitleLabel = new System.Windows.Forms.Label();
            this.episodeReleseDateLabel = new System.Windows.Forms.Label();
            this.episodeCoverPictureBox = new System.Windows.Forms.PictureBox();
            this.episodeGenresLabel = new System.Windows.Forms.Label();
            this.episodeRatingLabel = new System.Windows.Forms.Label();
            this.episodeRatingNumberLabel = new System.Windows.Forms.Label();
            this.episodePlotOutlineTextBox = new System.Windows.Forms.TextBox();
            this.episodeRunningTimeLabel = new System.Windows.Forms.Label();
            this.episodeRunningTimeMinutesLabel = new System.Windows.Forms.Label();
            this.episodeReleseDateDateLabel = new System.Windows.Forms.Label();
            this.episodeCommentTextBox = new System.Windows.Forms.TextBox();
            this.episodeCommentLabel = new System.Windows.Forms.Label();
            this.saveEpisodeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.episodeCoverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // episodeTitleLabel
            // 
            this.episodeTitleLabel.AutoSize = true;
            this.episodeTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.episodeTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.episodeTitleLabel.Location = new System.Drawing.Point(15, 30);
            this.episodeTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.episodeTitleLabel.MaximumSize = new System.Drawing.Size(350, 37);
            this.episodeTitleLabel.MinimumSize = new System.Drawing.Size(350, 37);
            this.episodeTitleLabel.Name = "episodeTitleLabel";
            this.episodeTitleLabel.Size = new System.Drawing.Size(350, 37);
            this.episodeTitleLabel.TabIndex = 0;
            // 
            // episodeReleseDateLabel
            // 
            this.episodeReleseDateLabel.AutoSize = true;
            this.episodeReleseDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.episodeReleseDateLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.episodeReleseDateLabel.Location = new System.Drawing.Point(15, 435);
            this.episodeReleseDateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.episodeReleseDateLabel.MaximumSize = new System.Drawing.Size(120, 30);
            this.episodeReleseDateLabel.MinimumSize = new System.Drawing.Size(120, 30);
            this.episodeReleseDateLabel.Name = "episodeReleseDateLabel";
            this.episodeReleseDateLabel.Size = new System.Drawing.Size(120, 30);
            this.episodeReleseDateLabel.TabIndex = 0;
            this.episodeReleseDateLabel.Text = "Relese date:";
            // 
            // episodeCoverPictureBox
            // 
            this.episodeCoverPictureBox.ErrorImage = global::IMDbTrackerUI.Properties.Resources.IMDb_yellow_logo;
            this.episodeCoverPictureBox.Image = global::IMDbTrackerUI.Properties.Resources.IMDb_yellow_logo;
            this.episodeCoverPictureBox.InitialImage = global::IMDbTrackerUI.Properties.Resources.IMDb_yellow_logo;
            this.episodeCoverPictureBox.Location = new System.Drawing.Point(15, 110);
            this.episodeCoverPictureBox.MaximumSize = new System.Drawing.Size(350, 320);
            this.episodeCoverPictureBox.MinimumSize = new System.Drawing.Size(350, 320);
            this.episodeCoverPictureBox.Name = "episodeCoverPictureBox";
            this.episodeCoverPictureBox.Size = new System.Drawing.Size(350, 320);
            this.episodeCoverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.episodeCoverPictureBox.TabIndex = 4;
            this.episodeCoverPictureBox.TabStop = false;
            // 
            // episodeGenresLabel
            // 
            this.episodeGenresLabel.AutoSize = true;
            this.episodeGenresLabel.BackColor = System.Drawing.Color.Transparent;
            this.episodeGenresLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.episodeGenresLabel.Location = new System.Drawing.Point(15, 70);
            this.episodeGenresLabel.Margin = new System.Windows.Forms.Padding(0);
            this.episodeGenresLabel.MaximumSize = new System.Drawing.Size(350, 30);
            this.episodeGenresLabel.MinimumSize = new System.Drawing.Size(350, 30);
            this.episodeGenresLabel.Name = "episodeGenresLabel";
            this.episodeGenresLabel.Size = new System.Drawing.Size(350, 30);
            this.episodeGenresLabel.TabIndex = 0;
            // 
            // episodeRatingLabel
            // 
            this.episodeRatingLabel.AutoSize = true;
            this.episodeRatingLabel.BackColor = System.Drawing.Color.Transparent;
            this.episodeRatingLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.episodeRatingLabel.Location = new System.Drawing.Point(15, 495);
            this.episodeRatingLabel.Margin = new System.Windows.Forms.Padding(0);
            this.episodeRatingLabel.MaximumSize = new System.Drawing.Size(75, 30);
            this.episodeRatingLabel.MinimumSize = new System.Drawing.Size(75, 30);
            this.episodeRatingLabel.Name = "episodeRatingLabel";
            this.episodeRatingLabel.Size = new System.Drawing.Size(75, 30);
            this.episodeRatingLabel.TabIndex = 0;
            this.episodeRatingLabel.Text = "Rating:";
            // 
            // episodeRatingNumberLabel
            // 
            this.episodeRatingNumberLabel.AutoSize = true;
            this.episodeRatingNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.episodeRatingNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.episodeRatingNumberLabel.Location = new System.Drawing.Point(90, 493);
            this.episodeRatingNumberLabel.Margin = new System.Windows.Forms.Padding(0);
            this.episodeRatingNumberLabel.MaximumSize = new System.Drawing.Size(75, 30);
            this.episodeRatingNumberLabel.MinimumSize = new System.Drawing.Size(75, 30);
            this.episodeRatingNumberLabel.Name = "episodeRatingNumberLabel";
            this.episodeRatingNumberLabel.Size = new System.Drawing.Size(75, 30);
            this.episodeRatingNumberLabel.TabIndex = 0;
            this.episodeRatingNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // episodePlotOutlineTextBox
            // 
            this.episodePlotOutlineTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.episodePlotOutlineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.episodePlotOutlineTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.episodePlotOutlineTextBox.ForeColor = System.Drawing.Color.Black;
            this.episodePlotOutlineTextBox.Location = new System.Drawing.Point(20, 525);
            this.episodePlotOutlineTextBox.MaximumSize = new System.Drawing.Size(340, 100);
            this.episodePlotOutlineTextBox.MinimumSize = new System.Drawing.Size(340, 100);
            this.episodePlotOutlineTextBox.Multiline = true;
            this.episodePlotOutlineTextBox.Name = "episodePlotOutlineTextBox";
            this.episodePlotOutlineTextBox.ReadOnly = true;
            this.episodePlotOutlineTextBox.Size = new System.Drawing.Size(340, 100);
            this.episodePlotOutlineTextBox.TabIndex = 0;
            // 
            // episodeRunningTimeLabel
            // 
            this.episodeRunningTimeLabel.AutoSize = true;
            this.episodeRunningTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.episodeRunningTimeLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.episodeRunningTimeLabel.Location = new System.Drawing.Point(15, 465);
            this.episodeRunningTimeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.episodeRunningTimeLabel.MaximumSize = new System.Drawing.Size(150, 30);
            this.episodeRunningTimeLabel.MinimumSize = new System.Drawing.Size(150, 30);
            this.episodeRunningTimeLabel.Name = "episodeRunningTimeLabel";
            this.episodeRunningTimeLabel.Size = new System.Drawing.Size(150, 30);
            this.episodeRunningTimeLabel.TabIndex = 0;
            this.episodeRunningTimeLabel.Text = "Runing time:";
            // 
            // episodeRunningTimeMinutesLabel
            // 
            this.episodeRunningTimeMinutesLabel.AutoSize = true;
            this.episodeRunningTimeMinutesLabel.BackColor = System.Drawing.Color.Transparent;
            this.episodeRunningTimeMinutesLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.episodeRunningTimeMinutesLabel.Location = new System.Drawing.Point(140, 463);
            this.episodeRunningTimeMinutesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.episodeRunningTimeMinutesLabel.MaximumSize = new System.Drawing.Size(75, 30);
            this.episodeRunningTimeMinutesLabel.MinimumSize = new System.Drawing.Size(75, 30);
            this.episodeRunningTimeMinutesLabel.Name = "episodeRunningTimeMinutesLabel";
            this.episodeRunningTimeMinutesLabel.Size = new System.Drawing.Size(75, 30);
            this.episodeRunningTimeMinutesLabel.TabIndex = 0;
            this.episodeRunningTimeMinutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // episodeReleseDateDateLabel
            // 
            this.episodeReleseDateDateLabel.AutoSize = true;
            this.episodeReleseDateDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.episodeReleseDateDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.episodeReleseDateDateLabel.Location = new System.Drawing.Point(130, 433);
            this.episodeReleseDateDateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.episodeReleseDateDateLabel.MaximumSize = new System.Drawing.Size(120, 30);
            this.episodeReleseDateDateLabel.MinimumSize = new System.Drawing.Size(120, 30);
            this.episodeReleseDateDateLabel.Name = "episodeReleseDateDateLabel";
            this.episodeReleseDateDateLabel.Size = new System.Drawing.Size(120, 30);
            this.episodeReleseDateDateLabel.TabIndex = 0;
            this.episodeReleseDateDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // episodeCommentTextBox
            // 
            this.episodeCommentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.episodeCommentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.episodeCommentTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.episodeCommentTextBox.ForeColor = System.Drawing.Color.Black;
            this.episodeCommentTextBox.Location = new System.Drawing.Point(15, 660);
            this.episodeCommentTextBox.MaximumSize = new System.Drawing.Size(340, 160);
            this.episodeCommentTextBox.MinimumSize = new System.Drawing.Size(340, 160);
            this.episodeCommentTextBox.Multiline = true;
            this.episodeCommentTextBox.Name = "episodeCommentTextBox";
            this.episodeCommentTextBox.Size = new System.Drawing.Size(340, 160);
            this.episodeCommentTextBox.TabIndex = 1;
            // 
            // episodeCommentLabel
            // 
            this.episodeCommentLabel.AutoSize = true;
            this.episodeCommentLabel.BackColor = System.Drawing.Color.Transparent;
            this.episodeCommentLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.episodeCommentLabel.Location = new System.Drawing.Point(15, 625);
            this.episodeCommentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.episodeCommentLabel.MaximumSize = new System.Drawing.Size(150, 30);
            this.episodeCommentLabel.MinimumSize = new System.Drawing.Size(150, 30);
            this.episodeCommentLabel.Name = "episodeCommentLabel";
            this.episodeCommentLabel.Size = new System.Drawing.Size(150, 30);
            this.episodeCommentLabel.TabIndex = 0;
            this.episodeCommentLabel.Text = "Comment:";
            // 
            // saveEpisodeButton
            // 
            this.saveEpisodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveEpisodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))));
            this.saveEpisodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveEpisodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveEpisodeButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEpisodeButton.Location = new System.Drawing.Point(35, 840);
            this.saveEpisodeButton.Margin = new System.Windows.Forms.Padding(0);
            this.saveEpisodeButton.Name = "saveEpisodeButton";
            this.saveEpisodeButton.Size = new System.Drawing.Size(300, 60);
            this.saveEpisodeButton.TabIndex = 2;
            this.saveEpisodeButton.Text = "Save";
            this.saveEpisodeButton.UseVisualStyleBackColor = false;
            this.saveEpisodeButton.Click += new System.EventHandler(this.SaveEpisodeButton_Click);
            // 
            // EpisodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(384, 911);
            this.Controls.Add(this.saveEpisodeButton);
            this.Controls.Add(this.episodeCommentLabel);
            this.Controls.Add(this.episodeCommentTextBox);
            this.Controls.Add(this.episodeReleseDateDateLabel);
            this.Controls.Add(this.episodeRunningTimeMinutesLabel);
            this.Controls.Add(this.episodeRunningTimeLabel);
            this.Controls.Add(this.episodePlotOutlineTextBox);
            this.Controls.Add(this.episodeRatingNumberLabel);
            this.Controls.Add(this.episodeRatingLabel);
            this.Controls.Add(this.episodeGenresLabel);
            this.Controls.Add(this.episodeCoverPictureBox);
            this.Controls.Add(this.episodeReleseDateLabel);
            this.Controls.Add(this.episodeTitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 950);
            this.MinimumSize = new System.Drawing.Size(400, 950);
            this.Name = "EpisodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDb Tracker";
            this.Load += new System.EventHandler(this.EpisodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.episodeCoverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label episodeTitleLabel;
        private System.Windows.Forms.Label episodeReleseDateLabel;
        private System.Windows.Forms.PictureBox episodeCoverPictureBox;
        private System.Windows.Forms.Label episodeGenresLabel;
        private System.Windows.Forms.Label episodeRatingLabel;
        private System.Windows.Forms.Label episodeRatingNumberLabel;
        private System.Windows.Forms.TextBox episodePlotOutlineTextBox;
        private System.Windows.Forms.Label episodeRunningTimeLabel;
        private System.Windows.Forms.Label episodeRunningTimeMinutesLabel;
        private System.Windows.Forms.Label episodeReleseDateDateLabel;
        private System.Windows.Forms.TextBox episodeCommentTextBox;
        private System.Windows.Forms.Label episodeCommentLabel;
        private System.Windows.Forms.Button saveEpisodeButton;
    }
}