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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
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
