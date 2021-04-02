namespace JellyBellyAcheCentral
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSearchJBFlavors = new System.Windows.Forms.Button();
            this.BtnShowFlavorCat = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSearchJBFlavors
            // 
            this.BtnSearchJBFlavors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchJBFlavors.Location = new System.Drawing.Point(12, 418);
            this.BtnSearchJBFlavors.Name = "BtnSearchJBFlavors";
            this.BtnSearchJBFlavors.Size = new System.Drawing.Size(194, 40);
            this.BtnSearchJBFlavors.TabIndex = 1;
            this.BtnSearchJBFlavors.Text = "Search Jelly Belly Flavors";
            this.BtnSearchJBFlavors.UseVisualStyleBackColor = true;
            // 
            // BtnShowFlavorCat
            // 
            this.BtnShowFlavorCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowFlavorCat.Location = new System.Drawing.Point(212, 418);
            this.BtnShowFlavorCat.Name = "BtnShowFlavorCat";
            this.BtnShowFlavorCat.Size = new System.Drawing.Size(200, 40);
            this.BtnShowFlavorCat.TabIndex = 2;
            this.BtnShowFlavorCat.Text = "Show Flavor Categories";
            this.BtnShowFlavorCat.UseVisualStyleBackColor = true;
            this.BtnShowFlavorCat.Click += new System.EventHandler(this.BtnShowFlavorCat_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(299, 478);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(113, 31);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 522);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnShowFlavorCat);
            this.Controls.Add(this.BtnSearchJBFlavors);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSearchJBFlavors;
        private System.Windows.Forms.Button BtnShowFlavorCat;
        private System.Windows.Forms.Button BtnClose;
    }
}

