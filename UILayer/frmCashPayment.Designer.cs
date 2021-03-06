
namespace UILayer
{
    partial class frmCashPayment
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpTotal = new System.Windows.Forms.GroupBox();
            this.txtUserCashPaymentValue = new System.Windows.Forms.TextBox();
            this.txtTotalCostValue = new System.Windows.Forms.TextBox();
            this.lblUserCashPayment = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTender = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.grpCustom = new System.Windows.Forms.GroupBox();
            this.flwlyoutQuickBtns = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpTotal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpCustom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(55, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(252, 23);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(36, 13);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "Points";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(55, 70);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:";
            // 
            // grpTotal
            // 
            this.grpTotal.Controls.Add(this.txtUserCashPaymentValue);
            this.grpTotal.Controls.Add(this.txtTotalCostValue);
            this.grpTotal.Controls.Add(this.lblUserCashPayment);
            this.grpTotal.Controls.Add(this.lblTotalCost);
            this.grpTotal.Location = new System.Drawing.Point(12, 122);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Size = new System.Drawing.Size(192, 346);
            this.grpTotal.TabIndex = 6;
            this.grpTotal.TabStop = false;
            this.grpTotal.Text = "Total Cost";
            // 
            // txtUserCashPaymentValue
            // 
            this.txtUserCashPaymentValue.Location = new System.Drawing.Point(86, 105);
            this.txtUserCashPaymentValue.Name = "txtUserCashPaymentValue";
            this.txtUserCashPaymentValue.ReadOnly = true;
            this.txtUserCashPaymentValue.Size = new System.Drawing.Size(100, 20);
            this.txtUserCashPaymentValue.TabIndex = 12;
            this.txtUserCashPaymentValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalCostValue
            // 
            this.txtTotalCostValue.Location = new System.Drawing.Point(86, 54);
            this.txtTotalCostValue.Name = "txtTotalCostValue";
            this.txtTotalCostValue.ReadOnly = true;
            this.txtTotalCostValue.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCostValue.TabIndex = 11;
            this.txtTotalCostValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUserCashPayment
            // 
            this.lblUserCashPayment.AutoSize = true;
            this.lblUserCashPayment.Location = new System.Drawing.Point(6, 108);
            this.lblUserCashPayment.Name = "lblUserCashPayment";
            this.lblUserCashPayment.Size = new System.Drawing.Size(78, 13);
            this.lblUserCashPayment.TabIndex = 10;
            this.lblUserCashPayment.Text = "Cash Payment:";
            this.lblUserCashPayment.TextChanged += new System.EventHandler(this.lblUserCashPayment_TextChanged);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(6, 57);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(58, 13);
            this.lblTotalCost.TabIndex = 9;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(190, 165);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 48);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTender
            // 
            this.btnTender.Location = new System.Drawing.Point(160, 273);
            this.btnTender.Name = "btnTender";
            this.btnTender.Size = new System.Drawing.Size(282, 40);
            this.btnTender.TabIndex = 5;
            this.btnTender.Text = "Tender";
            this.btnTender.UseVisualStyleBackColor = true;
            this.btnTender.Click += new System.EventHandler(this.btnTender_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnOne, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnTwo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnThree, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFour, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFive, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSix, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSeven, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnEight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNine, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnReset, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnZero, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(160, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 216);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnOne
            // 
            this.btnOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOne.Location = new System.Drawing.Point(3, 3);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(87, 48);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTwo.Location = new System.Drawing.Point(96, 3);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(88, 48);
            this.btnTwo.TabIndex = 8;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThree.Location = new System.Drawing.Point(190, 3);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(89, 48);
            this.btnThree.TabIndex = 9;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnFour
            // 
            this.btnFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFour.Location = new System.Drawing.Point(3, 57);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(87, 48);
            this.btnFour.TabIndex = 10;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFive.Location = new System.Drawing.Point(96, 57);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(88, 48);
            this.btnFive.TabIndex = 11;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSix.Location = new System.Drawing.Point(190, 57);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(89, 48);
            this.btnSix.TabIndex = 12;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeven.Location = new System.Drawing.Point(3, 111);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(87, 48);
            this.btnSeven.TabIndex = 13;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEight.Location = new System.Drawing.Point(96, 111);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(88, 48);
            this.btnEight.TabIndex = 14;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNine.Location = new System.Drawing.Point(190, 111);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(89, 48);
            this.btnNine.TabIndex = 15;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(3, 165);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 48);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.buttonDecimal_Click);
            // 
            // btnZero
            // 
            this.btnZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZero.Location = new System.Drawing.Point(96, 165);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(88, 48);
            this.btnZero.TabIndex = 17;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // grpCustom
            // 
            this.grpCustom.Controls.Add(this.flwlyoutQuickBtns);
            this.grpCustom.Controls.Add(this.tableLayoutPanel1);
            this.grpCustom.Controls.Add(this.btnTender);
            this.grpCustom.Location = new System.Drawing.Point(210, 122);
            this.grpCustom.Name = "grpCustom";
            this.grpCustom.Size = new System.Drawing.Size(447, 346);
            this.grpCustom.TabIndex = 9;
            this.grpCustom.TabStop = false;
            this.grpCustom.Text = "Custom";
            // 
            // flwlyoutQuickBtns
            // 
            this.flwlyoutQuickBtns.Location = new System.Drawing.Point(6, 51);
            this.flwlyoutQuickBtns.Name = "flwlyoutQuickBtns";
            this.flwlyoutQuickBtns.Size = new System.Drawing.Size(148, 262);
            this.flwlyoutQuickBtns.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(573, 491);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCashPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 526);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpCustom);
            this.Controls.Add(this.grpTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCashPayment";
            this.Text = "Cash Payment";
            this.grpTotal.ResumeLayout(false);
            this.grpTotal.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpCustom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grpTotal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTender;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.GroupBox grpCustom;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUserCashPayment;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox txtUserCashPaymentValue;
        private System.Windows.Forms.TextBox txtTotalCostValue;
        private System.Windows.Forms.FlowLayoutPanel flwlyoutQuickBtns;
    }
}