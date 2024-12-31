using Fuzzy__n_Friends.Properties;
using NAudio.Wave;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Fuzzy__n_Friends
{
    public partial class correct : Form
    {
        private IWavePlayer waveOutDevice;   
        private AudioFileReader audioFileReader; 

        public correct()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void correct_Load(object sender, EventArgs e)
        {
            string musicPath = @"C:\Users\Jechris\source\repos\Fuzzy-n-Friends\Fuzzy 'n Friends\Resources\children_yay.wav";  // Update with your path

            if (File.Exists(musicPath))
            {
                waveOutDevice = new WaveOutEvent();

                audioFileReader = new AudioFileReader(musicPath);

                waveOutDevice.Init(audioFileReader);

                waveOutDevice.Play();
            }
            else
            {
                MessageBox.Show("Music file not found at: " + musicPath);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            waveOutDevice?.Dispose();
            audioFileReader?.Dispose();
            base.OnFormClosed(e);
        }

        private void continue_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            Form c = Application.OpenForms["complete_the_word"];
            Form d = Application.OpenForms["math_quiz"];
            if (c != null)
            { 
                c.Close();
            }
            if (d != null)
            {
                d.Close();
            }
            this.Close(); 
            menu menu = new menu();
            menu.Show();
        }

        private void quit_btn_MouseHover(object sender, EventArgs e)
        {
            quit_btn.Image = Properties.Resources.quit_hover;
        }

        private void quit_btn_MouseLeave(object sender, EventArgs e)
        {
            quit_btn.Image = Properties.Resources.quit;
        }

        private void continue_btn_MouseHover(object sender, EventArgs e)
        {
            continue_btn.Image = Properties.Resources._continue;
        }

        private void continue_btn_MouseLeave(object sender, EventArgs e)
        {
            continue_btn.Image = Properties.Resources.continue_hover;
        }
    }
}
