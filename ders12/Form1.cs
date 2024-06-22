using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ders12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        bool sağ,sol;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)

                sol = true;

            else if (e.KeyCode == Keys.Right)

                sağ = true;         
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {          
            if (e.KeyCode == Keys.Left)
            
                sol = false;
          
            else if (e.KeyCode == Keys.Right)
            
                sağ = false;
        }

        Random ras;
        int top_min = -200 , top_max = -40 ;
        int left_min1=10 , left_max1=200 , left_min2=200,left_max2=418;       
        private void Form1_Load(object sender, EventArgs e)
        {           
            ses1 = new SoundPlayer("casino.wav");
            ses2 = new SoundPlayer("gameover.wav");
            ras = new Random();                                                                           
            sol = false;                                                               
            sağ = false;
            pb_resim.Top = 442;
            pb_resim.Left = 200;

            lb_skor.Text = "SKOR:" + skor2.ToString();
            
            update_coin1();
            update_coin2();
            update_bomba();
        }
       private void update_coin2()
        {
            pb_coin2.Top = ras.Next(top_min, top_max);
            pb_coin2.Left = ras.Next(left_min2, left_max2);
        }
        private void update_bomba()
        {
            pb_bomba.Top = ras.Next(top_min, top_max);
            pb_bomba.Left = ras.Next(left_min1, left_max2);
        }
        private void update_coin1()
        {
            pb_coin1.Top = ras.Next(top_min, top_max);
            pb_coin1.Left = ras.Next(left_min1, left_max1);
        }
       
        int adım = 10;
        int adim2 = 10;
        int skor1 = 0;
        int skor2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            yenidenbaşlat();
        }

        SoundPlayer ses1;
        SoundPlayer ses2;
        private void yenidenbaşlat()
        {
           skor2 = 0;
           timer1.Enabled = true;
           panel1.Visible = false;
           lb_gameover.Visible = false;
            
            sol = false;
            sağ = false;
            pb_resim.Top = 442;
            pb_resim.Left = 200;

            lb_skor.Text = "SKOR:" + skor2.ToString();

            update_coin1();
            update_coin2();
            update_bomba();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {         
             if (sol)
            {
                if (pb_resim.Left > 10)
                    pb_resim.Left -= adım;
                else
                    pb_resim.Left = 10;
            }
             else if (sağ)
            {
                if  (pb_resim.Left < 414)
                     pb_resim.Left += adım;
                else
                    pb_resim.Left = 414;
            }
                      pb_coin1.Top += adim2;
                      pb_coin2.Top += adim2;
                      pb_bomba.Top += adim2;

            if (pb_coin1.Bounds.IntersectsWith(pb_resim.Bounds) == true) 
            {
                ses1.Play();
                update_coin1();
                skor_güncelle();
            }
            if (pb_coin2.Bounds.IntersectsWith(pb_resim.Bounds) == true) 
            {
                ses1.Play(); 
                update_coin2();
                skor_güncelle();      
            }              
            if (pb_bomba.Bounds.IntersectsWith(pb_resim.Bounds) == true) 
            
            {
                ses2.Play();
                game_over();
            } 
            if (pb_coin1.Top >= 500)
            {
                update_coin1();
            }
            if (pb_coin2.Top >= 500)
            {
                update_coin2();
            }
            if (pb_bomba.Top >= 500)
            {
                update_bomba();
            }

           lb_skor.Text = "SKOR:" + skor2.ToString();
        }
        private void game_over()
        {
          timer1.Enabled = false;
          lb_gameover.Text = "GAME OVER\n SKOR = " + skor2.ToString();
          panel1.Visible = true;
          lb_gameover.Visible = true;
          button1.Enabled = true;
        }

        int puan = 5;
        private void skor_güncelle()
        {
            skor2 += puan;
            skor1 += puan;
            if(skor1 >= 50)
            {               
                skor1 = 0;
                adim2 += 2;
            }
        }

       
    }
}
