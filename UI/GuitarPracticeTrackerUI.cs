using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class GuitarPracticeTrackerUI : Form
    {
        public GuitarPracticeTrackerUI()
        {
            InitializeComponent();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            AddSongUI addSong = new AddSongUI();
            addSong.Show();
        }
    }
}
