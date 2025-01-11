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
            AverageRating = new DataGridViewTextBoxColumn();
            GameName = new DataGridViewTextBoxColumn();
            ReleaseDate = new DataGridViewTextBoxColumn();
            PublisherName = new DataGridViewTextBoxColumn();
            lblUsername = new Label();
            inMemoryDbBindingSource = new BindingSource(components);
            btnBuy = new Button();
            btnAdmin = new Button();
            btnCreateTable = new Button();
            Insert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSelect = new Button();
            lstGenres = new ListBox();
            btnAssignGenres = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inMemoryDbBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvGames
            // 
            dgvGames.AllowUserToAddRows = false;
            dgvGames.AllowUserToDeleteRows = false;
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Columns.AddRange(new DataGridViewColumn[] { Id, AverageRating, GameName, ReleaseDate, PublisherName });
            dgvGames.Location = new Point(12, 135);
            dgvGames.Name = "dgvGames";
            dgvGames.ReadOnly = true;
            dgvGames.RowHeadersWidth = 51;
            dgvGames.RowTemplate.Height = 29;
            dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGames.Size = new Size(890, 376);
            dgvGames.TabIndex = 1;
            dgvGames.CellDoubleClick += dgvGames_CellDoubleClick;
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
            // AverageRating
            // 
            AverageRating.DataPropertyName = "AverageRating";
            AverageRating.HeaderText = "Rating";
            AverageRating.MinimumWidth = 6;
            AverageRating.Name = "AverageRating";
            AverageRating.ReadOnly = true;
            AverageRating.Width = 125;
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
            lblUsername.Font = new Font("Segoe UI", 24F);
            lblUsername.Location = new Point(12, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(220, 54);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "[username]";
            // 
            // inMemoryDbBindingSource
            // 
            inMemoryDbBindingSource.DataSource = typeof(TinyGameStore.InMemory.DBActions);
            // 
            // btnBuy
            // 
            btnBuy.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
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
            // btnCreateTable
            // 
            btnCreateTable.Location = new Point(170, 527);
            btnCreateTable.Name = "btnCreateTable";
            btnCreateTable.Size = new Size(111, 29);
            btnCreateTable.TabIndex = 5;
            btnCreateTable.Text = "Create Table";
            btnCreateTable.UseVisualStyleBackColor = true;
            btnCreateTable.Click += btnCreateTable_Click;
            // 
            // Insert
            // 
            Insert.Location = new Point(170, 562);
            Insert.Name = "Insert";
            Insert.Size = new Size(111, 29);
            Insert.TabIndex = 5;
            Insert.Text = "Insert Row";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += Insert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(287, 527);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update Row";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(287, 562);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Row";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(404, 542);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(111, 29);
            btnSelect.TabIndex = 5;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // lstGenres
            // 
            lstGenres.FormattingEnabled = true;
            lstGenres.ImeMode = ImeMode.NoControl;
            lstGenres.ItemHeight = 20;
            lstGenres.Location = new Point(908, 161);
            lstGenres.Name = "lstGenres";
            lstGenres.SelectionMode = SelectionMode.MultiSimple;
            lstGenres.Size = new Size(150, 304);
            lstGenres.TabIndex = 6;
            // 
            // btnAssignGenres
            // 
            btnAssignGenres.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnAssignGenres.Location = new Point(908, 475);
            btnAssignGenres.Name = "btnAssignGenres";
            btnAssignGenres.Size = new Size(150, 36);
            btnAssignGenres.TabIndex = 3;
            btnAssignGenres.Text = "ASSIGN";
            btnAssignGenres.UseVisualStyleBackColor = true;
            btnAssignGenres.Click += btnAssignGenres_Click;
            // 
            // frmStore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 600);
            Controls.Add(lstGenres);
            Controls.Add(btnSelect);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(Insert);
            Controls.Add(btnCreateTable);
            Controls.Add(btnAdmin);
            Controls.Add(btnAssignGenres);
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
        private Button btnBuy;
        private Button btnAdmin;
        private Button btnCreateTable;
        private Button Insert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSelect;
        private ListBox lstGenres;
        private Button btnAssignGenres;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn AverageRating;
        private DataGridViewTextBoxColumn GameName;
        private DataGridViewTextBoxColumn ReleaseDate;
        private DataGridViewTextBoxColumn PublisherName;
    }
}