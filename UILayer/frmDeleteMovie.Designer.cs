
namespace UILayer
{
    partial class frmDeleteMovie
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
            this.CListBoxMovie = new System.Windows.Forms.CheckedListBox();
            this.mysqlCinemaDataSet = new UILayer.mysqlCinemaDataSet();
            this.movieTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieTicketTableAdapter = new UILayer.mysqlCinemaDataSetTableAdapters.MovieTicketTableAdapter();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpExit = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mysqlCinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTicketBindingSource)).BeginInit();
            this.grpMain.SuspendLayout();
            this.grpExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // CListBoxMovie
            // 
            this.CListBoxMovie.FormattingEnabled = true;
            this.CListBoxMovie.Location = new System.Drawing.Point(40, 55);
            this.CListBoxMovie.Name = "CListBoxMovie";
            this.CListBoxMovie.Size = new System.Drawing.Size(207, 274);
            this.CListBoxMovie.TabIndex = 0;
            // 
            // mysqlCinemaDataSet
            // 
            this.mysqlCinemaDataSet.DataSetName = "mysqlCinemaDataSet";
            this.mysqlCinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieTicketBindingSource
            // 
            this.movieTicketBindingSource.DataMember = "MovieTicket";
            this.movieTicketBindingSource.DataSource = this.mysqlCinemaDataSet;
            // 
            // movieTicketTableAdapter
            // 
            this.movieTicketTableAdapter.ClearBeforeFill = true;
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(86, 19);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(121, 21);
            this.cmbGenre.TabIndex = 1;
            this.cmbGenre.SelectedIndexChanged += new System.EventHandler(this.cmbGenre_SelectedIndexChanged);
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.btnSubmit);
            this.grpMain.Controls.Add(this.CListBoxMovie);
            this.grpMain.Controls.Add(this.cmbGenre);
            this.grpMain.Location = new System.Drawing.Point(12, 45);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(287, 387);
            this.grpMain.TabIndex = 2;
            this.grpMain.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(108, 349);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // grpExit
            // 
            this.grpExit.Controls.Add(this.btnExit);
            this.grpExit.Location = new System.Drawing.Point(358, 45);
            this.grpExit.Name = "grpExit";
            this.grpExit.Size = new System.Drawing.Size(258, 83);
            this.grpExit.TabIndex = 3;
            this.grpExit.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(156, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 475);
            this.Controls.Add(this.grpExit);
            this.Controls.Add(this.grpMain);
            this.Name = "frmDeleteMovie";
            this.Text = "frmDeleteMovie";
            ((System.ComponentModel.ISupportInitialize)(this.mysqlCinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTicketBindingSource)).EndInit();
            this.grpMain.ResumeLayout(false);
            this.grpExit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CListBoxMovie;
        private mysqlCinemaDataSet mysqlCinemaDataSet;
        private System.Windows.Forms.BindingSource movieTicketBindingSource;
        private mysqlCinemaDataSetTableAdapters.MovieTicketTableAdapter movieTicketTableAdapter;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpExit;
        private System.Windows.Forms.Button btnExit;
    }
}