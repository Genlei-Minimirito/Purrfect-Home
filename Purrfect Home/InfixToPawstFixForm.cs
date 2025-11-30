using Purrfect_Home;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InfixToPawstfixGame
{
    public partial class InfixToPawstFixForm : Form
    {
        // Questions for a fixed 5-round game
        private List<(string infix, string postfix)> questions = new List<(string, string)>
        {
            ("A+B", "AB+"),
            ("A+B*C", "ABC*+"),
            ("(A+B)*C", "AB+C*"),
            ("A*B+C", "AB*C+"),
            ("A+(B*C-D)", "ABC*D-+")
        };

        private int currentRound = 0;   // rounds completed (0..5)
        private int points = 0;
        private Random rand = new Random();

        // NEW: prevents multiple clicks after selecting
        private bool choicesLocked = false;

        public InfixToPawstFixForm()
        {
            InitializeComponent();

            // Ensure click handlers are attached
            lblChoice1.Click -= lblChoice1_Click;
            lblChoice2.Click -= lblChoice2_Click;
            lblChoice3.Click -= lblChoice3_Click;

            lblChoice1.Click += lblChoice1_Click;
            lblChoice2.Click += lblChoice2_Click;
            lblChoice3.Click += lblChoice3_Click;

            // Make choices clickable
            lblChoice1.Cursor = Cursors.Hand;
            lblChoice2.Cursor = Cursors.Hand;
            lblChoice3.Cursor = Cursors.Hand;

            StartGame();
        }

        private void StartGame()
        {
            currentRound = 0;
            points = 0;
            lblPoints.Text = points.ToString();
            NextRound();
        }

        private void NextRound()
        {
            if (currentRound >= 5)
            {
                string msg = (points == 5) ? "YOU WIN! PERFECT SCORE!" : $"Game Over. Score: {points}/5";
                MessageBox.Show(msg, "Game Finished");
                StartGame();
                return;
            }

            ResetChoiceColors();
            lblCorrectAns.Text = "";
            choicesLocked = false; // allow clicking again

            var q = questions[currentRound];
            lblGiven.Text = q.infix;

            // Build choices list
            var choices = new List<string> { q.postfix };

            // Add wrong choices
            while (choices.Count < 3)
            {
                int r = rand.Next(questions.Count);
                string candidate = questions[r].postfix;
                if (!choices.Contains(candidate))
                    choices.Add(candidate);
            }

            // shuffle
            for (int i = 0; i < 10; i++)
            {
                int a = rand.Next(3);
                int b = rand.Next(3);
                (choices[a], choices[b]) = (choices[b], choices[a]);
            }

            // assign
            lblChoice1.Text = choices[0];
            lblChoice2.Text = choices[1];
            lblChoice3.Text = choices[2];

            currentRound++;
        }

        private void CheckAnswer(Label selectedChoice)
        {
            // NEW: block if already clicked
            if (choicesLocked) return;
            choicesLocked = true;

            string correctAnswer = questions[currentRound - 1].postfix;

            lblCorrectAns.Text = "Correct Answer: " + correctAnswer;

            // Color the answers
            foreach (var lbl in new[] { lblChoice1, lblChoice2, lblChoice3 })
            {
                if (lbl.Text == correctAnswer)
                    lbl.ForeColor = Color.Green;
                else
                    lbl.ForeColor = Color.Red;
            }

            // Score
            if (selectedChoice.Text == correctAnswer)
            {
                points++;
                lblPoints.Text = points.ToString();
            }

            // Delay and go to next round
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                NextRound();
            };
            timer.Start();
        }

        private void lblChoice1_Click(object sender, EventArgs e) => CheckAnswer(lblChoice1);
        private void lblChoice2_Click(object sender, EventArgs e) => CheckAnswer(lblChoice2);
        private void lblChoice3_Click(object sender, EventArgs e) => CheckAnswer(lblChoice3);

        private void ResetChoiceColors()
        {
            lblChoice1.ForeColor = Color.Black;
            lblChoice2.ForeColor = Color.Black;
            lblChoice3.ForeColor = Color.Black;
        }

        // designer stubs
        private void lblGiven_Click(object sender, EventArgs e) { }
        private void lblCorrectAns_Click(object sender, EventArgs e) { }
        private void lblPoints_Click(object sender, EventArgs e) { }

        private void picMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formMenu = new HomeForm();
            formMenu.StartPosition = FormStartPosition.Manual;
            formMenu.Location = this.Location;
            formMenu.ShowDialog();
        }
    }
}
