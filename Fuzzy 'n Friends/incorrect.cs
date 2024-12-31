using NAudio.Wave;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Fuzzy__n_Friends
{
    public partial class incorrect : Form
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;
        private string musicPath = @"C:\Users\Jechris\source\repos\Fuzzy-n-Friends\Fuzzy 'n Friends\Resources\boing.wav";

        public incorrect()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void incorrect_Load(object sender, EventArgs e)
        {
            PlayMusic();
        }

        private void PlayMusic()
        {
            if (File.Exists(musicPath))
            {
                try
                {
                    waveOutDevice = new WaveOutEvent();
                    audioFileReader = new AudioFileReader(musicPath);
                    waveOutDevice.Init(audioFileReader);
                    waveOutDevice.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error playing music: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show($"Music file not found at: {musicPath}");
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            DisposeMusic();
            base.OnFormClosed(e);
        }

        private void DisposeMusic()
        {
            waveOutDevice?.Stop();
            waveOutDevice?.Dispose();
            audioFileReader?.Dispose();
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            Form c = Application.OpenForms["complete_the_word"];
            Form d = Application.OpenForms["math_quiz"];
            if (c != null)
            {
                c.Close();
            }
            else if (d != null)
            {
                d.Close();
            }
            this.Close();
            menu menu = new menu();
            menu.Show();
        }

        private void try_again_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void try_again_btn_MouseHover(object sender, EventArgs e)
        {
            try_again_btn.Image = Properties.Resources.try_again_hover;
        }

        private void try_again_btn_MouseLeave(object sender, EventArgs e)
        {
            try_again_btn.Image = Properties.Resources.try_again;
        }

        private void quit_btn_MouseHover(object sender, EventArgs e)
        {
            quit_btn.Image = Properties.Resources.quit_hover;
        }

        private void quit_btn_MouseLeave(object sender, EventArgs e)
        {
            quit_btn.Image = Properties.Resources.quit;
        }
    }
}
