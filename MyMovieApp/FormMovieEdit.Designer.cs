namespace MyMovieApp
{
    partial class FormMovieEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovieEdit));
            this.lblId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.CmbGenre = new System.Windows.Forms.ComboBox();
            this.tblGenreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIEDataSet7 = new MyMovieApp.MOVIEDataSet7();
            this.LblGenre = new System.Windows.Forms.Label();
            this.TxtContent = new System.Windows.Forms.RichTextBox();
            this.LblRating = new System.Windows.Forms.Label();
            this.TxtRating = new System.Windows.Forms.TextBox();
            this.LblWriter = new System.Windows.Forms.Label();
            this.TxtWriter = new System.Windows.Forms.TextBox();
            this.LblDirector = new System.Windows.Forms.Label();
            this.TxtDirector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMovieName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tblGenreTableAdapter = new MyMovieApp.MOVIEDataSet7TableAdapters.TblGenreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblGenreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblId.Location = new System.Drawing.Point(45, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(58, 16);
            this.lblId.TabIndex = 38;
            this.lblId.Text = "Movie Id";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(141, 36);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(191, 22);
            this.TxtId.TabIndex = 37;
            // 
            // CmbGenre
            // 
            this.CmbGenre.DataSource = this.tblGenreBindingSource;
            this.CmbGenre.DisplayMember = "Name";
            this.CmbGenre.FormattingEnabled = true;
            this.CmbGenre.Location = new System.Drawing.Point(141, 412);
            this.CmbGenre.Name = "CmbGenre";
            this.CmbGenre.Size = new System.Drawing.Size(191, 24);
            this.CmbGenre.TabIndex = 36;
            this.CmbGenre.ValueMember = "Id";
            // 
            // tblGenreBindingSource
            // 
            this.tblGenreBindingSource.DataMember = "TblGenre";
            this.tblGenreBindingSource.DataSource = this.mOVIEDataSet7;
            // 
            // mOVIEDataSet7
            // 
            this.mOVIEDataSet7.DataSetName = "MOVIEDataSet7";
            this.mOVIEDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LblGenre
            // 
            this.LblGenre.AutoSize = true;
            this.LblGenre.BackColor = System.Drawing.Color.Transparent;
            this.LblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGenre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblGenre.Location = new System.Drawing.Point(45, 415);
            this.LblGenre.Name = "LblGenre";
            this.LblGenre.Size = new System.Drawing.Size(44, 16);
            this.LblGenre.TabIndex = 35;
            this.LblGenre.Text = "Genre";
            // 
            // TxtContent
            // 
            this.TxtContent.Location = new System.Drawing.Point(141, 134);
            this.TxtContent.Name = "TxtContent";
            this.TxtContent.Size = new System.Drawing.Size(191, 108);
            this.TxtContent.TabIndex = 34;
            this.TxtContent.Text = "";
            // 
            // LblRating
            // 
            this.LblRating.AutoSize = true;
            this.LblRating.BackColor = System.Drawing.Color.Transparent;
            this.LblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRating.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblRating.Location = new System.Drawing.Point(45, 368);
            this.LblRating.Name = "LblRating";
            this.LblRating.Size = new System.Drawing.Size(46, 16);
            this.LblRating.TabIndex = 33;
            this.LblRating.Text = "Rating";
            // 
            // TxtRating
            // 
            this.TxtRating.Location = new System.Drawing.Point(141, 365);
            this.TxtRating.Name = "TxtRating";
            this.TxtRating.Size = new System.Drawing.Size(191, 22);
            this.TxtRating.TabIndex = 32;
            // 
            // LblWriter
            // 
            this.LblWriter.AutoSize = true;
            this.LblWriter.BackColor = System.Drawing.Color.Transparent;
            this.LblWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblWriter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblWriter.Location = new System.Drawing.Point(45, 322);
            this.LblWriter.Name = "LblWriter";
            this.LblWriter.Size = new System.Drawing.Size(42, 16);
            this.LblWriter.TabIndex = 31;
            this.LblWriter.Text = "Writer";
            // 
            // TxtWriter
            // 
            this.TxtWriter.Location = new System.Drawing.Point(141, 319);
            this.TxtWriter.Name = "TxtWriter";
            this.TxtWriter.Size = new System.Drawing.Size(191, 22);
            this.TxtWriter.TabIndex = 30;
            // 
            // LblDirector
            // 
            this.LblDirector.AutoSize = true;
            this.LblDirector.BackColor = System.Drawing.Color.Transparent;
            this.LblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDirector.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblDirector.Location = new System.Drawing.Point(45, 275);
            this.LblDirector.Name = "LblDirector";
            this.LblDirector.Size = new System.Drawing.Size(54, 16);
            this.LblDirector.TabIndex = 29;
            this.LblDirector.Text = "Director";
            // 
            // TxtDirector
            // 
            this.TxtDirector.Location = new System.Drawing.Point(141, 272);
            this.TxtDirector.Name = "TxtDirector";
            this.TxtDirector.Size = new System.Drawing.Size(191, 22);
            this.TxtDirector.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(45, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(45, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Movie Name";
            // 
            // TxtMovieName
            // 
            this.TxtMovieName.Location = new System.Drawing.Point(141, 85);
            this.TxtMovieName.Name = "TxtMovieName";
            this.TxtMovieName.Size = new System.Drawing.Size(191, 22);
            this.TxtMovieName.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 39;
            this.button1.Text = "Update Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblGenreTableAdapter
            // 
            this.tblGenreTableAdapter.ClearBeforeFill = true;
            // 
            // FormMovieEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(404, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.CmbGenre);
            this.Controls.Add(this.LblGenre);
            this.Controls.Add(this.TxtContent);
            this.Controls.Add(this.LblRating);
            this.Controls.Add(this.TxtRating);
            this.Controls.Add(this.LblWriter);
            this.Controls.Add(this.TxtWriter);
            this.Controls.Add(this.LblDirector);
            this.Controls.Add(this.TxtDirector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtMovieName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMovieEdit";
            this.Text = "FormMovieEdit";
            this.Load += new System.EventHandler(this.FormMovieEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblGenreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.ComboBox CmbGenre;
        private System.Windows.Forms.Label LblGenre;
        private System.Windows.Forms.RichTextBox TxtContent;
        private System.Windows.Forms.Label LblRating;
        private System.Windows.Forms.TextBox TxtRating;
        private System.Windows.Forms.Label LblWriter;
        private System.Windows.Forms.TextBox TxtWriter;
        private System.Windows.Forms.Label LblDirector;
        private System.Windows.Forms.TextBox TxtDirector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMovieName;
        private System.Windows.Forms.Button button1;
        private MOVIEDataSet7 mOVIEDataSet7;
        private System.Windows.Forms.BindingSource tblGenreBindingSource;
        private MOVIEDataSet7TableAdapters.TblGenreTableAdapter tblGenreTableAdapter;
    }
}