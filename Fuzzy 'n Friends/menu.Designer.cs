namespace Fuzzy__n_Friends
{
    partial class menu
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
            this.play_btn = new System.Windows.Forms.PictureBox();
            this.about_btn = new System.Windows.Forms.PictureBox();
            this.exit_btn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.play_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.about_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // play_btn
            // 
            this.play_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.play_btn.BackColor = System.Drawing.Color.Transparent;
            this.play_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.play_btn.Image = global::Fuzzy__n_Friends.Properties.Resources.play;
            this.play_btn.Location = new System.Drawing.Point(1027, 15);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(522, 92);
            this.play_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.play_btn.TabIndex = 0;
            this.play_btn.TabStop = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            this.play_btn.MouseLeave += new System.EventHandler(this.play_btn_MouseLeave);
            this.play_btn.MouseHover += new System.EventHandler(this.play_btn_MouseHover);
            // 
            // about_btn
            // 
            this.about_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.about_btn.BackColor = System.Drawing.Color.Transparent;
            this.about_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.about_btn.Image = global::Fuzzy__n_Friends.Properties.Resources.about;
            this.about_btn.Location = new System.Drawing.Point(1027, 99);
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(522, 92);
            this.about_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.about_btn.TabIndex = 1;
            this.about_btn.TabStop = false;
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            this.about_btn.MouseLeave += new System.EventHandler(this.about_btn_MouseLeave);
            this.about_btn.MouseHover += new System.EventHandler(this.about_btn_MouseHover);
            // 
            // exit_btn
            // 
            this.exit_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_btn.Image = global::Fuzzy__n_Friends.Properties.Resources.exit;
            this.exit_btn.Location = new System.Drawing.Point(1027, 183);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(522, 92);
            this.exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit_btn.TabIndex = 2;
            this.exit_btn.TabStop = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            this.exit_btn.MouseLeave += new System.EventHandler(this.exit_btn_MouseLeave);
            this.exit_btn.MouseHover += new System.EventHandler(this.exit_btn_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.play_btn);
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.about_btn);
            this.panel1.Location = new System.Drawing.Point(0, 623);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1932, 309);
            this.panel1.TabIndex = 3;
            // 
            // menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = global::Fuzzy__n_Friends.Properties.Resources.main_menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1900, 945);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuzzy \'n Friends!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.play_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.about_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox play_btn;
        private System.Windows.Forms.PictureBox about_btn;
        private System.Windows.Forms.PictureBox exit_btn;
        private System.Windows.Forms.Panel panel1;
    }
}

