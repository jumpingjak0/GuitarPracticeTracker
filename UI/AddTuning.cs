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
    public partial class AddTuning : Form
    {
        public AddTuning()
        {
            InitializeComponent();
        }

        private void btnAddTuning_Click(object sender, EventArgs e)
        {
            if(Tunings.AddTuning(tbTuningName.Text))
            {
                MessageBox.Show("Tuning Added");
            }
            else
            {
                MessageBox.Show("Tuning Already Present");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
