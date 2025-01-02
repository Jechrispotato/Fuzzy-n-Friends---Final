using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fuzzy__n_Friends
{
    public partial class kill_a_pest : Form
    {
        public kill_a_pest()
        {
            InitializeComponent();
            Arrow.Visible = false; // Hide arrow initially
            InitializeBalloons();

            timer1.Interval = 20; // Set the interval (in milliseconds)
            timer1.Tick += timer1_Tick; // Attach the Tick event
            timer1.Start(); // Start the timer
        }

        int score;
        Random rnd = new Random();
        bool arrowActive = false; // Tracks if the arrow is active
        Stack<Control> balloons = new Stack<Control>(); // Stack to manage balloons

        void InitializeBalloons()
        {
            // Add balloons to the stack
            balloons.Push(b_1);
            balloons.Push(b_2);
            balloons.Push(b_3);

            // Set initial positions
            b_1.Left = 1200; b_1.Top = 100;
            b_2.Left = 1300; b_2.Top = 200;
            b_3.Left = 1400; b_3.Top = 300;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Shoot();
            Baloon();
            Game();
        }

        void Game()
        {
            if (arrowActive)
            {
                foreach (var balloon in balloons)
                {
                    if (Arrow.Bounds.IntersectsWith(balloon.Bounds))
                    {
                        RespawnBalloon(balloon);
                        score += 5;
                        lbl_score.Text = "Score :" + score;
                        Arrow.Image = Fuzzy__n_Friends.Properties.Resources.Explosion;
                        ResetArrow();
                        break;
                    }
                }
            }

            // Check for collision with the player
            foreach (var balloon in balloons)
            {
                if (balloon.Bounds.IntersectsWith(Player.Bounds))
                {
                    GameOver();
                    return;
                }
            }
        }

        void Baloon()
        {
            var tempStack = new Stack<Control>();

            while (balloons.Count > 0)
            {
                var balloon = balloons.Pop();

                if (balloon.Left < 20)
                {
                    // Balloon got past the player, game over
                    GameOver();
                    return;
                }
                else
                {
                    balloon.Left -= rnd.Next(0, 10); // Randomize speed
                }

                tempStack.Push(balloon);
            }

            // Restore balloons to the original stack
            while (tempStack.Count > 0)
            {
                balloons.Push(tempStack.Pop());
            }
        }

        void RespawnBalloon(Control balloon)
        {
            bool overlap;
            int attempts = 0;
            do
            {
                overlap = false;
                balloon.Left = 1490;
                balloon.Top = rnd.Next(50, 750);

                foreach (var otherBalloon in balloons)
                {
                    if (balloon != otherBalloon && balloon.Bounds.IntersectsWith(otherBalloon.Bounds))
                    {
                        overlap = true;
                        break;
                    }
                }

                attempts++;
                if (attempts > 10) break; // Prevent infinite loop
            } while (overlap);
        }

        void Shoot()
        {
            if (arrowActive)
            {
                Arrow.Left += 100;
                if (Arrow.Left > 1000)
                {
                    ResetArrow();
                }
            }
        }

        void ResetArrow()
        {
            arrowActive = false;
            Arrow.Visible = false; // Hide the arrow
            Arrow.Left = Player.Left;
            Arrow.Top = Player.Top + 35;
            Arrow.Image = Fuzzy__n_Friends.Properties.Resources.arrow;
        }

        void GameOver()
        {
            // Stop the game timer
            timer1.Stop();

            // Display a game-over message with restart option
            var result = MessageBox.Show("Game Over! Your final score is: " + score + "\nDo you want to restart?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {
                this.Close();
            }
        }

        void RestartGame()
        {
            // Reset score
            score = 0;
            lbl_score.Text = "Score :" + score;

            // Reset player and arrow positions
            Player.Top = 400;
            Arrow.Visible = false;
            arrowActive = false;

            // Reset balloons
            InitializeBalloons();
            foreach (var balloon in balloons)
            {
                RespawnBalloon(balloon);
            }

            // Restart timer
            timer1.Start();
        }

        private void kill_a_pest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !arrowActive)
            {
                arrowActive = true;
                Arrow.Visible = true;
                Arrow.Left = Player.Left;
                Arrow.Top = Player.Top + 35;
            }

            if (e.KeyCode == Keys.Up && Player.Top > 25)
            {
                Player.Top -= 20;
            }
            if (e.KeyCode == Keys.Down && Player.Top < 840 - Player.Height)
            {
                Player.Top += 20;
            }
        }
    }
}
