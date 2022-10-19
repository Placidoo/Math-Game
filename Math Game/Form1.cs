using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Math_Game
{
    public partial class mainForm : Form
    {

        int number1, number2, ops, result, heart, difficulty, score;
        bool gameStart;

        public mainForm()
        {
            InitializeComponent();
            HideLife();
        }

        private void mainForm_Load(object sender, EventArgs e) // When Program Starts
        {
            Life3.Show();
            lblStreak.Text = "Welcome!";
            difficulty = 1;
            Time.SetState(3);
            this.Size = new Size(355, 516);
            pnlMenu.Location = new Point(10, 140);
            lblTip.Hide();
        }

        private void timeLimit_Tick(object sender, EventArgs e)
        {
            if (Time.Value != 0 && difficulty == 1) // Time For Easy Mode
            {
                Time.Value -= 1;
            }
            else if (Time.Value != 0 && difficulty == 2) // Time for Medium Mode
            {
                Time.Value -= 1;
            }
            else if (Time.Value != 0 && difficulty == 3) // Time for Hard Mode
            {
                Time.Value -= 2;
            }
            if (Time.Value == 97 || Time.Value == 94)
            {
                pnlCorrect.Hide();
                pnlIncorrect.Hide();
            }
            if (Time.Value == 0) // Lose Heart
            {
                pnlIncorrect.Show();
                if (difficulty == 1) // Lose Heart in Easy
                {
                    heart--;
                    timeLimit.Enabled = false;
                    Easy();
                }
                else if (difficulty == 2) // Lose Heart in Medium
                {
                    heart--;
                    timeLimit.Enabled = false;
                    Medium();
                }
                else if (difficulty == 3) // Lose Heart in Hard
                {
                    heart--;
                    timeLimit.Enabled = false;
                    Hard();
                }
            }
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)    // Controls
        {
            if (gameStart == true)
            {
                if (e.KeyCode == Keys.D1)
                {
                    if (lblAnswer.Text == "Input Number")
                    {
                        lblAnswer.Text = "1";
                    }
                    else
                    {
                        lblAnswer.Text += "1";
                    }
                }
                else if (e.KeyCode == Keys.D2)
                {
                    if (lblAnswer.Text == "Input Number")
                    {
                        lblAnswer.Text = "2";
                    }
                    else
                    {
                        lblAnswer.Text += "2";
                    }
                }
                else if (e.KeyCode == Keys.D3)
                {
                    if (lblAnswer.Text == "Input Number")
                    {
                        lblAnswer.Text = "3";
                    }
                    else
                    {
                        lblAnswer.Text += "3";
                    }
                }
                else if (e.KeyCode == Keys.D4)
                {
                    if (lblAnswer.Text == "Input Number")
                    {
                        lblAnswer.Text = "4";
                    }
                    else
                    {
                        lblAnswer.Text += "4";
                    }
                }
                else if (e.KeyCode == Keys.D5)
                {
                    if (lblAnswer.Text == "Input Number")
                    {
                        lblAnswer.Text = "5";
                    }
                    else
                    {
                        lblAnswer.Text += "5";
                    }
                }
                else if (e.KeyCode == Keys.D6)
                {
                    if (lblAnswer.Text == "Input Number")
                    {
                        lblAnswer.Text = "6";
                    }
                    else
                    {
                        lblAnswer.Text += "6";
                    }
                }
                else if (e.KeyCode == Keys.D7)
                {
                    if (lblAnswer.Text == "Input Number")
                    {
                        lblAnswer.Text = "7";
                    }
                    else
                    {
                        lblAnswer.Text += "7";
                    }
                }
                else if (e.KeyCode == Keys.D8)
                {
                    if (lblAnswer.Text == "Input Number")
                    {
                        lblAnswer.Text = "8";
                    }
                    else
                    {
                        lblAnswer.Text += "8";
                    }
                }
                else if (e.KeyCode == Keys.D9)
                {
                    if (lblAnswer.Text == "Input Number")
                    {
                        lblAnswer.Text = "9";
                    }
                    else
                    {
                        lblAnswer.Text += "9";
                    }
                }
                else if (e.KeyCode == Keys.D0)
                {
                    if (lblAnswer.Text != "Input Number")
                    {
                        lblAnswer.Text += "0";
                    }
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (lblAnswer.Text == "")
                    {
                        lblAnswer.Text = "Input Number";
                    }
                    else if (lblAnswer.Text != "Input Number")
                    {
                        lblAnswer.Text = lblAnswer.Text.Remove(lblAnswer.Text.Length - 1, 1);
                    }
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    if (lblAnswer.Text == "Input Number")
                    {
                        lblTip.Show();
                        lblTip.Text = ("Answer the Question, Can You?");
                    }
                    else if (result == Convert.ToInt32(lblAnswer.Text))
                    {
                        lblTip.Hide();
                        pnlCorrect.Show();
                        pnlCorrect.Location = new Point(10, 10);
                        if (difficulty == 1)
                        {
                            if (Time.Value >= 80) // Give Score
                            {
                                score += 50;
                            }
                            else if (Time.Value >= 50)
                            {
                                score += 25;
                            }
                            else
                            {
                                score += 15;
                            }
                            lblAnswer.Text = "Input Number";
                            Easy();
                        }
                        if (difficulty == 2)
                        {
                            if (Time.Value >= 80) // Give Score
                            {
                                score += 50;
                            }
                            else if (Time.Value >= 50)
                            {
                                score += 25;
                            }
                            else
                            {
                                score += 15;
                            }
                            lblAnswer.Text = "Input Number";
                            Medium();
                        }
                        if (difficulty == 3)
                        {
                            if (Time.Value >= 80) // Give Score
                            {
                                score += 50;
                            }
                            else if (Time.Value >= 50)
                            {
                                score += 25;
                            }
                            else
                            {
                                score += 15;
                            }
                            Time.Value = 100;
                            lblAnswer.Text = "Input Number";
                            Hard();
                        }
                    }
                    else
                    {
                        lblTip.Hide();
                        pnlIncorrect.Show();
                        pnlIncorrect.Location = new Point(10, 10);
                        Time.Value = 100;
                        if (difficulty == 1)
                        {
                            lblAnswer.Text = "Input Number";
                            Easy();
                            if (heart != 0)
                            {
                                heart--;
                            }
                        }
                        else if (difficulty == 2)
                        {
                            lblAnswer.Text = "Input Number";
                            Medium();
                            if (heart != 0)
                            {
                                heart--;
                            }
                        }
                        else if (difficulty == 3)
                        {
                            lblAnswer.Text = "Input Number";
                            if (heart != 0)
                            {
                                heart--;
                            }
                        }
                    }
                }
            }
        }

        private void Background_Tick(object sender, EventArgs e)
        {
            lblScore.Text = Convert.ToString(score);
            if (Time.Value < 30) // Turn Progress Bar to Red if Below 30%
            {
                Time.SetState(2);
            }
            else if (Time.Value >= 30) // Turn Progress Bar to Yellow if above 30%
            {
                Time.SetState(3);
            }
            if (lblAnswer.Text.Length > 5 && lblAnswer.Text != "Input Number") // Prevent large answer
            {
                lblAnswer.Text = lblAnswer.Text.Remove(lblAnswer.Text.Length - 1, 1);
            }
            if (lblAnswer.Text == "")
            {
                lblAnswer.Text = "Input Number";
            }
            if (difficulty == 1)
            {
                lblDiff.Text = "Easy Mode";
            }
            if (difficulty == 2)
            {
                lblDiff.Text = "Medium Mode";
            }
            if (difficulty == 3)
            {
                lblDiff.Text = "Hard Mode";
            }
            if (difficulty == 1 && gameStart == true || difficulty == 2 && gameStart == true)  // Display Life When Difficulty is Easy  
            {
                if (heart == 3)
                {
                    HideLife();
                    Life3.Show();
                }
                else if (heart == 2)
                {
                    HideLife();
                    Life2.Show();
                }
                else if (heart == 1)
                {
                    HideLife();
                    Life1.Show();
                }
                else if (heart == 0) // Game End
                {
                    HideLife();
                    Life0.Show();
                    timeLimit.Enabled = false;
                    gameStart = false;
                    pnlScore.Show();
                    Game_End();
                    pnlScore.Location = new Point(10, 140);
                }
            }
            if (difficulty == 3 && gameStart == true) // Hard
            {
                if (heart == 1)
                {
                    HideLife();
                    Life3.Show();
                }
                else if (heart == 0)
                {
                    HideLife();
                    Life0.Show();
                    timeLimit.Enabled = false;
                    gameStart = false;
                    pnlScore.Show();
                    Game_End();
                    pnlScore.Location = new Point(10, 140);
                }
            }
        }

        private void btnExitAbtMe_Click(object sender, EventArgs e)
        {
            pnlAboutMe.Hide();
        }

        private void btnAboutMe_Click(object sender, EventArgs e)
        {
            pnlAboutMe.Show();
            pnlAboutMe.Location = new Point(10, 140);
        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            Time.Value = 0;
            lblStreak.Text = "Get Ready!";
            Loading.Enabled = true;
        }

        private void Loading_Tick(object sender, EventArgs e) // Display Loading when Play button is pressed
        {
            if (Time.Value == 100)
            {
                Loading.Enabled = false;
                gameStart = true;
                lblStreak.Text = "Break a Leg!";
                pnlMenu.Hide();
                timeLimit.Enabled = true;
                if (difficulty == 1)
                {
                    heart = 3;
                    Easy();
                }
                else if (difficulty == 2)
                {
                    heart = 3;
                    Medium();
                }
                else if (difficulty == 3)
                {
                    heart = 1;
                    Hard();
                }
            }
            else if (Time.Value != 100)
            {
                Time.Value += 2;
            }
        }

        private void lblPlay_MouseEnter(object sender, EventArgs e) // lblPlay Color Change
        {
            lblPlay.ForeColor = Color.Red;
        }

        private void lblPlay_MouseLeave(object sender, EventArgs e) // lblPlay Color Change
        {
            lblPlay.ForeColor = Color.White;
        }

        private void lblEasy_Click(object sender, EventArgs e) // 3 Lives and Time Activated
        {
            difficulty = 1;
            pnlDifficulty.Location = new Point(0, 0);
            lblDifficulty.Text = "Easy";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            pnlScore.Hide();
            pnlMenu.Show();
            Menu();
        }

        private void lblMedium_Click(object sender, EventArgs e) // 3 Lives and harder questions
        {
            difficulty = 2;
            pnlDifficulty.Location = new Point(80, 0);
            lblDifficulty.Text = "Medium";
        }

        private void lblHard_Click(object sender, EventArgs e) // Harder Question, 1 life and plus time each correct answer
        {
            difficulty = 3;
            pnlDifficulty.Location = new Point(160, 0);
            lblDifficulty.Text = "Hard";
        }

        private void pcMenu_Click(object sender, EventArgs e)
        {
            heart = 0;
        }

        public void Easy()
        {
            if (gameStart == true)
            {
                Time.Value = 100;
                timeLimit.Enabled = true;
                Random randomizer = new Random();
                number1 = randomizer.Next(1, 11);
                number2 = randomizer.Next(1, 11);
                ops = randomizer.Next(1, 3);
                if (ops == 1)
                {
                    lblQuestion.Text = (number1 + " + " + number2);
                    result = number1 + number2;
                }
                else if (ops == 2)
                {
                    if (number2 > number1 || number1 == number2)
                    {
                        Easy();
                    }
                    else
                    {
                        lblQuestion.Text = (number1 + " - " + number2);
                        result = number1 - number2;
                    }
                }
            }
        }

        public void Medium()
        {
            if (gameStart == true)
            {
                Time.Value = 100;
                timeLimit.Enabled = true;
                Random randomizer = new Random();
                number1 = randomizer.Next(1, 51);
                number2 = randomizer.Next(1, 51);
                ops = randomizer.Next(1, 6);
                if (ops == 1 || ops == 4)
                {
                    lblQuestion.Text = (number1 + " + " + number2);
                    result = number1 + number2;
                }
                else if (ops == 2 || ops == 5)
                {
                    if (number2 > number1 || number1 == number2)
                    {
                        Medium();
                    }
                    else
                    {
                        lblQuestion.Text = (number1 + " - " + number2);
                        result = number1 - number2;
                    }
                }
                else if (ops == 3)
                {
                    number1 = randomizer.Next(1, 11);
                    number2 = randomizer.Next(1, 11);
                    lblQuestion.Text = (number1 + " x " + number2);
                    result = number1 * number2;
                }
            }
        }

        public void Hard()
        {
            if (gameStart == true)
            {
                Time.Value = 100;
                timeLimit.Enabled = true;
                Random randomizer = new Random();
                number1 = randomizer.Next(1, 51);
                number2 = randomizer.Next(1, 51);
                ops = randomizer.Next(1, 6);
                if (ops == 1 || ops == 4)
                {
                    lblQuestion.Text = (number1 + " + " + number2);
                    result = number1 + number2;
                }
                else if (ops == 2 || ops == 5)
                {
                    if (number2 > number1 || number1 == number2)
                    {
                        Hard();
                    }
                    else
                    {
                        lblQuestion.Text = (number1 + " - " + number2);
                        result = number1 - number2;
                    }
                }
                else if (ops == 3)
                {
                    number1 = randomizer.Next(1, 11);
                    number2 = randomizer.Next(1, 11);
                    lblQuestion.Text = (number1 + " x " + number2);
                    result = number1 * number2;
                }
            }
        }

        public void Game_End()
        {
            pnlIncorrect.Hide();
            lblStreak.Text = "Good Game!";
        }

        public void Menu()
        {
            score = 0;
            Life3.Show();
            lblStreak.Text = "Welcome!";
            Time.SetState(3);
            this.Size = new Size(355, 516);
            pnlMenu.Location = new Point(10, 140);
            lblTip.Hide();
        }

        public void HideLife()
        {
            Life0.Hide();
            Life1.Hide();
            Life2.Hide();
            Life3.Hide();
        }
    }
    public static class ModifyProgressBarColor // Changes the Progress Bar Color ( 1 = Green, 2 = Red, 3 = Yellow )
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
