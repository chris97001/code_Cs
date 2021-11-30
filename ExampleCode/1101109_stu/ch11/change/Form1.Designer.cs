namespace change
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.選項SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChange = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl50 = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lbl500 = new System.Windows.Forms.Label();
            this.lbl1000 = new System.Windows.Forms.Label();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk10 = new System.Windows.Forms.CheckBox();
            this.chk50 = new System.Windows.Forms.CheckBox();
            this.chk100 = new System.Windows.Forms.CheckBox();
            this.chk500 = new System.Windows.Forms.CheckBox();
            this.chk1000 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKind = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.選項SToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 選項SToolStripMenuItem
            // 
            this.選項SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChange,
            this.mnuExit});
            this.選項SToolStripMenuItem.Name = "選項SToolStripMenuItem";
            this.選項SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.選項SToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.選項SToolStripMenuItem.Text = "選項(&S)";
            // 
            // mnuChange
            // 
            this.mnuChange.Name = "mnuChange";
            this.mnuChange.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuChange.Size = new System.Drawing.Size(156, 22);
            this.mnuChange.Text = "兌換(&R)";
            this.mnuChange.Click += new System.EventHandler(this.mnuChange_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuExit.Size = new System.Drawing.Size(156, 22);
            this.mnuExit.Text = "結束(&X)";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "STEP 3. 執行功能表中兌換功能";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.chk1);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.lbl10);
            this.groupBox1.Controls.Add(this.lbl50);
            this.groupBox1.Controls.Add(this.lbl100);
            this.groupBox1.Controls.Add(this.lbl500);
            this.groupBox1.Controls.Add(this.lbl1000);
            this.groupBox1.Controls.Add(this.chk5);
            this.groupBox1.Controls.Add(this.chk10);
            this.groupBox1.Controls.Add(this.chk50);
            this.groupBox1.Controls.Add(this.chk100);
            this.groupBox1.Controls.Add(this.chk500);
            this.groupBox1.Controls.Add(this.chk1000);
            this.groupBox1.Location = new System.Drawing.Point(16, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 86);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STEP2. 請勾選兌換面額：";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(327, 58);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(33, 12);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "label9";
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(329, 31);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(42, 16);
            this.chk1.TabIndex = 12;
            this.chk1.Text = "1元";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(283, 58);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(33, 12);
            this.lbl5.TabIndex = 11;
            this.lbl5.Text = "label8";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(233, 58);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(33, 12);
            this.lbl10.TabIndex = 10;
            this.lbl10.Text = "label7";
            // 
            // lbl50
            // 
            this.lbl50.AutoSize = true;
            this.lbl50.Location = new System.Drawing.Point(183, 58);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(33, 12);
            this.lbl50.TabIndex = 9;
            this.lbl50.Text = "label6";
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Location = new System.Drawing.Point(127, 58);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(33, 12);
            this.lbl100.TabIndex = 8;
            this.lbl100.Text = "label5";
            // 
            // lbl500
            // 
            this.lbl500.AutoSize = true;
            this.lbl500.Location = new System.Drawing.Point(71, 58);
            this.lbl500.Name = "lbl500";
            this.lbl500.Size = new System.Drawing.Size(33, 12);
            this.lbl500.TabIndex = 7;
            this.lbl500.Text = "label4";
            // 
            // lbl1000
            // 
            this.lbl1000.AutoSize = true;
            this.lbl1000.Location = new System.Drawing.Point(14, 58);
            this.lbl1000.Name = "lbl1000";
            this.lbl1000.Size = new System.Drawing.Size(33, 12);
            this.lbl1000.TabIndex = 6;
            this.lbl1000.Text = "label3";
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(285, 30);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(42, 16);
            this.chk5.TabIndex = 5;
            this.chk5.Text = "5元";
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk10
            // 
            this.chk10.AutoSize = true;
            this.chk10.Location = new System.Drawing.Point(235, 30);
            this.chk10.Name = "chk10";
            this.chk10.Size = new System.Drawing.Size(48, 16);
            this.chk10.TabIndex = 4;
            this.chk10.Text = "10元";
            this.chk10.UseVisualStyleBackColor = true;
            // 
            // chk50
            // 
            this.chk50.AutoSize = true;
            this.chk50.Location = new System.Drawing.Point(185, 30);
            this.chk50.Name = "chk50";
            this.chk50.Size = new System.Drawing.Size(48, 16);
            this.chk50.TabIndex = 3;
            this.chk50.Text = "50元";
            this.chk50.UseVisualStyleBackColor = true;
            // 
            // chk100
            // 
            this.chk100.AutoSize = true;
            this.chk100.Location = new System.Drawing.Point(129, 30);
            this.chk100.Name = "chk100";
            this.chk100.Size = new System.Drawing.Size(54, 16);
            this.chk100.TabIndex = 2;
            this.chk100.Text = "100元";
            this.chk100.UseVisualStyleBackColor = true;
            // 
            // chk500
            // 
            this.chk500.AutoSize = true;
            this.chk500.Location = new System.Drawing.Point(73, 30);
            this.chk500.Name = "chk500";
            this.chk500.Size = new System.Drawing.Size(54, 16);
            this.chk500.TabIndex = 1;
            this.chk500.Text = "500元";
            this.chk500.UseVisualStyleBackColor = true;
            // 
            // chk1000
            // 
            this.chk1000.AutoSize = true;
            this.chk1000.Location = new System.Drawing.Point(11, 31);
            this.chk1000.Name = "chk1000";
            this.chk1000.Size = new System.Drawing.Size(60, 16);
            this.chk1000.TabIndex = 0;
            this.chk1000.Text = "1000元";
            this.chk1000.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "STEP 1. 請輸入兌換金額：";
            // 
            // lblKind
            // 
            this.lblKind.AutoSize = true;
            this.lblKind.Location = new System.Drawing.Point(280, 38);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(17, 12);
            this.lblKind.TabIndex = 25;
            this.lblKind.Text = "元";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(171, 35);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 22);
            this.txtMoney.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 201);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKind);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 選項SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuChange;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl50;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lbl500;
        private System.Windows.Forms.Label lbl1000;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk10;
        private System.Windows.Forms.CheckBox chk50;
        private System.Windows.Forms.CheckBox chk100;
        private System.Windows.Forms.CheckBox chk500;
        private System.Windows.Forms.CheckBox chk1000;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.TextBox txtMoney;
    }
}

