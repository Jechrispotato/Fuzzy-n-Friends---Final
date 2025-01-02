namespace Fuzzy__n_Friends
{
    partial class kill_a_pest
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
            this.components = new System.ComponentModel.Container();
            this.lbl_score = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Arrow = new System.Windows.Forms.PictureBox();
            this.b_3 = new System.Windows.Forms.PictureBox();
            this.b_2 = new System.Windows.Forms.PictureBox();
            this.b_1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_score.Location = new System.Drawing.Point(12, 9);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(143, 46);
            this.lbl_score.TabIndex = 0;
            this.lbl_score.Text = "Score:";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::Fuzzy__n_Friends.Properties.Resources.shoot_a_pest_character_right;
            this.Player.Location = new System.Drawing.Point(36, 411);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(357, 148);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // Arrow
            // 
            this.Arrow.BackColor = System.Drawing.Color.Transparent;
            this.Arrow.Image = global::Fuzzy__n_Friends.Properties.Resources.arrow;
            this.Arrow.Location = new System.Drawing.Point(399, 441);
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(116, 22);
            this.Arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Arrow.TabIndex = 2;
            this.Arrow.TabStop = false;
            // 
            // b_3
            // 
            this.b_3.BackColor = System.Drawing.Color.Transparent;
            this.b_3.Image = global::Fuzzy__n_Friends.Properties.Resources.shoot_a_pest_pest1;
            this.b_3.Location = new System.Drawing.Point(1217, 592);
            this.b_3.Name = "b_3";
            this.b_3.Size = new System.Drawing.Size(357, 148);
            this.b_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b_3.TabIndex = 3;
            this.b_3.TabStop = false;
            // 
            // b_2
            // 
            this.b_2.BackColor = System.Drawing.Color.Transparent;
            this.b_2.Image = global::Fuzzy__n_Friends.Properties.Resources.shoot_a_pest_pest2;
            this.b_2.Location = new System.Drawing.Point(1217, 359);
            this.b_2.Name = "b_2";
            this.b_2.Size = new System.Drawing.Size(357, 148);
            this.b_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b_2.TabIndex = 4;
            this.b_2.TabStop = false;
            // 
            // b_1
            // 
            this.b_1.BackColor = System.Drawing.Color.Transparent;
            this.b_1.Image = global::Fuzzy__n_Friends.Properties.Resources.shoot_a_pest_pest3;
            this.b_1.Location = new System.Drawing.Point(1217, 92);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(357, 148);
            this.b_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b_1.TabIndex = 5;
            this.b_1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kill_a_pest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fuzzy__n_Friends.Properties.Resources.fre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.b_1);
            this.Controls.Add(this.b_2);
            this.Controls.Add(this.b_3);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Arrow);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1388, 726);
            this.Name = "kill_a_pest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kill_a_pest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kill_a_pest_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Arrow;
        private System.Windows.Forms.PictureBox b_3;
        private System.Windows.Forms.PictureBox b_2;
        private System.Windows.Forms.PictureBox b_1;
        private System.Windows.Forms.Timer timer1;
    }
}