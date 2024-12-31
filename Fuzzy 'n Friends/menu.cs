using NAudio.Wave;
using System;
using System.IO;
using System.Windows.Forms;

namespace Fuzzy__n_Friends
{
    public partial class menu : Form
    {
        private static IWavePlayer waveOutDevice;
        private static AudioFileReader audioFileReader;
        private static bool isMusicPlaying;

        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            PlayMusicIfNeeded();
        }

        private void PlayMusicIfNeeded()
        {
            if (isMusicPlaying) return;

            string musicPath = @"C:\Users\Jechris\source\repos\Fuzzy-n-Friends\Fuzzy 'n Friends\Resources\lobby_music.wav";

            if (File.Exists(musicPath))
            {
                isMusicPlaying = true;
                waveOutDevice = new WaveOutEvent();
                audioFileReader = new AudioFileReader(musicPath);
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopMusic();
            base.OnFormClosing(e);
        }

        private void StopMusic()
        {
            if (isMusicPlaying)
            {
                waveOutDevice.Stop();
                waveOutDevice.Dispose();
                audioFileReader.Dispose();
                isMusicPlaying = false;
            }
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form selection_pane = new selection_pane();
            selection_pane.ShowDialog();
        }

        private void play_btn_MouseHover(object sender, EventArgs e)
        {
            play_btn.Image = Properties.Resources.play_hover;
        }

        private void play_btn_MouseLeave(object sender, EventArgs e)
        {
            play_btn.Image = Properties.Resources.play;
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form about_us = new about();
            about_us.ShowDialog();
        }

        private void about_btn_MouseHover(object sender, EventArgs e)
        {
            about_btn.Image = Properties.Resources.about_hover;
        }

        private void about_btn_MouseLeave(object sender, EventArgs e)
        {
            about_btn.Image = Properties.Resources.about;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_btn_MouseHover(object sender, EventArgs e)
        {
            exit_btn.Image = Properties.Resources.exit_hover;
        }

        private void exit_btn_MouseLeave(object sender, EventArgs e)
        {
            exit_btn.Image = Properties.Resources.exit;
        }
    }
}
