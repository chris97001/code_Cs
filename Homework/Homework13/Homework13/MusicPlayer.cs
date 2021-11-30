using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework13
{
    class MusicPlayer:SoundPlayer
    {
        public bool Loop = false;
        public string[] Playlist;

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
        public void Play1()
        {
            if (SoundLocation == "") return;
            Load();
            if (Loop)
                PlayLooping();
            else
                Play();
        }
        public void setMusicLocation(String path)
        {
            SoundLocation = path;
        }
    }
}
