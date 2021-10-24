
namespace UILayer
{
    partial class frmCCManagement
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
            this.lblCreditCardCompany = new System.Windows.Forms.Label();
            this.lblCardHolderName = new System.Windows.Forms.Label();
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.grpAddCC = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtCCNum = new System.Windows.Forms.TextBox();
            this.txtCardHolder = new System.Windows.Forms.TextBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbCreditCardComp = new System.Windows.Forms.ComboBox();
            this.grpRemoveCC = new System.Windows.Forms.GroupBox();
            this.cmbCCNum = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstViewCC = new System.Windows.Forms.ListView();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lblMemberPhone = new System.Windows.Forms.Label();
            this.grpAddCC.SuspendLayout();
            this.grpRemoveCC.SuspendLayout();
            this.grpMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(315, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(124, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Credit Card Management";
            // 
            // lblCreditCardCompany
            // 
            this.lblCreditCardCompany.AutoSize = true;
            this.lblCreditCardCompany.Location = new System.Drawing.Point(22, 52);
            this.lblCreditCardCompany.Name = "lblCreditCardCompany";
            this.lblCreditCardCompany.Size = new System.Drawing.Size(106, 13);
            this.lblCreditCardCompany.TabIndex = 2;
            this.lblCreditCardCompany.Text = "Credit Card Company";
            // 
            // lblCardHolderName
            // 
            this.lblCardHolderName.AutoSize = true;
            this.lblCardHolderName.Location = new System.Drawing.Point(22, 76);
            this.lblCardHolderName.Name = "lblCardHolderName";
            this.lblCardHolderName.Size = new System.Drawing.Size(94, 13);
            this.lblCardHolderName.TabIndex = 3;
            this.lblCardHolderName.Text = "Card Holder Name";
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Location = new System.Drawing.Point(22, 100);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Size = new System.Drawing.Size(99, 13);
            this.lblCreditCardNumber.TabIndex = 4;
            this.lblCreditCardNumber.Text = "Credit Card Number";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(22, 124);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(51, 13);
            this.lblExpDate.TabIndex = 5;
            this.lblExpDate.Text = "Exp Date";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(22, 146);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(77, 13);
            this.lblAddress1.TabIndex = 6;
            this.lblAddress1.Text = "Address Line 1";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(22, 171);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(77, 13);
            this.lblAddress2.TabIndex = 7;
            this.lblAddress2.Text = "Address Line 2";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(22, 194);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(22, 217);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "State";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(22, 240);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblZipCode.TabIndex = 10;
            this.lblZipCode.Text = "Zip Code";
            // 
            // grpAddCC
            // 
            this.grpAddCC.Controls.Add(this.btnApply);
            this.grpAddCC.Controls.Add(this.dateTimePicker1);
            this.grpAddCC.Controls.Add(this.txtZipCode);
            this.grpAddCC.Controls.Add(this.txtAddress2);
            this.grpAddCC.Controls.Add(this.txtAddress1);
            this.grpAddCC.Controls.Add(this.txtCCNum);
            this.grpAddCC.Controls.Add(this.txtCardHolder);
            this.grpAddCC.Controls.Add(this.cmbState);
            this.grpAddCC.Controls.Add(this.cmbCity);
            this.grpAddCC.Controls.Add(this.cmbCreditCardComp);
            this.grpAddCC.Controls.Add(this.lblCardHolderName);
            this.grpAddCC.Controls.Add(this.lblZipCode);
            this.grpAddCC.Controls.Add(this.lblState);
            this.grpAddCC.Controls.Add(this.lblCreditCardCompany);
            this.grpAddCC.Controls.Add(this.lblCity);
            this.grpAddCC.Controls.Add(this.lblCreditCardNumber);
            this.grpAddCC.Controls.Add(this.lblAddress2);
            this.grpAddCC.Controls.Add(this.lblExpDate);
            this.grpAddCC.Controls.Add(this.lblAddress1);
            this.grpAddCC.Location = new System.Drawing.Point(63, 144);
            this.grpAddCC.Name = "grpAddCC";
            this.grpAddCC.Size = new System.Drawing.Size(311, 307);
            this.grpAddCC.TabIndex = 11;
            this.grpAddCC.TabStop = false;
            this.grpAddCC.Text = "Add Credit Card";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(205, 263);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 20;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(159, 237);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(121, 20);
            this.txtZipCode.TabIndex = 18;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(159, 168);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(121, 20);
            this.txtAddress2.TabIndex = 17;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(159, 143);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(121, 20);
            this.txtAddress1.TabIndex = 16;
            // 
            // txtCCNum
            // 
            this.txtCCNum.Location = new System.Drawing.Point(159, 97);
            this.txtCCNum.Name = "txtCCNum";
            this.txtCCNum.Size = new System.Drawing.Size(121, 20);
            this.txtCCNum.TabIndex = 15;
            // 
            // txtCardHolder
            // 
            this.txtCardHolder.Location = new System.Drawing.Point(159, 73);
            this.txtCardHolder.Name = "txtCardHolder";
            this.txtCardHolder.Size = new System.Drawing.Size(121, 20);
            this.txtCardHolder.TabIndex = 14;
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(159, 214);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(121, 21);
            this.cmbState.TabIndex = 13;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(159, 191);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCity.TabIndex = 12;
            // 
            // cmbCreditCardComp
            // 
            this.cmbCreditCardComp.FormattingEnabled = true;
            this.cmbCreditCardComp.Location = new System.Drawing.Point(159, 49);
            this.cmbCreditCardComp.Name = "cmbCreditCardComp";
            this.cmbCreditCardComp.Size = new System.Drawing.Size(121, 21);
            this.cmbCreditCardComp.TabIndex = 11;
            // 
            // grpRemoveCC
            // 
            this.grpRemoveCC.Controls.Add(this.cmbCCNum);
            this.grpRemoveCC.Controls.Add(this.btnRemove);
            this.grpRemoveCC.Controls.Add(this.lblCardNum);
            this.grpRemoveCC.Location = new System.Drawing.Point(63, 477);
            this.grpRemoveCC.Name = "grpRemoveCC";
            this.grpRemoveCC.Size = new System.Drawing.Size(311, 92);
            this.grpRemoveCC.TabIndex = 12;
            this.grpRemoveCC.TabStop = false;
            this.grpRemoveCC.Text = "Remove Credit Card";
            // 
            // cmbCCNum
            // 
            this.cmbCCNum.FormattingEnabled = true;
            this.cmbCCNum.Location = new System.Drawing.Point(159, 19);
            this.cmbCCNum.Name = "cmbCCNum";
            this.cmbCCNum.Size = new System.Drawing.Size(121, 21);
            this.cmbCCNum.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(205, 54);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.Location = new System.Drawing.Point(22, 19);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(99, 13);
            this.lblCardNum.TabIndex = 0;
            this.lblCardNum.Text = "Credit Card Number";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(268, 589);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstViewCC
            // 
            this.lstViewCC.HideSelection = false;
            this.lstViewCC.Location = new System.Drawing.Point(398, 144);
            this.lstViewCC.Name = "lstViewCC";
            this.lstViewCC.Size = new System.Drawing.Size(380, 307);
            this.lstViewCC.TabIndex = 14;
            this.lstViewCC.UseCompatibleStateImageBehavior = false;
            this.lstViewCC.SelectedIndexChanged += new System.EventHandler(this.lstViewCC_SelectedIndexChanged);
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.btnConfirm);
            this.grpMember.Controls.Add(this.txtPhoneNum);
            this.grpMember.Controls.Add(this.lblMemberPhone);
            this.grpMember.Location = new System.Drawing.Point(164, 41);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(412, 64);
            this.grpMember.TabIndex = 15;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "Member Info";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(305, 25);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(114, 26);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(171, 20);
            this.txtPhoneNum.TabIndex = 1;
            // 
            // lblMemberPhone
            // 
            this.lblMemberPhone.AutoSize = true;
            this.lblMemberPhone.Location = new System.Drawing.Point(19, 30);
            this.lblMemberPhone.Name = "lblMemberPhone";
            this.lblMemberPhone.Size = new System.Drawing.Size(79, 13);
            this.lblMemberPhone.TabIndex = 0;
            this.lblMemberPhone.Text = "Member Phone";
            // 
            // frmCCManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 628);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.lstViewCC);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpRemoveCC);
            this.Controls.Add(this.grpAddCC);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCCManagement";
            this.Text = "Credit Card Info";
            this.grpAddCC.ResumeLayout(false);
            this.grpAddCC.PerformLayout();
            this.grpRemoveCC.ResumeLayout(false);
            this.grpRemoveCC.PerformLayout();
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCreditCardCompany;
        private System.Windows.Forms.Label lblCardHolderName;
        private System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.GroupBox grpAddCC;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtCCNum;
        private System.Windows.Forms.TextBox txtCardHolder;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbCreditCardComp;
        private System.Windows.Forms.GroupBox grpRemoveCC;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbCCNum;
        private System.Windows.Forms.ListView lstViewCC;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label lblMemberPhone;
    }
}