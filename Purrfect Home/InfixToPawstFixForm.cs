using Purrfect_Home;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InfixToPawstfixGame
{
    public partial class InfixToPawstFixForm : Form
    {
        private int currentRound = 0;
        private int points = 0;
        private bool choicesLocked = false;
        private Random rand = new Random();

        public InfixToPawstFixForm()
        {
            InitializeComponent();

            lblChoice1.Click += lblChoice1_Click;
            lblChoice2.Click += lblChoice2_Click;
            lblChoice3.Click += lblChoice3_Click;

            lblChoice1.Cursor = Cursors.Hand;
            lblChoice2.Cursor = Cursors.Hand;
            lblChoice3.Cursor = Cursors.Hand;

            StartGame();
        }

        // ------------------------------
        // GAME SETUP
        // ------------------------------
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
            choicesLocked = false;

            // --------------------------
            // Generate HARD expression
            // --------------------------
            string infix = GenerateHardInfix();
            string postfix = InfixToPostfix(infix);

            lblGiven.Text = infix;

            // Build answer choices
            List<string> choices = new List<string> { postfix };

            while (choices.Count < 3)
            {
                string wrong = GenerateWrongPostfix(postfix);
                if (!choices.Contains(wrong))
                    choices.Add(wrong);
            }

            // Shuffle
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

        // ------------------------------------------------
        // HARD INFIX EXPRESSION GENERATOR
        // ------------------------------------------------
        private string GenerateHardInfix()
        {
            // Example outputs:
            // (A+B)*(C-D/E)
            // A*(B+C*(D-E))
            // (A+B*C-D)/(E-F)
            // A*(B-(C+D)/E)+F

            string[] ops = { "+", "-", "*", "/" };
            string[] vars = { "A", "B", "C", "D", "E", "F" };

            string RandVar() => vars[rand.Next(vars.Length)];
            string RandOp() => ops[rand.Next(ops.Length)];

            // Build something like:
            // (X op X) op (X op X op X)
            string left = $"({RandVar()}{RandOp()}{RandVar()})";

            string mid = $"{RandVar()}{RandOp()}{RandVar()}";

            string right = $"({mid}{RandOp()}{RandVar()})";

            // final combine
            string final = $"{left}{RandOp()}{right}";

            return final;
        }

        // ------------------------------------------------
        // REAL INFIX ? POSTFIX USING STACK (POP / PUSH)
        // ------------------------------------------------
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
                    _ => 0
                };
            }

            foreach (char ch in infix)
            {
                if (char.IsLetter(ch))
                {
                    // Operand ? directly to output
                    output += ch;
                }
                else if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    // POP until '('
                    while (stack.Count > 0 && stack.Peek() != '(')
                        output += stack.Pop();
                    stack.Pop(); // remove '('
                }
                else if ("+-*/".Contains(ch))
                {
                    // POP while stack top has higher or equal precedence
                    while (stack.Count > 0 && Prec(stack.Peek()) >= Prec(ch))
                        output += stack.Pop();

                    stack.Push(ch);
                }
            }

            // POP remaining operators
            while (stack.Count > 0)
                output += stack.Pop();

            return output;
        }

        // ------------------------------------------------
        // WRONG ANSWER GENERATOR (slightly scrambled postfix)
        // ------------------------------------------------
        private string GenerateWrongPostfix(string postfix)
        {
            char[] arr = postfix.ToCharArray();

            // randomly swap two positions
            int a = rand.Next(arr.Length);
            int b = rand.Next(arr.Length);
            (arr[a], arr[b]) = (arr[b], arr[a]);

            return new string(arr);
        }

        // ------------------------------------------------
        // ANSWER CHECKING
        // ------------------------------------------------
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

        private void picMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form m = new HomeForm();
            m.StartPosition = FormStartPosition.Manual;
            m.Location = this.Location;
            m.ShowDialog();
        }
    }
}
