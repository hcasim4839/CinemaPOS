
namespace UILayer
{
    partial class frmNewMovies
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
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpNewCategory = new System.Windows.Forms.GroupBox();
            this.btnSubmitCategory = new System.Windows.Forms.Button();
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.grpExit = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNewCategory = new System.Windows.Forms.TextBox();
            this.grpMain.SuspendLayout();
            this.grpNewCategory.SuspendLayout();
            this.grpExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.cmbGenre);
            this.grpMain.Controls.Add(this.btnSubmit);
            this.grpMain.Controls.Add(this.txtPrice);
            this.grpMain.Controls.Add(this.txtName);
            this.grpMain.Controls.Add(this.lblCategory);
            this.grpMain.Controls.Add(this.lblPrice);
            this.grpMain.Controls.Add(this.lblName);
            this.grpMain.Location = new System.Drawing.Point(25, 66);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(345, 234);
            this.grpMain.TabIndex = 0;
            this.grpMain.TabStop = false;
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(120, 114);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(148, 21);
            this.cmbGenre.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(193, 179);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(120, 74);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(148, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(37, 117);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(37, 77);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // grpNewCategory
            // 
            this.grpNewCategory.Controls.Add(this.txtNewCategory);
            this.grpNewCategory.Controls.Add(this.btnSubmitCategory);
            this.grpNewCategory.Controls.Add(this.lblNewCategory);
            this.grpNewCategory.Location = new System.Drawing.Point(418, 66);
            this.grpNewCategory.Name = "grpNewCategory";
            this.grpNewCategory.Size = new System.Drawing.Size(269, 128);
            this.grpNewCategory.TabIndex = 1;
            this.grpNewCategory.TabStop = false;
            // 
            // btnSubmitCategory
            // 
            this.btnSubmitCategory.Location = new System.Drawing.Point(178, 89);
            this.btnSubmitCategory.Name = "btnSubmitCategory";
            this.btnSubmitCategory.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitCategory.TabIndex = 1;
            this.btnSubmitCategory.Text = "Submit";
            this.btnSubmitCategory.UseVisualStyleBackColor = true;
            this.btnSubmitCategory.Click += new System.EventHandler(this.btnSubmitCategory_Click);
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Location = new System.Drawing.Point(24, 46);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(52, 13);
            this.lblNewCategory.TabIndex = 0;
            this.lblNewCategory.Text = "Category:";
            // 
            // grpExit
            // 
            this.grpExit.Controls.Add(this.btnExit);
            this.grpExit.Location = new System.Drawing.Point(418, 200);
            this.grpExit.Name = "grpExit";
            this.grpExit.Size = new System.Drawing.Size(269, 100);
            this.grpExit.TabIndex = 2;
            this.grpExit.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(178, 45);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(298, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(152, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Insertion of New Movie(s)";
            // 
            // txtNewCategory
            // 
            this.txtNewCategory.Location = new System.Drawing.Point(93, 43);
            this.txtNewCategory.Name = "txtNewCategory";
            this.txtNewCategory.Size = new System.Drawing.Size(160, 20);
            this.txtNewCategory.TabIndex = 2;
            // 
            // frmNewMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 342);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpExit);
            this.Controls.Add(this.grpNewCategory);
            this.Controls.Add(this.grpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmNewMovies";
            this.Text = "frmNewMovies";
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.grpNewCategory.ResumeLayout(false);
            this.grpNewCategory.PerformLayout();
            this.grpExit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.GroupBox grpNewCategory;
        private System.Windows.Forms.GroupBox grpExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNewCategory;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSubmitCategory;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.TextBox txtNewCategory;
    }
}