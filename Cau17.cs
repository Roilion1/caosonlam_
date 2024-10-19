using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX01
{
    public partial class Cau17 : Form
    {
        public Cau17()
        {
            InitializeComponent();
        }
        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //int index = this.lbSong.IndexFromPoint(e.Location);
            //if (index != System.Windows.Forms.ListBox.NoMatches)
            //{
            //    string song = lbSong.SelectedItem.ToString();
            //    lbFavorite.Items.Add(song);
            //    lbSong.Items.RemoveAt(lbSong.SelectedIndex);
            //}
        }
        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //int index = this.lbFavorite.IndexFromPoint(e.Location);
            //if (index != System.Windows.Forms.ListBox.NoMatches)
            //{
            //    string song = lbFavorite.SelectedItem.ToString();
            //    lbSong.Items.Add(song);
            //    lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            //}
        }
        private void btSelect_Click(object sender, EventArgs e)
        {
            if (lbSong.SelectedItem != null)
            {
                lbFavorite.Items.Add(lbSong.SelectedItem);
                lbSong.Items.Remove(lbSong.SelectedItem);
            }
        }

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                lbSong.Items.Add(lbFavorite.SelectedItem);
                lbFavorite.Items.Remove(lbFavorite.SelectedItem);
            }
        }
        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            while (lbFavorite.Items.Count > 0)
            {
                lbSong.Items.Add(lbFavorite.Items[0]);
                lbSong.Items.RemoveAt(0);
            }
        }
        private void btDeselect_Click(object sender, EventArgs e)
        {
            while (lbSong.Items.Count > 0)
            {
                lbFavorite.Items.Add(lbSong.Items[0]);
                lbSong.Items.RemoveAt(0);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
