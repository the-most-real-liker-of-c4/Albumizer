namespace Albumizer
{
    partial class Form1
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
            label1 = new Label();
            LoadedAlbum_Text = new Label();
            LoadAlbum = new Button();
            albumFolderLoader = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog();
            MainAlbumControls = new Panel();
            Mpeg3controls = new Panel();
            AlbumArt = new PictureBox();
            SongList = new ListBox();
            MainAlbumControls.SuspendLayout();
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
            MainAlbumControls.Controls.Add(SongList);
            MainAlbumControls.Controls.Add(Mpeg3controls);
            MainAlbumControls.Controls.Add(AlbumArt);
            MainAlbumControls.Location = new Point(0, 40);
            MainAlbumControls.Name = "MainAlbumControls";
            MainAlbumControls.Size = new Size(800, 410);
            MainAlbumControls.TabIndex = 3;
            MainAlbumControls.Visible = false;
            // 
            // Mpeg3controls
            // 
            Mpeg3controls.Location = new Point(575, 12);
            Mpeg3controls.Name = "Mpeg3controls";
            Mpeg3controls.Size = new Size(213, 304);
            Mpeg3controls.TabIndex = 2;
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
            // SongList
            // 
            SongList.FormattingEnabled = true;
            SongList.ItemHeight = 15;
            SongList.Location = new Point(226, 12);
            SongList.Name = "SongList";
            SongList.Size = new Size(343, 304);
            SongList.TabIndex = 3;
            SongList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainAlbumControls);
            Controls.Add(LoadAlbum);
            Controls.Add(LoadedAlbum_Text);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            MainAlbumControls.ResumeLayout(false);
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
        private Panel Mpeg3controls;
        private ListBox SongList;
    }
}