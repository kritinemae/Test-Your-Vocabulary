namespace Test_Your_Vocabulary
{
    partial class HardForm
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbQuestions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HardTimer = new System.Windows.Forms.Timer(this.components);
            this.lbHardTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(694, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 82);
            this.button4.TabIndex = 24;
            this.button4.Tag = "4";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.checkAnswert);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(523, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 82);
            this.button3.TabIndex = 23;
            this.button3.Tag = "3";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.checkAnswert);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 82);
            this.button2.TabIndex = 22;
            this.button2.Tag = "2";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkAnswert);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 82);
            this.button1.TabIndex = 21;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkAnswert);
            // 
            // lbScore
            // 
            this.lbScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.LightGray;
            this.lbScore.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbScore.ForeColor = System.Drawing.Color.Black;
            this.lbScore.Location = new System.Drawing.Point(674, 61);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(129, 38);
            this.lbScore.TabIndex = 19;
            this.lbScore.Text = "Score : 0";
            // 
            // lbQuestions
            // 
            this.lbQuestions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbQuestions.AutoSize = true;
            this.lbQuestions.BackColor = System.Drawing.Color.LightGray;
            this.lbQuestions.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbQuestions.ForeColor = System.Drawing.Color.Black;
            this.lbQuestions.Location = new System.Drawing.Point(266, 214);
            this.lbQuestions.Name = "lbQuestions";
            this.lbQuestions.Size = new System.Drawing.Size(0, 38);
            this.lbQuestions.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 48);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mode : Hard";
            // 
            // HardTimer
            // 
            this.HardTimer.Enabled = true;
            this.HardTimer.Interval = 1000;
            this.HardTimer.Tick += new System.EventHandler(this.HardTimer_Tick);
            // 
            // lbHardTimer
            // 
            this.lbHardTimer.AutoSize = true;
            this.lbHardTimer.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHardTimer.Location = new System.Drawing.Point(454, 157);
            this.lbHardTimer.Name = "lbHardTimer";
            this.lbHardTimer.Size = new System.Drawing.Size(64, 48);
            this.lbHardTimer.TabIndex = 25;
            this.lbHardTimer.Text = "00";
            // 
            // HardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1007, 525);
            this.Controls.Add(this.lbHardTimer);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbQuestions);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HardForm";
            this.Load += new System.EventHandler(this.HardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label lbScore;
        private Label lbQuestions;
        private Label label1;
        private System.Windows.Forms.Timer HardTimer;
        private Label lbHardTimer;
    }
}