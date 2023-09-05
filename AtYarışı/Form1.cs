using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklık, ikinciatsolauzaklık, ucuncuatsolauzaklık;

        Random rastgele = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text=derece.ToString();

            int birinciatıngenisligi = pictureBox1.Width;
            int ikiniciatıngenisligi = pictureBox2.Width;
            int ucuncuatıngenisligi = pictureBox3.Width;

            int bitisuzaklıgı = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "1 Numaralı At Yarışı Önde Götürüyor";
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "2 Numaralı At İyi Bir Atakla Öne Geçti";
            }

            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "3 Numaralı At Liderliği Ele Geçirdi";
            }





                if (birinciatıngenisligi + pictureBox1.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label6.Text="1 numaralı at yarışı kazandı!!!";
                
            }
            if(ikiniciatıngenisligi+pictureBox2.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label6.Text="2 numaralı at yarışı kazandı!!!";
      
            }
            if(ucuncuatıngenisligi+pictureBox3.Left>= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label6.Text="3 numaralı at yarışı kazandı!!!";
                
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık= pictureBox2.Left;
            ucuncuatsolauzaklık=pictureBox3.Left;


        }
    }
}
