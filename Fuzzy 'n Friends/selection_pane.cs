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

        private void game1_Click(object sender, EventArgs e)
        {
            this.Hide();
            complete_the_word game_1 = new complete_the_word();
            game_1.ShowDialog();
        }
        private void game1_MouseHover(object sender, EventArgs e)
        {
            game1.Image = Properties.Resources.thumbnail1_hover;
        }
        private void game1_MouseLeave(object sender, EventArgs e)
        {
            game1.Image = Properties.Resources.thumbnail11;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void game2_Click(object sender, EventArgs e)
        {
            this.Hide();
            math_quiz game_2 = new math_quiz();
            game_2.ShowDialog();
        }
        private void game2_MouseHover(object sender, EventArgs e)
        {
            game2.Image = Properties.Resources.thumbnail2_hover1;
        }
        private void game2_MouseLeave(object sender, EventArgs e)
        {
            game2.Image = Properties.Resources.thumbnail21;
        }

        private void game3_Click(object sender, EventArgs e)
        {
           
        }
        private void game3_MouseHover(object sender, EventArgs e)
        {
            game3.Image = Properties.Resources.thumbnail3_hover;
        }
        private void game3_MouseLeave(object sender, EventArgs e)
        {
            game3.Image = Properties.Resources.thumbnail3;
        }

        private void game3_Click_1(object sender, EventArgs e)
        {
            kill_a_pest game_3 = new kill_a_pest(); 
            game_3.ShowDialog();
        }
    }
}
