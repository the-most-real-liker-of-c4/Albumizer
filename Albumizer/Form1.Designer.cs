namespace Albumizer
{
    partial class MainWin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            label1 = new Label();
            LoadedAlbum_Text = new Label();
            LoadAlbum = new Button();
            albumFolderLoader = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog();
            MainAlbumControls = new Panel();
            PlaySong = new Button();
            SongList = new ListBox();
            TagControls = new Panel();
            listBox1 = new ListBox();
            AlbumArt = new PictureBox();
            LengthFinder = new Label();
            MainAlbumControls.SuspendLayout();
            TagControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AlbumArt).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Loaded Album:";
            // 
            // LoadedAlbum_Text
            // 
            LoadedAlbum_Text.AutoSize = true;
            LoadedAlbum_Text.Location = new Point(106, 9);
            LoadedAlbum_Text.Name = "LoadedAlbum_Text";
            LoadedAlbum_Text.Size = new Size(36, 15);
            LoadedAlbum_Text.TabIndex = 1;
            LoadedAlbum_Text.Text = "None";
            LoadedAlbum_Text.Click += label2_Click;
            // 
            // LoadAlbum
            // 
            LoadAlbum.Location = new Point(700, 5);
            LoadAlbum.Name = "LoadAlbum";
            LoadAlbum.Size = new Size(88, 23);
            LoadAlbum.TabIndex = 2;
            LoadAlbum.Text = "Load Album";
            LoadAlbum.UseVisualStyleBackColor = true;
            LoadAlbum.Click += LoadAlbum_Click;
            // 
            // MainAlbumControls
            // 
            MainAlbumControls.Controls.Add(PlaySong);
            MainAlbumControls.Controls.Add(SongList);
            MainAlbumControls.Controls.Add(TagControls);
            MainAlbumControls.Controls.Add(AlbumArt);
            MainAlbumControls.Location = new Point(0, 40);
            MainAlbumControls.Name = "MainAlbumControls";
            MainAlbumControls.Size = new Size(800, 410);
            MainAlbumControls.TabIndex = 3;
            MainAlbumControls.Visible = false;
            // 
            // PlaySong
            // 
            PlaySong.Location = new Point(365, 322);
            PlaySong.Name = "PlaySong";
            PlaySong.Size = new Size(130, 23);
            PlaySong.TabIndex = 5;
            PlaySong.Text = "Play that song!!1!";
            PlaySong.UseVisualStyleBackColor = true;
            PlaySong.Visible = false;
            PlaySong.Click += PlaySong_Click;
            // 
            // SongList
            // 
            SongList.FormattingEnabled = true;
            SongList.HorizontalExtent = 98;
            SongList.HorizontalScrollbar = true;
            SongList.ItemHeight = 15;
            SongList.Location = new Point(226, 12);
            SongList.MaximumSize = new Size(400, 304);
            SongList.MinimumSize = new Size(343, 304);
            SongList.Name = "SongList";
            SongList.Size = new Size(343, 304);
            SongList.TabIndex = 3;
            SongList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // TagControls
            // 
            TagControls.Controls.Add(listBox1);
            TagControls.Location = new Point(575, 12);
            TagControls.Name = "TagControls";
            TagControls.Size = new Size(213, 304);
            TagControls.TabIndex = 2;
            TagControls.Visible = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(210, 289);
            listBox1.TabIndex = 0;
            // 
            // AlbumArt
            // 
            AlbumArt.InitialImage = null;
            AlbumArt.Location = new Point(12, 12);
            AlbumArt.Name = "AlbumArt";
            AlbumArt.Size = new Size(208, 208);
            AlbumArt.SizeMode = PictureBoxSizeMode.Zoom;
            AlbumArt.TabIndex = 0;
            AlbumArt.TabStop = false;
            // 
            // LengthFinder
            // 
            LengthFinder.AutoSize = true;
            LengthFinder.Location = new Point(272, 22);
            LengthFinder.Name = "LengthFinder";
            LengthFinder.Size = new Size(0, 15);
            LengthFinder.TabIndex = 6;
            // 
            // MainWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LengthFinder);
            Controls.Add(MainAlbumControls);
            Controls.Add(LoadAlbum);
            Controls.Add(LoadedAlbum_Text);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWin";
            Text = "The Albumizer";
            MainAlbumControls.ResumeLayout(false);
            TagControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AlbumArt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LoadedAlbum_Text;
        private Button LoadAlbum;
        private Ookii.Dialogs.WinForms.VistaFolderBrowserDialog albumFolderLoader;
        private Panel MainAlbumControls;
        private PictureBox AlbumArt;
        private Panel TagControls;
        private ListBox SongList;
        private Button PlaySong;
        private ListBox listBox1;
        private Label LengthFinder;
    }
}