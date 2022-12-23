namespace Test_Your_Vocabulary
{
    partial class EasyForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbQuestions = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.easyTimer = new System.Windows.Forms.Timer(this.components);
            this.lbEasyTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(113, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mode : Easy";
            // 
            // lbQuestions
            // 
            this.lbQuestions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbQuestions.AutoSize = true;
            this.lbQuestions.BackColor = System.Drawing.Color.LightGray;
            this.lbQuestions.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbQuestions.ForeColor = System.Drawing.Color.Black;
            this.lbQuestions.Location = new System.Drawing.Point(344, 195);
            this.lbQuestions.Name = "lbQuestions";
            this.lbQuestions.Size = new System.Drawing.Size(0, 38);
            this.lbQuestions.TabIndex = 4;
            // 
            // lbScore
            // 
            this.lbScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.LightGray;
            this.lbScore.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbScore.ForeColor = System.Drawing.Color.Black;
            this.lbScore.Location = new System.Drawing.Point(723, 26);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(129, 38);
            this.lbScore.TabIndex = 6;
            this.lbScore.Text = "Score : 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 82);
            this.button1.TabIndex = 12;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkAnswer);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 82);
            this.button2.TabIndex = 13;
            this.button2.Tag = "2";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkAnswer);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(535, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 82);
            this.button3.TabIndex = 14;
            this.button3.Tag = "3";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.checkAnswer);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(706, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 82);
            this.button4.TabIndex = 15;
            this.button4.Tag = "4";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.checkAnswer);
            // 
            // easyTimer
            // 
            this.easyTimer.Enabled = true;
            this.easyTimer.Interval = 1000;
            this.easyTimer.Tick += new System.EventHandler(this.easyTimer_Tick);
            // 
            // lbEasyTimer
            // 
            this.lbEasyTimer.AutoSize = true;
            this.lbEasyTimer.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEasyTimer.Location = new System.Drawing.Point(479, 139);
            this.lbEasyTimer.Name = "lbEasyTimer";
            this.lbEasyTimer.Size = new System.Drawing.Size(64, 48);
            this.lbEasyTimer.TabIndex = 16;
            this.lbEasyTimer.Text = "00";
            // 
            // EasyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1007, 525);
            this.Controls.Add(this.lbEasyTimer);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbQuestions);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EasyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyForm";
            this.Load += new System.EventHandler(this.EasyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbQuestions;
        private Label lbScore;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private System.Windows.Forms.Timer easyTimer;
        private Label lbEasyTimer;
    }
}