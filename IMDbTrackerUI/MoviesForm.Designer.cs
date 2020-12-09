
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
            this.SuspendLayout();
            // 
            // moviesListBox
            // 
            this.moviesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.moviesListBox.FormattingEnabled = true;
            this.moviesListBox.ItemHeight = 21;
            this.moviesListBox.Location = new System.Drawing.Point(15, 140);
            this.moviesListBox.MaximumSize = new System.Drawing.Size(250, 592);
            this.moviesListBox.MinimumSize = new System.Drawing.Size(250, 592);
            this.moviesListBox.Name = "moviesListBox";
            this.moviesListBox.Size = new System.Drawing.Size(250, 592);
            this.moviesListBox.TabIndex = 0;
            // 
            // moviesTypeComboBox
            // 
            this.moviesTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.moviesTypeComboBox.DropDownHeight = 105;
            this.moviesTypeComboBox.ForeColor = System.Drawing.Color.Black;
            this.moviesTypeComboBox.FormattingEnabled = true;
            this.moviesTypeComboBox.IntegralHeight = false;
            this.moviesTypeComboBox.Location = new System.Drawing.Point(15, 20);
            this.moviesTypeComboBox.Name = "moviesTypeComboBox";
            this.moviesTypeComboBox.Size = new System.Drawing.Size(250, 29);
            this.moviesTypeComboBox.TabIndex = 1;
            // 
            // filterMoviesLabel
            // 
            this.filterMoviesLabel.AutoSize = true;
            this.filterMoviesLabel.BackColor = System.Drawing.Color.Transparent;
            this.filterMoviesLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.filterMoviesLabel.Location = new System.Drawing.Point(9, 65);
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
            this.filterMoviesTextBox.Location = new System.Drawing.Point(15, 90);
            this.filterMoviesTextBox.MaxLength = 150;
            this.filterMoviesTextBox.Name = "filterMoviesTextBox";
            this.filterMoviesTextBox.Size = new System.Drawing.Size(250, 29);
            this.filterMoviesTextBox.TabIndex = 2;
            this.filterMoviesTextBox.TextChanged += new System.EventHandler(this.FilterMoviesTextBox_TextChanged);
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.filterMoviesTextBox);
            this.Controls.Add(this.filterMoviesLabel);
            this.Controls.Add(this.moviesTypeComboBox);
            this.Controls.Add(this.moviesListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "MoviesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDb Tracker - Movies";
            this.Load += new System.EventHandler(this.MoviesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox moviesListBox;
        private System.Windows.Forms.ComboBox moviesTypeComboBox;
        private System.Windows.Forms.Label filterMoviesLabel;
        private System.Windows.Forms.TextBox filterMoviesTextBox;
    }
}