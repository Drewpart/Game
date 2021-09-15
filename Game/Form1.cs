using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Game
{
    public partial class Warzone : Form
    {
        public Warzone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources._523763__matrixxx__select_granted_06);
            start.Hide();
            pressPlay.Hide();
            player.Play();

            Refresh();
            play.ForeColor = Color.Red;
            Thread.Sleep(1000);
            player.Play();
            play.Text = " Game Starts In 3...";
           
            
            Refresh();
            Thread.Sleep(1000);
            player.Play();
            play.Text = " 2...";
            
            Refresh();
            Thread.Sleep(1000);
            player.Play();
            play.Text = "1";
            
            Refresh();
            Thread.Sleep(1000);
            play.Text = "Start";

            BackColor = Color.Green;
            play.ForeColor = Color.White;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
