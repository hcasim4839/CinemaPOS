
namespace UILayer
{
    partial class frmTickets
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
            this.grpPaymentNeeded = new System.Windows.Forms.GroupBox();
            this.btnPayPoints = new System.Windows.Forms.Button();
            this.btnPayCreditCard = new System.Windows.Forms.Button();
            this.btnPayCash = new System.Windows.Forms.Button();
            this.lstBoxPaymentNeeded = new System.Windows.Forms.ListBox();
            this.grpMovies = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lstViewMovies = new System.Windows.Forms.ListView();
            this.cmbMovieGenre = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.grpPaymentNeeded.SuspendLayout();
            this.grpMovies.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPaymentNeeded
            // 
            this.grpPaymentNeeded.Controls.Add(this.btnPayPoints);
            this.grpPaymentNeeded.Controls.Add(this.btnPayCreditCard);
            this.grpPaymentNeeded.Controls.Add(this.btnPayCash);
            this.grpPaymentNeeded.Controls.Add(this.lstBoxPaymentNeeded);
            this.grpPaymentNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPaymentNeeded.Location = new System.Drawing.Point(11, 77);
            this.grpPaymentNeeded.Name = "grpPaymentNeeded";
            this.grpPaymentNeeded.Size = new System.Drawing.Size(250, 382);
            this.grpPaymentNeeded.TabIndex = 0;
            this.grpPaymentNeeded.TabStop = false;
            this.grpPaymentNeeded.Text = "  ";
            // 
            // btnPayPoints
            // 
            this.btnPayPoints.Location = new System.Drawing.Point(138, 302);
            this.btnPayPoints.Name = "btnPayPoints";
            this.btnPayPoints.Size = new System.Drawing.Size(106, 23);
            this.btnPayPoints.TabIndex = 4;
            this.btnPayPoints.Text = "Points Payment";
            this.btnPayPoints.UseVisualStyleBackColor = true;
            this.btnPayPoints.Click += new System.EventHandler(this.btnPayPoints_Click);
            // 
            // btnPayCreditCard
            // 
            this.btnPayCreditCard.Location = new System.Drawing.Point(6, 333);
            this.btnPayCreditCard.Name = "btnPayCreditCard";
            this.btnPayCreditCard.Size = new System.Drawing.Size(238, 23);
            this.btnPayCreditCard.TabIndex = 3;
            this.btnPayCreditCard.Text = "Credit Card Payment";
            this.btnPayCreditCard.UseVisualStyleBackColor = true;
            // 
            // btnPayCash
            // 
            this.btnPayCash.Location = new System.Drawing.Point(6, 302);
            this.btnPayCash.Name = "btnPayCash";
            this.btnPayCash.Size = new System.Drawing.Size(107, 23);
            this.btnPayCash.TabIndex = 2;
            this.btnPayCash.Text = "Cash Payment";
            this.btnPayCash.UseVisualStyleBackColor = true;
            this.btnPayCash.Click += new System.EventHandler(this.btnPayCash_Click);
            // 
            // lstBoxPaymentNeeded
            // 
            this.lstBoxPaymentNeeded.FormattingEnabled = true;
            this.lstBoxPaymentNeeded.Location = new System.Drawing.Point(6, 32);
            this.lstBoxPaymentNeeded.Name = "lstBoxPaymentNeeded";
            this.lstBoxPaymentNeeded.Size = new System.Drawing.Size(238, 264);
            this.lstBoxPaymentNeeded.TabIndex = 1;
            this.lstBoxPaymentNeeded.Click += new System.EventHandler(this.lstBoxPaymentNeeded_Click);
            // 
            // grpMovies
            // 
            this.grpMovies.Controls.Add(this.btnEnter);
            this.grpMovies.Controls.Add(this.lstViewMovies);
            this.grpMovies.Controls.Add(this.cmbMovieGenre);
            this.grpMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMovies.Location = new System.Drawing.Point(281, 77);
            this.grpMovies.Name = "grpMovies";
            this.grpMovies.Size = new System.Drawing.Size(462, 356);
            this.grpMovies.TabIndex = 1;
            this.grpMovies.TabStop = false;
            this.grpMovies.Text = "Movie Selections";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(271, 19);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lstViewMovies
            // 
            this.lstViewMovies.HideSelection = false;
            this.lstViewMovies.Location = new System.Drawing.Point(21, 62);
            this.lstViewMovies.Name = "lstViewMovies";
            this.lstViewMovies.OwnerDraw = true;
            this.lstViewMovies.Size = new System.Drawing.Size(423, 234);
            this.lstViewMovies.TabIndex = 1;
            this.lstViewMovies.UseCompatibleStateImageBehavior = false;
            this.lstViewMovies.View = System.Windows.Forms.View.List;
            this.lstViewMovies.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lstViewMovies_DrawItem);
            this.lstViewMovies.Click += new System.EventHandler(this.lstViewMovies_Click);
            // 
            // cmbMovieGenre
            // 
            this.cmbMovieGenre.FormattingEnabled = true;
            this.cmbMovieGenre.Location = new System.Drawing.Point(115, 19);
            this.cmbMovieGenre.Name = "cmbMovieGenre";
            this.cmbMovieGenre.Size = new System.Drawing.Size(121, 21);
            this.cmbMovieGenre.TabIndex = 0;
            this.cmbMovieGenre.SelectedIndexChanged += new System.EventHandler(this.cmbMovieGenre_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(614, 439);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(123, 28);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(36, 13);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Text = "Points";
            // 
            // frmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 471);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpMovies);
            this.Controls.Add(this.grpPaymentNeeded);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmTickets";
            this.Text = "Movie Ticket Sales";
            this.Load += new System.EventHandler(this.frmTickets_Load);
            this.grpPaymentNeeded.ResumeLayout(false);
            this.grpMovies.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPaymentNeeded;
        private System.Windows.Forms.GroupBox grpMovies;
        private System.Windows.Forms.ComboBox cmbMovieGenre;
        private System.Windows.Forms.ListBox lstBoxPaymentNeeded;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView lstViewMovies;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnPayPoints;
        private System.Windows.Forms.Button btnPayCreditCard;
        private System.Windows.Forms.Button btnPayCash;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPoints;
    }
}