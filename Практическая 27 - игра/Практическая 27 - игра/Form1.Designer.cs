namespace Практическая_27___игра
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pBFieldOfPlay = new System.Windows.Forms.PictureBox();
            this.lblMaxScore = new System.Windows.Forms.Label();
            this.btnStartOrStop = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBFieldOfPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // pBFieldOfPlay
            // 
            this.pBFieldOfPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBFieldOfPlay.Location = new System.Drawing.Point(26, 106);
            this.pBFieldOfPlay.Name = "pBFieldOfPlay";
            this.pBFieldOfPlay.Size = new System.Drawing.Size(750, 505);
            this.pBFieldOfPlay.TabIndex = 0;
            this.pBFieldOfPlay.TabStop = false;
            this.pBFieldOfPlay.Paint += new System.Windows.Forms.PaintEventHandler(this.pBFieldOfPlay_Paint);
            // 
            // lblMaxScore
            // 
            this.lblMaxScore.AutoSize = true;
            this.lblMaxScore.Location = new System.Drawing.Point(452, 58);
            this.lblMaxScore.Name = "lblMaxScore";
            this.lblMaxScore.Size = new System.Drawing.Size(65, 13);
            this.lblMaxScore.TabIndex = 1;
            this.lblMaxScore.Text = "Макс. Очки";
            this.lblMaxScore.Click += new System.EventHandler(this.lblMaxScore_Click);
            // 
            // btnStartOrStop
            // 
            this.btnStartOrStop.Location = new System.Drawing.Point(26, 41);
            this.btnStartOrStop.Name = "btnStartOrStop";
            this.btnStartOrStop.Size = new System.Drawing.Size(111, 47);
            this.btnStartOrStop.TabIndex = 2;
            this.btnStartOrStop.Text = "Начать";
            this.btnStartOrStop.UseVisualStyleBackColor = true;
            this.btnStartOrStop.Click += new System.EventHandler(this.btnStartOrStop_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(685, 58);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(32, 13);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Очки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 641);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnStartOrStop);
            this.Controls.Add(this.lblMaxScore);
            this.Controls.Add(this.pBFieldOfPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Snake";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pBFieldOfPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBFieldOfPlay;
        private System.Windows.Forms.Label lblMaxScore;
        private System.Windows.Forms.Button btnStartOrStop;
        private System.Windows.Forms.Label lblScore;
    }
}

