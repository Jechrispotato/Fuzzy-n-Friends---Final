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
                // Create the wave output device (handles audio output)
                waveOutDevice = new WaveOutEvent();

                // Create an AudioFileReader (reads the MP3 file)
                audioFileReader = new AudioFileReader(musicPath);

                // Initialize the output device with the audio file reader
                waveOutDevice.Init(audioFileReader);

                // Start playing the music once
                waveOutDevice.Play();
            }
            else
            {
                // If the file does not exist, show an error message
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
            if (c != null)
            { 
                c.Close();
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
