using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace visualProgrammingFinalExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {       
            button1.Text = "baslat";
        }

        int[] ai = new int[10];
        int[] kul = new int[5];

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[3];
            int rndm;

            a[0] = int.Parse(textBox1.Text);
            a[1] = int.Parse(textBox2.Text);

            if (a[0] > a[1])
            {
                MessageBox.Show("araliklari ters girmissiniz duzeltiyorum.");
                int c;

                c = a[0];
                a[0] = a[1];
                a[1] = c;
            }

            Random rnd = new Random();

            for(int i = 0; i < ai.Length; i++)
            {
            rndm:
                rndm = rnd.Next(a[0], a[1] + 1);
                
                int iof = Array.IndexOf(ai, rndm);

                if (iof == -1)
                {
                    ai[i] = rndm;
                }
                else
                {
                    goto rndm;
                }
            }

            for(int i = 0;i < kul.Length; i++)
            {
                kul[i] = int.Parse(Interaction.InputBox($"{i}. tahmininizi giriniz","Kullanici tahmin ekrani","0",500,500));
            }

            for (int i = 0; i < ai.Length; i++)
            {
                listBox1.Items.Add(ai[i]);
            }

            for ( int i = 0; i < kul.Length; i++)
            {
                listBox2.Items.Add(kul[i]);
            }
            eslestirme();
        }

        public void eslestirme()
        {
            int puan = 0;
            for(int i = 0;i<5;i++)
            {
                for (int j = 0;j < 10;j++)
                {
                    if (kul[i] == ai[j]) 
                    {
                        puan++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            if(puan == 5)
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\ayten\\OneDrive\\Masaüstü\\ABDCJSH\\C#\\Workspace\\visualProgrammingFinalExam\\music\\(Pilli Bebek) - Kızım.mp3";
                MessageBox.Show("BİZ KAVUŞTUK");
            }
            else if(puan == 0) 
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\ayten\\OneDrive\\Masaüstü\\ABDCJSH\\C#\\Workspace\\visualProgrammingFinalExam\\music\\Redd - Prensesin Uykusuyum.mp3";
                MessageBox.Show("Elbet Birgün");
            }
            else
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\ayten\\OneDrive\\Masaüstü\\ABDCJSH\\C#\\Workspace\\visualProgrammingFinalExam\\music\\Velet - Başka Ninni Yok.mp3";
                MessageBox.Show("Bir İhtimal");
            }
        }
    }
}
