namespace RadixSort
{
    partial class Radix
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
            this.bSort = new System.Windows.Forms.Button();
            this.listB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bSort
            // 
            this.bSort.Location = new System.Drawing.Point(12, 34);
            this.bSort.Name = "bSort";
            this.bSort.Size = new System.Drawing.Size(76, 290);
            this.bSort.TabIndex = 0;
            this.bSort.Text = "Sort";
            this.bSort.UseVisualStyleBackColor = true;
            this.bSort.Click += new System.EventHandler(this.bSort_Click);
            // 
            // listB
            // 
            this.listB.FormattingEnabled = true;
            this.listB.Location = new System.Drawing.Point(129, 34);
            this.listB.Name = "listB";
            this.listB.Size = new System.Drawing.Size(120, 290);
            this.listB.TabIndex = 1;
            // 
            // Radix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 356);
            this.Controls.Add(this.listB);
            this.Controls.Add(this.bSort);
            this.Name = "Radix";
            this.Text = "Radix Sort";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSort;
        private System.Windows.Forms.ListBox listB;
    }
}

