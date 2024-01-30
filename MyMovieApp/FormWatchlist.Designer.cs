namespace MyMovieApp
{
    partial class FormWatchlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWatchlist));
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
            this.DeleteMovie = new System.Windows.Forms.PictureBox();
            this.AddMovie = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewComment = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComment)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 24;
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
            this.wATCHLISTToolStripMenuItem.Click += new System.EventHandler(this.wATCHLISTToolStripMenuItem_Click_1);
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
            this.pictureBox2.Location = new System.Drawing.Point(37, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // MovieApp
            // 
            this.MovieApp.AutoSize = true;
            this.MovieApp.BackColor = System.Drawing.Color.Transparent;
            this.MovieApp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MovieApp.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MovieApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.MovieApp.Location = new System.Drawing.Point(88, 55);
            this.MovieApp.Name = "MovieApp";
            this.MovieApp.Size = new System.Drawing.Size(135, 51);
            this.MovieApp.TabIndex = 27;
            this.MovieApp.Text = "Movies";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(391, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(339, 340);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // DeleteMovie
            // 
            this.DeleteMovie.BackColor = System.Drawing.Color.Transparent;
            this.DeleteMovie.Image = ((System.Drawing.Image)(resources.GetObject("DeleteMovie.Image")));
            this.DeleteMovie.Location = new System.Drawing.Point(678, 211);
            this.DeleteMovie.Name = "DeleteMovie";
            this.DeleteMovie.Size = new System.Drawing.Size(36, 40);
            this.DeleteMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteMovie.TabIndex = 33;
            this.DeleteMovie.TabStop = false;
            this.DeleteMovie.Click += new System.EventHandler(this.DeleteMovie_Click);
            // 
            // AddMovie
            // 
            this.AddMovie.BackColor = System.Drawing.Color.Transparent;
            this.AddMovie.Image = ((System.Drawing.Image)(resources.GetObject("AddMovie.Image")));
            this.AddMovie.Location = new System.Drawing.Point(307, 211);
            this.AddMovie.Name = "AddMovie";
            this.AddMovie.Size = new System.Drawing.Size(41, 40);
            this.AddMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddMovie.TabIndex = 31;
            this.AddMovie.TabStop = false;
            this.AddMovie.Tag = "";
            this.AddMovie.Click += new System.EventHandler(this.AddMovie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(394, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 37);
            this.label1.TabIndex = 34;
            this.label1.Text = "Watchlist :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 249);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(360, 340);
            this.dataGridView2.TabIndex = 42;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(31, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 34);
            this.label3.TabIndex = 44;
            this.label3.Text = "Let\'s add new movie";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(230, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(13, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 34);
            this.label2.TabIndex = 46;
            this.label2.Text = " to Watchlist :";
            // 
            // dataGridViewComment
            // 
            this.dataGridViewComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComment.Location = new System.Drawing.Point(749, 251);
            this.dataGridViewComment.Name = "dataGridViewComment";
            this.dataGridViewComment.RowHeadersWidth = 51;
            this.dataGridViewComment.RowTemplate.Height = 24;
            this.dataGridViewComment.Size = new System.Drawing.Size(455, 338);
            this.dataGridViewComment.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(757, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 37);
            this.label4.TabIndex = 48;
            this.label4.Text = "Comments :";
            // 
            // FormWatchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1216, 612);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteMovie);
            this.Controls.Add(this.AddMovie);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.MovieApp);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWatchlist";
            this.Text = "FormWatchlist";
            this.Load += new System.EventHandler(this.FormWatchlist_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label MovieApp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox DeleteMovie;
        private System.Windows.Forms.PictureBox AddMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewComment;
        private System.Windows.Forms.Label label4;
    }
}