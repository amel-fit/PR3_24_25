namespace TinyGameStore_G2
{
    partial class frmAdminPanel
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            cmbUsers = new ComboBox();
            dgvGamesOfUser = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            GameName = new DataGridViewTextBoxColumn();
            ReleaseDate = new DataGridViewTextBoxColumn();
            PublisherName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvGamesOfUser).BeginInit();
            SuspendLayout();
            // 
            // cmbUsers
            // 
            cmbUsers.DisplayMember = "UserName";
            cmbUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsers.Font = new Font("Segoe UI", 12F);
            cmbUsers.FormattingEnabled = true;
            cmbUsers.Location = new Point(12, 79);
            cmbUsers.Name = "cmbUsers";
            cmbUsers.Size = new Size(338, 36);
            cmbUsers.TabIndex = 1;
            cmbUsers.ValueMember = "Id";
            cmbUsers.SelectedIndexChanged += cmbUsers_SelectedIndexChanged;
            // 
            // dgvGamesOfUser
            // 
            dgvGamesOfUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGamesOfUser.Columns.AddRange(new DataGridViewColumn[] { Id, GameName, ReleaseDate, PublisherName });
            dgvGamesOfUser.Location = new Point(12, 122);
            dgvGamesOfUser.Name = "dgvGamesOfUser";
            dgvGamesOfUser.ReadOnly = true;
            dgvGamesOfUser.RowHeadersWidth = 51;
            dgvGamesOfUser.RowTemplate.Height = 29;
            dgvGamesOfUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGamesOfUser.Size = new Size(776, 316);
            dgvGamesOfUser.TabIndex = 2;
            dgvGamesOfUser.CellContentClick += dgvGamesOfUser_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // GameName
            // 
            GameName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GameName.DataPropertyName = "Name";
            GameName.HeaderText = "Name";
            GameName.MinimumWidth = 6;
            GameName.Name = "GameName";
            GameName.ReadOnly = true;
            // 
            // ReleaseDate
            // 
            ReleaseDate.DataPropertyName = "ReleaseDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = "NULL";
            ReleaseDate.DefaultCellStyle = dataGridViewCellStyle1;
            ReleaseDate.HeaderText = "Release";
            ReleaseDate.MinimumWidth = 6;
            ReleaseDate.Name = "ReleaseDate";
            ReleaseDate.ReadOnly = true;
            ReleaseDate.Width = 125;
            // 
            // PublisherName
            // 
            PublisherName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PublisherName.DataPropertyName = "Publisher";
            PublisherName.HeaderText = "Publisher";
            PublisherName.MinimumWidth = 6;
            PublisherName.Name = "PublisherName";
            PublisherName.ReadOnly = true;
            // 
            // frmAdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvGamesOfUser);
            Controls.Add(cmbUsers);
            Name = "frmAdminPanel";
            Text = "frmAdminPanel";
            ((System.ComponentModel.ISupportInitialize)dgvGamesOfUser).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cmbUsers;
        private DataGridView dgvGamesOfUser;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn GameName;
        private DataGridViewTextBoxColumn ReleaseDate;
        private DataGridViewTextBoxColumn PublisherName;
    }
}