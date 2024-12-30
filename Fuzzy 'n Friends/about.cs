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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

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
    }
}
