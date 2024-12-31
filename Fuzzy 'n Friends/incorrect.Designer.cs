namespace Fuzzy__n_Friends
{
    partial class incorrect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quit_btn = new System.Windows.Forms.PictureBox();
            this.try_again_btn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.quit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.try_again_btn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quit_btn
            // 
            this.quit_btn.BackColor = System.Drawing.Color.Transparent;
            this.quit_btn.Image = global::Fuzzy__n_Friends.Properties.Resources.quit;
            this.quit_btn.Location = new System.Drawing.Point(543, 108);
            this.quit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(280, 80);
            this.quit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quit_btn.TabIndex = 1;
            this.quit_btn.TabStop = false;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            this.quit_btn.MouseLeave += new System.EventHandler(this.quit_btn_MouseLeave);
            this.quit_btn.MouseHover += new System.EventHandler(this.quit_btn_MouseHover);
            // 
            // try_again_btn
            // 
            this.try_again_btn.BackColor = System.Drawing.Color.Transparent;
            this.try_again_btn.Image = global::Fuzzy__n_Friends.Properties.Resources.try_again;
            this.try_again_btn.Location = new System.Drawing.Point(530, 17);
            this.try_again_btn.Margin = new System.Windows.Forms.Padding(4);
            this.try_again_btn.Name = "try_again_btn";
            this.try_again_btn.Size = new System.Drawing.Size(305, 99);
            this.try_again_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.try_again_btn.TabIndex = 1;
            this.try_again_btn.TabStop = false;
            this.try_again_btn.Click += new System.EventHandler(this.try_again_btn_Click);
            this.try_again_btn.MouseLeave += new System.EventHandler(this.try_again_btn_MouseLeave);
            this.try_again_btn.MouseHover += new System.EventHandler(this.try_again_btn_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.try_again_btn);
            this.panel1.Controls.Add(this.quit_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 311);
            this.panel1.TabIndex = 2;
            // 
            // incorrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fuzzy__n_Friends.Properties.Resources.another_incorrect;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 718);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1352, 718);
            this.MinimumSize = new System.Drawing.Size(1352, 718);
            this.Name = "incorrect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.incorrect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.try_again_btn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox quit_btn;
        private System.Windows.Forms.PictureBox try_again_btn;
        private System.Windows.Forms.Panel panel1;
    }
}