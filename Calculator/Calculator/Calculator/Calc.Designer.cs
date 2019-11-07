namespace Calculator
{
    partial class Calc
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
            this.tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.bZero = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bPoint = new System.Windows.Forms.Button();
            this.bEquals = new System.Windows.Forms.Button();
            this.bMulti = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSqrt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bCubeRT = new System.Windows.Forms.Button();
            this.bInv = new System.Windows.Forms.Button();
            this.bTan = new System.Windows.Forms.Button();
            this.bSin = new System.Windows.Forms.Button();
            this.bCos = new System.Windows.Forms.Button();
            this.bNeg = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb.Location = new System.Drawing.Point(20, 28);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(177, 29);
            this.tb.TabIndex = 0;
            this.tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(85, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(147, 106);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(20, 152);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(85, 152);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(147, 152);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // bZero
            // 
            this.bZero.Location = new System.Drawing.Point(85, 192);
            this.bZero.Name = "bZero";
            this.bZero.Size = new System.Drawing.Size(50, 23);
            this.bZero.TabIndex = 10;
            this.bZero.Text = "0";
            this.bZero.UseVisualStyleBackColor = true;
            this.bZero.Click += new System.EventHandler(this.BtnZero_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(20, 192);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(50, 23);
            this.bClear.TabIndex = 11;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // bPoint
            // 
            this.bPoint.Location = new System.Drawing.Point(147, 192);
            this.bPoint.Name = "bPoint";
            this.bPoint.Size = new System.Drawing.Size(50, 23);
            this.bPoint.TabIndex = 12;
            this.bPoint.Text = ".";
            this.bPoint.UseVisualStyleBackColor = true;
            this.bPoint.Click += new System.EventHandler(this.BtnPoint_Click);
            // 
            // bEquals
            // 
            this.bEquals.Location = new System.Drawing.Point(218, 192);
            this.bEquals.Name = "bEquals";
            this.bEquals.Size = new System.Drawing.Size(75, 23);
            this.bEquals.TabIndex = 13;
            this.bEquals.Text = "=";
            this.bEquals.UseVisualStyleBackColor = true;
            this.bEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // bMulti
            // 
            this.bMulti.Location = new System.Drawing.Point(218, 154);
            this.bMulti.Name = "bMulti";
            this.bMulti.Size = new System.Drawing.Size(75, 23);
            this.bMulti.TabIndex = 14;
            this.bMulti.Text = "*";
            this.bMulti.UseVisualStyleBackColor = true;
            this.bMulti.Click += new System.EventHandler(this.bMulti_Click);
            // 
            // bDiv
            // 
            this.bDiv.Location = new System.Drawing.Point(218, 123);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(75, 23);
            this.bDiv.TabIndex = 15;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // bSub
            // 
            this.bSub.Location = new System.Drawing.Point(218, 94);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(75, 23);
            this.bSub.TabIndex = 16;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = true;
            this.bSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(218, 65);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 17;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // bSqrt
            // 
            this.bSqrt.Location = new System.Drawing.Point(218, 28);
            this.bSqrt.Name = "bSqrt";
            this.bSqrt.Size = new System.Drawing.Size(75, 23);
            this.bSqrt.TabIndex = 18;
            this.bSqrt.Text = "SQRT";
            this.bSqrt.UseVisualStyleBackColor = true;
            this.bSqrt.Click += new System.EventHandler(this.BtnSqrt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.Clear_ToolStripMenuItem);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.Quit_ToolStripMenuItem);
            // 
            // bCubeRT
            // 
            this.bCubeRT.Location = new System.Drawing.Point(316, 28);
            this.bCubeRT.Name = "bCubeRT";
            this.bCubeRT.Size = new System.Drawing.Size(75, 23);
            this.bCubeRT.TabIndex = 20;
            this.bCubeRT.Text = "CubeRT";
            this.bCubeRT.UseVisualStyleBackColor = true;
            this.bCubeRT.Click += new System.EventHandler(this.BtnCubeRT_Click);
            // 
            // bInv
            // 
            this.bInv.Location = new System.Drawing.Point(316, 65);
            this.bInv.Name = "bInv";
            this.bInv.Size = new System.Drawing.Size(75, 23);
            this.bInv.TabIndex = 21;
            this.bInv.Text = "Inverse";
            this.bInv.UseVisualStyleBackColor = true;
            this.bInv.Click += new System.EventHandler(this.BtnInv_Click);
            // 
            // bTan
            // 
            this.bTan.Location = new System.Drawing.Point(316, 94);
            this.bTan.Name = "bTan";
            this.bTan.Size = new System.Drawing.Size(75, 23);
            this.bTan.TabIndex = 22;
            this.bTan.Text = "Tan";
            this.bTan.UseVisualStyleBackColor = true;
            this.bTan.Click += new System.EventHandler(this.BtnTan_Click);
            // 
            // bSin
            // 
            this.bSin.Location = new System.Drawing.Point(316, 123);
            this.bSin.Name = "bSin";
            this.bSin.Size = new System.Drawing.Size(75, 23);
            this.bSin.TabIndex = 23;
            this.bSin.Text = "Sin";
            this.bSin.UseVisualStyleBackColor = true;
            this.bSin.Click += new System.EventHandler(this.BtnSin_Click);
            // 
            // bCos
            // 
            this.bCos.Location = new System.Drawing.Point(316, 154);
            this.bCos.Name = "bCos";
            this.bCos.Size = new System.Drawing.Size(75, 23);
            this.bCos.TabIndex = 24;
            this.bCos.Text = "Cos";
            this.bCos.UseVisualStyleBackColor = true;
            this.bCos.Click += new System.EventHandler(this.BtnCos_Click);
            // 
            // bNeg
            // 
            this.bNeg.Location = new System.Drawing.Point(316, 192);
            this.bNeg.Name = "bNeg";
            this.bNeg.Size = new System.Drawing.Size(75, 23);
            this.bNeg.TabIndex = 25;
            this.bNeg.Text = "Negative";
            this.bNeg.UseVisualStyleBackColor = true;
            this.bNeg.Click += new System.EventHandler(this.BtnNeg_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(418, 248);
            this.Controls.Add(this.bNeg);
            this.Controls.Add(this.bCos);
            this.Controls.Add(this.bSin);
            this.Controls.Add(this.bTan);
            this.Controls.Add(this.bInv);
            this.Controls.Add(this.bCubeRT);
            this.Controls.Add(this.bSqrt);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bSub);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bMulti);
            this.Controls.Add(this.bEquals);
            this.Controls.Add(this.bPoint);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bZero);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calc";
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button bZero;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bPoint;
        private System.Windows.Forms.Button bEquals;
        private System.Windows.Forms.Button bMulti;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bSqrt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button bCubeRT;
        private System.Windows.Forms.Button bInv;
        private System.Windows.Forms.Button bTan;
        private System.Windows.Forms.Button bSin;
        private System.Windows.Forms.Button bCos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button bNeg;
    }
}

