namespace LInked_List
{
    partial class LinkedList
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
            System.Windows.Forms.Label label1;
            this.listBx = new System.Windows.Forms.ListBox();
            this.nameBx = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.addLastBtn = new System.Windows.Forms.Button();
            this.addBeforeBtn = new System.Windows.Forms.Button();
            this.addAfterBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.numNodes = new System.Windows.Forms.TextBox();
            this.nodePosBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(123, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 13);
            label1.TabIndex = 10;
            label1.Text = "Car Name";
            // 
            // listBx
            // 
            this.listBx.FormattingEnabled = true;
            this.listBx.Location = new System.Drawing.Point(126, 122);
            this.listBx.Name = "listBx";
            this.listBx.Size = new System.Drawing.Size(120, 95);
            this.listBx.TabIndex = 0;
            this.listBx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBx_MouseClick);
            this.listBx.SelectedIndexChanged += new System.EventHandler(this.listBx_SelectedIndexChanged);
            // 
            // nameBx
            // 
            this.nameBx.Location = new System.Drawing.Point(126, 33);
            this.nameBx.Name = "nameBx";
            this.nameBx.Size = new System.Drawing.Size(100, 20);
            this.nameBx.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add First";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addLastBtn
            // 
            this.addLastBtn.Location = new System.Drawing.Point(12, 41);
            this.addLastBtn.Name = "addLastBtn";
            this.addLastBtn.Size = new System.Drawing.Size(75, 23);
            this.addLastBtn.TabIndex = 3;
            this.addLastBtn.Text = "Add Last";
            this.addLastBtn.UseVisualStyleBackColor = true;
            this.addLastBtn.Click += new System.EventHandler(this.addLastBtn_Click);
            // 
            // addBeforeBtn
            // 
            this.addBeforeBtn.Location = new System.Drawing.Point(12, 70);
            this.addBeforeBtn.Name = "addBeforeBtn";
            this.addBeforeBtn.Size = new System.Drawing.Size(75, 23);
            this.addBeforeBtn.TabIndex = 4;
            this.addBeforeBtn.Text = "Add Before";
            this.addBeforeBtn.UseVisualStyleBackColor = true;
            this.addBeforeBtn.Click += new System.EventHandler(this.addBeforeBtn_Click);
            // 
            // addAfterBtn
            // 
            this.addAfterBtn.Location = new System.Drawing.Point(12, 99);
            this.addAfterBtn.Name = "addAfterBtn";
            this.addAfterBtn.Size = new System.Drawing.Size(75, 23);
            this.addAfterBtn.TabIndex = 5;
            this.addAfterBtn.Text = "Add After";
            this.addAfterBtn.UseVisualStyleBackColor = true;
            this.addAfterBtn.Click += new System.EventHandler(this.addAfterBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(12, 156);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 6;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(12, 185);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // numNodes
            // 
            this.numNodes.Location = new System.Drawing.Point(126, 234);
            this.numNodes.Name = "numNodes";
            this.numNodes.ReadOnly = true;
            this.numNodes.Size = new System.Drawing.Size(51, 20);
            this.numNodes.TabIndex = 8;
            // 
            // nodePosBx
            // 
            this.nodePosBx.Location = new System.Drawing.Point(126, 87);
            this.nodePosBx.Name = "nodePosBx";
            this.nodePosBx.Size = new System.Drawing.Size(100, 20);
            this.nodePosBx.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Node Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number of Nodes";
            // 
            // LinkedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.nodePosBx);
            this.Controls.Add(this.numNodes);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addAfterBtn);
            this.Controls.Add(this.addBeforeBtn);
            this.Controls.Add(this.addLastBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.nameBx);
            this.Controls.Add(this.listBx);
            this.Name = "LinkedList";
            this.Text = "Linked List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBx;
        private System.Windows.Forms.TextBox nameBx;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button addLastBtn;
        private System.Windows.Forms.Button addBeforeBtn;
        private System.Windows.Forms.Button addAfterBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox numNodes;
        private System.Windows.Forms.TextBox nodePosBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

