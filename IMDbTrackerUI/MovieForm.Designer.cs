
namespace IMDbTrackerUI {
    partial class MovieForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieForm));
            this.movieTitleLabel = new System.Windows.Forms.Label();
            this.movieReleseDateLabel = new System.Windows.Forms.Label();
            this.movieCoverPictureBox = new System.Windows.Forms.PictureBox();
            this.movieGenresLabel = new System.Windows.Forms.Label();
            this.movieRatingLabel = new System.Windows.Forms.Label();
            this.movieRatingNumberLabel = new System.Windows.Forms.Label();
            this.moviePlotOutlineTextBox = new System.Windows.Forms.TextBox();
            this.movieRunningTimeLabel = new System.Windows.Forms.Label();
            this.movieRunningTimeMinutesLabel = new System.Windows.Forms.Label();
            this.movieReleseDateDateLabel = new System.Windows.Forms.Label();
            this.movieCommentTextBox = new System.Windows.Forms.TextBox();
            this.movieCommentLabel = new System.Windows.Forms.Label();
            this.saveMovieButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movieCoverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // movieTitleLabel
            // 
            this.movieTitleLabel.AutoSize = true;
            this.movieTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.movieTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.movieTitleLabel.Location = new System.Drawing.Point(15, 30);
            this.movieTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.movieTitleLabel.MaximumSize = new System.Drawing.Size(350, 37);
            this.movieTitleLabel.MinimumSize = new System.Drawing.Size(350, 37);
            this.movieTitleLabel.Name = "movieTitleLabel";
            this.movieTitleLabel.Size = new System.Drawing.Size(350, 37);
            this.movieTitleLabel.TabIndex = 0;
            // 
            // movieReleseDateLabel
            // 
            this.movieReleseDateLabel.AutoSize = true;
            this.movieReleseDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.movieReleseDateLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.movieReleseDateLabel.Location = new System.Drawing.Point(15, 435);
            this.movieReleseDateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.movieReleseDateLabel.MaximumSize = new System.Drawing.Size(120, 30);
            this.movieReleseDateLabel.MinimumSize = new System.Drawing.Size(120, 30);
            this.movieReleseDateLabel.Name = "movieReleseDateLabel";
            this.movieReleseDateLabel.Size = new System.Drawing.Size(120, 30);
            this.movieReleseDateLabel.TabIndex = 0;
            this.movieReleseDateLabel.Text = "Relese date:";
            // 
            // movieCoverPictureBox
            // 
            this.movieCoverPictureBox.ErrorImage = global::IMDbTrackerUI.Properties.Resources.IMDb_yellow_logo;
            this.movieCoverPictureBox.Image = global::IMDbTrackerUI.Properties.Resources.IMDb_yellow_logo;
            this.movieCoverPictureBox.InitialImage = global::IMDbTrackerUI.Properties.Resources.IMDb_yellow_logo;
            this.movieCoverPictureBox.Location = new System.Drawing.Point(15, 110);
            this.movieCoverPictureBox.MaximumSize = new System.Drawing.Size(350, 320);
            this.movieCoverPictureBox.MinimumSize = new System.Drawing.Size(350, 320);
            this.movieCoverPictureBox.Name = "movieCoverPictureBox";
            this.movieCoverPictureBox.Size = new System.Drawing.Size(350, 320);
            this.movieCoverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movieCoverPictureBox.TabIndex = 4;
            this.movieCoverPictureBox.TabStop = false;
            // 
            // movieGenresLabel
            // 
            this.movieGenresLabel.AutoSize = true;
            this.movieGenresLabel.BackColor = System.Drawing.Color.Transparent;
            this.movieGenresLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.movieGenresLabel.Location = new System.Drawing.Point(15, 70);
            this.movieGenresLabel.Margin = new System.Windows.Forms.Padding(0);
            this.movieGenresLabel.MaximumSize = new System.Drawing.Size(350, 30);
            this.movieGenresLabel.MinimumSize = new System.Drawing.Size(350, 30);
            this.movieGenresLabel.Name = "movieGenresLabel";
            this.movieGenresLabel.Size = new System.Drawing.Size(350, 30);
            this.movieGenresLabel.TabIndex = 0;
            // 
            // movieRatingLabel
            // 
            this.movieRatingLabel.AutoSize = true;
            this.movieRatingLabel.BackColor = System.Drawing.Color.Transparent;
            this.movieRatingLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.movieRatingLabel.Location = new System.Drawing.Point(15, 495);
            this.movieRatingLabel.Margin = new System.Windows.Forms.Padding(0);
            this.movieRatingLabel.MaximumSize = new System.Drawing.Size(75, 30);
            this.movieRatingLabel.MinimumSize = new System.Drawing.Size(75, 30);
            this.movieRatingLabel.Name = "movieRatingLabel";
            this.movieRatingLabel.Size = new System.Drawing.Size(75, 30);
            this.movieRatingLabel.TabIndex = 0;
            this.movieRatingLabel.Text = "Rating:";
            // 
            // movieRatingNumberLabel
            // 
            this.movieRatingNumberLabel.AutoSize = true;
            this.movieRatingNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.movieRatingNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.movieRatingNumberLabel.Location = new System.Drawing.Point(90, 493);
            this.movieRatingNumberLabel.Margin = new System.Windows.Forms.Padding(0);
            this.movieRatingNumberLabel.MaximumSize = new System.Drawing.Size(75, 30);
            this.movieRatingNumberLabel.MinimumSize = new System.Drawing.Size(75, 30);
            this.movieRatingNumberLabel.Name = "movieRatingNumberLabel";
            this.movieRatingNumberLabel.Size = new System.Drawing.Size(75, 30);
            this.movieRatingNumberLabel.TabIndex = 0;
            this.movieRatingNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // moviePlotOutlineTextBox
            // 
            this.moviePlotOutlineTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.moviePlotOutlineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moviePlotOutlineTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.moviePlotOutlineTextBox.ForeColor = System.Drawing.Color.Black;
            this.moviePlotOutlineTextBox.Location = new System.Drawing.Point(20, 525);
            this.moviePlotOutlineTextBox.MaximumSize = new System.Drawing.Size(340, 160);
            this.moviePlotOutlineTextBox.MinimumSize = new System.Drawing.Size(340, 160);
            this.moviePlotOutlineTextBox.Multiline = true;
            this.moviePlotOutlineTextBox.Name = "moviePlotOutlineTextBox";
            this.moviePlotOutlineTextBox.ReadOnly = true;
            this.moviePlotOutlineTextBox.Size = new System.Drawing.Size(340, 160);
            this.moviePlotOutlineTextBox.TabIndex = 0;
            // 
            // movieRunningTimeLabel
            // 
            this.movieRunningTimeLabel.AutoSize = true;
            this.movieRunningTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.movieRunningTimeLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.movieRunningTimeLabel.Location = new System.Drawing.Point(15, 465);
            this.movieRunningTimeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.movieRunningTimeLabel.MaximumSize = new System.Drawing.Size(150, 30);
            this.movieRunningTimeLabel.MinimumSize = new System.Drawing.Size(150, 30);
            this.movieRunningTimeLabel.Name = "movieRunningTimeLabel";
            this.movieRunningTimeLabel.Size = new System.Drawing.Size(150, 30);
            this.movieRunningTimeLabel.TabIndex = 0;
            this.movieRunningTimeLabel.Text = "Runing time:";
            // 
            // movieRunningTimeMinutesLabel
            // 
            this.movieRunningTimeMinutesLabel.AutoSize = true;
            this.movieRunningTimeMinutesLabel.BackColor = System.Drawing.Color.Transparent;
            this.movieRunningTimeMinutesLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.movieRunningTimeMinutesLabel.Location = new System.Drawing.Point(140, 463);
            this.movieRunningTimeMinutesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.movieRunningTimeMinutesLabel.MaximumSize = new System.Drawing.Size(75, 30);
            this.movieRunningTimeMinutesLabel.MinimumSize = new System.Drawing.Size(75, 30);
            this.movieRunningTimeMinutesLabel.Name = "movieRunningTimeMinutesLabel";
            this.movieRunningTimeMinutesLabel.Size = new System.Drawing.Size(75, 30);
            this.movieRunningTimeMinutesLabel.TabIndex = 0;
            this.movieRunningTimeMinutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // movieReleseDateDateLabel
            // 
            this.movieReleseDateDateLabel.AutoSize = true;
            this.movieReleseDateDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.movieReleseDateDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.movieReleseDateDateLabel.Location = new System.Drawing.Point(130, 433);
            this.movieReleseDateDateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.movieReleseDateDateLabel.MaximumSize = new System.Drawing.Size(120, 30);
            this.movieReleseDateDateLabel.MinimumSize = new System.Drawing.Size(120, 30);
            this.movieReleseDateDateLabel.Name = "movieReleseDateDateLabel";
            this.movieReleseDateDateLabel.Size = new System.Drawing.Size(120, 30);
            this.movieReleseDateDateLabel.TabIndex = 0;
            this.movieReleseDateDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // movieCommentTextBox
            // 
            this.movieCommentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.movieCommentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movieCommentTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.movieCommentTextBox.ForeColor = System.Drawing.Color.Black;
            this.movieCommentTextBox.Location = new System.Drawing.Point(15, 730);
            this.movieCommentTextBox.MaximumSize = new System.Drawing.Size(340, 160);
            this.movieCommentTextBox.MinimumSize = new System.Drawing.Size(340, 160);
            this.movieCommentTextBox.Multiline = true;
            this.movieCommentTextBox.Name = "movieCommentTextBox";
            this.movieCommentTextBox.Size = new System.Drawing.Size(340, 160);
            this.movieCommentTextBox.TabIndex = 1;
            // 
            // movieCommentLabel
            // 
            this.movieCommentLabel.AutoSize = true;
            this.movieCommentLabel.BackColor = System.Drawing.Color.Transparent;
            this.movieCommentLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.movieCommentLabel.Location = new System.Drawing.Point(15, 695);
            this.movieCommentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.movieCommentLabel.MaximumSize = new System.Drawing.Size(150, 30);
            this.movieCommentLabel.MinimumSize = new System.Drawing.Size(150, 30);
            this.movieCommentLabel.Name = "movieCommentLabel";
            this.movieCommentLabel.Size = new System.Drawing.Size(150, 30);
            this.movieCommentLabel.TabIndex = 0;
            this.movieCommentLabel.Text = "Comment:";
            // 
            // saveMovieButton
            // 
            this.saveMovieButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveMovieButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))));
            this.saveMovieButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveMovieButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveMovieButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveMovieButton.Location = new System.Drawing.Point(36, 910);
            this.saveMovieButton.Margin = new System.Windows.Forms.Padding(0);
            this.saveMovieButton.Name = "saveMovieButton";
            this.saveMovieButton.Size = new System.Drawing.Size(300, 60);
            this.saveMovieButton.TabIndex = 2;
            this.saveMovieButton.Text = "Save";
            this.saveMovieButton.UseVisualStyleBackColor = false;
            this.saveMovieButton.Click += new System.EventHandler(this.SaveMovieButton_Click);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(384, 999);
            this.Controls.Add(this.saveMovieButton);
            this.Controls.Add(this.movieCommentLabel);
            this.Controls.Add(this.movieCommentTextBox);
            this.Controls.Add(this.movieReleseDateDateLabel);
            this.Controls.Add(this.movieRunningTimeMinutesLabel);
            this.Controls.Add(this.movieRunningTimeLabel);
            this.Controls.Add(this.moviePlotOutlineTextBox);
            this.Controls.Add(this.movieRatingNumberLabel);
            this.Controls.Add(this.movieRatingLabel);
            this.Controls.Add(this.movieGenresLabel);
            this.Controls.Add(this.movieCoverPictureBox);
            this.Controls.Add(this.movieReleseDateLabel);
            this.Controls.Add(this.movieTitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 1050);
            this.MinimumSize = new System.Drawing.Size(400, 1038);
            this.Name = "MovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDb Tracker";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieCoverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label movieTitleLabel;
        private System.Windows.Forms.Label movieReleseDateLabel;
        private System.Windows.Forms.PictureBox movieCoverPictureBox;
        private System.Windows.Forms.Label movieGenresLabel;
        private System.Windows.Forms.Label movieRatingLabel;
        private System.Windows.Forms.Label movieRatingNumberLabel;
        private System.Windows.Forms.TextBox moviePlotOutlineTextBox;
        private System.Windows.Forms.Label movieRunningTimeLabel;
        private System.Windows.Forms.Label movieRunningTimeMinutesLabel;
        private System.Windows.Forms.Label movieReleseDateDateLabel;
        private System.Windows.Forms.TextBox movieCommentTextBox;
        private System.Windows.Forms.Label movieCommentLabel;
        private System.Windows.Forms.Button saveMovieButton;
    }
}