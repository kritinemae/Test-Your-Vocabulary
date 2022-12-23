using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Your_Vocabulary
{
    public partial class MediumForm : Form
    {
        //variables of the game
        int score = 0;
        int correctAnswer;
        int numberOfQuestions = 1;
        int medium_timer = 20;
        bool time_is_active;
        public MediumForm()
        {
            InitializeComponent();
            mediumQuestions(numberOfQuestions);
            time_is_active = true;
            lbMediumTimer.Text = medium_timer.ToString();
        }

        private void checkAnswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                //condition of correct answer
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
                mediumQuestions(numberOfQuestions += 1);
            }
        }
        private void mediumQuestions(int mediumquestions)
        {
            switch (mediumquestions)
            {
                case 1:
                    lbQuestions.Text = "what is in another terms of voracious?";
                    button1.Text = "quick";
                    button2.Text = "scaly";
                    button3.Text = "furry";
                    button4.Text = "insatiable";
                    correctAnswer = 4;
                    break;
                case 2:
                    lbQuestions.Text = "what is in another terms of addendum?";
                    button1.Text = "memo";
                    button2.Text = "goodwill";
                    button3.Text = "introduction";
                    button4.Text = "supplement";
                    correctAnswer = 4;
                    break;
                case 3:
                    lbQuestions.Text = "what is in another terms of ecstatic?";
                    button1.Text = "joyful";
                    button2.Text = "guarded";
                    button3.Text = "loud";
                    button4.Text = "unreal";
                    correctAnswer = 1;
                    break;
                case 4:
                    lbQuestions.Text = "what is in another terms of persuade?";
                    button1.Text = "convince";
                    button2.Text = "accept";
                    button3.Text = "tempt";
                    button4.Text = "trick";
                    correctAnswer = 1;
                    break;
                case 5:
                    lbQuestions.Text = "what is in another terms of supersede?";
                    button1.Text = "prepare";
                    button2.Text = "break";
                    button3.Text = "recite";
                    button4.Text = "replace";
                    correctAnswer = 4;
                    break;
                case 6:
                    lbQuestions.Text = "what is in another terms of ornery?";
                    button1.Text = "confident";
                    button2.Text = "irritable";
                    button3.Text = "effective";
                    button4.Text = "damage";
                    correctAnswer = 2;
                    break;
                case 7:
                    lbQuestions.Text = "what is in another terms of orthodox?";
                    button1.Text = "conventional";
                    button2.Text = "pleasant";
                    button3.Text = "breezy";
                    button4.Text = "deceptive";
                    correctAnswer = 1;
                    break;
                case 8:
                    lbQuestions.Text = "what is in another terms of paunch?";
                    button1.Text = "baggage";
                    button2.Text = "belly";
                    button3.Text = "blockage";
                    button4.Text = "attack";
                    correctAnswer = 2;
                    break;
                case 9:
                    lbQuestions.Text = "what is in another terms of jidicious?";
                    button1.Text = "guilty";
                    button2.Text = "sensible";
                    button3.Text = "thankful";
                    button4.Text = "grieving";
                    correctAnswer = 2;
                    break;
                case 10:
                    lbQuestions.Text = "what is in another terms of epedemic?";
                    button1.Text = "mocking";
                    button2.Text = "infectious";
                    button3.Text = "artificial";
                    button4.Text = "swift";
                    correctAnswer = 4;
                    break;
                case 11:
                    lbQuestions.Text = "what is in another terms of accrue?";
                    button1.Text = "labor";
                    button2.Text = "spend";
                    button3.Text = "accumulate";
                    button4.Text = "watch";
                    correctAnswer = 3;
                    break;
                case 12:
                    lbQuestions.Text = "what is in another terms of appeal?";
                    button1.Text = "request";
                    button2.Text = "decoration";
                    button3.Text = "battle";
                    button4.Text = "accident";
                    correctAnswer = 1;
                    break;
                case 13:
                    lbQuestions.Text = "what is in another terms of revert?";
                    button1.Text = "speak";
                    button2.Text = "distract";
                    button3.Text = "drop";
                    button4.Text = "return";
                    correctAnswer = 4;
                    break;
                case 14:
                    lbQuestions.Text = "what is in another terms of foster?";
                    button1.Text = "promote";
                    button2.Text = "submit";
                    button3.Text = "convince";
                    button4.Text = "export";
                    correctAnswer = 1;
                    break;
                case 15:
                    lbQuestions.Text = "what is in another terms of feat?";
                    button1.Text = "trill";
                    button2.Text = "talent";
                    button3.Text = "accomplishment";
                    button4.Text = "celebration";
                    correctAnswer = 3;
                    break;
            }

        }
        public void QuestionsLimit()
        {
            if (numberOfQuestions > 15)
            {
                MediumTimer.Stop();
                MessageBox.Show($"Mode : Medium\nScore : {score}", "Message Info!", MessageBoxButtons.OK);
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
        }

        private void MediumForm_Load(object sender, EventArgs e)
        {
            lbScore.Text = "Score : " + score;
        }
        private void ResetTimer()
        {
            medium_timer = 20;
            lbMediumTimer.Text = medium_timer.ToString();
            mediumQuestions(numberOfQuestions += 1);


        }

        private void MediumTimer_Tick(object sender, EventArgs e)
        {
            time_is_active = true;
            medium_timer--;
            lbMediumTimer.Text = medium_timer.ToString();
            if (medium_timer == 0)
            {
                ResetTimer();
            }
        }
    }
}
