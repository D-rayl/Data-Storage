namespace Binary_Search
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
            this.s = new System.Windows.Forms.Button();
            this.tB = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(89, 79);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(75, 23);
            this.s.TabIndex = 0;
            this.s.Text = "Search";
            this.s.UseVisualStyleBackColor = true;
            this.s.Click += new System.EventHandler(this.s_Click);
            // 
            // tB
            // 
            this.tB.Location = new System.Drawing.Point(89, 157);
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(100, 20);
            this.tB.TabIndex = 1;
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(89, 35);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(75, 23);
            this.p.TabIndex = 0;
            this.p.Text = "pop";
            this.p.UseVisualStyleBackColor = true;
            this.p.Click += new System.EventHandler(this.p_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.p);
            this.Controls.Add(this.tB);
            this.Controls.Add(this.s);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button s;
        private System.Windows.Forms.TextBox tB;
        private System.Windows.Forms.Button p;
    }
}

