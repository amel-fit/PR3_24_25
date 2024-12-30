namespace TinyGameStore_G2
{
    partial class frmRateGame
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
            gbRatings = new GroupBox();
            rb1 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            lblUserName = new Label();
            lblGame = new Label();
            btnRate = new Button();
            gbRatings.SuspendLayout();
            SuspendLayout();
            // 
            // gbRatings
            // 
            gbRatings.Controls.Add(rb1);
            gbRatings.Controls.Add(radioButton4);
            gbRatings.Controls.Add(radioButton1);
            gbRatings.Controls.Add(radioButton3);
            gbRatings.Controls.Add(radioButton2);
            gbRatings.Font = new Font("Segoe UI", 19F);
            gbRatings.Location = new Point(43, 183);
            gbRatings.Name = "gbRatings";
            gbRatings.Size = new Size(745, 145);
            gbRatings.TabIndex = 1;
            gbRatings.TabStop = false;
            gbRatings.Text = "Rate the Game:";
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(9, 66);
            rb1.Name = "rb1";
            rb1.Size = new Size(58, 49);
            rb1.TabIndex = 0;
            rb1.TabStop = true;
            rb1.Text = "1";
            rb1.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(681, 66);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(58, 49);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "5";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(181, 66);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 49);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "2";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(525, 66);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(58, 49);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "4";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(348, 66);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(58, 49);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "3";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 19F);
            lblUserName.Location = new Point(52, 36);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(179, 45);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "[username]";
            // 
            // lblGame
            // 
            lblGame.AutoSize = true;
            lblGame.Font = new Font("Segoe UI", 19F);
            lblGame.Location = new Point(52, 106);
            lblGame.Name = "lblGame";
            lblGame.Size = new Size(120, 45);
            lblGame.TabIndex = 3;
            lblGame.Text = "[game]";
            // 
            // btnRate
            // 
            btnRate.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            btnRate.Location = new Point(629, 368);
            btnRate.Name = "btnRate";
            btnRate.Size = new Size(153, 54);
            btnRate.TabIndex = 4;
            btnRate.Text = "RATE";
            btnRate.UseVisualStyleBackColor = true;
            btnRate.Click += btnRate_Click;
            // 
            // frmRateGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRate);
            Controls.Add(lblGame);
            Controls.Add(lblUserName);
            Controls.Add(gbRatings);
            Name = "frmRateGame";
            Text = "frmRateGame";
            gbRatings.ResumeLayout(false);
            gbRatings.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rb1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox gbRatings;
        private Label lblUserName;
        private Label lblGame;
        private Button btnRate;
    }
}