using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Fuzzy__n_Friends
{
    public partial class math_quiz : Form
    {
        private string[] questions =
        {
            "9 - 8 = ?",
            "1 + 1 = ?",
            "6 - 3 = ?",
            "2 x 2 = ?",
            "2 + 3 = ?",
            "3 + 3 = ?",
            "9 - 2 = ?",
            "4 x 2 = ?",
            "5 + 4 = ?"
        };

        private int[] answers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // Corresponding answers

        private int currentQuestionIndex = 0;
        private int score = 0;
        private const int maxScore = 9;
        private Random random = new Random();
        private HashSet<int> usedQuestionIndices = new HashSet<int>(); // Track used question indices

        public math_quiz()
        {
            InitializeComponent();
            LoadQuestion();
            UpdateScoreLabel();
        }

        private void LoadQuestion()
        {
            if (score >= maxScore)
            {
                MessageBox.Show("Congratulations! You've completed the quiz!", "Quiz Finished");
                ResetQuiz();
                return; // Exit method
            }

            // Ensure the question index is unique
            int newQuestionIndex;
            do
            {
                newQuestionIndex = random.Next(questions.Length);
            } while (usedQuestionIndices.Contains(newQuestionIndex)); // Ensure no repeated indices

            usedQuestionIndices.Add(newQuestionIndex); // Track used indices
            currentQuestionIndex = newQuestionIndex;

            label1.Text = questions[currentQuestionIndex];

            int correctAnswer = answers[currentQuestionIndex];

            for (int i = 0; i < 9; i++)
            {
                Button button = this.Controls.Find($"button{i + 1}", true).FirstOrDefault() as Button;
                if (button == null) continue;

                if (i == correctAnswer - 1)
                {
                    button.Text = correctAnswer.ToString(); // Set correct answer
                    button.Tag = correctAnswer; // Tag set to correct answer
                }
                else
                {
                    int wrongAnswer = answers[i];
                    if (wrongAnswer != correctAnswer)
                    {
                        button.Text = wrongAnswer.ToString(); // Incorrect answers
                        button.Tag = wrongAnswer;
                    }
                    else
                    {
                        i--; // Avoid repeating correct answer
                    }
                }
            }
        }

        private void ResetQuiz()
        {
            currentQuestionIndex = 0; // Reset quiz
            score = 0; // Reset score
            usedQuestionIndices.Clear(); // Clear previously used indices
            UpdateScoreLabel();
        }

        private void UpdateScoreLabel()
        {
            label2.Text = $"Score: {score}/{maxScore}";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                if (int.TryParse(clickedButton.Tag?.ToString(), out int selectedAnswer))
                {
                    var correctAnswer = answers[currentQuestionIndex]; // Get current question answer

                    if (selectedAnswer == correctAnswer)
                    {
                        score++;
                        UpdateScoreLabel();

                        if (score == maxScore)
                        {
                            MessageBox.Show("Congratulations! You've completed the quiz!", "Congratulations");
                            ResetQuiz(); // Reset the quiz after completion
                        }
                        else
                        {
                            MessageBox.Show("Correct!", "Result");
                            LoadQuestion(); // Load next question
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong answer. Try again!", "Result");
                    }
                }
            }
        }
    }
}
