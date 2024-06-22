namespace ders12
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_skor = new System.Windows.Forms.Label();
            this.lb_gameover = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_coin2 = new System.Windows.Forms.PictureBox();
            this.pb_bomba = new System.Windows.Forms.PictureBox();
            this.pb_coin1 = new System.Windows.Forms.PictureBox();
            this.pb_resim = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bomba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_skor
            // 
            this.lb_skor.AutoSize = true;
            this.lb_skor.BackColor = System.Drawing.Color.Transparent;
            this.lb_skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_skor.Location = new System.Drawing.Point(347, 4);
            this.lb_skor.Name = "lb_skor";
            this.lb_skor.Size = new System.Drawing.Size(121, 31);
            this.lb_skor.TabIndex = 2;
            this.lb_skor.Text = "SKOR: 0";
            // 
            // lb_gameover
            // 
            this.lb_gameover.AutoSize = true;
            this.lb_gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_gameover.Location = new System.Drawing.Point(88, 19);
            this.lb_gameover.Name = "lb_gameover";
            this.lb_gameover.Size = new System.Drawing.Size(253, 42);
            this.lb_gameover.TabIndex = 3;
            this.lb_gameover.Text = "GAME OVER";
            this.lb_gameover.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lb_gameover);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(44, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 182);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.BackgroundImage = global::ders12.Properties.Resources._7752981_clean_cleaning_refresh_repeat_replay_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(147, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 60);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb_coin2
            // 
            this.pb_coin2.BackColor = System.Drawing.Color.Transparent;
            this.pb_coin2.BackgroundImage = global::ders12.Properties.Resources._3017875_clover_coin_day_gold_patrick_icon;
            this.pb_coin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_coin2.Location = new System.Drawing.Point(418, 53);
            this.pb_coin2.Name = "pb_coin2";
            this.pb_coin2.Size = new System.Drawing.Size(50, 50);
            this.pb_coin2.TabIndex = 1;
            this.pb_coin2.TabStop = false;
            // 
            // pb_bomba
            // 
            this.pb_bomba.BackColor = System.Drawing.Color.Transparent;
            this.pb_bomba.BackgroundImage = global::ders12.Properties.Resources._8665106_bomb_icon;
            this.pb_bomba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_bomba.Location = new System.Drawing.Point(200, 53);
            this.pb_bomba.Name = "pb_bomba";
            this.pb_bomba.Size = new System.Drawing.Size(50, 50);
            this.pb_bomba.TabIndex = 1;
            this.pb_bomba.TabStop = false;
            // 
            // pb_coin1
            // 
            this.pb_coin1.BackColor = System.Drawing.Color.Transparent;
            this.pb_coin1.BackgroundImage = global::ders12.Properties.Resources._3017875_clover_coin_day_gold_patrick_icon;
            this.pb_coin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_coin1.Location = new System.Drawing.Point(12, 53);
            this.pb_coin1.Name = "pb_coin1";
            this.pb_coin1.Size = new System.Drawing.Size(50, 50);
            this.pb_coin1.TabIndex = 1;
            this.pb_coin1.TabStop = false;
            // 
            // pb_resim
            // 
            this.pb_resim.BackColor = System.Drawing.Color.Transparent;
            this.pb_resim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_resim.BackgroundImage")));
            this.pb_resim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_resim.Location = new System.Drawing.Point(190, 443);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(49, 51);
            this.pb_resim.TabIndex = 0;
            this.pb_resim.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_skor);
            this.Controls.Add(this.pb_coin2);
            this.Controls.Add(this.pb_bomba);
            this.Controls.Add(this.pb_coin1);
            this.Controls.Add(this.pb_resim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bomba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pb_resim;
        private System.Windows.Forms.PictureBox pb_coin1;
        private System.Windows.Forms.PictureBox pb_bomba;
        private System.Windows.Forms.PictureBox pb_coin2;
        private System.Windows.Forms.Label lb_skor;
        private System.Windows.Forms.Label lb_gameover;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

