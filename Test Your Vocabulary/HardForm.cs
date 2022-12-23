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
    public partial class HardForm : Form
    {
        int score = 0;
        int correctAnswer;
        int numberOfQuestions = 1;
        int hard_timer = 30;
        bool time_is_active;
        public HardForm()
        {
            InitializeComponent();
            hardQuestions(numberOfQuestions);
            time_is_active = true;
            lbHardTimer.Text = hard_timer.ToString();
        }

        private void HardForm_Load(object sender, EventArgs e)
        {
            lbScore.Text = "Score : " + score;
        }

        private void checkAnswert(object sender, EventArgs e)
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
                hardQuestions(numberOfQuestions += 1);
            }
        }
        private void hardQuestions(int hardquestions)
        {
            switch (hardquestions)
            {
                case 1:
                    lbQuestions.Text = "what is in another terms of resilient?";
                    button1.Text = "fortunates";
                    button2.Text = "adaptable";
                    button3.Text = "thick";
                    button4.Text = "unpredictable";
                    correctAnswer = 2;
                    break;
                case 2:
                    lbQuestions.Text = "what is in another terms of presemptuous?";
                    button1.Text = "unpopular";
                    button2.Text = "alone";
                    button3.Text = "awake";
                    button4.Text = "bold";
                    correctAnswer = 4;
                    break;
                case 3:
                    lbQuestions.Text = "what is in another terms of mar?";
                    button1.Text = "spell";
                    button2.Text = "steal";
                    button3.Text = "consume";
                    button4.Text = "clean";
                    correctAnswer = 1;
                    break;
                case 4:
                    lbQuestions.Text = "what is in another terms of pastiche?";
                    button1.Text = "collage";
                    button2.Text = "necktie";
                    button3.Text = "napkin";
                    button4.Text = "noodle";
                    correctAnswer = 1;
                    break;
                case 5:
                    lbQuestions.Text = "what is in another terms of errant?";
                    button1.Text = "fundamental";
                    button2.Text = "proper";
                    button3.Text = "foreign";
                    button4.Text = "direct";
                    correctAnswer = 2;
                    break;
                case 6:
                    lbQuestions.Text = "what is in another terms of vet?";
                    button1.Text = "expose";
                    button2.Text = "join";
                    button3.Text = "review";
                    button4.Text = "stumble";
                    correctAnswer = 3;
                    break;
                case 7:
                    lbQuestions.Text = "what is in another terms of impeccable?";
                    button1.Text = "weight";
                    button2.Text = "approval";
                    button3.Text = "flawless";
                    button4.Text = "agreeable";
                    correctAnswer = 3;
                    break;
                case 8:
                    lbQuestions.Text = "what is in another terms of perception?";
                    button1.Text = "bravery";
                    button2.Text = "stupidity";
                    button3.Text = "choice";
                    button4.Text = "insight";
                    correctAnswer = 4;
                    break;
                case 9:
                    lbQuestions.Text = "what is in another terms of cadre?";
                    button1.Text = "relief";
                    button2.Text = "destination";
                    button3.Text = "group";
                    button4.Text = "magic";
                    correctAnswer = 3;
                    break;
                case 10:
                    lbQuestions.Text = "what is in another terms of cacophony?";
                    button1.Text = "warmth";
                    button2.Text = "noise";
                    button3.Text = "insanity";
                    button4.Text = "refreshment";
                    correctAnswer = 2;
                    break;
                case 11:
                    lbQuestions.Text = "what is in another terms of benign?";
                    button1.Text = "feverish";
                    button2.Text = "childlike";
                    button3.Text = "harmless";
                    button4.Text = "accidental";
                    correctAnswer = 3;
                    break;
                case 12:
                    lbQuestions.Text = "what is in another terms of paramount?";
                    button1.Text = "unsetting";
                    button2.Text = "supreme";
                    button3.Text = "disguised";
                    button4.Text = "heavy";
                    correctAnswer = 2;
                    break;
                case 13:
                    lbQuestions.Text = "what is in another terms of buccaneer?";
                    button1.Text = "pirate";
                    button2.Text = "doctor";
                    button3.Text = "cowboy";
                    button4.Text = "lawyer";
                    correctAnswer = 1;
                    break;
                case 14:
                    lbQuestions.Text = "what is in another terms of surfeit?";
                    button1.Text = "relaxation";
                    button2.Text = "dread";
                    button3.Text = "hunger";
                    button4.Text = "excess";
                    correctAnswer = 4;
                    break;
                case 15:
                    lbQuestions.Text = "what is in another terms of judicious?";
                    button1.Text = "sensiblel";
                    button2.Text = "subject";
                    button3.Text = "negative";
                    button4.Text = "whim";
                    correctAnswer = 1;
                    break;
                    
            }
        }
        public void QuestionsLimit()
        {
            if (numberOfQuestions > 15)
            {
                if (numberOfQuestions > 15)
                {
                    HardTimer.Stop();
                    MessageBox.Show($"Mode : Medium\nScore : {score}", "Message Info!", MessageBoxButtons.OK);
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                }
            }
        }
        private void ResetTimer()
        {
            hard_timer = 30;
            lbHardTimer.Text = hard_timer.ToString();
            hardQuestions(numberOfQuestions += 1);


        }

        private void HardTimer_Tick(object sender, EventArgs e)
        {
            time_is_active = true;
            hard_timer--;
            lbHardTimer.Text = hard_timer.ToString();
            if (hard_timer == 0)
            {
                ResetTimer();
            }
        }
    }
}
