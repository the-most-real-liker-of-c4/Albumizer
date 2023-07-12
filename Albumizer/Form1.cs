using System.Collections.Immutable;
using Id3;

namespace Albumizer
{
    public partial class Form1 : Form
    {
        private string? _path = null;
        private List<MusicFile> _songList = new List<MusicFile>();
        public Form1()
        {
            InitializeComponent();



            AlbumArt.Image = new Bitmap(Albumizer.Properties.Resources.FISH);

        }

        public struct MusicFile
        {
            public string Path { get; set; }
            public string Name { get; set; }
            public string Runningtime { get; set; }
            public Mp3 SongFile { get; set; }

            public MusicFile(string path,string name,string time,Mp3? mp3Object)
            {
                Path = path;
                Name = name;
                Runningtime = time;
                
                if(mp3Object != null) SongFile = mp3Object;
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadAlbum_Click(object sender, EventArgs e)
        {
            //Load Folder
            albumFolderLoader.UseDescriptionForTitle = true;
            albumFolderLoader.Description = "Select Album Root Folder";
            if (albumFolderLoader.ShowDialog() == DialogResult.Cancel) return;
            _path = albumFolderLoader.SelectedPath;
            LoadedAlbum_Text.Text = albumFolderLoader.SelectedPath ?? "None";
            MainAlbumControls.Visible = true;
            //Load Files
            Directory.GetFiles(_path, "*.mp3");
            foreach (string file in Directory.GetFiles(_path, "*.mp3"))
            {
                Mp3 currMp3 =new Mp3(file);
                
                MessageBox.Show($@"Loading File!
 Loc:{file}
 Has Tags?:{currMp3.HasTags}
Name:{currMp3.GetAllTags().ElementAt(0).Title}
AlbumName:{currMp3.GetAllTags().ElementAt(0).Album}
");
                
                //_songList.Add(new MusicFile(file,));
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}