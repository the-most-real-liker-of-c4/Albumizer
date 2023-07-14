using System;
using System.Collections.Generic;
using File = TagLib.File;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Albumizer
{

    public partial class MainWin : Form
    {
        private string? _path = null;
        private List<MusicFile> _songList = new List<MusicFile>();
        public MainWin()
        {
            InitializeComponent();



            AlbumArt.Image = new Bitmap(Albumizer.Properties.Resources.FISH);

        }

        public struct MusicFile
        {
            public string Path { get; set; }
            public string Name { get; set; }
            public TimeSpan Runningtime { get; set; }
            public TagLib.File SongFile { get; set; }

            public MusicFile(string path, string name, TimeSpan time, TagLib.File mp3Object)
            {
                Path = path;
                Name = name;
                Runningtime = time;

                SongFile = mp3Object;
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadAlbum_Click(object sender, EventArgs e)
        {
            if (SongList.Items.Count == 0)
            {
                //TODO: Load files in correct order using song index
                //Load Folder
                albumFolderLoader.UseDescriptionForTitle = true;
                albumFolderLoader.Description = "Select Album Root Folder";
                if (albumFolderLoader.ShowDialog() == DialogResult.Cancel) return;
                _path = albumFolderLoader.SelectedPath;
                LoadedAlbum_Text.Text = albumFolderLoader.SelectedPath ?? "None";
                MainAlbumControls.Visible = true;
                //Load Files
                //TODO:Load .MP3 and .mp3
                //Directory.GetFiles(_path, "*.mp3");
                foreach (string file in Directory.GetFiles(_path, "*.mp3"))
                {
                    File currMp3 = TagLib.File.Create(file);

                    //TODO: what if there are no tags??
                    // the two arrays should have the same index for a given item (eg. Splattack! - Squid Squad at index zero on both) this is a dirty trick that will help us later.
                    _songList.Add(new MusicFile(file, currMp3.Tag.Title, currMp3.Properties.Duration, currMp3));
                    SongList.Items.Add(
                        $"{currMp3.Tag.Title} : {String.Join(",", currMp3.Tag.Performers)} - part of {currMp3.Tag.Album} Track No. {currMp3.Tag.Track}");

                }

                //check for no album art before blowing up the program
                //always use the first album art of the first song (its easier that way)

                Bitmap? albumArtBitmap = null;
                if (_songList[0].SongFile.Tag.Pictures.Length == 0)
                {
                    albumArtBitmap = new Bitmap(Albumizer.Properties.Resources.Nullart);
                }
                else
                {
                    albumArtBitmap = new Bitmap(
                        new MemoryStream(_songList[0].SongFile.Tag.Pictures[0].Data.Data)
                    );
                }

                AlbumArt.Image = albumArtBitmap;

                //finally we must calculate the length of the longest element in the Song List (for scrolling)
                //Sorting algorithm (yay!!)

                string[] lengthList = new string[SongList.Items.Count];
                SongList.Items.CopyTo(lengthList, 0);
                Array.Sort(lengthList, (x, y) => x.Length.CompareTo(y.Length));
                LengthFinder.Text = lengthList[^1];
                LengthFinder.Visible = false;
                SongList.HorizontalExtent = LengthFinder.Width;
                //force select to prevent playing a null song
                SongList.SelectedIndex = 0;
                PlaySong.Visible = true;
            }
            else
            {
                AlbumArt.Image = new Bitmap(Albumizer.Properties.Resources.Nullart);
                _songList.Clear();
                SongList.Items.Clear();
                //possible LOOP!!! (shouldn't occur)
                LoadAlbum_Click(sender, e);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PlaySong_Click(object sender, EventArgs e)
        {

            Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", "\"" + _songList[SongList.SelectedIndex].Path + "\"");
        }
    }
}