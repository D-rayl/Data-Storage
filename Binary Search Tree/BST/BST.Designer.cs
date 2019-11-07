namespace BST
{
    partial class BST
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
            this.bFill = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.bRemove = new System.Windows.Forms.Button();
            this.bFind = new System.Windows.Forms.Button();
            this.bFindMin = new System.Windows.Forms.Button();
            this.bFindMax = new System.Windows.Forms.Button();
            this.bRoot = new System.Windows.Forms.Button();
            this.bRemoveMin = new System.Windows.Forms.Button();
            this.bMakeEmpty = new System.Windows.Forms.Button();
            this.bIsEmpty = new System.Windows.Forms.Button();
            this.insertBx = new System.Windows.Forms.TextBox();
            this.removeBx = new System.Windows.Forms.TextBox();
            this.findBx = new System.Windows.Forms.TextBox();
            this.findMinBx = new System.Windows.Forms.TextBox();
            this.findMaxBx = new System.Windows.Forms.TextBox();
            this.rootBx = new System.Windows.Forms.TextBox();
            this.list = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bFill
            // 
            this.bFill.Location = new System.Drawing.Point(12, 22);
            this.bFill.Name = "bFill";
            this.bFill.Size = new System.Drawing.Size(75, 23);
            this.bFill.TabIndex = 0;
            this.bFill.Text = "Fill Array";
            this.bFill.UseVisualStyleBackColor = true;
            this.bFill.Click += new System.EventHandler(this.bFill_Click);
            // 
            // bInsert
            // 
            this.bInsert.Location = new System.Drawing.Point(99, 22);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(75, 23);
            this.bInsert.TabIndex = 1;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(99, 60);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(75, 23);
            this.bRemove.TabIndex = 2;
            this.bRemove.Text = "Remove";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // bFind
            // 
            this.bFind.Location = new System.Drawing.Point(99, 102);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(75, 23);
            this.bFind.TabIndex = 3;
            this.bFind.Text = "Find";
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.bFind_Click);
            // 
            // bFindMin
            // 
            this.bFindMin.Location = new System.Drawing.Point(295, 22);
            this.bFindMin.Name = "bFindMin";
            this.bFindMin.Size = new System.Drawing.Size(75, 23);
            this.bFindMin.TabIndex = 4;
            this.bFindMin.Text = "Find Min";
            this.bFindMin.UseVisualStyleBackColor = true;
            this.bFindMin.Click += new System.EventHandler(this.bFindMin_Click);
            // 
            // bFindMax
            // 
            this.bFindMax.Location = new System.Drawing.Point(295, 60);
            this.bFindMax.Name = "bFindMax";
            this.bFindMax.Size = new System.Drawing.Size(75, 23);
            this.bFindMax.TabIndex = 5;
            this.bFindMax.Text = "Find Max";
            this.bFindMax.UseVisualStyleBackColor = true;
            this.bFindMax.Click += new System.EventHandler(this.bFindMax_Click);
            // 
            // bRoot
            // 
            this.bRoot.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bRoot.Location = new System.Drawing.Point(295, 102);
            this.bRoot.Name = "bRoot";
            this.bRoot.Size = new System.Drawing.Size(75, 23);
            this.bRoot.TabIndex = 6;
            this.bRoot.Text = "Root";
            this.bRoot.UseVisualStyleBackColor = true;
            this.bRoot.Click += new System.EventHandler(this.bRoot_Click);
            // 
            // bRemoveMin
            // 
            this.bRemoveMin.Location = new System.Drawing.Point(507, 102);
            this.bRemoveMin.Name = "bRemoveMin";
            this.bRemoveMin.Size = new System.Drawing.Size(75, 23);
            this.bRemoveMin.TabIndex = 7;
            this.bRemoveMin.Text = "Remove Min";
            this.bRemoveMin.UseVisualStyleBackColor = true;
            this.bRemoveMin.Click += new System.EventHandler(this.bRemoveMin_Click);
            // 
            // bMakeEmpty
            // 
            this.bMakeEmpty.Location = new System.Drawing.Point(507, 60);
            this.bMakeEmpty.Name = "bMakeEmpty";
            this.bMakeEmpty.Size = new System.Drawing.Size(75, 23);
            this.bMakeEmpty.TabIndex = 8;
            this.bMakeEmpty.Text = "Make Empty";
            this.bMakeEmpty.UseVisualStyleBackColor = true;
            this.bMakeEmpty.Click += new System.EventHandler(this.bMakeEmpty_Click);
            // 
            // bIsEmpty
            // 
            this.bIsEmpty.Location = new System.Drawing.Point(507, 22);
            this.bIsEmpty.Name = "bIsEmpty";
            this.bIsEmpty.Size = new System.Drawing.Size(75, 23);
            this.bIsEmpty.TabIndex = 9;
            this.bIsEmpty.Text = "Is Empty?";
            this.bIsEmpty.UseVisualStyleBackColor = true;
            this.bIsEmpty.Click += new System.EventHandler(this.bIsEmpty_Click);
            // 
            // insertBx
            // 
            this.insertBx.Location = new System.Drawing.Point(180, 25);
            this.insertBx.Name = "insertBx";
            this.insertBx.Size = new System.Drawing.Size(100, 20);
            this.insertBx.TabIndex = 10;
            // 
            // removeBx
            // 
            this.removeBx.Location = new System.Drawing.Point(180, 63);
            this.removeBx.Name = "removeBx";
            this.removeBx.Size = new System.Drawing.Size(100, 20);
            this.removeBx.TabIndex = 11;
            // 
            // findBx
            // 
            this.findBx.Location = new System.Drawing.Point(180, 104);
            this.findBx.Name = "findBx";
            this.findBx.Size = new System.Drawing.Size(100, 20);
            this.findBx.TabIndex = 12;
            // 
            // findMinBx
            // 
            this.findMinBx.Location = new System.Drawing.Point(389, 22);
            this.findMinBx.Name = "findMinBx";
            this.findMinBx.ReadOnly = true;
            this.findMinBx.Size = new System.Drawing.Size(100, 20);
            this.findMinBx.TabIndex = 13;
            // 
            // findMaxBx
            // 
            this.findMaxBx.Location = new System.Drawing.Point(389, 63);
            this.findMaxBx.Name = "findMaxBx";
            this.findMaxBx.ReadOnly = true;
            this.findMaxBx.Size = new System.Drawing.Size(100, 20);
            this.findMaxBx.TabIndex = 14;
            // 
            // rootBx
            // 
            this.rootBx.Location = new System.Drawing.Point(389, 104);
            this.rootBx.Name = "rootBx";
            this.rootBx.ReadOnly = true;
            this.rootBx.Size = new System.Drawing.Size(100, 20);
            this.rootBx.TabIndex = 15;
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(21, 145);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(560, 95);
            this.list.TabIndex = 16;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 272);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(616, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(67, 17);
            this.StatusLabel.Text = "StatusLabel";
            this.StatusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // BST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 294);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.rootBx);
            this.Controls.Add(this.findMaxBx);
            this.Controls.Add(this.findMinBx);
            this.Controls.Add(this.findBx);
            this.Controls.Add(this.removeBx);
            this.Controls.Add(this.insertBx);
            this.Controls.Add(this.bIsEmpty);
            this.Controls.Add(this.bMakeEmpty);
            this.Controls.Add(this.bRemoveMin);
            this.Controls.Add(this.bRoot);
            this.Controls.Add(this.bFindMax);
            this.Controls.Add(this.bFindMin);
            this.Controls.Add(this.bFind);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.bFill);
            this.Name = "BST";
            this.Text = "BST";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFill;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.Button bFindMin;
        private System.Windows.Forms.Button bFindMax;
        private System.Windows.Forms.Button bRoot;
        private System.Windows.Forms.Button bRemoveMin;
        private System.Windows.Forms.Button bMakeEmpty;
        private System.Windows.Forms.Button bIsEmpty;
        private System.Windows.Forms.TextBox insertBx;
        private System.Windows.Forms.TextBox removeBx;
        private System.Windows.Forms.TextBox findBx;
        private System.Windows.Forms.TextBox findMinBx;
        private System.Windows.Forms.TextBox findMaxBx;
        private System.Windows.Forms.TextBox rootBx;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

