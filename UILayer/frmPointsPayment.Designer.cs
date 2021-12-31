
namespace UILayer
{
    partial class frmPointsPayment
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
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.cmbDiscounts = new System.Windows.Forms.ComboBox();
            this.lblMember = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConfirmation = new System.Windows.Forms.Button();
            this.lblPointsReduction = new System.Windows.Forms.Label();
            this.lblLeftoverPoints = new System.Windows.Forms.Label();
            this.grpExit = new System.Windows.Forms.GroupBox();
            this.grpPointsInfo = new System.Windows.Forms.GroupBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.grpMemberInfo = new System.Windows.Forms.GroupBox();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.grpExit.SuspendLayout();
            this.grpPointsInfo.SuspendLayout();
            this.grpMemberInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(21, 55);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(46, 13);
            this.lblPoints.TabIndex = 0;
            this.lblPoints.Text = "Points:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(52, 74);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(103, 13);
            this.lblDiscount.TabIndex = 1;
            this.lblDiscount.Text = "Discounts Available:";
            // 
            // cmbDiscounts
            // 
            this.cmbDiscounts.FormattingEnabled = true;
            this.cmbDiscounts.Location = new System.Drawing.Point(174, 71);
            this.cmbDiscounts.Name = "cmbDiscounts";
            this.cmbDiscounts.Size = new System.Drawing.Size(121, 21);
            this.cmbDiscounts.TabIndex = 2;
            this.cmbDiscounts.SelectedIndexChanged += new System.EventHandler(this.cmbDiscounts_SelectedIndexChanged);
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(21, 29);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(48, 13);
            this.lblMember.TabIndex = 3;
            this.lblMember.Text = "Member:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(250, 52);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.Location = new System.Drawing.Point(281, 214);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmation.TabIndex = 5;
            this.btnConfirmation.Text = "Confirm";
            this.btnConfirmation.UseVisualStyleBackColor = true;
            this.btnConfirmation.Click += new System.EventHandler(this.btnConfirmation_Click);
            // 
            // lblPointsReduction
            // 
            this.lblPointsReduction.AutoSize = true;
            this.lblPointsReduction.Location = new System.Drawing.Point(52, 111);
            this.lblPointsReduction.Name = "lblPointsReduction";
            this.lblPointsReduction.Size = new System.Drawing.Size(91, 13);
            this.lblPointsReduction.TabIndex = 6;
            this.lblPointsReduction.Text = "Points Reduction:";
            // 
            // lblLeftoverPoints
            // 
            this.lblLeftoverPoints.AutoSize = true;
            this.lblLeftoverPoints.Location = new System.Drawing.Point(52, 150);
            this.lblLeftoverPoints.Name = "lblLeftoverPoints";
            this.lblLeftoverPoints.Size = new System.Drawing.Size(109, 13);
            this.lblLeftoverPoints.TabIndex = 7;
            this.lblLeftoverPoints.Text = "Points After Discount:";
            // 
            // grpExit
            // 
            this.grpExit.Controls.Add(this.btnExit);
            this.grpExit.Location = new System.Drawing.Point(73, 393);
            this.grpExit.Name = "grpExit";
            this.grpExit.Size = new System.Drawing.Size(331, 91);
            this.grpExit.TabIndex = 8;
            this.grpExit.TabStop = false;
            // 
            // grpPointsInfo
            // 
            this.grpPointsInfo.Controls.Add(this.lblNewPrice);
            this.grpPointsInfo.Controls.Add(this.lblTotalCost);
            this.grpPointsInfo.Controls.Add(this.lblDiscount);
            this.grpPointsInfo.Controls.Add(this.cmbDiscounts);
            this.grpPointsInfo.Controls.Add(this.btnConfirmation);
            this.grpPointsInfo.Controls.Add(this.lblLeftoverPoints);
            this.grpPointsInfo.Controls.Add(this.lblPointsReduction);
            this.grpPointsInfo.Location = new System.Drawing.Point(42, 135);
            this.grpPointsInfo.Name = "grpPointsInfo";
            this.grpPointsInfo.Size = new System.Drawing.Size(383, 252);
            this.grpPointsInfo.TabIndex = 9;
            this.grpPointsInfo.TabStop = false;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(52, 29);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(58, 13);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // grpMemberInfo
            // 
            this.grpMemberInfo.Controls.Add(this.lblPoints);
            this.grpMemberInfo.Controls.Add(this.lblMember);
            this.grpMemberInfo.Location = new System.Drawing.Point(73, 27);
            this.grpMemberInfo.Name = "grpMemberInfo";
            this.grpMemberInfo.Size = new System.Drawing.Size(331, 102);
            this.grpMemberInfo.TabIndex = 10;
            this.grpMemberInfo.TabStop = false;
            this.grpMemberInfo.Text = "Member Information: ";
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Location = new System.Drawing.Point(52, 183);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(83, 13);
            this.lblNewPrice.TabIndex = 9;
            this.lblNewPrice.Text = "New Total Cost:";
            // 
            // frmPointsPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 496);
            this.Controls.Add(this.grpMemberInfo);
            this.Controls.Add(this.grpPointsInfo);
            this.Controls.Add(this.grpExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPointsPayment";
            this.Text = "Points Payment";
            this.grpExit.ResumeLayout(false);
            this.grpPointsInfo.ResumeLayout(false);
            this.grpPointsInfo.PerformLayout();
            this.grpMemberInfo.ResumeLayout(false);
            this.grpMemberInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.ComboBox cmbDiscounts;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConfirmation;
        private System.Windows.Forms.Label lblPointsReduction;
        private System.Windows.Forms.Label lblLeftoverPoints;
        private System.Windows.Forms.GroupBox grpExit;
        private System.Windows.Forms.GroupBox grpPointsInfo;
        private System.Windows.Forms.GroupBox grpMemberInfo;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblNewPrice;
    }
}