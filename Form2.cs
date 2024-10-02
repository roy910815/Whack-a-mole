using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打地鼠
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Form1 form2 = new Form1();//例項化一個Form2視窗
        private Font f = new Font("標楷體", 12, FontStyle.Bold);
        private Font f1 = new Font("標楷體", 14, FontStyle.Bold);
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private string string1;
       public string String1
       {
           set
          {
              string1 = value;
           }
       }

        public  void SetTextBox(string text)
        {
            name.Font = f;
            name.Text = text;
            string filename = @"..\..\..\打地鼠\score\" + name.Text + ".txt";
        }

       
        private void normal1_Click(object sender, EventArgs e)
        {
            string filename = @"..\..\..\打地鼠\score\" + name.Text + ".txt";
            if (!File.Exists(filename))
            {
                person.Font = f1;
                person.Text = "沒有歷史紀錄";
            }
            else
            {

                StreamReader sr = new StreamReader(filename);
                string data;
                int da;

                int count = 0;
                string[] strread;
                strread = File.ReadAllLines(filename);
                int counta = 0;
                foreach (var item in strread)
                {
                    counta = counta + 1;
                }
                int[] data1 = new int[counta];
                for (int i = 0; i < counta; i++)
                {
                    data = sr.ReadLine();
                    da = int.Parse(data);
                    data1[count] = da;
                    count += 1;
                }
                sr.Close();
                Array.Sort(data1);
                Array.Reverse(data1);
                for (int i = 0; i < count; i++)
                {
                    if (i >= 10)
                    {
                        break;
                    }
                    int k = i + 1;
                    person.Font = f1;
                    person.Text += k + "." + data1[i] + "\r\n";
                }
            }
                string filename1 = @"..\..\..\打地鼠\score\score.txt";
                StreamReader sr1 = new StreamReader(filename1);
                string[] data2;
                string[] strread2;
                int count1 = 0;
                string[] name1;
                int[] score1;
                strread2 = File.ReadAllLines(filename1);
                int count2 = 0;
                foreach (var item in strread2)
                {
                    count2 = count2 + 1;
                }
                name1 = new string[count2];
                score1 = new int[count2];
                for (int i = 0; i < count2; i++)
                {
                    data2 = sr1.ReadLine().Split(',');
                    name1[count1] = data2[0];
                    score1[count1] = int.Parse(data2[1]);
                    count1 += 1;
                }
                sr1.Close();
                Array.Sort(score1, name1);
                Array.Reverse(score1);
                Array.Reverse(name1);
                rank1.Font = f1;
                rank1.Text += "名次." + "姓名" + ":" + "成績" + "\r\n";
                for (int i = 0; i < count1; i++)
                {
                    if (i >= 10)
                    {
                        break;
                    }
                    rank1.Font = f1;
                    int k = i + 1;
                    rank1.Text += k + ". " + name1[i] + ":" + score1[i] + "\r\n";

                }
                normal1.Enabled = false;
            
        }
          

     private void button2_Click(object sender, EventArgs e)
     {
           this.Close();
     }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
