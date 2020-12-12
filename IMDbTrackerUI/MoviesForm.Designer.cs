
namespace IMDbTrackerUI {
    partial class MoviesForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviesForm));
            this.moviesListBox = new System.Windows.Forms.ListBox();
            this.moviesTypeComboBox = new System.Windows.Forms.ComboBox();
            this.filterMoviesLabel = new System.Windows.Forms.Label();
            this.filterMoviesTextBox = new System.Windows.Forms.TextBox();
            this.movieCoverPictureBox = new System.Windows.Forms.PictureBox();
            this.movieTitleLabel = new System.Windows.Forms.Label();
            this.movieReleseYearLabel = new System.Windows.Forms.Label();
            this.addRemoveFavoritesButton = new System.Windows.Forms.Button();
            this.movieDetailsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movieCoverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesListBox
            // 
            this.moviesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.moviesListBox.FormattingEnabled = true;
            this.moviesListBox.ItemHeight = 21;
            this.moviesListBox.Location = new System.Drawing.Point(15, 150);
            this.moviesListBox.MaximumSize = new System.Drawing.Size(250, 500);
            this.moviesListBox.MinimumSize = new System.Drawing.Size(250, 500);
            this.moviesListBox.Name = "moviesListBox";
            this.moviesListBox.Size = new System.Drawing.Size(250, 487);
            this.moviesListBox.TabIndex = 3;
            this.moviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // moviesTypeComboBox
            // 
            this.moviesTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.moviesTypeComboBox.DropDownHeight = 200;
            this.moviesTypeComboBox.ForeColor = System.Drawing.Color.Black;
            this.moviesTypeComboBox.FormattingEnabled = true;
            this.moviesTypeComboBox.IntegralHeight = false;
            this.moviesTypeComboBox.Location = new System.Drawing.Point(15, 30);
            this.moviesTypeComboBox.Name = "moviesTypeComboBox";
            this.moviesTypeComboBox.Size = new System.Drawing.Size(250, 29);
            this.moviesTypeComboBox.TabIndex = 1;
            this.moviesTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.MoviesTypeComboBox_SelectedIndexChanged);
            // 
            // filterMoviesLabel
            // 
            this.filterMoviesLabel.AutoSize = true;
            this.filterMoviesLabel.BackColor = System.Drawing.Color.Transparent;
            this.filterMoviesLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.filterMoviesLabel.Location = new System.Drawing.Point(15, 75);
            this.filterMoviesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.filterMoviesLabel.Name = "filterMoviesLabel";
            this.filterMoviesLabel.Size = new System.Drawing.Size(129, 25);
            this.filterMoviesLabel.TabIndex = 0;
            this.filterMoviesLabel.Text = "Filter movies:";
            // 
            // filterMoviesTextBox
            // 
            this.filterMoviesTextBox.BackColor = System.Drawing.Color.White;
            this.filterMoviesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterMoviesTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.filterMoviesTextBox.Location = new System.Drawing.Point(15, 100);
            this.filterMoviesTextBox.MaxLength = 150;
            this.filterMoviesTextBox.Name = "filterMoviesTextBox";
            this.filterMoviesTextBox.Size = new System.Drawing.Size(250, 29);
            this.filterMoviesTextBox.TabIndex = 2;
            this.filterMoviesTextBox.TextChanged += new System.EventHandler(this.FilterMoviesTextBox_TextChanged);
            // 
            // movieCoverPictureBox
            // 
            this.movieCoverPictureBox.ErrorImage = global::IMDbTrackerUI.Properties.Resources.IMDb_yellow_logo;
            this.movieCoverPictureBox.Image = global::IMDbTrackerUI.Properties.Resources.IMDb_black_logo;
            this.movieCoverPictureBox.InitialImage = global::IMDbTrackerUI.Properties.Resources.IMDb_yellow_logo;
            this.movieCoverPictureBox.Location = new System.Drawing.Point(320, 30);
            this.movieCoverPictureBox.MaximumSize = new System.Drawing.Size(330, 310);
            this.movieCoverPictureBox.MinimumSize = new System.Drawing.Size(330, 310);
            this.movieCoverPictureBox.Name = "movieCoverPictureBox";
            this.movieCoverPictureBox.Size = new System.Drawing.Size(330, 310);
            this.movieCoverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movieCoverPictureBox.TabIndex = 3;
            this.movieCoverPictureBox.TabStop = false;
            // 
            // movieTitleLabel
            // 
            this.movieTitleLabel.AutoSize = true;
            this.movieTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.movieTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.movieTitleLabel.Location = new System.Drawing.Point(320, 350);
            this.movieTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.movieTitleLabel.MaximumSize = new System.Drawing.Size(325, 37);
            this.movieTitleLabel.MinimumSize = new System.Drawing.Size(325, 37);
            this.movieTitleLabel.Name = "movieTitleLabel";
            this.movieTitleLabel.Size = new System.Drawing.Size(325, 37);
            this.movieTitleLabel.TabIndex = 0;
            this.movieTitleLabel.Text = "Movie title";
            // 
            // movieReleseYearLabel
            // 
            this.movieReleseYearLabel.AutoSize = true;
            this.movieReleseYearLabel.BackColor = System.Drawing.Color.Transparent;
            this.movieReleseYearLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.movieReleseYearLabel.Location = new System.Drawing.Point(320, 395);
            this.movieReleseYearLabel.Margin = new System.Windows.Forms.Padding(0);
            this.movieReleseYearLabel.MaximumSize = new System.Drawing.Size(195, 30);
            this.movieReleseYearLabel.MinimumSize = new System.Drawing.Size(195, 30);
            this.movieReleseYearLabel.Name = "movieReleseYearLabel";
            this.movieReleseYearLabel.Size = new System.Drawing.Size(195, 30);
            this.movieReleseYearLabel.TabIndex = 0;
            this.movieReleseYearLabel.Text = "Movie relese year";
            // 
            // addRemoveFavoritesButton
            // 
            this.addRemoveFavoritesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addRemoveFavoritesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))));
            this.addRemoveFavoritesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRemoveFavoritesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addRemoveFavoritesButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRemoveFavoritesButton.Location = new System.Drawing.Point(340, 460);
            this.addRemoveFavoritesButton.Margin = new System.Windows.Forms.Padding(0);
            this.addRemoveFavoritesButton.Name = "addRemoveFavoritesButton";
            this.addRemoveFavoritesButton.Size = new System.Drawing.Size(300, 60);
            this.addRemoveFavoritesButton.TabIndex = 4;
            this.addRemoveFavoritesButton.Text = "Add Remove Favorites";
            this.addRemoveFavoritesButton.UseVisualStyleBackColor = false;
            this.addRemoveFavoritesButton.Click += new System.EventHandler(this.AddRemoveFavoritesButton_Click);
            // 
            // movieDetailsButton
            // 
            this.movieDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieDetailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))));
            this.movieDetailsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.movieDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.movieDetailsButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieDetailsButton.Location = new System.Drawing.Point(340, 550);
            this.movieDetailsButton.Margin = new System.Windows.Forms.Padding(0);
            this.movieDetailsButton.Name = "movieDetailsButton";
            this.movieDetailsButton.Size = new System.Drawing.Size(300, 60);
            this.movieDetailsButton.TabIndex = 5;
            this.movieDetailsButton.Text = "Details";
            this.movieDetailsButton.UseVisualStyleBackColor = false;
            this.movieDetailsButton.Click += new System.EventHandler(this.MovieDetailsButton_Click);
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.movieDetailsButton);
            this.Controls.Add(this.addRemoveFavoritesButton);
            this.Controls.Add(this.movieReleseYearLabel);
            this.Controls.Add(this.movieTitleLabel);
            this.Controls.Add(this.movieCoverPictureBox);
            this.Controls.Add(this.filterMoviesTextBox);
            this.Controls.Add(this.filterMoviesLabel);
            this.Controls.Add(this.moviesTypeComboBox);
            this.Controls.Add(this.moviesListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "MoviesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDb Tracker - Movies";
            this.Load += new System.EventHandler(this.MoviesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieCoverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox moviesListBox;
        private System.Windows.Forms.ComboBox moviesTypeComboBox;
        private System.Windows.Forms.Label filterMoviesLabel;
        private System.Windows.Forms.TextBox filterMoviesTextBox;
        private System.Windows.Forms.PictureBox movieCoverPictureBox;
        private System.Windows.Forms.Label movieTitleLabel;
        private System.Windows.Forms.Label movieReleseYearLabel;
        private System.Windows.Forms.Button addRemoveFavoritesButton;
        private System.Windows.Forms.Button movieDetailsButton;
    }
}