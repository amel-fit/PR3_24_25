namespace TinyGameStore_G2
{
    partial class frmStore
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvGames = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            GameName = new DataGridViewTextBoxColumn();
            ReleaseDate = new DataGridViewTextBoxColumn();
            PublisherName = new DataGridViewTextBoxColumn();
            lblUsername = new Label();
            inMemoryDbBindingSource = new BindingSource(components);
            btnBuy = new Button();
            btnAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inMemoryDbBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvGames
            // 
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Columns.AddRange(new DataGridViewColumn[] { Id, GameName, ReleaseDate, PublisherName });
            dgvGames.Location = new Point(12, 135);
            dgvGames.Name = "dgvGames";
            dgvGames.ReadOnly = true;
            dgvGames.RowHeadersWidth = 51;
            dgvGames.RowTemplate.Height = 29;
            dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGames.Size = new Size(890, 400);
            dgvGames.TabIndex = 1;
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
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(12, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(220, 54);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "[username]";
            // 
            // inMemoryDbBindingSource
            // 
            inMemoryDbBindingSource.DataSource = typeof(TinyGameStore.InMemory.InMemoryDb);
            // 
            // btnBuy
            // 
            btnBuy.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuy.Location = new Point(781, 552);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(121, 36);
            btnBuy.TabIndex = 3;
            btnBuy.Text = "BUY";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(12, 552);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(122, 29);
            btnAdmin.TabIndex = 4;
            btnAdmin.Text = "Administration";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // frmStore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnAdmin);
            Controls.Add(btnBuy);
            Controls.Add(lblUsername);
            Controls.Add(dgvGames);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmStore";
            Text = "Tiny game store";
            FormClosed += frmStore_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ((System.ComponentModel.ISupportInitialize)inMemoryDbBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGames;
        private Label lblUsername;
        private BindingSource inMemoryDbBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn GameName;
        private DataGridViewTextBoxColumn ReleaseDate;
        private DataGridViewTextBoxColumn PublisherName;
        private Button btnBuy;
        private Button btnAdmin;
    }
}