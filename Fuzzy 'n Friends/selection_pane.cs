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
    public partial class selection_pane : Form
    {
        public selection_pane()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new menu();
            menu.ShowDialog();
        }

        private void back_btn_MouseHover(object sender, EventArgs e)
        {

            back_btn.Image = Properties.Resources.back_hover;
        }

        private void back_btn_MouseLeave(object sender, EventArgs e)
        {

            back_btn.Image = Properties.Resources.back;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            complete_the_word game_1 = new complete_the_word();
            game_1.ShowDialog();
        }
        private void game1_MouseHover(object sender, EventArgs e)
        {
            game1.Image = Properties.Resources.thumbnail1_design;
        }
        private void game1_MouseLeave(object sender, EventArgs e)
        {
            game1.Image = Properties.Resources.thumbnail1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
