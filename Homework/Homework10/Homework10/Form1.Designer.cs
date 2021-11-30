namespace Homework10
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EnemyAnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CountDownLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WaterRadioButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.FireRadioButton = new System.Windows.Forms.RadioButton();
            this.WoodRadioButton = new System.Windows.Forms.RadioButton();
            this.BulletCDTimer = new System.Windows.Forms.Timer(this.components);
            this.CountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.BulletAnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // EnemyAnimationTimer
            // 
            this.EnemyAnimationTimer.Tick += new System.EventHandler(this.EnemyAnimationTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(627, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "目前屬性:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(627, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "目前分數:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(627, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "剩餘時間:";
            this.label3.Visible = false;
            // 
            // CountDownLabel
            // 
            this.CountDownLabel.AutoSize = true;
            this.CountDownLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CountDownLabel.Location = new System.Drawing.Point(709, 151);
            this.CountDownLabel.Name = "CountDownLabel";
            this.CountDownLabel.Size = new System.Drawing.Size(24, 16);
            this.CountDownLabel.TabIndex = 3;
            this.CountDownLabel.Text = "60";
            this.CountDownLabel.Visible = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ScoreLabel.Location = new System.Drawing.Point(709, 74);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(16, 16);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "0";
            this.ScoreLabel.Visible = false;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TypeLabel.Location = new System.Drawing.Point(709, 37);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(24, 16);
            this.TypeLabel.TabIndex = 5;
            this.TypeLabel.Text = "火";
            this.TypeLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(289, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "選擇初始屬性";
            // 
            // WaterRadioButton
            // 
            this.WaterRadioButton.AutoSize = true;
            this.WaterRadioButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WaterRadioButton.Location = new System.Drawing.Point(292, 175);
            this.WaterRadioButton.Name = "WaterRadioButton";
            this.WaterRadioButton.Size = new System.Drawing.Size(42, 20);
            this.WaterRadioButton.TabIndex = 7;
            this.WaterRadioButton.TabStop = true;
            this.WaterRadioButton.Text = "水";
            this.WaterRadioButton.UseVisualStyleBackColor = true;
            this.WaterRadioButton.CheckedChanged += new System.EventHandler(this.WaterRadioButton_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startButton.Location = new System.Drawing.Point(292, 325);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(81, 38);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "開始";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // FireRadioButton
            // 
            this.FireRadioButton.AutoSize = true;
            this.FireRadioButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FireRadioButton.Location = new System.Drawing.Point(292, 226);
            this.FireRadioButton.Name = "FireRadioButton";
            this.FireRadioButton.Size = new System.Drawing.Size(42, 20);
            this.FireRadioButton.TabIndex = 11;
            this.FireRadioButton.TabStop = true;
            this.FireRadioButton.Text = "火";
            this.FireRadioButton.UseVisualStyleBackColor = true;
            this.FireRadioButton.CheckedChanged += new System.EventHandler(this.FireRadioButton_CheckedChanged);
            // 
            // WoodRadioButton
            // 
            this.WoodRadioButton.AutoSize = true;
            this.WoodRadioButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WoodRadioButton.Location = new System.Drawing.Point(292, 274);
            this.WoodRadioButton.Name = "WoodRadioButton";
            this.WoodRadioButton.Size = new System.Drawing.Size(42, 20);
            this.WoodRadioButton.TabIndex = 12;
            this.WoodRadioButton.TabStop = true;
            this.WoodRadioButton.Text = "木";
            this.WoodRadioButton.UseVisualStyleBackColor = true;
            this.WoodRadioButton.CheckedChanged += new System.EventHandler(this.WoodRadioButton_CheckedChanged);
            // 
            // BulletCDTimer
            // 
            this.BulletCDTimer.Interval = 1000;
            this.BulletCDTimer.Tick += new System.EventHandler(this.BulletCDTimer_Tick);
            // 
            // CountDownTimer
            // 
            this.CountDownTimer.Interval = 1000;
            this.CountDownTimer.Tick += new System.EventHandler(this.CountDownTimer_Tick);
            // 
            // BulletAnimationTimer
            // 
            this.BulletAnimationTimer.Tick += new System.EventHandler(this.BulletAnimationTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 379);
            this.Controls.Add(this.WoodRadioButton);
            this.Controls.Add(this.FireRadioButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.WaterRadioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.CountDownLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer EnemyAnimationTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CountDownLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton WaterRadioButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RadioButton FireRadioButton;
        private System.Windows.Forms.RadioButton WoodRadioButton;
        private System.Windows.Forms.Timer BulletCDTimer;
        private System.Windows.Forms.Timer CountDownTimer;
        private System.Windows.Forms.Timer BulletAnimationTimer;
    }
}

