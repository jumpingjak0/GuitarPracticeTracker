using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GuitarPracticeTrackerEngine;

namespace UI
{
    public partial class DeleteSong : Form
    {
        Song songToDelete;
        public DeleteSong(Song inSong)
        {
            InitializeComponent();
            songToDelete = inSong;
            rtbDeleteSongWarning.Text = "Are you sure you want to permanently delete " + songToDelete.Name + "?";
        }

        private void btnKeepSong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            SongList.DeleteSong(songToDelete);
            this.Close();
        }
    }
}
