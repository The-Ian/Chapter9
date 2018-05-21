namespace Chapter9
{
    partial class Tutorial9_6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bananaRB = new System.Windows.Forms.RadioButton();
            this.popcornRB = new System.Windows.Forms.RadioButton();
            this.muffinRB = new System.Windows.Forms.RadioButton();
            this.displayBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.muffinRB);
            this.groupBox1.Controls.Add(this.popcornRB);
            this.groupBox1.Controls.Add(this.bananaRB);
            this.groupBox1.Location = new System.Drawing.Point(40, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Food";
            // 
            // bananaRB
            // 
            this.bananaRB.AutoSize = true;
            this.bananaRB.Location = new System.Drawing.Point(7, 20);
            this.bananaRB.Name = "bananaRB";
            this.bananaRB.Size = new System.Drawing.Size(70, 17);
            this.bananaRB.TabIndex = 0;
            this.bananaRB.TabStop = true;
            this.bananaRB.Text = "1 banana";
            this.bananaRB.UseVisualStyleBackColor = true;
            // 
            // popcornRB
            // 
            this.popcornRB.AutoSize = true;
            this.popcornRB.Location = new System.Drawing.Point(7, 44);
            this.popcornRB.Name = "popcornRB";
            this.popcornRB.Size = new System.Drawing.Size(159, 17);
            this.popcornRB.TabIndex = 1;
            this.popcornRB.TabStop = true;
            this.popcornRB.Text = "1 cup of air popped popcorn";
            this.popcornRB.UseVisualStyleBackColor = true;
            // 
            // muffinRB
            // 
            this.muffinRB.AutoSize = true;
            this.muffinRB.Location = new System.Drawing.Point(7, 68);
            this.muffinRB.Name = "muffinRB";
            this.muffinRB.Size = new System.Drawing.Size(134, 17);
            this.muffinRB.TabIndex = 2;
            this.muffinRB.TabStop = true;
            this.muffinRB.Text = "1 large blueberry muffin";
            this.muffinRB.UseVisualStyleBackColor = true;
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(40, 174);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(75, 36);
            this.displayBtn.TabIndex = 1;
            this.displayBtn.Text = "Display Food Facts";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(165, 174);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 36);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // Tutorial9_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Tutorial9_6";
            this.Text = "Tutorial9_6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton muffinRB;
        private System.Windows.Forms.RadioButton popcornRB;
        private System.Windows.Forms.RadioButton bananaRB;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}