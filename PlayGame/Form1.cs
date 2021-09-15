using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace PlayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SoundPlayer clickPlayer = new SoundPlayer(Properties.Resources.click);
            SoundPlayer jumpscarePlayer = new SoundPlayer(Properties.Resources.jumpscare);
            clickPlayer.Play();

            Refresh();
            Thread.Sleep(2000);

            startButton.Hide();

            Refresh();
            Thread.Sleep(1000);

            welcomeLabel1.Text = "you...";

            Refresh();
            Thread.Sleep(1000);

            welcomeLabel2.Text = "shouldn't have...";

            Refresh();
            Thread.Sleep(1000);

            welcomeLabel3.Text = "done that! >:(";

            Refresh();
            Thread.Sleep(1000);

            welcomeLabel1.Hide();

            Refresh();
            Thread.Sleep(1000);

            welcomeLabel2.Hide();

            Refresh();
            Thread.Sleep(1000);

            welcomeLabel3.Hide();

            Refresh();
            Thread.Sleep(1000);

            jumpscarePlayer.Play();
            pictureBox1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
        }
    }
}
