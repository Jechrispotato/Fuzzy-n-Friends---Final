using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuzzy__n_Friends
{
    public partial class complete_the_word : Form
    {
        private List<(string withBlank, string fullWord)> words = new List<(string, string)>
        {
            ("BANA_A", "BANANA"),
            ("APP_ES", "APPLES"),
            ("OR_NGE", "ORANGE"),
            ("GRA_ES", "GRAPES"),
            ("M_NGOS", "MANGOS"),
            ("PAP_YA", "PAPAYA"),
            ("CHER_Y", "CHERRY"),
            ("PEA_HY", "PEACHY"),
            ("GUAVA_", "GUAVAS"),
            ("L_MONS", "LEMONS"),
        };

        private string currentWordWithBlank;
        private string currentFullWord;
        private char missingLetter;
        private int score = 0;
        private const int max_score = 10;
        public complete_the_word()
        {
            InitializeComponent();
        }

        private void Complete_the_word_Load(object sender, EventArgs e)
        {
            score = 0;
            UpdateScoreLabel();
            LoadNewQuestion();
        }

        private void LoadNewQuestion()
        {
            //random na pipili ng word sa list
            var random = new Random();
            var randomIndex = random.Next(words.Count);
            (currentWordWithBlank, currentFullWord) = words[randomIndex];

            //hahanapin yung missing na letter
            int missingIndex = currentWordWithBlank.IndexOf('_');
            missingLetter = currentFullWord[missingIndex];

            //function na nagu-pdate ng labels
            UpdateLabels(currentWordWithBlank);

            //panggenerate ng choices
            var allLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".Except(new[] { missingLetter }).ToList();
            var randomLetters = allLetters.OrderBy(x => random.Next()).Take(3).ToList();
            randomLetters.Add(missingLetter); // Add the correct letter
            randomLetters = randomLetters.OrderBy(x => random.Next()).ToList(); // Shuffle

            //pang update ng mga buttons
            button1.Text = randomLetters[0].ToString();
            button1.Tag = randomLetters[0];

            button2.Text = randomLetters[1].ToString();
            button2.Tag = randomLetters[1];

            button3.Text = randomLetters[2].ToString();
            button3.Tag = randomLetters[2];

            button4.Text = randomLetters[3].ToString();
            button4.Tag = randomLetters[3];
        }

        private void UpdateLabels(string wordWithBlank)
        {
            // Assign letters to the labels based on the word with the blank
            label1.Text = wordWithBlank.Length > 0 ? wordWithBlank[0].ToString() : "";
            label2.Text = wordWithBlank.Length > 1 ? wordWithBlank[1].ToString() : "";
            label3.Text = wordWithBlank.Length > 2 ? wordWithBlank[2].ToString() : "";
            label4.Text = wordWithBlank.Length > 3 ? wordWithBlank[3].ToString() : "";
            label5.Text = wordWithBlank.Length > 4 ? wordWithBlank[4].ToString() : "";
            label6.Text = wordWithBlank.Length > 5 ? wordWithBlank[5].ToString() : "";
        }

        private void UpdateScoreLabel()
        {
            scorelbl.Text = $"Score: {score}/{max_score}";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // pag iidentify ng button na clinick tapos adding ng score
            var clickedButton = sender as Button;
            var selectedLetter = (char)clickedButton.Tag;

            if (selectedLetter == missingLetter)
            {
                score++;
                UpdateScoreLabel();
                if (score >= 10)
                {
                    correct right = new correct();
                    //need ng new form for congratulation wanna try again?
                    right.ShowDialog();
                    this.Close();

                }
                else
                {
                    correct right = new correct();
                    right.ShowDialog();
                    LoadNewQuestion(); // Load a new word
                }
            }
            else
            {
                incorrect wrong = new incorrect();
                wrong.ShowDialog();
                
            }
        }
    }
}
