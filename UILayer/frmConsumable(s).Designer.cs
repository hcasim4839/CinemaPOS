
namespace UILayer
{
    partial class frmConsumable_s_
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
            this.grpExit = new System.Windows.Forms.GroupBox();
            this.grpCatgory = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNewCategory = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnSecondarySubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpMain.SuspendLayout();
            this.grpExit.SuspendLayout();
            this.grpCatgory.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.btnSubmit);
            this.grpMain.Controls.Add(this.cmbCategory);
            this.grpMain.Controls.Add(this.txtPrice);
            this.grpMain.Controls.Add(this.txtName);
            this.grpMain.Controls.Add(this.lblCategory);
            this.grpMain.Controls.Add(this.lblPrice);
            this.grpMain.Controls.Add(this.lblName);
            this.grpMain.Location = new System.Drawing.Point(41, 63);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(327, 249);
            this.grpMain.TabIndex = 0;
            this.grpMain.TabStop = false;
            // 
            // grpExit
            // 
            this.grpExit.Controls.Add(this.btnExit);
            this.grpExit.Location = new System.Drawing.Point(397, 207);
            this.grpExit.Name = "grpExit";
            this.grpExit.Size = new System.Drawing.Size(354, 105);
            this.grpExit.TabIndex = 1;
            this.grpExit.TabStop = false;
            // 
            // grpCatgory
            // 
            this.grpCatgory.Controls.Add(this.btnSecondarySubmit);
            this.grpCatgory.Controls.Add(this.txtNewCategory);
            this.grpCatgory.Controls.Add(this.lblNewCategory);
            this.grpCatgory.Location = new System.Drawing.Point(397, 63);
            this.grpCatgory.Name = "grpCatgory";
            this.grpCatgory.Size = new System.Drawing.Size(354, 107);
            this.grpCatgory.TabIndex = 2;
            this.grpCatgory.TabStop = false;
            this.grpCatgory.Text = "Enter New Movie Category";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(376, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(154, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Insert New Consumable(s)";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(28, 70);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(28, 109);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Location = new System.Drawing.Point(29, 48);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(52, 13);
            this.lblNewCategory.TabIndex = 3;
            this.lblNewCategory.Text = "Category:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(123, 67);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // txtNewCategory
            // 
            this.txtNewCategory.Location = new System.Drawing.Point(107, 45);
            this.txtNewCategory.Name = "txtNewCategory";
            this.txtNewCategory.Size = new System.Drawing.Size(132, 20);
            this.txtNewCategory.TabIndex = 4;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(123, 106);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(132, 21);
            this.cmbCategory.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(180, 168);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnSecondarySubmit
            // 
            this.btnSecondarySubmit.Location = new System.Drawing.Point(261, 43);
            this.btnSecondarySubmit.Name = "btnSecondarySubmit";
            this.btnSecondarySubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSecondarySubmit.TabIndex = 5;
            this.btnSecondarySubmit.Text = "Submit";
            this.btnSecondarySubmit.UseVisualStyleBackColor = true;
            this.btnSecondarySubmit.Click += new System.EventHandler(this.btnSecondarySubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(261, 48);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmConsumable_s_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 349);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpCatgory);
            this.Controls.Add(this.grpExit);
            this.Controls.Add(this.grpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmConsumable_s_";
            this.Text = "frmConsumable_s_";
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.grpExit.ResumeLayout(false);
            this.grpCatgory.ResumeLayout(false);
            this.grpCatgory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.GroupBox grpExit;
        private System.Windows.Forms.GroupBox grpCatgory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSecondarySubmit;
        private System.Windows.Forms.TextBox txtNewCategory;
        private System.Windows.Forms.Label lblNewCategory;
    }
}