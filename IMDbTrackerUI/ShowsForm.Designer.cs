
namespace IMDbTrackerUI {
    partial class ShowsForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowsForm));
            this.showsListBox = new System.Windows.Forms.ListBox();
            this.showsTypeComboBox = new System.Windows.Forms.ComboBox();
            this.filterShowsLabel = new System.Windows.Forms.Label();
            this.filterShowsTextBox = new System.Windows.Forms.TextBox();
            this.showCoverPictureBox = new System.Windows.Forms.PictureBox();
            this.showTitleLabel = new System.Windows.Forms.Label();
            this.showStartEndYearsLabel = new System.Windows.Forms.Label();
            this.addRemoveFavoritesButton = new System.Windows.Forms.Button();
            this.showSeasonEpisodesButton = new System.Windows.Forms.Button();
            this.showPlotOutlineTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seasonsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.showCoverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showsListBox
            // 
            this.showsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.showsListBox.ForeColor = System.Drawing.Color.Black;
            this.showsListBox.FormattingEnabled = true;
            this.showsListBox.ItemHeight = 21;
            this.showsListBox.Location = new System.Drawing.Point(15, 150);
            this.showsListBox.MaximumSize = new System.Drawing.Size(250, 280);
            this.showsListBox.MinimumSize = new System.Drawing.Size(250, 280);
            this.showsListBox.Name = "showsListBox";
            this.showsListBox.Size = new System.Drawing.Size(250, 277);
            this.showsListBox.TabIndex = 3;
            this.showsListBox.SelectedIndexChanged += new System.EventHandler(this.ShowsListBox_SelectedIndexChanged);
            // 
            // showsTypeComboBox
            // 
            this.showsTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.showsTypeComboBox.DropDownHeight = 200;
            this.showsTypeComboBox.ForeColor = System.Drawing.Color.Black;
            this.showsTypeComboBox.FormattingEnabled = true;
            this.showsTypeComboBox.IntegralHeight = false;
            this.showsTypeComboBox.Location = new System.Drawing.Point(15, 30);
            this.showsTypeComboBox.Name = "showsTypeComboBox";
            this.showsTypeComboBox.Size = new System.Drawing.Size(250, 29);
            this.showsTypeComboBox.TabIndex = 1;
            this.showsTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ShowsTypeComboBox_SelectedIndexChanged);
            // 
            // filterShowsLabel
            // 
            this.filterShowsLabel.AutoSize = true;
            this.filterShowsLabel.BackColor = System.Drawing.Color.Transparent;
            this.filterShowsLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.filterShowsLabel.Location = new System.Drawing.Point(15, 75);
            this.filterShowsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.filterShowsLabel.Name = "filterShowsLabel";
            this.filterShowsLabel.Size = new System.Drawing.Size(121, 25);
            this.filterShowsLabel.TabIndex = 0;
            this.filterShowsLabel.Text = "Filter shows:";
            // 
            // filterShowsTextBox
            // 
            this.filterShowsTextBox.BackColor = System.Drawing.Color.White;
            this.filterShowsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterShowsTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.filterShowsTextBox.Location = new System.Drawing.Point(15, 100);
            this.filterShowsTextBox.MaxLength = 150;
            this.filterShowsTextBox.Name = "filterShowsTextBox";
            this.filterShowsTextBox.Size = new System.Drawing.Size(250, 29);
            this.filterShowsTextBox.TabIndex = 2;
            this.filterShowsTextBox.TextChanged += new System.EventHandler(this.FilterShowsTextBox_TextChanged);
            // 
            // showCoverPictureBox
            // 
            this.showCoverPictureBox.ErrorImage = global::IMDbTrackerUI.Properties.Resources.IMDb_yellow_logo;
            this.showCoverPictureBox.Image = global::IMDbTrackerUI.Properties.Resources.IMDb_yellow_logo;
            this.showCoverPictureBox.InitialImage = global::IMDbTrackerUI.Properties.Resources.IMDb_yellow_logo;
            this.showCoverPictureBox.Location = new System.Drawing.Point(320, 84);
            this.showCoverPictureBox.MaximumSize = new System.Drawing.Size(330, 310);
            this.showCoverPictureBox.MinimumSize = new System.Drawing.Size(330, 310);
            this.showCoverPictureBox.Name = "showCoverPictureBox";
            this.showCoverPictureBox.Size = new System.Drawing.Size(330, 310);
            this.showCoverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showCoverPictureBox.TabIndex = 3;
            this.showCoverPictureBox.TabStop = false;
            // 
            // showTitleLabel
            // 
            this.showTitleLabel.AutoSize = true;
            this.showTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.showTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.showTitleLabel.Location = new System.Drawing.Point(320, 15);
            this.showTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.showTitleLabel.MaximumSize = new System.Drawing.Size(330, 37);
            this.showTitleLabel.MinimumSize = new System.Drawing.Size(330, 37);
            this.showTitleLabel.Name = "showTitleLabel";
            this.showTitleLabel.Size = new System.Drawing.Size(330, 37);
            this.showTitleLabel.TabIndex = 0;
            // 
            // showStartEndYearsLabel
            // 
            this.showStartEndYearsLabel.AutoSize = true;
            this.showStartEndYearsLabel.BackColor = System.Drawing.Color.Transparent;
            this.showStartEndYearsLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.showStartEndYearsLabel.Location = new System.Drawing.Point(325, 50);
            this.showStartEndYearsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.showStartEndYearsLabel.MaximumSize = new System.Drawing.Size(150, 30);
            this.showStartEndYearsLabel.MinimumSize = new System.Drawing.Size(150, 30);
            this.showStartEndYearsLabel.Name = "showStartEndYearsLabel";
            this.showStartEndYearsLabel.Size = new System.Drawing.Size(150, 30);
            this.showStartEndYearsLabel.TabIndex = 0;
            // 
            // addRemoveFavoritesButton
            // 
            this.addRemoveFavoritesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addRemoveFavoritesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))));
            this.addRemoveFavoritesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRemoveFavoritesButton.Enabled = false;
            this.addRemoveFavoritesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addRemoveFavoritesButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRemoveFavoritesButton.Location = new System.Drawing.Point(340, 505);
            this.addRemoveFavoritesButton.Margin = new System.Windows.Forms.Padding(0);
            this.addRemoveFavoritesButton.Name = "addRemoveFavoritesButton";
            this.addRemoveFavoritesButton.Size = new System.Drawing.Size(300, 60);
            this.addRemoveFavoritesButton.TabIndex = 5;
            this.addRemoveFavoritesButton.Text = "Add Remove Favorites";
            this.addRemoveFavoritesButton.UseVisualStyleBackColor = false;
            this.addRemoveFavoritesButton.Click += new System.EventHandler(this.AddRemoveFavoritesButton_Click);
            // 
            // showSeasonEpisodesButton
            // 
            this.showSeasonEpisodesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showSeasonEpisodesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))));
            this.showSeasonEpisodesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showSeasonEpisodesButton.Enabled = false;
            this.showSeasonEpisodesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showSeasonEpisodesButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSeasonEpisodesButton.Location = new System.Drawing.Point(340, 575);
            this.showSeasonEpisodesButton.Margin = new System.Windows.Forms.Padding(0);
            this.showSeasonEpisodesButton.Name = "showSeasonEpisodesButton";
            this.showSeasonEpisodesButton.Size = new System.Drawing.Size(300, 60);
            this.showSeasonEpisodesButton.TabIndex = 6;
            this.showSeasonEpisodesButton.Text = "Episodes";
            this.showSeasonEpisodesButton.UseVisualStyleBackColor = false;
            this.showSeasonEpisodesButton.Click += new System.EventHandler(this.ShowSeasonButton_Click);
            // 
            // showPlotOutlineTextBox
            // 
            this.showPlotOutlineTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.showPlotOutlineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showPlotOutlineTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.showPlotOutlineTextBox.ForeColor = System.Drawing.Color.Black;
            this.showPlotOutlineTextBox.Location = new System.Drawing.Point(320, 400);
            this.showPlotOutlineTextBox.MaximumSize = new System.Drawing.Size(330, 90);
            this.showPlotOutlineTextBox.MinimumSize = new System.Drawing.Size(330, 90);
            this.showPlotOutlineTextBox.Multiline = true;
            this.showPlotOutlineTextBox.Name = "showPlotOutlineTextBox";
            this.showPlotOutlineTextBox.ReadOnly = true;
            this.showPlotOutlineTextBox.Size = new System.Drawing.Size(330, 90);
            this.showPlotOutlineTextBox.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // seasonsListBox
            // 
            this.seasonsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.seasonsListBox.ForeColor = System.Drawing.Color.Black;
            this.seasonsListBox.FormattingEnabled = true;
            this.seasonsListBox.ItemHeight = 21;
            this.seasonsListBox.Location = new System.Drawing.Point(15, 450);
            this.seasonsListBox.MaximumSize = new System.Drawing.Size(250, 200);
            this.seasonsListBox.MinimumSize = new System.Drawing.Size(250, 200);
            this.seasonsListBox.Name = "seasonsListBox";
            this.seasonsListBox.Size = new System.Drawing.Size(250, 193);
            this.seasonsListBox.TabIndex = 4;
            this.seasonsListBox.SelectedIndexChanged += new System.EventHandler(this.SeasonsListBox_SelectedIndexChanged);
            // 
            // ShowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.seasonsListBox);
            this.Controls.Add(this.showPlotOutlineTextBox);
            this.Controls.Add(this.showSeasonEpisodesButton);
            this.Controls.Add(this.addRemoveFavoritesButton);
            this.Controls.Add(this.showStartEndYearsLabel);
            this.Controls.Add(this.showTitleLabel);
            this.Controls.Add(this.showCoverPictureBox);
            this.Controls.Add(this.filterShowsTextBox);
            this.Controls.Add(this.filterShowsLabel);
            this.Controls.Add(this.showsTypeComboBox);
            this.Controls.Add(this.showsListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "ShowsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDb Tracker - Shows";
            this.Load += new System.EventHandler(this.ShowsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showCoverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox showsListBox;
        private System.Windows.Forms.ComboBox showsTypeComboBox;
        private System.Windows.Forms.Label filterShowsLabel;
        private System.Windows.Forms.TextBox filterShowsTextBox;
        private System.Windows.Forms.PictureBox showCoverPictureBox;
        private System.Windows.Forms.Label showTitleLabel;
        private System.Windows.Forms.Label showStartEndYearsLabel;
        private System.Windows.Forms.Button addRemoveFavoritesButton;
        private System.Windows.Forms.Button showSeasonEpisodesButton;
        private System.Windows.Forms.TextBox showPlotOutlineTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox seasonsListBox;
    }
}