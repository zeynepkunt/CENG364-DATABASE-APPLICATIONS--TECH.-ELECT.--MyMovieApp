namespace MyMovieApp
{
    partial class FormMovie
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovie));
            this.tblMovieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIEDataSet1 = new MyMovieApp.MOVIEDataSet1();
            this.tblMovieTableAdapter = new MyMovieApp.MOVIEDataSet1TableAdapters.TblMovieTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.tblGenreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIEDataSet6 = new MyMovieApp.MOVIEDataSet6();
            this.tblGenreTableAdapter = new MyMovieApp.MOVIEDataSet6TableAdapters.TblGenreTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOVIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.addMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gENRESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtMovieName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDirector = new System.Windows.Forms.TextBox();
            this.LblDirector = new System.Windows.Forms.Label();
            this.TxtWriter = new System.Windows.Forms.TextBox();
            this.LblWriter = new System.Windows.Forms.Label();
            this.TxtRating = new System.Windows.Forms.TextBox();
            this.LblRating = new System.Windows.Forms.Label();
            this.TxtContent = new System.Windows.Forms.RichTextBox();
            this.LblGenre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.CmbGenre = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGenreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEDataSet6)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMovieBindingSource
            // 
            this.tblMovieBindingSource.DataMember = "TblMovie";
            this.tblMovieBindingSource.DataSource = this.mOVIEDataSet1;
            // 
            // mOVIEDataSet1
            // 
            this.mOVIEDataSet1.DataSetName = "MOVIEDataSet1";
            this.mOVIEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMovieTableAdapter
            // 
            this.tblMovieTableAdapter.ClearBeforeFill = true;
            // 
            // tblGenreBindingSource
            // 
            this.tblGenreBindingSource.DataMember = "TblGenre";
            this.tblGenreBindingSource.DataSource = this.mOVIEDataSet6;
            // 
            // mOVIEDataSet6
            // 
            this.mOVIEDataSet6.DataSetName = "MOVIEDataSet6";
            this.mOVIEDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblGenreTableAdapter
            // 
            this.tblGenreTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.mOVIESToolStripMenuItem,
            this.gENRESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1231, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userListsToolStripMenuItem,
            this.addUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.updateUserToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.usersToolStripMenuItem.Text = "USERS";
            // 
            // userListsToolStripMenuItem
            // 
            this.userListsToolStripMenuItem.Name = "userListsToolStripMenuItem";
            this.userListsToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.userListsToolStripMenuItem.Text = "User List";
            this.userListsToolStripMenuItem.Click += new System.EventHandler(this.userListsToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.updateUserToolStripMenuItem.Text = "Edit User";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // mOVIESToolStripMenuItem
            // 
            this.mOVIESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.addMovieToolStripMenuItem,
            this.deleteMovieToolStripMenuItem,
            this.editMovieToolStripMenuItem});
            this.mOVIESToolStripMenuItem.Name = "mOVIESToolStripMenuItem";
            this.mOVIESToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.mOVIESToolStripMenuItem.Text = "MOVIES";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItem2.Text = "Movie List";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // addMovieToolStripMenuItem
            // 
            this.addMovieToolStripMenuItem.Name = "addMovieToolStripMenuItem";
            this.addMovieToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.addMovieToolStripMenuItem.Text = "Add Movie";
            this.addMovieToolStripMenuItem.Click += new System.EventHandler(this.addMovieToolStripMenuItem_Click);
            // 
            // deleteMovieToolStripMenuItem
            // 
            this.deleteMovieToolStripMenuItem.Name = "deleteMovieToolStripMenuItem";
            this.deleteMovieToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.deleteMovieToolStripMenuItem.Text = "Delete Movie";
            this.deleteMovieToolStripMenuItem.Click += new System.EventHandler(this.deleteMovieToolStripMenuItem_Click);
            // 
            // editMovieToolStripMenuItem
            // 
            this.editMovieToolStripMenuItem.Name = "editMovieToolStripMenuItem";
            this.editMovieToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.editMovieToolStripMenuItem.Text = "Edit Movie";
            this.editMovieToolStripMenuItem.Click += new System.EventHandler(this.editMovieToolStripMenuItem_Click);
            // 
            // gENRESToolStripMenuItem
            // 
            this.gENRESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.addGenreToolStripMenuItem,
            this.deleteGenreToolStripMenuItem,
            this.editGenreToolStripMenuItem});
            this.gENRESToolStripMenuItem.Name = "gENRESToolStripMenuItem";
            this.gENRESToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.gENRESToolStripMenuItem.Text = "GENRES";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.toolStripMenuItem1.Text = "Genre List";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // addGenreToolStripMenuItem
            // 
            this.addGenreToolStripMenuItem.Name = "addGenreToolStripMenuItem";
            this.addGenreToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.addGenreToolStripMenuItem.Text = "Add Genre";
            this.addGenreToolStripMenuItem.Click += new System.EventHandler(this.addGenreToolStripMenuItem_Click);
            // 
            // deleteGenreToolStripMenuItem
            // 
            this.deleteGenreToolStripMenuItem.Name = "deleteGenreToolStripMenuItem";
            this.deleteGenreToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.deleteGenreToolStripMenuItem.Text = "Delete Genre";
            this.deleteGenreToolStripMenuItem.Click += new System.EventHandler(this.deleteGenreToolStripMenuItem_Click);
            // 
            // editGenreToolStripMenuItem
            // 
            this.editGenreToolStripMenuItem.Name = "editGenreToolStripMenuItem";
            this.editGenreToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.editGenreToolStripMenuItem.Text = "Edit Genre";
            this.editGenreToolStripMenuItem.Click += new System.EventHandler(this.editGenreToolStripMenuItem_Click);
            // 
            // TxtMovieName
            // 
            this.TxtMovieName.Location = new System.Drawing.Point(120, 225);
            this.TxtMovieName.Name = "TxtMovieName";
            this.TxtMovieName.Size = new System.Drawing.Size(191, 22);
            this.TxtMovieName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(30, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(30, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Content";
            // 
            // TxtDirector
            // 
            this.TxtDirector.Location = new System.Drawing.Point(120, 388);
            this.TxtDirector.Name = "TxtDirector";
            this.TxtDirector.Size = new System.Drawing.Size(191, 22);
            this.TxtDirector.TabIndex = 4;
            // 
            // LblDirector
            // 
            this.LblDirector.AutoSize = true;
            this.LblDirector.BackColor = System.Drawing.Color.Transparent;
            this.LblDirector.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblDirector.Location = new System.Drawing.Point(30, 391);
            this.LblDirector.Name = "LblDirector";
            this.LblDirector.Size = new System.Drawing.Size(54, 16);
            this.LblDirector.TabIndex = 5;
            this.LblDirector.Text = "Director";
            // 
            // TxtWriter
            // 
            this.TxtWriter.Location = new System.Drawing.Point(120, 429);
            this.TxtWriter.Name = "TxtWriter";
            this.TxtWriter.Size = new System.Drawing.Size(191, 22);
            this.TxtWriter.TabIndex = 6;
            // 
            // LblWriter
            // 
            this.LblWriter.AutoSize = true;
            this.LblWriter.BackColor = System.Drawing.Color.Transparent;
            this.LblWriter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblWriter.Location = new System.Drawing.Point(30, 432);
            this.LblWriter.Name = "LblWriter";
            this.LblWriter.Size = new System.Drawing.Size(42, 16);
            this.LblWriter.TabIndex = 7;
            this.LblWriter.Text = "Writer";
            // 
            // TxtRating
            // 
            this.TxtRating.Location = new System.Drawing.Point(120, 468);
            this.TxtRating.Name = "TxtRating";
            this.TxtRating.Size = new System.Drawing.Size(191, 22);
            this.TxtRating.TabIndex = 12;
            // 
            // LblRating
            // 
            this.LblRating.AutoSize = true;
            this.LblRating.BackColor = System.Drawing.Color.Transparent;
            this.LblRating.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblRating.Location = new System.Drawing.Point(30, 471);
            this.LblRating.Name = "LblRating";
            this.LblRating.Size = new System.Drawing.Size(46, 16);
            this.LblRating.TabIndex = 13;
            this.LblRating.Text = "Rating";
            // 
            // TxtContent
            // 
            this.TxtContent.Location = new System.Drawing.Point(120, 264);
            this.TxtContent.Name = "TxtContent";
            this.TxtContent.Size = new System.Drawing.Size(191, 108);
            this.TxtContent.TabIndex = 14;
            this.TxtContent.Text = "";
            // 
            // LblGenre
            // 
            this.LblGenre.AutoSize = true;
            this.LblGenre.BackColor = System.Drawing.Color.Transparent;
            this.LblGenre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblGenre.Location = new System.Drawing.Point(30, 508);
            this.LblGenre.Name = "LblGenre";
            this.LblGenre.Size = new System.Drawing.Size(44, 16);
            this.LblGenre.TabIndex = 16;
            this.LblGenre.Text = "Genre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(271, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(216, 119);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.Color.Silver;
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(120, 188);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(191, 22);
            this.TxtId.TabIndex = 23;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblId.Location = new System.Drawing.Point(30, 191);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(58, 16);
            this.lblId.TabIndex = 24;
            this.lblId.Text = "Movie Id";
            // 
            // CmbGenre
            // 
            this.CmbGenre.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblMovieBindingSource, "GenreId", true));
            this.CmbGenre.DataSource = this.tblGenreBindingSource;
            this.CmbGenre.DisplayMember = "Name";
            this.CmbGenre.FormattingEnabled = true;
            this.CmbGenre.Location = new System.Drawing.Point(120, 505);
            this.CmbGenre.Name = "CmbGenre";
            this.CmbGenre.Size = new System.Drawing.Size(191, 24);
            this.CmbGenre.TabIndex = 25;
            this.CmbGenre.ValueMember = "Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 448);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FormMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1231, 618);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.CmbGenre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblGenre);
            this.Controls.Add(this.TxtContent);
            this.Controls.Add(this.LblRating);
            this.Controls.Add(this.TxtRating);
            this.Controls.Add(this.LblWriter);
            this.Controls.Add(this.TxtWriter);
            this.Controls.Add(this.LblDirector);
            this.Controls.Add(this.TxtDirector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMovieName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMovie";
            this.Text = "FormMovie";
            this.Load += new System.EventHandler(this.FormMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblMovieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGenreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEDataSet6)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MOVIEDataSet1 mOVIEDataSet1;
        private System.Windows.Forms.BindingSource tblMovieBindingSource;
        private MOVIEDataSet1TableAdapters.TblMovieTableAdapter tblMovieTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private MOVIEDataSet6 mOVIEDataSet6;
        private System.Windows.Forms.BindingSource tblGenreBindingSource;
        private MOVIEDataSet6TableAdapters.TblGenreTableAdapter tblGenreTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOVIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gENRESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGenreToolStripMenuItem;
        private System.Windows.Forms.TextBox TxtMovieName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDirector;
        private System.Windows.Forms.Label LblDirector;
        private System.Windows.Forms.TextBox TxtWriter;
        private System.Windows.Forms.Label LblWriter;
        private System.Windows.Forms.TextBox TxtRating;
        private System.Windows.Forms.Label LblRating;
        private System.Windows.Forms.RichTextBox TxtContent;
        private System.Windows.Forms.Label LblGenre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox CmbGenre;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}