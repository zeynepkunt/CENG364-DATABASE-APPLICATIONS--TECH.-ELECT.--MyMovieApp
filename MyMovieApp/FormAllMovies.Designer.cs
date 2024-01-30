namespace MyMovieApp
{
    partial class FormAllMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllMovies));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MovieApp = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblAddWatchlist = new System.Windows.Forms.Label();
            this.LblAddWatched = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-83, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
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
            this.menuStrip1.TabIndex = 23;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // MovieApp
            // 
            this.MovieApp.AutoSize = true;
            this.MovieApp.BackColor = System.Drawing.Color.Transparent;
            this.MovieApp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MovieApp.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MovieApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.MovieApp.Location = new System.Drawing.Point(80, 62);
            this.MovieApp.Name = "MovieApp";
            this.MovieApp.Size = new System.Drawing.Size(135, 51);
            this.MovieApp.TabIndex = 25;
            this.MovieApp.Text = "Movies";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(80, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 384);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // LblAddWatchlist
            // 
            this.LblAddWatchlist.AutoSize = true;
            this.LblAddWatchlist.BackColor = System.Drawing.Color.LavenderBlush;
            this.LblAddWatchlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAddWatchlist.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddWatchlist.ForeColor = System.Drawing.Color.DarkViolet;
            this.LblAddWatchlist.Location = new System.Drawing.Point(671, 174);
            this.LblAddWatchlist.Name = "LblAddWatchlist";
            this.LblAddWatchlist.Size = new System.Drawing.Size(167, 29);
            this.LblAddWatchlist.TabIndex = 27;
            this.LblAddWatchlist.Text = "Add to Watchlist";
            this.LblAddWatchlist.Visible = false;
            this.LblAddWatchlist.Click += new System.EventHandler(this.LblAddWatchlist_Click);
            // 
            // LblAddWatched
            // 
            this.LblAddWatched.AutoSize = true;
            this.LblAddWatched.BackColor = System.Drawing.Color.LavenderBlush;
            this.LblAddWatched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAddWatched.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddWatched.ForeColor = System.Drawing.Color.DarkViolet;
            this.LblAddWatched.Location = new System.Drawing.Point(871, 174);
            this.LblAddWatched.Name = "LblAddWatched";
            this.LblAddWatched.Size = new System.Drawing.Size(233, 29);
            this.LblAddWatched.TabIndex = 28;
            this.LblAddWatched.Text = "Add to Watched Movies";
            this.LblAddWatched.Visible = false;
            this.LblAddWatched.Click += new System.EventHandler(this.LblAddWatched_Click);
            // 
            // FormAllMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1216, 612);
            this.Controls.Add(this.LblAddWatched);
            this.Controls.Add(this.LblAddWatchlist);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.MovieApp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAllMovies";
            this.Text = "FormAllMovies";
            this.Load += new System.EventHandler(this.FormAllMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tOPMOVIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tOP10MOVIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tOP25MOVIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wATCHLISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wATCHEDMOVIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gENREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fOLLOWINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fOLLOWERSToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label MovieApp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem aLLMOVIESToolStripMenuItem;
        private System.Windows.Forms.Label LblAddWatchlist;
        private System.Windows.Forms.Label LblAddWatched;
    }
}