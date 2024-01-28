using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NextQuestion();
        }
        Random rnd = new Random();
        int max_attempts = 3, attempts = 0, correct_answers = 0, incorrect_answers = 0, answer, correct_answer = 4, command = 0;
        int[] numbers = new int[5];
        char[] commands = { '+', '-'};
        string question = "2 + 2 =";

        private void Delay_Tick(object sender, EventArgs e)//Delay for reseting the button's color
        {
            if (Answer_button.BackColor != Color.LightGray)
            {
                Answer_button.BackColor = Color.LightGray;
                Delay.Enabled = false;
            }
        }

        private void Answer_button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(EquationAnswer_input.Text, out answer))
            {
                if (answer == correct_answer)
                {
                    correct_answers += 1;
                    Answer_button.BackColor = Color.Green;
                    Delay.Start();
                    NextQuestion();
                }
                else
                {
                    attempts += 1;
                    Answer_button.BackColor = Color.Red;
                    Delay.Start();
                    Lifes_text.Text = (max_attempts - attempts).ToString() + " попытки";
                    EquationAnswer_input.Clear();
                }
                if (attempts >= max_attempts)
                {
                    incorrect_answers += 1;
                    NextQuestion();
                }
            }
        }

        private void NextQuestion()
        {
            CorrectAnswer_text.Text = question + " " + correct_answer;
            //choosing values for the question
            attempts = 0;
            int difficulty = ((correct_answers - incorrect_answers) + 1) / 7;
            if(difficulty < 0)
            {
                difficulty = 0;
            }
            int commandcount = 1;
            if (rnd.Next(1, 101) <= difficulty * 10)
            {
                commandcount += 1;
            }
            numbers[0] = rnd.Next(1 + difficulty, 10 + difficulty * 2);
            correct_answer = numbers[0];
            question = numbers[0].ToString();
            for (int i = 1; i <= commandcount; ++i)
            {
                numbers[i] = rnd.Next(1 + difficulty, (10 + difficulty * 2) - i * 2);
                command = rnd.Next(2);
                switch (commands[command])
                {
                    default://aka +
                        correct_answer = correct_answer + numbers[i];
                        break;
                    case '-':
                        correct_answer = correct_answer - numbers[i];
                        break;
                }
                question += " " + commands[command] + " " + numbers[i];
            }
            if(correct_answer < 0)
            {
                question += " + " + (correct_answer * -1);
                correct_answer = 0;
            }
            question += " =";
            Equation_text.Text = question;
            //moving the answer box
            EquationAnswer_input.Location = new Point(Equation_text.Location.X + Equation_text.Width, EquationAnswer_input.Location.Y);
            //showing current attempts and clearing the input
            Lifes_text.Text = (max_attempts - attempts).ToString() + " попытки";
            Attempts_text.Text = correct_answers.ToString() + " правильно " + incorrect_answers.ToString() + " неправильно";
            EquationAnswer_input.Clear();
        }

    }
}
