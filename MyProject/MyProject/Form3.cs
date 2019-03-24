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

namespace MyProject
{
    public partial class Form3 : Form
    {
        int s = 0, r = 0, p = 0, k = 0;
        System.IO.StreamReader sr = new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\intrebari_raspunsuri1.txt");
        string linie = null;
        public Form3()
        {
            InitializeComponent();
            p++;
            linie = sr.ReadLine();
            label1.Text = linie;
            linie = sr.ReadLine();
            radioButton1.Text = linie;
            linie = sr.ReadLine();
            radioButton2.Text = linie;
            linie = sr.ReadLine();
            radioButton3.Text = linie;
            linie = sr.ReadLine();
            radioButton4.Text = linie;
            linie = sr.ReadLine();
            if (linie == null)
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                MessageBox.Show(Convert.ToString(s) + " din " + Convert.ToString(p));
            } 
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*linie = sr.ReadLine();
            label1.Text = linie;
            linie = sr.ReadLine();
            radioButton1.Text = linie;
            linie = sr.ReadLine();
            radioButton2.Text = linie;
            linie = sr.ReadLine();
            radioButton3.Text = linie;
            linie = sr.ReadLine();
            radioButton4.Text = linie;
            linie = sr.ReadLine();
            if (linie == null)
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                MessageBox.Show(Convert.ToString(s) + " din " + Convert.ToString(p));
            }
             */ 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //linie = sr.ReadLine();
            r = Convert.ToInt32(linie);
            if (r == 1 && radioButton1.Checked)
            {
                s++;
                MessageBox.Show("Corect");
            }
            else
                if (r == 2 && radioButton2.Checked)
                {
                    s++;
                    MessageBox.Show("Corect");
                }
                else
                    if (r == 3 && radioButton3.Checked)
                    {
                        s++;
                        MessageBox.Show("Corect");
                    }
                    else
                        if (r == 4 && radioButton4.Checked)
                        {
                            s++;
                            MessageBox.Show("Corect");
                        }
                        else
                            MessageBox.Show("Incorect");
            p++;
            linie = sr.ReadLine();
            label1.Text = linie;
            linie = sr.ReadLine();
            radioButton1.Text = linie;
            linie = sr.ReadLine();
            radioButton2.Text = linie;
            linie = sr.ReadLine();
            radioButton3.Text = linie;
            linie = sr.ReadLine();
            radioButton4.Text = linie;
            linie = sr.ReadLine();
            if (linie == null)
            {
                this.Hide();
                MessageBox.Show(Convert.ToString(s) + " din " + Convert.ToString(p));
                this.Close();
            }
             
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
        

