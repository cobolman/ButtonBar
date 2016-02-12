namespace ButtonBar
{
    partial class ButtonBar
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrior = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrior
            // 
            this.btnPrior.Location = new System.Drawing.Point(560, 0);
            this.btnPrior.Name = "btnPrior";
            this.btnPrior.Size = new System.Drawing.Size(20, 20);
            this.btnPrior.TabIndex = 0;
            this.btnPrior.Text = "<";
            this.btnPrior.UseVisualStyleBackColor = true;
            this.btnPrior.Click += new System.EventHandler(this.btnPrior_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(580, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(20, 20);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrior);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(600, 38);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrior;
        private System.Windows.Forms.Button btnNext;
    }
}
