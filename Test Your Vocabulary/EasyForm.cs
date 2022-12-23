using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Your_Vocabulary
{
    public partial class EasyForm : Form
    {
        //variables of the game
        int score = 0;
        int correctAnswer;
        int numberOfQuestions = 1;
        int easy_timer = 10;
        bool time_is_active;
        public EasyForm()
        {
            InitializeComponent();
            EasyQuestions(numberOfQuestions);
            time_is_active= true;
            lbEasyTimer.Text = easy_timer.ToString();
        }

        private void checkAnswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                time_is_active = true;
                ResetTimer();
                score += 1;
                lbScore.Text = "Score : " + score;
                QuestionsLimit();

            }
            else
            {
                SoundPlayer errorSound = new SoundPlayer(@"C:\Users\Charles Mc\source\repos\Test Your Vocabulary\sounds\mixkit-click-error-1110.wav");
                errorSound.Play();
                time_is_active = true;
                ResetTimer();
                QuestionsLimit();
                EasyQuestions(numberOfQuestions+=1);
            }
        }
        private void EasyQuestions(int easyQuestions)
        {
            switch(easyQuestions)
            {
                
                case 1:
                    lbQuestions.Text = " what is in another terms of ouvre?";
                    button1.Text = "disappointments";
                    button2.Text = "plans";
                    button3.Text = "works";
                    button4.Text = "dreams";
                    correctAnswer = 3;
                    break;
                case 2:
                    lbQuestions.Text = "what is in another terms of concession?";
                    button1.Text = "compromise";
                    button2.Text = "judgement";
                    button3.Text = "disagreement";
                    button4.Text = "bam";
                    correctAnswer = 1;
                    break;
                case 3:
                    lbQuestions.Text = "what is in another terms of enmity?";
                    button1.Text = "hostility";
                    button2.Text = "salary";
                    button3.Text = "intelligence";
                    button4.Text = "expectation";
                    correctAnswer = 1;
                    break;
                case 4:
                    lbQuestions.Text = "what is in another terms of brevity?";
                    button1.Text = "service";
                    button2.Text = "length";
                    button3.Text = "flaw";
                    button4.Text = "shortness";
                    correctAnswer = 4;
                    break;
                case 5:
                    lbQuestions.Text = "what is in another terms of succinct?";
                    button1.Text = "considerate";
                    button2.Text = "well";
                    button3.Text = "brief";
                    button4.Text = "high";
                    correctAnswer = 3;
                    break;
                case 6:
                    lbQuestions.Text = "what is in another terms of nuisance?";
                    button1.Text = "dyty";
                    button2.Text = "muscle";
                    button3.Text = "annoyance";
                    button4.Text = "candle";
                    correctAnswer = 3;
                    break;
                case 7:
                    lbQuestions.Text = "what is in another terms of impotent?";
                    button1.Text = "implied";
                    button2.Text = "ridiculous";
                    button3.Text = "powerless";
                    button4.Text = "excellent";
                    correctAnswer = 3;
                    break;
                case 8:
                    lbQuestions.Text = "what is in another terms of ilk?";
                    button1.Text = "texture";
                    button2.Text = "sort";
                    button3.Text = "motto";
                    button4.Text = "prediction";
                    correctAnswer = 2;
                    break;
                case 9:
                    lbQuestions.Text = "what is in another terms of vivacious?";
                    button1.Text = "impolite";
                    button2.Text = "lively";
                    button3.Text = "bruised";
                    button4.Text = "dying";
                    correctAnswer = 2;
                    break;
                case 10:
                    lbQuestions.Text = "what is in another terms of raucous?";
                    button1.Text = "covered";
                    button2.Text = "impossible";
                    button3.Text = "funny";
                    button4.Text = "fowdy";
                    correctAnswer = 4;
                    break;
                case 11:
                    lbQuestions.Text = "what is in another terms of mundane?";
                    button1.Text = "dissappointing";
                    button2.Text = "depressing";
                    button3.Text = "curious";
                    button4.Text = "commonplace";
                    correctAnswer = 4;
                    break;
                case 12:
                    lbQuestions.Text = "what is in another terms of detritus?";
                    button1.Text = "design";
                    button2.Text = "boredom";
                    button3.Text = "debut";
                    button4.Text = "debris";
                    correctAnswer = 4;
                    break;
                case 13:
                    lbQuestions.Text = "what is in another terms of camaraderie?";
                    button1.Text = "judgement";
                    button2.Text = "secrecy";
                    button3.Text = "fellowship";
                    button4.Text = "formality";
                    correctAnswer = 3;
                    break;
                case 14:
                    lbQuestions.Text = "what is in another terms of anithesis?";
                    button1.Text = "dublicate";
                    button2.Text = "opposite";
                    button3.Text = "sadness";
                    button4.Text = "synonym";
                    correctAnswer = 3;
                    break;
                case 15:
                    lbQuestions.Text = "what is in another terms of propriety?";
                    button1.Text = "appropriateness";
                    button2.Text = "well";
                    button3.Text = "glaring";
                    button4.Text = "accident";
                    correctAnswer = 1;
                    break;
                    

            }
        }

        private void EasyForm_Load(object sender, EventArgs e)
        {
            lbScore.Text = "Score : " + score;
        }

        public void QuestionsLimit()
        {
            if (numberOfQuestions > 15)
            {
                easyTimer.Stop();
                MessageBox.Show($"Mode : Easy\nScore : {score}","Message Info!",MessageBoxButtons.OK);
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
        }

        private void easyTimer_Tick(object sender, EventArgs e)
        {
            time_is_active= true;
            easy_timer--;
            lbEasyTimer.Text = easy_timer.ToString();
            if (easy_timer == 0)
            {
                ResetTimer();
            }

        }
        private void ResetTimer()
        {
            easy_timer = 10;
            lbEasyTimer.Text = easy_timer.ToString();
            EasyQuestions(numberOfQuestions += 1);
            

        }
    }
}
