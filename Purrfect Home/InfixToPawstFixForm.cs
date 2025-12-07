using MySql.Data.MySqlClient;
using Purrfect_Home;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InfixToPawstfixGame
{
    public partial class InfixToPawstFixForm : Form
    {
        private string currentUserId;   // actually the username
        private int currentRound = 0;
        private int points = 0;
        private bool choicesLocked = false;
        private Random rand = new Random();

        private string connectionString = "server=localhost;database=dbposagame;uid=root;pwd=;";

        public InfixToPawstFixForm(string userId)
        {
            InitializeComponent();
            currentUserId = userId;

            lblChoice1.Click += lblChoice1_Click;
            lblChoice2.Click += lblChoice2_Click;
            lblChoice3.Click += lblChoice3_Click;

            lblChoice1.Cursor = Cursors.Hand;
            lblChoice2.Cursor = Cursors.Hand;
            lblChoice3.Cursor = Cursors.Hand;

            StartGame();
        }

        // -----------------------------------------------------
        // GAME SETUP
        // -----------------------------------------------------
        private void StartGame()
        {
            currentRound = 0;
            points = 0;
            lblPoints.Text = points.ToString();
            NextRound();
        }

        private void NextRound()
        {
            if (currentRound >= 10)
            {
                EndGame();
                return;
            }

            ResetChoiceColors();
            lblCorrectAns.Text = "";
            choicesLocked = false;

            string infix = GenerateHardInfix();
            string postfix = InfixToPostfix(infix);

            lblGiven.Text = infix;

            List<string> choices = new List<string> { postfix };

            while (choices.Count < 3)
            {
                string wrong = GenerateWrongPostfix(postfix);
                if (!choices.Contains(wrong))
                    choices.Add(wrong);
            }

            for (int i = 0; i < 10; i++)
            {
                int a = rand.Next(3);
                int b = rand.Next(3);
                (choices[a], choices[b]) = (choices[b], choices[a]);
            }

            lblChoice1.Text = choices[0];
            lblChoice2.Text = choices[1];
            lblChoice3.Text = choices[2];

            currentRound++;
        }

        // -----------------------------------------------------
        // HARD INFIX GENERATOR
        // -----------------------------------------------------
        private string GenerateHardInfix()
        {
            string[] ops = { "+", "-", "*", "/" };
            string[] vars = { "A", "B", "C", "D", "E", "F" };

            string RandVar() => vars[rand.Next(vars.Length)];
            string RandOp() => ops[rand.Next(ops.Length)];

            string left = $"({RandVar()}{RandOp()}{RandVar()})";
            string mid = $"{RandVar()}{RandOp()}{RandVar()}";
            string right = $"({mid}{RandOp()}{RandVar()})";

            return $"{left}{RandOp()}{right}";
        }

        // -----------------------------------------------------
        // INFIX ? POSTFIX
        // -----------------------------------------------------
        private string InfixToPostfix(string infix)
        {
            Stack<char> stack = new Stack<char>();
            string output = "";

            int Prec(char op)
            {
                return op switch
                {
                    '+' => 1,
                    '-' => 1,
                    '*' => 2,
                    '/' => 2,
                    _ => 0,
                };
            }

            foreach (char ch in infix)
            {
                if (char.IsLetter(ch))
                {
                    output += ch;
                }
                else if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                        output += stack.Pop();
                    stack.Pop();
                }
                else if ("+-*/".Contains(ch))
                {
                    while (stack.Count > 0 && Prec(stack.Peek()) >= Prec(ch))
                        output += stack.Pop();

                    stack.Push(ch);
                }
            }

            while (stack.Count > 0)
                output += stack.Pop();

            return output;
        }

        // -----------------------------------------------------
        // WRONG POSTFIX (random scramble)
        // -----------------------------------------------------
        private string GenerateWrongPostfix(string postfix)
        {
            char[] arr = postfix.ToCharArray();
            int a = rand.Next(arr.Length);
            int b = rand.Next(arr.Length);
            (arr[a], arr[b]) = (arr[b], arr[a]);
            return new string(arr);
        }

        // -----------------------------------------------------
        // CHECK ANSWER
        // -----------------------------------------------------
        private void CheckAnswer(Label selectedChoice)
        {
            if (choicesLocked) return;
            choicesLocked = true;

            string correct = InfixToPostfix(lblGiven.Text);
            lblCorrectAns.Text = "Correct Answer: " + correct;

            foreach (var lbl in new[] { lblChoice1, lblChoice2, lblChoice3 })
            {
                lbl.ForeColor = (lbl.Text == correct ? Color.Green : Color.Red);
            }

            if (selectedChoice.Text == correct)
            {
                points++;
                lblPoints.Text = points.ToString();
            }

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

        // -----------------------------------------------------
        // END GAME + COIN LOGIC
        // -----------------------------------------------------
        private void EndGame()
        {
            int coinsWon = 0;

            if (points == 5)
                coinsWon = 1;
            else if (points >= 6 && points <= 7)
                coinsWon = 2;
            else if (points >= 8 && points <= 9)
                coinsWon = rand.Next(2, 4); // 2–3 coins
            else if (points == 10)
                coinsWon = rand.Next(3, 5); // 3–4 coins

            if (coinsWon > 0)
                AddCoinsToDatabase(coinsWon);

            MessageBox.Show($"Game Over!\nScore: {points}/10\nYou earned {coinsWon} coin(s)!", "Game Finished");

            StartGame();
        }

        // -----------------------------------------------------
        // SAVE COINS TO DATABASE (FIXED)
        // -----------------------------------------------------
        private void AddCoinsToDatabase(int coins)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE tbaccountdetails SET coins = coins + @coins WHERE username = @user";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@coins", coins);
                        cmd.Parameters.AddWithValue("@user", currentUserId); // username
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form m = new GameSelectionForm(currentUserId);
            m.StartPosition = FormStartPosition.Manual;
            m.Location = this.Location;
            m.ShowDialog();
        }
    }
}
