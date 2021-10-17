
namespace UILayer
{
    partial class frmConfirmation
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
            this.lblTransaction = new System.Windows.Forms.Label();
            this.grpMessage = new System.Windows.Forms.GroupBox();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnConfirmation = new System.Windows.Forms.Button();
            this.btnSnacksDrinks = new System.Windows.Forms.Button();
            this.btnTicktets = new System.Windows.Forms.Button();
            this.grpMessage.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Location = new System.Drawing.Point(20, 31);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(63, 13);
            this.lblTransaction.TabIndex = 0;
            this.lblTransaction.Text = "Transaction";
            // 
            // grpMessage
            // 
            this.grpMessage.Controls.Add(this.lblTransaction);
            this.grpMessage.Location = new System.Drawing.Point(85, 28);
            this.grpMessage.Name = "grpMessage";
            this.grpMessage.Size = new System.Drawing.Size(347, 100);
            this.grpMessage.TabIndex = 1;
            this.grpMessage.TabStop = false;
            this.grpMessage.Text = "Message";
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnTicktets);
            this.grpButtons.Controls.Add(this.btnSnacksDrinks);
            this.grpButtons.Controls.Add(this.btnConfirmation);
            this.grpButtons.Location = new System.Drawing.Point(85, 189);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(347, 100);
            this.grpButtons.TabIndex = 2;
            this.grpButtons.TabStop = false;
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.Location = new System.Drawing.Point(14, 39);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(81, 23);
            this.btnConfirmation.TabIndex = 0;
            this.btnConfirmation.UseVisualStyleBackColor = true;
            // 
            // btnSnacksDrinks
            // 
            this.btnSnacksDrinks.Location = new System.Drawing.Point(101, 39);
            this.btnSnacksDrinks.Name = "btnSnacksDrinks";
            this.btnSnacksDrinks.Size = new System.Drawing.Size(125, 23);
            this.btnSnacksDrinks.TabIndex = 1;
            this.btnSnacksDrinks.Text = "Buy Snacks && Drinks";
            this.btnSnacksDrinks.UseVisualStyleBackColor = true;
            // 
            // btnTicktets
            // 
            this.btnTicktets.Location = new System.Drawing.Point(232, 39);
            this.btnTicktets.Name = "btnTicktets";
            this.btnTicktets.Size = new System.Drawing.Size(100, 23);
            this.btnTicktets.TabIndex = 2;
            this.btnTicktets.Text = "Buy Tickets";
            this.btnTicktets.UseVisualStyleBackColor = true;
            // 
            // frmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 349);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.grpMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmConfirmation";
            this.Text = "Confirmation Form";
            this.grpMessage.ResumeLayout(false);
            this.grpMessage.PerformLayout();
            this.grpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.GroupBox grpMessage;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnTicktets;
        private System.Windows.Forms.Button btnSnacksDrinks;
        private System.Windows.Forms.Button btnConfirmation;
    }
}