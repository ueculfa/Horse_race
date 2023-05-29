using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        int birsoluzak, ikisoluzak, ucsoluzak;
         Random rastgele = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int biratgenisligi = pictureBox1.Width;
            int ikiatgenisligi = pictureBox2.Width;
            int ucatgenisligi = pictureBox3.Width;
            int bitisuzakligi = label6.Left;
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5,15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5,15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5,15);
            
            if(pictureBox1.Left >  pictureBox2.Left + 5 && pictureBox2.Left > pictureBox3.Left +5)
            {
                label7.Text = "1 Numaralı At yarışı önde götürüyor!";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label7.Text = "2 Numaralı At yarışı önde götürüyor!";
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label7.Text = "3 Numaralı At yarışı önde götürüyor!";
            }
            if (biratgenisligi + pictureBox1.Left >= bitisuzakligi)
            {
               timer1.Enabled = false;
                MessageBox.Show("1 Numaralı At Yarışı KAZANDI!!!");
            }
            if(ikiatgenisligi + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 Numaralı At Yarışı KAZANDI!!!");
            }
            if( ucatgenisligi + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 Numaralı At Yarışı KAZANDI!!!");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            birsoluzak = pictureBox1.Left;
            ikisoluzak = pictureBox2.Left;
            ucsoluzak = pictureBox3.Left;
        }
    }
}
