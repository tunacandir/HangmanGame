using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevIki
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        
        string[] kelimeler = {"peynir", "kıtlık", "karpuz", "poster", "makine", "elemek", "yelken", "devlet", "koltuk", "kelime"};
        Random rastgele = new Random();
        int index;
        char[] kelime;
        int yanlis = 0;
        public static int puan = 180;
        Form3 oyunSonu = new Form3();

        private void Form2_Load(object sender, EventArgs e)
        {
            
           
            index = rastgele.Next(0, 10);
            kelime = kelimeler[index].ToCharArray();
            label7.Text = Form1.isim;

            

            label1.Text = kelime[0].ToString();
            label2.Text = kelime[1].ToString();
            label3.Text = kelime[2].ToString();
            label4.Text = kelime[3].ToString();
            label5.Text = kelime[4].ToString();
            label6.Text = kelime[5].ToString();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            pictureBox1.Image = odevIki.Properties.Resources.adamAsmaca1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string harf = textBox1.Text.ToLower();
            if (label1.Text != harf && label2.Text != harf && label3.Text != harf && label4.Text != harf && label5.Text != harf && label6.Text != harf)
            {
                puan -= 30;

                yanlis++;
            }
            if (yanlis == 1)
            {
                pictureBox1.Image = odevIki.Properties.Resources.adamAsmaca2;
            }
            if (yanlis == 2)
            {
                pictureBox1.Image = odevIki.Properties.Resources.adamAsmaca3;
            }
            if (yanlis == 3)
            {
                pictureBox1.Image = odevIki.Properties.Resources.adamAsmaca4;
            }
            if (yanlis == 4)
            {
                pictureBox1.Image = odevIki.Properties.Resources.adamAsmaca5;
            }
            if (yanlis == 5)
            {
                pictureBox1.Image = odevIki.Properties.Resources.adamAsmaca6;
            }
            if (yanlis == 6)
            {
                pictureBox1.Image = odevIki.Properties.Resources.adamAsmaca7;
            }

            if (label1.Text == harf)
                label1.Show();
            if (label2.Text == harf)
                label2.Show();
            if (label3.Text == harf)
                label3.Show();
            if (label4.Text == harf)
                label4.Show();
            if (label5.Text == harf)
                label5.Show();
            if (label6.Text == harf)
                label6.Show();

            if (yanlis == 6)
            {
                oyunSonu.Show();
                this.Close();
            }
            if (label1.Visible==true && label2.Visible == true && label3.Visible == true && label4.Visible == true && label5.Visible == true && label6.Visible == true)
            {
                oyunSonu.Show();
                this.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
