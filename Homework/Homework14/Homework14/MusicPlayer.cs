using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework14
{
    class MusicPlayer:SoundPlayer
    {
        public bool Loop = false;
        public string[] Playlist=null;

        public string[] selectWavFiles()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "WAV(*.wav)|*.wav";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Playlist = openFileDialog.FileNames;
            }
            return Playlist;
        }
        public bool Play1()
        {
            if (SoundLocation == "") return false;
            Load();
            if (Loop)
                PlayLooping();
            else
                Play();
            return true;
        }
        public void setMusicLocation(String path)
        {
            SoundLocation = path;
        }
        public void SavePlaylist()
        {
            if (Playlist == null)
            {
                MessageBox.Show("請先建立撥放清單", "", MessageBoxButtons.OK);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName)) 
                {
                    foreach(string s in Playlist)
                    {
                        sw.WriteLine(s);
                    }
                }
            }
        }
        public string[] LoadPlaylist()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                List<string> slist = new List<string>();
                string line;
                line = sr.ReadLine();
                while (line != null)
                {
                    slist.Add(line.Trim());
                    line = sr.ReadLine();
                }
                Playlist = slist.ToArray();
            }
            return Playlist;
        }
    }
}
