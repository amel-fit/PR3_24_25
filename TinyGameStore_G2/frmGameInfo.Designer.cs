namespace TinyGameStore_G2
{
    partial class frmGameInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbCoverArt = new PictureBox();
            txtGameName = new TextBox();
            txtReleaseDate = new TextBox();
            txtPublisher = new TextBox();
            txtGenres = new TextBox();
            lblPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCoverArt).BeginInit();
            SuspendLayout();
            // 
            // pbCoverArt
            // 
            pbCoverArt.Location = new Point(27, 28);
            pbCoverArt.Name = "pbCoverArt";
            pbCoverArt.Size = new Size(209, 165);
            pbCoverArt.TabIndex = 0;
            pbCoverArt.TabStop = false;
            // 
            // txtGameName
            // 
            txtGameName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            txtGameName.Location = new Point(242, 28);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(546, 43);
            txtGameName.TabIndex = 1;
            txtGameName.Text = "[Game Name]";
            txtGameName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtReleaseDate
            // 
            txtReleaseDate.Location = new Point(624, 92);
            txtReleaseDate.Name = "txtReleaseDate";
            txtReleaseDate.Size = new Size(164, 27);
            txtReleaseDate.TabIndex = 2;
            txtReleaseDate.Text = "[Release Date]";
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(242, 92);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(252, 27);
            txtPublisher.TabIndex = 2;
            txtPublisher.Text = "[Publisher]";
            // 
            // txtGenres
            // 
            txtGenres.Location = new Point(242, 166);
            txtGenres.Name = "txtGenres";
            txtGenres.Size = new Size(546, 27);
            txtGenres.TabIndex = 3;
            txtGenres.Text = "[Genres]";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F);
            lblPrice.Location = new Point(722, 135);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(66, 28);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "[Price]";
            // 
            // frmGameInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 228);
            Controls.Add(lblPrice);
            Controls.Add(txtGenres);
            Controls.Add(txtPublisher);
            Controls.Add(txtReleaseDate);
            Controls.Add(txtGameName);
            Controls.Add(pbCoverArt);
            Name = "frmGameInfo";
            Text = "frmGameInfo";
            ((System.ComponentModel.ISupportInitialize)pbCoverArt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbCoverArt;
        private TextBox txtGameName;
        private TextBox txtReleaseDate;
        private TextBox txtPublisher;
        private TextBox txtGenres;
        private Label lblPrice;
    }
}