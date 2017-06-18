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
    public partial class PracticedSong : Form
    {
        Song songPracticed;
        GuitarPracticeTrackerUI mainUI;

        public PracticedSong(Song inSong, GuitarPracticeTrackerUI inMainUI)
        {
            InitializeComponent();
            songPracticed = inSong;
            mainUI = inMainUI;
        }

        private void btnLogPractice_Click(object sender, EventArgs e)
        {
            songPracticed.DateTimeLastPracticed = DateTime.Now;
            songPracticed.Comments.Add(rtbPracticeComment.Text);
            mainUI.UpdateDgvSongList();
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
