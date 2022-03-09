
namespace UILayer
{
    partial class frmCinemaMngmt
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMembership = new System.Windows.Forms.Button();
            this.btnPurchases = new System.Windows.Forms.Button();
            this.btnProductChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(195, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cinema Management System";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(242, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMembership
            // 
            this.btnMembership.Location = new System.Drawing.Point(198, 104);
            this.btnMembership.Name = "btnMembership";
            this.btnMembership.Size = new System.Drawing.Size(165, 23);
            this.btnMembership.TabIndex = 4;
            this.btnMembership.Text = "Membership";
            this.btnMembership.UseVisualStyleBackColor = true;
            this.btnMembership.Click += new System.EventHandler(this.btnMembership_Click);
            // 
            // btnPurchases
            // 
            this.btnPurchases.Location = new System.Drawing.Point(198, 55);
            this.btnPurchases.Name = "btnPurchases";
            this.btnPurchases.Size = new System.Drawing.Size(165, 23);
            this.btnPurchases.TabIndex = 5;
            this.btnPurchases.Text = "Purchases";
            this.btnPurchases.UseVisualStyleBackColor = true;
            this.btnPurchases.Click += new System.EventHandler(this.btnPurchases_Click);
            // 
            // btnProductChanges
            // 
            this.btnProductChanges.Location = new System.Drawing.Point(198, 154);
            this.btnProductChanges.Name = "btnProductChanges";
            this.btnProductChanges.Size = new System.Drawing.Size(165, 23);
            this.btnProductChanges.TabIndex = 6;
            this.btnProductChanges.Text = "Product Changes";
            this.btnProductChanges.UseVisualStyleBackColor = true;
            this.btnProductChanges.Click += new System.EventHandler(this.btnNewProducts_Click);
            // 
            // frmCinemaMngmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 304);
            this.Controls.Add(this.btnProductChanges);
            this.Controls.Add(this.btnPurchases);
            this.Controls.Add(this.btnMembership);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCinemaMngmt";
            this.Text = "Cinema Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMembership;
        private System.Windows.Forms.Button btnPurchases;
        private System.Windows.Forms.Button btnProductChanges;
    }
}