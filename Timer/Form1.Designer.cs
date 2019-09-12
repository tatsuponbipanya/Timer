namespace Timer
{
    partial class FormTimer
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.SetTime = new System.Windows.Forms.TextBox();
            this.RemainingTime = new System.Windows.Forms.TextBox();
            this.timerControl = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "時間設定";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "秒";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "残り時間";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "秒";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(60, 84);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(230, 30);
            this.Start.TabIndex = 4;
            this.Start.Text = "スタート";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // SetTime
            // 
            this.SetTime.Location = new System.Drawing.Point(145, 41);
            this.SetTime.Name = "SetTime";
            this.SetTime.Size = new System.Drawing.Size(100, 22);
            this.SetTime.TabIndex = 5;
            // 
            // RemainingTime
            // 
            this.RemainingTime.Location = new System.Drawing.Point(145, 132);
            this.RemainingTime.Name = "RemainingTime";
            this.RemainingTime.Size = new System.Drawing.Size(100, 22);
            this.RemainingTime.TabIndex = 6;
            // 
            // timerControl
            // 
            this.timerControl.Interval = 1000;
            this.timerControl.Tick += new System.EventHandler(this.TimerControl_Tick);
            // 
            // FormTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 192);
            this.Controls.Add(this.RemainingTime);
            this.Controls.Add(this.SetTime);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTimer";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox SetTime;
        private System.Windows.Forms.TextBox RemainingTime;
        private System.Windows.Forms.Timer timerControl;
    }
}

