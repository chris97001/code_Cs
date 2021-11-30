using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework14
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        MusicPlayer musicPlayer = new MusicPlayer();
        string[] playlist;
        Color color;
        Font font;
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicPlayer.SavePlaylist();
        }

        private void loadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.Visible = false;
            groupBox1.Controls.OfType<RadioButton>().ToList().ForEach(rb => rb.Dispose());
            musicPlayer.Stop();
            playlist = musicPlayer.LoadPlaylist();
            int iSize = -1;
            if (musicPlayer.Playlist == null) return;
            foreach(string s in musicPlayer.Playlist)
            {
                iSize++;
                RadioButton rb = new RadioButton();
                rb.Font = font;
                rb.ForeColor = color;
                rb.CheckedChanged += rb_CheckChanged;
                rb.Text = s;
                rb.AutoSize = false;
                groupBox1.Controls.Add(rb);
                rb.SetBounds(50, 10+50 * iSize, 600, 50);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!musicPlayer.Play1()) return;
            if (musicPlayer.Loop)
            {
                if(f2.Visible==false)
                    f2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2.Visible = false;
            musicPlayer.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f2.Visible = false;
            groupBox1.Controls.OfType<RadioButton>().ToList().ForEach(rb => rb.Dispose());
            musicPlayer.Stop();
            playlist=musicPlayer.selectWavFiles();
            int iSize = -1;
            if (musicPlayer.Playlist == null) return;
            foreach(string s in musicPlayer.Playlist)
            {
                iSize++;
                RadioButton rb = new RadioButton();
                rb.Font = font;
                rb.ForeColor = color;
                rb.CheckedChanged += rb_CheckChanged;
                rb.Text = s;
                rb.AutoSize = false;
                groupBox1.Controls.Add(rb);
                rb.SetBounds(50, 10+50 * iSize, 600, 50);
            }

        }
        private void rb_CheckChanged(object sender,EventArgs e)
        {
            f2.Visible = false;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (musicPlayer.Loop)
            {
                musicPlayer.Loop = false;
            }
            else
                musicPlayer.Loop = true;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                groupBox1.Controls.OfType<RadioButton>().ToList().ForEach(rb => rb.ForeColor=color);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog1.Font;
                groupBox1.Controls.OfType<RadioButton>().ToList().ForEach(rb => rb.Font=font);
            }
        }
    }
}
