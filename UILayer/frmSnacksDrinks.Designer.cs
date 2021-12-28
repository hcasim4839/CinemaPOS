
namespace UILayer
{
    partial class frmSnacksDrinks
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.grpPaymentNeeded = new System.Windows.Forms.GroupBox();
            this.btnPoints = new System.Windows.Forms.Button();
            this.btnCC = new System.Windows.Forms.Button();
            this.btnPayCash = new System.Windows.Forms.Button();
            this.grpSnacks = new System.Windows.Forms.GroupBox();
            this.btnSnacksEnter = new System.Windows.Forms.Button();
            this.lstViewSnacks = new System.Windows.Forms.ListView();
            this.cmbSnacks = new System.Windows.Forms.ComboBox();
            this.grpDrinks = new System.Windows.Forms.GroupBox();
            this.btnDrinksEnter = new System.Windows.Forms.Button();
            this.lstViewDrinks = new System.Windows.Forms.ListView();
            this.cmbDrinks = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstBoxPaymentNeeded = new System.Windows.Forms.ListBox();
            this.grpPaymentNeeded.SuspendLayout();
            this.grpSnacks.SuspendLayout();
            this.grpDrinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(40, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(139, 39);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(36, 13);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "Points";
            this.lblPoints.Click += new System.EventHandler(this.lblPoints_Click);
            // 
            // grpPaymentNeeded
            // 
            this.grpPaymentNeeded.Controls.Add(this.lstBoxPaymentNeeded);
            this.grpPaymentNeeded.Controls.Add(this.btnPoints);
            this.grpPaymentNeeded.Controls.Add(this.btnCC);
            this.grpPaymentNeeded.Controls.Add(this.btnPayCash);
            this.grpPaymentNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPaymentNeeded.Location = new System.Drawing.Point(12, 98);
            this.grpPaymentNeeded.Name = "grpPaymentNeeded";
            this.grpPaymentNeeded.Size = new System.Drawing.Size(253, 361);
            this.grpPaymentNeeded.TabIndex = 3;
            this.grpPaymentNeeded.TabStop = false;
            this.grpPaymentNeeded.Text = "Total Cost";
            // 
            // btnPoints
            // 
            this.btnPoints.Location = new System.Drawing.Point(16, 332);
            this.btnPoints.Name = "btnPoints";
            this.btnPoints.Size = new System.Drawing.Size(107, 23);
            this.btnPoints.TabIndex = 3;
            this.btnPoints.Text = "Points Payment";
            this.btnPoints.UseVisualStyleBackColor = true;
            // 
            // btnCC
            // 
            this.btnCC.Location = new System.Drawing.Point(119, 304);
            this.btnCC.Name = "btnCC";
            this.btnCC.Size = new System.Drawing.Size(134, 23);
            this.btnCC.TabIndex = 2;
            this.btnCC.Text = "Credit Card Payment";
            this.btnCC.UseVisualStyleBackColor = true;
            // 
            // btnPayCash
            // 
            this.btnPayCash.Location = new System.Drawing.Point(16, 303);
            this.btnPayCash.Name = "btnPayCash";
            this.btnPayCash.Size = new System.Drawing.Size(97, 23);
            this.btnPayCash.TabIndex = 1;
            this.btnPayCash.Text = "Cash Payment";
            this.btnPayCash.UseVisualStyleBackColor = true;
            this.btnPayCash.Click += new System.EventHandler(this.btnPayCash_Click);
            // 
            // grpSnacks
            // 
            this.grpSnacks.Controls.Add(this.btnSnacksEnter);
            this.grpSnacks.Controls.Add(this.lstViewSnacks);
            this.grpSnacks.Controls.Add(this.cmbSnacks);
            this.grpSnacks.Location = new System.Drawing.Point(271, 98);
            this.grpSnacks.Name = "grpSnacks";
            this.grpSnacks.Size = new System.Drawing.Size(200, 327);
            this.grpSnacks.TabIndex = 4;
            this.grpSnacks.TabStop = false;
            this.grpSnacks.Text = "Snacks";
            // 
            // btnSnacksEnter
            // 
            this.btnSnacksEnter.Location = new System.Drawing.Point(69, 43);
            this.btnSnacksEnter.Name = "btnSnacksEnter";
            this.btnSnacksEnter.Size = new System.Drawing.Size(75, 23);
            this.btnSnacksEnter.TabIndex = 2;
            this.btnSnacksEnter.Text = "Enter";
            this.btnSnacksEnter.UseVisualStyleBackColor = true;
            this.btnSnacksEnter.Click += new System.EventHandler(this.btnSnacksEnter_Click);
            // 
            // lstViewSnacks
            // 
            this.lstViewSnacks.HideSelection = false;
            this.lstViewSnacks.Location = new System.Drawing.Point(18, 72);
            this.lstViewSnacks.Name = "lstViewSnacks";
            this.lstViewSnacks.Size = new System.Drawing.Size(165, 210);
            this.lstViewSnacks.TabIndex = 1;
            this.lstViewSnacks.UseCompatibleStateImageBehavior = false;
            this.lstViewSnacks.View = System.Windows.Forms.View.List;
            this.lstViewSnacks.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lstViewSnacks_DrawItem);
            this.lstViewSnacks.Click += new System.EventHandler(this.lstViewSnacks_Click);
            // 
            // cmbSnacks
            // 
            this.cmbSnacks.FormattingEnabled = true;
            this.cmbSnacks.Location = new System.Drawing.Point(42, 19);
            this.cmbSnacks.Name = "cmbSnacks";
            this.cmbSnacks.Size = new System.Drawing.Size(121, 21);
            this.cmbSnacks.TabIndex = 0;
            // 
            // grpDrinks
            // 
            this.grpDrinks.Controls.Add(this.btnDrinksEnter);
            this.grpDrinks.Controls.Add(this.lstViewDrinks);
            this.grpDrinks.Controls.Add(this.cmbDrinks);
            this.grpDrinks.Location = new System.Drawing.Point(477, 98);
            this.grpDrinks.Name = "grpDrinks";
            this.grpDrinks.Size = new System.Drawing.Size(200, 327);
            this.grpDrinks.TabIndex = 5;
            this.grpDrinks.TabStop = false;
            this.grpDrinks.Text = "Drinks";
            // 
            // btnDrinksEnter
            // 
            this.btnDrinksEnter.Location = new System.Drawing.Point(66, 43);
            this.btnDrinksEnter.Name = "btnDrinksEnter";
            this.btnDrinksEnter.Size = new System.Drawing.Size(75, 23);
            this.btnDrinksEnter.TabIndex = 2;
            this.btnDrinksEnter.Text = "Enter";
            this.btnDrinksEnter.UseVisualStyleBackColor = true;
            this.btnDrinksEnter.Click += new System.EventHandler(this.btnDrinksEnter_Click);
            // 
            // lstViewDrinks
            // 
            this.lstViewDrinks.HideSelection = false;
            this.lstViewDrinks.Location = new System.Drawing.Point(15, 72);
            this.lstViewDrinks.Name = "lstViewDrinks";
            this.lstViewDrinks.Size = new System.Drawing.Size(170, 210);
            this.lstViewDrinks.TabIndex = 1;
            this.lstViewDrinks.UseCompatibleStateImageBehavior = false;
            this.lstViewDrinks.View = System.Windows.Forms.View.List;
            this.lstViewDrinks.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lstViewDrinks_DrawItem);
            this.lstViewDrinks.Click += new System.EventHandler(this.lstViewDrinks_Click);
            // 
            // cmbDrinks
            // 
            this.cmbDrinks.FormattingEnabled = true;
            this.cmbDrinks.Location = new System.Drawing.Point(45, 19);
            this.cmbDrinks.Name = "cmbDrinks";
            this.cmbDrinks.Size = new System.Drawing.Size(121, 21);
            this.cmbDrinks.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(602, 436);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstBoxPaymentNeeded
            // 
            this.lstBoxPaymentNeeded.FormattingEnabled = true;
            this.lstBoxPaymentNeeded.Location = new System.Drawing.Point(6, 72);
            this.lstBoxPaymentNeeded.Name = "lstBoxPaymentNeeded";
            this.lstBoxPaymentNeeded.Size = new System.Drawing.Size(229, 212);
            this.lstBoxPaymentNeeded.TabIndex = 7;
            this.lstBoxPaymentNeeded.Click += new System.EventHandler(this.lstBoxPaymentNeeded_Click);
            // 
            // frmSnacksDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 471);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpDrinks);
            this.Controls.Add(this.grpSnacks);
            this.Controls.Add(this.grpPaymentNeeded);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSnacksDrinks";
            this.Text = "Snacks & Drinks";
            this.grpPaymentNeeded.ResumeLayout(false);
            this.grpSnacks.ResumeLayout(false);
            this.grpDrinks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.GroupBox grpPaymentNeeded;
        private System.Windows.Forms.GroupBox grpSnacks;
        private System.Windows.Forms.GroupBox grpDrinks;
        private System.Windows.Forms.ComboBox cmbSnacks;
        private System.Windows.Forms.ComboBox cmbDrinks;
        private System.Windows.Forms.ListView lstViewSnacks;
        private System.Windows.Forms.ListView lstViewDrinks;
        private System.Windows.Forms.Button btnPoints;
        private System.Windows.Forms.Button btnCC;
        private System.Windows.Forms.Button btnPayCash;
        private System.Windows.Forms.Button btnSnacksEnter;
        private System.Windows.Forms.Button btnDrinksEnter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstBoxPaymentNeeded;
    }
}