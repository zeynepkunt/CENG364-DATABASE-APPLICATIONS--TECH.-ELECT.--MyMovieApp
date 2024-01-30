namespace MyMovieApp
{
    partial class FormFollowing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFollowing));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MovieApp = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tOPMOVIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tOP10MOVIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tOP25MOVIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLLMOVIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wATCHLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wATCHEDMOVIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gENREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fOLLOWINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fOLLOWERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblShowWatchlist = new System.Windows.Forms.Label();
            this.LblShowWatched = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbUsers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // MovieApp
            // 
            this.MovieApp.AutoSize = true;
            this.MovieApp.BackColor = System.Drawing.Color.Transparent;
            this.MovieApp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MovieApp.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MovieApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.MovieApp.Location = new System.Drawing.Point(93, 52);
            this.MovieApp.Name = "MovieApp";
            this.MovieApp.Size = new System.Drawing.Size(179, 51);
            this.MovieApp.TabIndex = 33;
            this.MovieApp.Text = "Following";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem,
            this.tOPMOVIESToolStripMenuItem,
            this.wATCHLISTToolStripMenuItem,
            this.wATCHEDMOVIESToolStripMenuItem,
            this.gENREToolStripMenuItem,
            this.fOLLOWINGToolStripMenuItem,
            this.fOLLOWERSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1216, 31);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homePageToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(119, 27);
            this.homePageToolStripMenuItem.Text = "HOME PAGE";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click);
            // 
            // tOPMOVIESToolStripMenuItem
            // 
            this.tOPMOVIESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tOP10MOVIESToolStripMenuItem,
            this.tOP25MOVIESToolStripMenuItem,
            this.aLLMOVIESToolStripMenuItem});
            this.tOPMOVIESToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tOPMOVIESToolStripMenuItem.Name = "tOPMOVIESToolStripMenuItem";
            this.tOPMOVIESToolStripMenuItem.Size = new System.Drawing.Size(110, 27);
            this.tOPMOVIESToolStripMenuItem.Text = "TOP  MOVIES";
            // 
            // tOP10MOVIESToolStripMenuItem
            // 
            this.tOP10MOVIESToolStripMenuItem.Name = "tOP10MOVIESToolStripMenuItem";
            this.tOP10MOVIESToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.tOP10MOVIESToolStripMenuItem.Text = "TOP 10 MOVIES";
            this.tOP10MOVIESToolStripMenuItem.Click += new System.EventHandler(this.tOP10MOVIESToolStripMenuItem_Click);
            // 
            // tOP25MOVIESToolStripMenuItem
            // 
            this.tOP25MOVIESToolStripMenuItem.Name = "tOP25MOVIESToolStripMenuItem";
            this.tOP25MOVIESToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.tOP25MOVIESToolStripMenuItem.Text = "TOP 25 MOVIES";
            this.tOP25MOVIESToolStripMenuItem.Click += new System.EventHandler(this.tOP25MOVIESToolStripMenuItem_Click);
            // 
            // aLLMOVIESToolStripMenuItem
            // 
            this.aLLMOVIESToolStripMenuItem.Name = "aLLMOVIESToolStripMenuItem";
            this.aLLMOVIESToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.aLLMOVIESToolStripMenuItem.Text = "ALL MOVIES";
            this.aLLMOVIESToolStripMenuItem.Click += new System.EventHandler(this.aLLMOVIESToolStripMenuItem_Click);
            // 
            // wATCHLISTToolStripMenuItem
            // 
            this.wATCHLISTToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.wATCHLISTToolStripMenuItem.Name = "wATCHLISTToolStripMenuItem";
            this.wATCHLISTToolStripMenuItem.Size = new System.Drawing.Size(99, 27);
            this.wATCHLISTToolStripMenuItem.Text = "WATCHLIST";
            this.wATCHLISTToolStripMenuItem.Click += new System.EventHandler(this.wATCHLISTToolStripMenuItem_Click);
            // 
            // wATCHEDMOVIESToolStripMenuItem
            // 
            this.wATCHEDMOVIESToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.wATCHEDMOVIESToolStripMenuItem.Name = "wATCHEDMOVIESToolStripMenuItem";
            this.wATCHEDMOVIESToolStripMenuItem.Size = new System.Drawing.Size(148, 27);
            this.wATCHEDMOVIESToolStripMenuItem.Text = "WATCHED MOVIES";
            this.wATCHEDMOVIESToolStripMenuItem.Click += new System.EventHandler(this.wATCHEDMOVIESToolStripMenuItem_Click);
            // 
            // gENREToolStripMenuItem
            // 
            this.gENREToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gENREToolStripMenuItem.Name = "gENREToolStripMenuItem";
            this.gENREToolStripMenuItem.Size = new System.Drawing.Size(69, 27);
            this.gENREToolStripMenuItem.Text = "GENRE";
            this.gENREToolStripMenuItem.Click += new System.EventHandler(this.gENREToolStripMenuItem_Click);
            // 
            // fOLLOWINGToolStripMenuItem
            // 
            this.fOLLOWINGToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fOLLOWINGToolStripMenuItem.Name = "fOLLOWINGToolStripMenuItem";
            this.fOLLOWINGToolStripMenuItem.Size = new System.Drawing.Size(104, 27);
            this.fOLLOWINGToolStripMenuItem.Text = "FOLLOWING";
            this.fOLLOWINGToolStripMenuItem.Click += new System.EventHandler(this.fOLLOWINGToolStripMenuItem_Click);
            // 
            // fOLLOWERSToolStripMenuItem
            // 
            this.fOLLOWERSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fOLLOWERSToolStripMenuItem.Name = "fOLLOWERSToolStripMenuItem";
            this.fOLLOWERSToolStripMenuItem.Size = new System.Drawing.Size(104, 27);
            this.fOLLOWERSToolStripMenuItem.Text = "FOLLOWERS";
            this.fOLLOWERSToolStripMenuItem.Click += new System.EventHandler(this.fOLLOWERSToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(607, 385);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // LblShowWatchlist
            // 
            this.LblShowWatchlist.AutoSize = true;
            this.LblShowWatchlist.BackColor = System.Drawing.Color.Transparent;
            this.LblShowWatchlist.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblShowWatchlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LblShowWatchlist.Location = new System.Drawing.Point(708, 442);
            this.LblShowWatchlist.Name = "LblShowWatchlist";
            this.LblShowWatchlist.Size = new System.Drawing.Size(310, 27);
            this.LblShowWatchlist.TabIndex = 36;
            this.LblShowWatchlist.Text = "Show selected friend\'s watchlist ";
            this.LblShowWatchlist.Click += new System.EventHandler(this.LblShowWatchlist_Click);
            // 
            // LblShowWatched
            // 
            this.LblShowWatched.AutoSize = true;
            this.LblShowWatched.BackColor = System.Drawing.Color.Transparent;
            this.LblShowWatched.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblShowWatched.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LblShowWatched.Location = new System.Drawing.Point(708, 508);
            this.LblShowWatched.Name = "LblShowWatched";
            this.LblShowWatched.Size = new System.Drawing.Size(361, 27);
            this.LblShowWatched.TabIndex = 37;
            this.LblShowWatched.Text = "Show selected friend\'s watched movies";
            this.LblShowWatched.Click += new System.EventHandler(this.LblShowWatched_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(24, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 43);
            this.label3.TabIndex = 38;
            this.label3.Text = "Follow new user !";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(591, 155);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(25, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 27);
            this.label4.TabIndex = 43;
            this.label4.Text = "Username :";
            // 
            // CmbUsers
            // 
            this.CmbUsers.FormattingEnabled = true;
            this.CmbUsers.Location = new System.Drawing.Point(180, 91);
            this.CmbUsers.Name = "CmbUsers";
            this.CmbUsers.Size = new System.Drawing.Size(121, 24);
            this.CmbUsers.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(45, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 37);
            this.label5.TabIndex = 45;
            this.label5.Text = "Following :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.CmbUsers);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(713, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 159);
            this.panel1.TabIndex = 46;
            // 
            // FormFollowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1216, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.LblShowWatched);
            this.Controls.Add(this.LblShowWatchlist);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.MovieApp);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFollowing";
            this.Text = "FormFollowing";
            this.Load += new System.EventHandler(this.FormFollowing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label MovieApp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tOPMOVIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tOP10MOVIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tOP25MOVIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLLMOVIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wATCHLISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wATCHEDMOVIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gENREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fOLLOWINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fOLLOWERSToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblShowWatchlist;
        private System.Windows.Forms.Label LblShowWatched;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}