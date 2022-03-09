
namespace UILayer
{
    partial class frmProductChanges
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
            this.btnMovie = new System.Windows.Forms.Button();
            this.btnConsumable = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnDeleteConsumable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMovie
            // 
            this.btnMovie.Location = new System.Drawing.Point(167, 75);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(176, 23);
            this.btnMovie.TabIndex = 0;
            this.btnMovie.Text = "Insert New Movie(s)";
            this.btnMovie.UseVisualStyleBackColor = true;
            this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click);
            // 
            // btnConsumable
            // 
            this.btnConsumable.Location = new System.Drawing.Point(167, 114);
            this.btnConsumable.Name = "btnConsumable";
            this.btnConsumable.Size = new System.Drawing.Size(176, 23);
            this.btnConsumable.TabIndex = 1;
            this.btnConsumable.Text = "Insert New Consumable(s)";
            this.btnConsumable.UseVisualStyleBackColor = true;
            this.btnConsumable.Click += new System.EventHandler(this.btnConsumable_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(215, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(201, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(104, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Product Changes";
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(167, 154);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(176, 23);
            this.btnDeleteMovie.TabIndex = 5;
            this.btnDeleteMovie.Text = "Delete Movie(s)";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnDeleteConsumable
            // 
            this.btnDeleteConsumable.Location = new System.Drawing.Point(167, 195);
            this.btnDeleteConsumable.Name = "btnDeleteConsumable";
            this.btnDeleteConsumable.Size = new System.Drawing.Size(176, 23);
            this.btnDeleteConsumable.TabIndex = 6;
            this.btnDeleteConsumable.Text = "Delete Consumable(s)";
            this.btnDeleteConsumable.UseVisualStyleBackColor = true;
            // 
            // frmProductChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 348);
            this.Controls.Add(this.btnDeleteConsumable);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConsumable);
            this.Controls.Add(this.btnMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmProductChanges";
            this.Text = "Product Changes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMovie;
        private System.Windows.Forms.Button btnConsumable;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnDeleteConsumable;
    }
}