using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework13
{
    public partial class Form1 : Form
    {
        MusicPlayer musicPlayer = new MusicPlayer();
        string[] playlist;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.OfType<RadioButton>().ToList().ForEach(rb => rb.Dispose());
            musicPlayer.Stop();
            playlist=musicPlayer.selectWavFiles();
            int iSize = 0;
            if (musicPlayer.Playlist == null) return;
            foreach(string s in musicPlayer.Playlist)
            {
                iSize++;
                RadioButton rb = new RadioButton();
                rb.CheckedChanged += rb_CheckChanged;
                rb.Text = s;
                rb.AutoSize = false;
                groupBox1.Controls.Add(rb);
                rb.SetBounds(50, 40 * iSize, 600, 30);
            }
        }
        private void rb_CheckChanged(object sender,EventArgs e)
        {
            musicPlayer.Stop();
            RadioButton rbRef = (RadioButton)sender;
            foreach(string s in playlist)
            {
                if (s == rbRef.Text)
                {
                    musicPlayer.setMusicLocation(s);
                    break;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            musicPlayer.Play1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musicPlayer.Stop();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (musicPlayer.Loop)
            {
                musicPlayer.Loop = false;
            }
            else
                musicPlayer.Loop = true;
        }
    }
}
