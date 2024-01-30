namespace MyMovieApp
{
    partial class FormGenre_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenre_User));
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CmbGenre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieApp
            // 
            this.MovieApp.AutoSize = true;
            this.MovieApp.BackColor = System.Drawing.Color.Transparent;
            this.MovieApp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MovieApp.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MovieApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.MovieApp.Location = new System.Drawing.Point(90, 54);
            this.MovieApp.Name = "MovieApp";
            this.MovieApp.Size = new System.Drawing.Size(126, 51);
            this.MovieApp.TabIndex = 33;
            this.MovieApp.Text = "Genres";
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
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // CmbGenre
            // 
            this.CmbGenre.FormattingEnabled = true;
            this.CmbGenre.Location = new System.Drawing.Point(39, 186);
            this.CmbGenre.Name = "CmbGenre";
            this.CmbGenre.Size = new System.Drawing.Size(121, 24);
            this.CmbGenre.TabIndex = 35;
            this.CmbGenre.SelectedIndexChanged += new System.EventHandler(this.CmbGenre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(43, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 27);
            this.label1.TabIndex = 36;
            this.label1.Text = "Please select a movie genre below";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1113, 359);
            this.dataGridView1.TabIndex = 37;
            // 
            // FormGenre_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1216, 612);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbGenre);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.MovieApp);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGenre_User";
            this.Text = "FormGenre_User";
            this.Load += new System.EventHandler(this.FormGenre_User_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox CmbGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}