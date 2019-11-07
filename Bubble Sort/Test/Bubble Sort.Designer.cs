namespace Test
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
            this.listRes = new System.Windows.Forms.ListBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.textOutF = new System.Windows.Forms.TextBox();
            this.textInnerF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listRes
            // 
            this.listRes.FormattingEnabled = true;
            this.listRes.Location = new System.Drawing.Point(12, 12);
            this.listRes.Name = "listRes";
            this.listRes.Size = new System.Drawing.Size(120, 511);
            this.listRes.TabIndex = 0;
            // 
            // sortBtn
            // 
            this.sortBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortBtn.Location = new System.Drawing.Point(138, 12);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(186, 114);
            this.sortBtn.TabIndex = 1;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // textOutF
            // 
            this.textOutF.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textOutF.Location = new System.Drawing.Point(160, 195);
            this.textOutF.Name = "textOutF";
            this.textOutF.Size = new System.Drawing.Size(100, 20);
            this.textOutF.TabIndex = 2;
            // 
            // textInnerF
            // 
            this.textInnerF.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textInnerF.Location = new System.Drawing.Point(160, 277);
            this.textInnerF.Name = "textInnerF";
            this.textInnerF.Size = new System.Drawing.Size(100, 20);
            this.textInnerF.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Outer FOR loop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inner FOR loop";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(336, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textInnerF);
            this.Controls.Add(this.textOutF);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.listRes);
            this.Name = "Form1";
            this.Text = "Bubble Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listRes;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.TextBox textOutF;
        private System.Windows.Forms.TextBox textInnerF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

