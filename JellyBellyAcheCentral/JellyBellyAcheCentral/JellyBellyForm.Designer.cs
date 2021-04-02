namespace JellyBellyAcheCentral
{
    partial class JellyBellyForm
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
            this.LvCategory = new System.Windows.Forms.ListView();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LvCategory
            // 
            this.LvCategory.GridLines = true;
            this.LvCategory.HideSelection = false;
            this.LvCategory.Location = new System.Drawing.Point(12, 21);
            this.LvCategory.Name = "LvCategory";
            this.LvCategory.Size = new System.Drawing.Size(776, 398);
            this.LvCategory.TabIndex = 0;
            this.LvCategory.UseCompatibleStateImageBehavior = false;
            this.LvCategory.View = System.Windows.Forms.View.Details;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(668, 425);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // JellyBellyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LvCategory);
            this.Name = "JellyBellyForm";
            this.Text = "JellyBellyForm";
            this.Load += new System.EventHandler(this.JellyBellyForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvCategory;
        private System.Windows.Forms.Button BtnClose;
    }
}