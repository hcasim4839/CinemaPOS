
namespace UILayer
{
    partial class frmCreditCardPayment
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
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnConfirmation = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbMemberCreditCard = new System.Windows.Forms.ComboBox();
            this.lblCreditCards = new System.Windows.Forms.Label();
            this.grpCreditCardInfo = new System.Windows.Forms.GroupBox();
            this.grpExit = new System.Windows.Forms.GroupBox();
            this.grpMemberInfo = new System.Windows.Forms.GroupBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.grpCreditCardInfo.SuspendLayout();
            this.grpExit.SuspendLayout();
            this.grpMemberInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(16, 38);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(69, 13);
            this.lblTotalCost.TabIndex = 0;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(16, 26);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(48, 13);
            this.lblMemberName.TabIndex = 1;
            this.lblMemberName.Text = "Member:";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(16, 62);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(39, 13);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "Points:";
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.Location = new System.Drawing.Point(202, 124);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmation.TabIndex = 3;
            this.btnConfirmation.Text = "Confirm";
            this.btnConfirmation.UseVisualStyleBackColor = true;
            this.btnConfirmation.Click += new System.EventHandler(this.btnConfirmation_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(202, 47);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbMemberCreditCard
            // 
            this.cbMemberCreditCard.FormattingEnabled = true;
            this.cbMemberCreditCard.Location = new System.Drawing.Point(156, 78);
            this.cbMemberCreditCard.Name = "cbMemberCreditCard";
            this.cbMemberCreditCard.Size = new System.Drawing.Size(121, 21);
            this.cbMemberCreditCard.TabIndex = 5;
            // 
            // lblCreditCards
            // 
            this.lblCreditCards.AutoSize = true;
            this.lblCreditCards.Location = new System.Drawing.Point(16, 81);
            this.lblCreditCards.Name = "lblCreditCards";
            this.lblCreditCards.Size = new System.Drawing.Size(67, 13);
            this.lblCreditCards.TabIndex = 6;
            this.lblCreditCards.Text = "Credit Cards:";
            // 
            // grpCreditCardInfo
            // 
            this.grpCreditCardInfo.Controls.Add(this.lblCost);
            this.grpCreditCardInfo.Controls.Add(this.cbMemberCreditCard);
            this.grpCreditCardInfo.Controls.Add(this.lblCreditCards);
            this.grpCreditCardInfo.Controls.Add(this.btnConfirmation);
            this.grpCreditCardInfo.Controls.Add(this.lblTotalCost);
            this.grpCreditCardInfo.Location = new System.Drawing.Point(74, 132);
            this.grpCreditCardInfo.Name = "grpCreditCardInfo";
            this.grpCreditCardInfo.Size = new System.Drawing.Size(348, 168);
            this.grpCreditCardInfo.TabIndex = 7;
            this.grpCreditCardInfo.TabStop = false;
            // 
            // grpExit
            // 
            this.grpExit.Controls.Add(this.btnExit);
            this.grpExit.Location = new System.Drawing.Point(74, 337);
            this.grpExit.Name = "grpExit";
            this.grpExit.Size = new System.Drawing.Size(348, 76);
            this.grpExit.TabIndex = 8;
            this.grpExit.TabStop = false;
            // 
            // grpMemberInfo
            // 
            this.grpMemberInfo.Controls.Add(this.lblMemberName);
            this.grpMemberInfo.Controls.Add(this.lblPoints);
            this.grpMemberInfo.Location = new System.Drawing.Point(74, 22);
            this.grpMemberInfo.Name = "grpMemberInfo";
            this.grpMemberInfo.Size = new System.Drawing.Size(348, 94);
            this.grpMemberInfo.TabIndex = 9;
            this.grpMemberInfo.TabStop = false;
            this.grpMemberInfo.Text = "Member Info:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(153, 38);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(0, 13);
            this.lblCost.TabIndex = 7;
            // 
            // frmCreditCardPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.grpMemberInfo);
            this.Controls.Add(this.grpExit);
            this.Controls.Add(this.grpCreditCardInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCreditCardPayment";
            this.Text = "Credit Card Payment";
            this.grpCreditCardInfo.ResumeLayout(false);
            this.grpCreditCardInfo.PerformLayout();
            this.grpExit.ResumeLayout(false);
            this.grpMemberInfo.ResumeLayout(false);
            this.grpMemberInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button btnConfirmation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbMemberCreditCard;
        private System.Windows.Forms.Label lblCreditCards;
        private System.Windows.Forms.GroupBox grpCreditCardInfo;
        private System.Windows.Forms.GroupBox grpExit;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.GroupBox grpMemberInfo;
    }
}