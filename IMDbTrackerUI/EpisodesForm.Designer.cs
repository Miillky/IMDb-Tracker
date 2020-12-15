
namespace IMDbTrackerUI {
    partial class EpisodesForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EpisodesForm));
            this.showTitleLabel = new System.Windows.Forms.Label();
            this.seasonLabel = new System.Windows.Forms.Label();
            this.episodeCoverPictureBox = new System.Windows.Forms.PictureBox();
            this.episodeTitleLabel = new System.Windows.Forms.Label();
            this.episodesListBox = new System.Windows.Forms.ListBox();
            this.episodeDetailsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.episodeCoverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showTitleLabel
            // 
            this.showTitleLabel.AutoSize = true;
            this.showTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.showTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.showTitleLabel.Location = new System.Drawing.Point(25, 12);
            this.showTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.showTitleLabel.MaximumSize = new System.Drawing.Size(330, 37);
            this.showTitleLabel.MinimumSize = new System.Drawing.Size(330, 37);
            this.showTitleLabel.Name = "showTitleLabel";
            this.showTitleLabel.Size = new System.Drawing.Size(330, 37);
            this.showTitleLabel.TabIndex = 8;
            // 
            // seasonLabel
            // 
            this.seasonLabel.AutoSize = true;
            this.seasonLabel.BackColor = System.Drawing.Color.Transparent;
            this.seasonLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.seasonLabel.Location = new System.Drawing.Point(30, 45);
            this.seasonLabel.Margin = new System.Windows.Forms.Padding(0);
            this.seasonLabel.MaximumSize = new System.Drawing.Size(195, 30);
            this.seasonLabel.MinimumSize = new System.Drawing.Size(195, 30);
            this.seasonLabel.Name = "seasonLabel";
            this.seasonLabel.Size = new System.Drawing.Size(195, 30);
            this.seasonLabel.TabIndex = 0;
            // 
            // episodeCoverPictureBox
            // 
            this.episodeCoverPictureBox.ErrorImage = global::IMDbTrackerUI.Properties.Resources.IMDb_yellow_logo;
            this.episodeCoverPictureBox.Image = global::IMDbTrackerUI.Properties.Resources.IMDb_yellow_logo;
            this.episodeCoverPictureBox.InitialImage = global::IMDbTrackerUI.Properties.Resources.IMDb_yellow_logo;
            this.episodeCoverPictureBox.Location = new System.Drawing.Point(25, 80);
            this.episodeCoverPictureBox.MaximumSize = new System.Drawing.Size(330, 310);
            this.episodeCoverPictureBox.MinimumSize = new System.Drawing.Size(330, 310);
            this.episodeCoverPictureBox.Name = "episodeCoverPictureBox";
            this.episodeCoverPictureBox.Size = new System.Drawing.Size(330, 310);
            this.episodeCoverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.episodeCoverPictureBox.TabIndex = 9;
            this.episodeCoverPictureBox.TabStop = false;
            // 
            // episodeTitleLabel
            // 
            this.episodeTitleLabel.AutoSize = true;
            this.episodeTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.episodeTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.episodeTitleLabel.Location = new System.Drawing.Point(25, 400);
            this.episodeTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.episodeTitleLabel.MaximumSize = new System.Drawing.Size(330, 40);
            this.episodeTitleLabel.MinimumSize = new System.Drawing.Size(330, 40);
            this.episodeTitleLabel.Name = "episodeTitleLabel";
            this.episodeTitleLabel.Size = new System.Drawing.Size(330, 40);
            this.episodeTitleLabel.TabIndex = 0;
            // 
            // episodesListBox
            // 
            this.episodesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.episodesListBox.ForeColor = System.Drawing.Color.Black;
            this.episodesListBox.FormattingEnabled = true;
            this.episodesListBox.ItemHeight = 21;
            this.episodesListBox.Location = new System.Drawing.Point(45, 454);
            this.episodesListBox.MaximumSize = new System.Drawing.Size(300, 200);
            this.episodesListBox.MinimumSize = new System.Drawing.Size(300, 200);
            this.episodesListBox.Name = "episodesListBox";
            this.episodesListBox.Size = new System.Drawing.Size(300, 193);
            this.episodesListBox.TabIndex = 1;
            this.episodesListBox.SelectedIndexChanged += new System.EventHandler(this.SeasonsListBox_SelectedIndexChanged);
            // 
            // episodeDetailsButton
            // 
            this.episodeDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.episodeDetailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))));
            this.episodeDetailsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.episodeDetailsButton.Enabled = false;
            this.episodeDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.episodeDetailsButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeDetailsButton.Location = new System.Drawing.Point(45, 670);
            this.episodeDetailsButton.Margin = new System.Windows.Forms.Padding(0);
            this.episodeDetailsButton.Name = "episodeDetailsButton";
            this.episodeDetailsButton.Size = new System.Drawing.Size(300, 60);
            this.episodeDetailsButton.TabIndex = 2;
            this.episodeDetailsButton.Text = "Details";
            this.episodeDetailsButton.UseVisualStyleBackColor = false;
            this.episodeDetailsButton.Click += new System.EventHandler(this.EpisodeDetailsButton_Click);
            // 
            // EpisodesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(384, 761);
            this.Controls.Add(this.episodeDetailsButton);
            this.Controls.Add(this.episodesListBox);
            this.Controls.Add(this.episodeTitleLabel);
            this.Controls.Add(this.seasonLabel);
            this.Controls.Add(this.showTitleLabel);
            this.Controls.Add(this.episodeCoverPictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EpisodesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDb Tracker";
            this.Load += new System.EventHandler(this.EpisodesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.episodeCoverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label showTitleLabel;
        private System.Windows.Forms.Label seasonLabel;
        private System.Windows.Forms.PictureBox episodeCoverPictureBox;
        private System.Windows.Forms.Label episodeTitleLabel;
        private System.Windows.Forms.ListBox episodesListBox;
        private System.Windows.Forms.Button episodeDetailsButton;
    }
}