namespace Chapter9
{
    partial class Tutorial9_5
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
            this.displayFormBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayFormBtn
            // 
            this.displayFormBtn.Location = new System.Drawing.Point(46, 58);
            this.displayFormBtn.Name = "displayFormBtn";
            this.displayFormBtn.Size = new System.Drawing.Size(75, 23);
            this.displayFormBtn.TabIndex = 0;
            this.displayFormBtn.Text = "Display Form";
            this.displayFormBtn.UseVisualStyleBackColor = true;
            this.displayFormBtn.Click += new System.EventHandler(this.displayFormBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(161, 58);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Tutorial9_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.displayFormBtn);
            this.Name = "Tutorial9_5";
            this.Text = "Tutorial9_5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayFormBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}