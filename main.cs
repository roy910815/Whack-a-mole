using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using System.Threading;
using System.Media;

namespace 打地鼠
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static System.Timers.Timer aTimer;
   //     private static System.Timers.Timer Timer2;
      
        internal void SetValue()
        {
            throw new NotImplementedException();
        }
        private int bt1,bt2,bt3,bt4,bt5, bt6, bt12,bt11,bt10 ,bt9,bt8,bt7;
        private int score1 = 0;
        private int k1,k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12,k13,k14,k15,k16,k17,k18 = 0;
        private int t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18 = 0;
        private int timeLeft;
        private int time2 = 1 ;
        private int time3 = 1;
        private int sc,sc1 = 3;        
        private void btnenable()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;
        }
      
        private void Random1()
        { 
           Random rnd1 = new Random();
            int ran = rnd1.Next(1, 13);
            if(ran == 1)
            {
                k1 = 1;
                t1 = 1;
                pictureBox1.Enabled = true;
                pictureBox1.Visible = true;
                Random mousernd = new Random();
                int mouseran = mousernd.Next(0, 3);
                if (mouseran == 0)
                {
                    pictureBox1.Image = imageList1.Images[0];
                    sc = 0;
                    bt1 = 0;
                }
                else  if (mouseran == 1)
                {
                    pictureBox1.Image = imageList1.Images[1];
                    sc = 1;
                    bt1 = 1;
                }
                else if (mouseran == 2)
                {
                    pictureBox1.Image = imageList1.Images[2];
                    sc = 2;
                    bt1 = 2;
                }
                timer2.Start();
             }
            else  if (ran == 2)
            {
                k2 = 1;
                t2 = 1;
                pictureBox2.Enabled = true;
                pictureBox2.Visible = true;
                Random mousernd = new Random();
                int mouseran = mousernd.Next(0, 3);
                if (mouseran == 0)
                {
                    pictureBox2.Image = imageList1.Images[0];
                    sc = 0;
                    bt2 = 0;
                }
                else if (mouseran == 1)
                {
                    pictureBox2.Image = imageList1.Images[1];
                    sc = 1;
                    bt2 = 1;
                }
                else if (mouseran == 2)
                {
                    pictureBox2.Image = imageList1.Images[2];
                    sc = 2;
                    bt2 = 2;
                }
                timer2.Start();
            }
            else if (ran == 3)
            {
                k3 = 1;
                t3 = 1;
                pictureBox3.Enabled = true;
                pictureBox3.Visible = true;
                Random mousernd = new Random();
                int mouseran = mousernd.Next(0, 3);
                if (mouseran == 0)
                {
                    pictureBox3.Image = imageList1.Images[0];
                    sc = 0;
                    bt3 = 0;
                }
                else if (mouseran == 1)
                {
                    pictureBox3.Image = imageList1.Images[1];
                    sc = 1;
                    bt3 = 1;
                }
                else if (mouseran == 2)
                {
                    pictureBox3.Image = imageList1.Images[2];
                    sc = 2;
                    bt3 = 2;
                }
                timer2.Start();
            }
            else if (ran == 4)
            {
                k4 = 1;
                t4 = 1;
                pictureBox4.Enabled = true;
                pictureBox4.Visible = true;
                Random mousernd = new Random();
                int mouseran = mousernd.Next(0, 3);
                if (mouseran == 0)
                {
                    pictureBox4.Image = imageList1.Images[0];
                    sc = 0;
                    bt4 = 0;
                }
                else if (mouseran == 1)
                {
                    pictureBox4.Image = imageList1.Images[1];
                    sc = 1;
                    bt4 = 1;
                }
                else if (mouseran == 2)
                {
                    pictureBox4.Image = imageList1.Images[2];
                    sc = 2;
                    bt4 = 2;
                }
                timer2.Start();
            }
            else if (ran == 5)
            {
                k5 = 1;
                t5 = 1;
                pictureBox5.Enabled = true;
                pictureBox5.Visible = true;
                Random mousernd = new Random();
                int mouseran = mousernd.Next(0, 3);
                if (mouseran == 0)
                {
                    pictureBox5.Image = imageList1.Images[0];
                    sc = 0;
                    bt5 = 0;
                }
                else if (mouseran == 1)
                {
                    pictureBox5.Image = imageList1.Images[1];
                    sc = 1;
                    bt5 = 1;
                }
                else if (mouseran == 2)
                {
                    pictureBox5.Image = imageList1.Images[2];
                    sc = 2;
                    bt5 = 2;
                }
                timer2.Start();
            }
            else if (ran == 6)
            {
                k6 = 1;
                t6 = 1;
                pictureBox6.Enabled = true;
                pictureBox6.Visible = true;
                Random mousernd = new Random();
                int mouseran = mousernd.Next(0, 3);
                if (mouseran == 0)
                {
                    pictureBox6.Image = imageList1.Images[0];
                    sc = 0;
                    bt6 = 0;
                }
                else if (mouseran == 1)
                {
                    pictureBox6.Image = imageList1.Images[1];
                    sc = 1;
                    bt6 = 1;
                }
                else if (mouseran == 2)
                {
                    pictureBox6.Image = imageList1.Images[2];
                    sc = 2;
                    bt6 = 2;
                }
                timer2.Start();
            }
            else if (ran == 7)
            {
                k7 = 1;
                t7 = 1;
                pictureBox7.Enabled = true;
                pictureBox7.Visible = true;
                Random mousernd = new Random();
                int mouseran = mousernd.Next(0, 3);
                if (mouseran == 0)
                {
                    pictureBox7.Image = imageList1.Images[0];
                    sc = 0;
                    bt7 = 0;
                }
                else if (mouseran == 1)
                {
                    pictureBox7.Image = imageList1.Images[1];
                    sc = 1;
                    bt7 = 1;
                }
                else if (mouseran == 2)
                {
                    pictureBox7.Image = imageList1.Images[2];
                    sc = 2;
                    bt7 = 2;
                }
                timer2.Start();
            }
            else if (ran == 8)
            {
                k8 = 1;
                t8 = 1;
                pictureBox8.Enabled = true;
                pictureBox8.Visible = true;
                Random mousernd = new Random();
                int mouseran = mousernd.Next(0, 3);
                if (mouseran == 0)
                {
                    pictureBox8.Image = imageList1.Images[0];
                    sc = 0;
                    bt8 = 0;
                }
                else if (mouseran == 1)
                {
                    pictureBox8.Image = imageList1.Images[1];
                    sc = 1;
                    bt8 = 1;
                }
                else if (mouseran == 2)
                {
                    pictureBox8.Image = imageList1.Images[2];
                    sc = 2;
                    bt8 = 2;
                }
           //     Timer2 = new System.Timers.Timer(1000);
                timer2.Start();
            }
            else if (ran == 9)
            {
                k9 = 1;
                t9 = 1;
                pictureBox9.Enabled = true;
                pictureBox9.Visible = true;
                Random mousernd = new Random();
                int mouseran = mousernd.Next(0, 3);
                if (mouseran == 0)
                {
                    pictureBox9.Image = imageList1.Images[0];
                    sc = 0;
                    bt9 = 0;
                }
                else if (mouseran == 1)
                {
                    pictureBox9.Image = imageList1.Images[1];
                    sc = 1;
                    bt9 = 1;
                }
                else if (mouseran == 2)
                {
                    pictureBox9.Image = imageList1.Images[2];
                    sc = 2;
                    bt9 = 2;
                }
                timer2.Start();
            }
            else if (ran == 10)
            {
                k10 = 1;
                t10 = 1;
                pictureBox10.Enabled = true;
                pictureBox10.Visible = true;
                Random mousernd = new Random();
                int mouseran = mousernd.Next(0, 3);
                if (mouseran == 0)
                {
                    pictureBox10.Image = imageList1.Images[0];
                    sc = 0;
                    bt10 = 0;
                }
                else if (mouseran == 1)
                {
                    pictureBox10.Image = imageList1.Images[1];
                    sc = 1;
                    bt10 = 1;
                }
                else if (mouseran == 2)
                {
                    pictureBox10.Image = imageList1.Images[2];
                    sc = 2;
                    bt10 = 2;
                }    
                timer2.Start();
            }
            else if (ran == 11)
            {
                k11 = 1;
                t11 = 1;
                pictureBox11.Enabled = true;
                pictureBox11.Visible = true;
                Random mousernd = new Random();
                int mouseran = mousernd.Next(0, 3);
                if (mouseran == 0)
                {
                    pictureBox11.Image = imageList1.Images[0];
                    sc = 0;
                    bt11 = 0;
                }
                else if (mouseran == 1)
                {
                    pictureBox11.Image = imageList1.Images[1];
                    sc = 1;
                    bt11= 1;
                }
                else if (mouseran == 2)
                {
                    pictureBox11.Image = imageList1.Images[2];
                    sc = 2;
                    bt11 = 2;
                }
                timer2.Start();
            }
            else if (ran == 12)
            {
                k12 = 1;
                t12 = 1;
                pictureBox12.Enabled = true;
                pictureBox12.Visible = true;
                Random mousernd = new Random();
                int mouseran = mousernd.Next(0, 3);
                if (mouseran == 0)
                {
                    pictureBox12.Image = imageList1.Images[0];
                    sc = 0;
                    bt12 = 0;
                }
                else if (mouseran == 1)
                {
                    pictureBox12.Image = imageList1.Images[1];
                    sc = 1;
                    bt12 = 1;
                }
                else if (mouseran == 2)
                {
                    pictureBox12.Image = imageList1.Images[2];
                    sc = 2;
                    bt12 = 2;
                }
                timer2.Start();
            }
        }
        private void Random2()
        {
            Random rnd2 = new Random();
            int ran = rnd2.Next(1, 7);
            if (ran == 1)
            {
                k13 = 1;
                t13 = 1;
                Random rndcolor = new Random();
                int rnd = rndcolor.Next(1, 4);
                pictureBox1.Enabled = true;
                pictureBox1.Visible = true;
                pictureBox12.Enabled = true;
                pictureBox12.Visible = true;
                if(rnd == 1)
                {
                    pictureBox1.Image = imageList1.Images[2];
                    bt1 = 2;
                    sc = 2;
                    pictureBox12.Image = imageList1.Images[0];
                    bt12=0;
                    sc1 = 0;
                }
                else if(rnd ==2)
                {
                    pictureBox1.Image = imageList1.Images[1];
                    bt1 = 1;
                    sc = 1;
                    pictureBox12.Image = imageList1.Images[0];
                    bt12 = 0;
                    sc1 = 0;
                }
                else  if (rnd == 3)
                {
                    pictureBox1.Image = imageList1.Images[1];
                    bt1 = 1;
                    sc = 1;
                    pictureBox12.Image = imageList1.Images[2];
                    bt12 = 2;
                    sc1 = 2;
                }
                timer2.Start();
            }
            else if (ran == 2)
            {
                k14 = 1;
                t14 = 1;
                pictureBox11.Enabled = true;
                pictureBox11.Visible = true;
                pictureBox3.Enabled = true;
                pictureBox3.Visible = true;
                Random rndcolor = new Random();
                int rnd = rndcolor.Next(1, 4);
                if (rnd == 1)
                {
                    pictureBox11.Image = imageList1.Images[2];
                    bt11 = 2;
                    sc = 2;
                    pictureBox3.Image = imageList1.Images[0];
                    bt3 = 0;
                    sc1 = 0;
                }
                else if (rnd == 2)
                {
                    pictureBox11.Image = imageList1.Images[1];
                    bt11 = 1;
                    sc = 1;
                    pictureBox3.Image = imageList1.Images[0];
                    bt3 = 0;
                    sc1 = 0;
                }
                else if (rnd == 3)
                {
                    pictureBox11.Image = imageList1.Images[1];
                    bt11 = 1;
                    sc = 1;
                    pictureBox3.Image = imageList1.Images[2];
                    bt3 = 2;
                    sc1 = 2;
                }
                timer2.Start();
            }
            else if (ran == 3)
            {
                k15 = 1;
                t15 = 1;
                pictureBox4.Enabled = true;
                pictureBox4.Visible = true;
                pictureBox7.Enabled = true;
                pictureBox7.Visible = true;
                Random rndcolor = new Random();
                int rnd = rndcolor.Next(1, 4);
                if (rnd == 1)
                {
                    pictureBox4.Image = imageList1.Images[2];
                    bt4 = 2;
                    sc = 2;
                    pictureBox7.Image = imageList1.Images[0];
                    bt7 = 0;
                    sc1 = 0;
                }
                else if (rnd == 2)
                {
                    pictureBox4.Image = imageList1.Images[1];
                    bt4 = 1;
                    sc = 1;
                    pictureBox7.Image = imageList1.Images[0];
                    bt7 = 0;
                    sc1 = 0;
                }
                else if (rnd == 3)
                {
                    pictureBox4.Image = imageList1.Images[1];
                    bt4 = 1;
                    sc = 1;
                    pictureBox7.Image = imageList1.Images[2];
                    bt7 = 2;
                    sc1 = 2;
                }
                timer2.Start();
            }
            if (ran == 4)
            {
                k16 = 1;
                t16 = 1;
                pictureBox10.Enabled = true;
                pictureBox10.Visible = true;
                pictureBox2.Enabled = true;
                pictureBox2.Visible = true;
                Random rndcolor = new Random();
                int rnd = rndcolor.Next(1, 4);
                if (rnd == 1)
                {
                    pictureBox10.Image = imageList1.Images[2];
                    bt10 = 2;
                    sc = 2;
                    pictureBox2.Image = imageList1.Images[0];
                    bt2 = 0;
                    sc1 = 0;
                }
                else if (rnd == 2)
                {
                    pictureBox10.Image = imageList1.Images[1];
                    bt10 = 1;
                    sc = 1;
                    pictureBox2.Image = imageList1.Images[0];
                    bt2 = 0;
                    sc1 = 0;
                }
                else if (rnd == 3)
                {
                    pictureBox10.Image = imageList1.Images[1];
                    bt10 = 1;
                    sc = 1;
                    pictureBox2.Image = imageList1.Images[2];
                    bt2 = 2;
                    sc1 = 2;
                }
                timer2.Start();
            }
            if (ran == 5)
            {
                k17 = 1;
                t17 = 1;
                pictureBox9.Enabled = true;
                pictureBox9.Visible = true;
                pictureBox8.Enabled = true;
                pictureBox8.Visible = true;
                Random rndcolor = new Random();
                int rnd = rndcolor.Next(1, 4);
                if (rnd == 1)
                {
                    pictureBox9.Image = imageList1.Images[2];
                    bt9 = 2;
                    sc = 2;
                    pictureBox8.Image = imageList1.Images[0];
                    bt8 = 0;
                    sc1 = 0;
                }
                else if (rnd == 2)
                {
                    pictureBox9.Image = imageList1.Images[1];
                    bt9 = 1;
                    sc = 1;
                    pictureBox8.Image = imageList1.Images[0];
                    bt8 = 0;
                    sc1 = 0;
                }
                else if (rnd == 3)
                {
                    pictureBox9.Image = imageList1.Images[1];
                    bt9 = 1;
                    sc = 1;
                    pictureBox8.Image = imageList1.Images[2];
                    bt8 = 2;
                    sc1 = 2;
                }
                timer2.Start();
            }
            if (ran == 6)
            {
                k18 = 1;
                t18 = 1;
                pictureBox5.Enabled = true;
                pictureBox5.Visible = true;
                pictureBox6.Enabled = true;
                pictureBox6.Visible = true;
                Random rndcolor = new Random();
                int rnd = rndcolor.Next(1, 4);
                if (rnd == 1)
                {
                    pictureBox5.Image = imageList1.Images[2];
                    bt5 = 2;
                    sc = 2;
                    pictureBox6.Image = imageList1.Images[0];
                    bt6 = 0;
                    sc1 = 0;
                }
                else if (rnd == 2)
                {
                    pictureBox5.Image = imageList1.Images[1];
                    bt5 = 1;
                    sc = 1;
                    pictureBox6.Image = imageList1.Images[0];
                    bt6 = 0;
                    sc1 = 0;
                }
                else if (rnd == 3)
                {
                    pictureBox5.Image = imageList1.Images[1];
                    bt5 = 1;
                    sc = 1;
                    pictureBox6.Image = imageList1.Images[2];
                    bt6 = 2;
                    sc1 = 2;
                }
                timer2.Start();
            }
        }
        private void score0()
        {
          //  SystemSounds hit1 ;
            SystemSounds.Exclamation.Play();
            if (sc == 0 || sc1 == 0 )
            {
                score1 = score1 + 1;
               
            }
            if (sc == 1 || sc1 == 1)
            {
                score1 = score1 - 1;
               
            }
            if (sc == 2 || sc1 == 2)
            {
                score1 = score1 + 3;              
            }
            sc = 3;
            sc1 = 3;
            score.Text = score1.ToString() ;           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            button13.Enabled = false;
            this.Cursor = new Cursor(new Bitmap(@"..\..\..\打地鼠\hammer1.png").GetHicon());
             SoundPlayer player1 = new SoundPlayer(@"..\..\..\打地鼠\Backgroundmusic.wav");
             player1.SoundLocation = @"..\..\..\打地鼠\Backgroundmusic.wav";
             player1.Load();    
             player1.PlayLooping();
          
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = new Cursor(new Bitmap(@"..\..\..\打地鼠\hammer.png").GetHicon());
        }

        private void score_Click(object sender, EventArgs e)
        {

        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(new Bitmap(@"..\..\..\打地鼠\hammer1.png").GetHicon());
        }
              
        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否要重新開始遊戲", "開始遊戲", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                score1 = 0;
                score.Text = score1.ToString();
                timer1.Stop();
                String s = Interaction.InputBox("輸入您的遊戲名稱", "玩家登入", "lily");
                name1.Text = s;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                timeLeft = 50;
                timer.Text = timeLeft + " seconds";
                timer1.Start();
             //   aTimer = new System.Timers.Timer(1000);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否要離開", "離開", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 20)
            {
                timeLeft = timeLeft - 1;
                timer.Text = timeLeft + " seconds";
                Random1();
            }
            else if (timeLeft > 0 && timeLeft <= 20)
            {
                timeLeft = timeLeft - 1;
                timer.Text = timeLeft + " seconds";
                Random2();
            }
            else
            {
                timer1.Stop(); 
                btnenable();
                string filename = @"..\..\..\打地鼠\score\" + name1.Text + ".txt";
                FileInfo saccount = new FileInfo(filename);
                StreamWriter sw;
                if (!File.Exists(filename))
                {
                    Directory.CreateDirectory(saccount.DirectoryName);
                    sw = saccount.CreateText();
                    sw.WriteLine(score.Text);
                    sw.Flush();
                    sw.Close();
                }
                else
                {
                    Directory.CreateDirectory(saccount.DirectoryName);
                    sw = saccount.AppendText();
                    sw.WriteLine(score.Text);
                    sw.Flush();
                    sw.Close();
                }
                string filenameall = @"..\..\..\打地鼠\score\score.txt";
                FileInfo fileall = new FileInfo(filenameall);
                StreamWriter swall;
                Directory.CreateDirectory(saccount.DirectoryName);
                swall = fileall.AppendText();
                swall.WriteLine(name1.Text +","+ score.Text);
                swall.Flush();
                swall.Close();
                DialogResult result = MessageBox.Show("遊戲結束", " ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
    }

        private void button14_Click(object sender, EventArgs e)
        {
            button13.Enabled = true;
            string message = "棕色地鼠加一分" + "\r\n" + "紅色地鼠扣一分" + "\r\n" + "黃色地鼠加三分"+ "\r\n" + "當兩隻地鼠同時出現時，若擊中一隻則:"+"\r\n" + "紅色地鼠和黃色地鼠加兩分" + "\r\n" + "黃色地鼠和棕色加四分"+"\r\n" + "紅色地鼠和棕色地鼠加零分"+"\r\n" ;
            string caption = "遊戲規則:";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {           
            if(time2 == 1)
            {
                if (t1 == 1)
                {
                    pictureBox1.Visible = false;
                    t1 = 0;
                }
                if (t2 == 1)
                {
                    pictureBox2.Visible = false;
                    t2 = 0;
                }
                if (t3 == 1)
                {
                    pictureBox3.Visible = false;
                    t3 = 0;
                }
                 if (t4 == 1)
                {
                    pictureBox4.Visible = false;
                    t4 = 0;
                }
                if (t5 == 1)
                {
                    pictureBox5.Visible = false;
                    t5 = 0;
                }
                if (t6 == 1)
                {
                    pictureBox6.Visible = false;
                    t6 = 0;
                }
                if (t7 == 1)
                {
                    pictureBox7.Visible = false;
                    t7 = 0;
                }
                if (t8 == 1)
                {
                    pictureBox8.Visible = false;
                    t8 = 0;
                }
                if (t9 == 1)
                {
                    pictureBox9.Visible = false;
                    t9 = 0;
                }
                 if (t10 == 1)
                {
                    pictureBox10.Visible = false;
                    t10 = 0;
                }
                 if (t11 == 1)
                {
                    pictureBox11.Visible = false;
                    t11 = 0;
                }
                if (t12 == 1)
                {
                    pictureBox12.Visible = false;
                    t12 = 0;
                }
                if (t13 == 1)
                {
                    pictureBox12.Visible = false;
                    pictureBox1.Visible = false;
                    t13 = 0;
                }
                if (t14 == 1)
                {
                    pictureBox11.Visible = false;
                    pictureBox3.Visible = false;
                    t14 = 0;
                }
                if (t15 == 1)
                {
                    pictureBox4.Visible = false;
                    pictureBox7.Visible = false;
                    t15 = 0;
                }
                if (t16 == 1)
                {
                    pictureBox10.Visible = false;
                    pictureBox2.Visible = false;
                    t16 = 0;
                }
                if (t17 == 1)
                {
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    t17 = 0;
                }
                if (t18 == 1)
                {
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                   t18 = 0;
                }
                timer2.Stop();
            }       
        }
        public void SetTextBox(string text) //實作一個公開方法，使其他Form可以傳遞資料進來
        {
            name1.Text = text;
        }
        private void history_Click(object sender, EventArgs e)
        {
            String s = Interaction.InputBox("輸入您的遊戲名稱", "玩家登入", "lily");
            name1.Text = s;
            Form2 lForm = new Form2();//例項化一個Form2視窗
            lForm.SetTextBox(name1.Text);
           // lForm.SetValue();//設定Form2中Label1的
           // this.Hide();  //關閉父視窗 (同時結束應用程式)
            lForm.Show();
         
        }
       public bool click2
       {
          set
          {
              click2 = value;
          }
       }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             pictureBox1.Enabled = false;
            if (bt1 == 0)
            {
                pictureBox1.Image = imageList2.Images[0];
                timer3.Start();
            }
            else if (bt1 == 1)
            {
                pictureBox1.Image = imageList2.Images[1];
                timer3.Start();
            }
            else if (bt1 == 2)
            {
                pictureBox1.Image = imageList2.Images[2];
                timer3.Start();
            }
            score0();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            pictureBox2.Enabled = false;
            if (bt2 == 0)
            {
                pictureBox2.Image = imageList2.Images[0];
                timer3.Start();
            }
            else if (bt2 == 1)
            {
                pictureBox2.Image = imageList2.Images[1];
                timer3.Start();
            }
            else if (bt2 == 2)
            {
                pictureBox2.Image = imageList2.Images[2];
                timer3.Start();
            }          
            score0();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
            pictureBox3.Enabled = false;
            if (bt3 == 0)
            {
                pictureBox3.Image = imageList2.Images[0];
                timer3.Start();
            }
            else if (bt3 == 1)
            {
                pictureBox3.Image = imageList2.Images[1];
                timer3.Start();
            }
            else if (bt3 == 2)
            {
                pictureBox3.Image = imageList2.Images[2];
                timer3.Start();
            }           
            score0();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
          
            pictureBox4.Enabled = false;
            if (bt4 == 0)
            {
                pictureBox4.Image = imageList2.Images[0];
                timer3.Start();
            }
            else if (bt4 == 1)
            {
                pictureBox4.Image = imageList2.Images[1];
                timer3.Start();
            }
            else if (bt4 == 2)
            {
                pictureBox4.Image = imageList2.Images[2];
                timer3.Start();
            }
          
            score0();
        }
       
        private void pictureBox5_Click(object sender, EventArgs e)
        {
             pictureBox5.Enabled = false;
            if (bt5 == 0)
            {
                pictureBox5.Image = imageList2.Images[0];
                timer3.Start();  
            }
            else if (bt5 == 1)
            {
                pictureBox5.Image = imageList2.Images[1];
                timer3.Start();
            }
            else if (bt5 == 2)
            {
                pictureBox5.Image = imageList2.Images[2];
                timer3.Start();
            }
            score0();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
            pictureBox6.Enabled = false;
            if (bt6 == 0)
            {
                pictureBox6.Image = imageList2.Images[0];
                timer3.Start();
            }
            else if (bt6 == 1)
            {
                pictureBox6.Image = imageList2.Images[1];
                timer3.Start();
            }
            else if (bt6 == 2)
            {
                pictureBox6.Image = imageList2.Images[2];
                timer3.Start();
            }       
            score0();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
            pictureBox7.Enabled = false;
            if (bt7 == 0)
            {
                pictureBox7.Image = imageList2.Images[0];
                timer3.Start();
            }
            else if (bt7 == 1)
            {
                pictureBox7.Image = imageList2.Images[1];
                timer3.Start();
            }
            else if (bt7 == 2)
            {
                pictureBox7.Image = imageList2.Images[2];
                timer3.Start();
            }            
            score0();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
            pictureBox8.Enabled = false;
            if (bt8 == 0)
            {
                pictureBox8.Image = imageList2.Images[0];
                timer3.Start();
            }
            else if (bt8 == 1)
            {
                pictureBox8.Image = imageList2.Images[1];
                timer3.Start();
            }
            else if (bt8 == 2)
            {
                pictureBox8.Image = imageList2.Images[2];
                timer3.Start();
            }         
            score0();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            
            pictureBox9.Enabled = false;
            if (bt9 == 0)
            {
                pictureBox9.Image = imageList2.Images[0];
                timer3.Start();
            }
            else if (bt9 == 1)
            {
                pictureBox9.Image = imageList2.Images[1];
                timer3.Start();
            }
            else if (bt9 == 2)
            {
                pictureBox9.Image = imageList2.Images[2];
                timer3.Start();
            }
            score0();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            
            pictureBox10.Enabled = false;
            if (bt10 == 0)
            {
                pictureBox10.Image = imageList2.Images[0];
                timer3.Start();
            }
            else if (bt10 == 1)
            {
                pictureBox10.Image = imageList2.Images[1];
                timer3.Start();
            }
            else if (bt10 == 2)
            {
                pictureBox10.Image = imageList2.Images[2];
                timer3.Start();
            }          
            score0();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            
            pictureBox11.Enabled = false;
            if (bt11 == 0)
            {
                pictureBox11.Image = imageList2.Images[0];
                timer3.Start();
            }
            else if (bt11 == 1)
            {
                pictureBox11.Image = imageList2.Images[1];
                timer3.Start();
            }
            else if (bt11 == 2)
            {
                pictureBox11.Image = imageList2.Images[2];
                timer3.Start();
            }          
            score0();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            
            pictureBox12.Enabled = false;
            if (bt12 == 0)
            {
                pictureBox12.Image = imageList2.Images[0];
                timer3.Start();
            }
            else if (bt12 == 1)
            {
                pictureBox12.Image = imageList2.Images[1];
                timer3.Start();
            }
            else if (bt12 == 2)
            {
                pictureBox12.Image = imageList2.Images[2];
                timer3.Start();
            }         
            score0();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {  
            
                if (k1 == 1)
                {
                    pictureBox1.Visible = false;
                    k1 = 0;
                    timer3.Stop();
                }
                if (k2 == 1)
                {
                    pictureBox2.Visible = false;
                    k2 = 0;
                    timer3.Stop();
                }
                if (k3 == 1)
                {
                    pictureBox3.Visible = false;
                    k3 = 0;
                    timer3.Stop();
                }
                if (k4 == 1)
                {
                    pictureBox4.Visible = false;
                    k4 = 0;
                    timer3.Stop();
                }
                if (k5 == 1)
                {
                    pictureBox5.Visible = false;
                    k5 = 0;
                    timer3.Stop();
                }
                if (k6 == 1)
                {
                    pictureBox6.Visible = false;
                    k6 = 0;
                    timer3.Stop();
                }
                if (k7 == 1)
                {
                    pictureBox7.Visible = false;
                    k7 = 0;
                    timer3.Stop();
                }
                if (k8 == 1)
                {
                    pictureBox8.Visible = false;
                    k8 = 0;
                    timer3.Stop();
                }
                if (k9 == 1)
                {
                    pictureBox9.Visible = false;
                    k9 = 0;
                    timer3.Stop();
                }
                 if (k10 == 1)
                {
                    pictureBox10.Visible = false;
                    k10 = 0;
                    timer3.Stop();
                }
                if (k11 == 1)
                {
                    pictureBox11.Visible = false;
                    k11 = 0;
                    timer3.Stop();
                }
                if (k12 == 1)
                {
                    pictureBox12.Visible = false;
                    k12 = 0;
                    timer3.Stop();
                }
                if (k13 == 1)
                {
                    pictureBox12.Visible = false;
                    pictureBox1.Visible = false;
                    k13 = 0;
                    timer3.Stop();
                }
                if (k14 == 1)
                {
                    pictureBox11.Visible = false;
                    pictureBox3.Visible = false;
                    k14 = 0;
                    timer3.Stop();
                }
                if (k15 == 1)
                {
                    pictureBox4.Visible = false;
                    pictureBox7.Visible = false;
                    k15 = 0;
                    timer3.Stop();
                }
                if (k16 == 1)
                {
                    pictureBox10.Visible = false;
                    pictureBox2.Visible = false;
                    k16 = 0;
                    timer3.Stop();
                }
                if (k17 == 1)
                {
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    k17 = 0;
                    timer3.Stop();
                }
                if (k18 == 1)
                {
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    k18 = 0;
                    timer3.Stop();
                }
            
        }
    }
}
