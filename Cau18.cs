using System;
using System.Collections;
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
    public partial class Cau18 : Form
    {
        public Cau18()
        {
            InitializeComponent();
        }

        private void Cau18_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            lbSong.DataSource = lst;
            lbSong.DisplayMember = "Name";
        }
        //private void btSelect_Click(object sender, EventArgs e)
        //{
        //    Song song = (Song)lbSong.SelectedItem;
        //    string id = song.Id.ToString();
        //    string name = song.Name;
        //    string author = song.Author;
        //    lbFavorite.Items.Add(id + " - " + name + " - " + author);
        //}
        private void btSelect_Click(object sender, EventArgs e)
        {
            if (lbSong.SelectedItem != null)
            {
                lbFavorite.Items.Add(lbSong.SelectedItem);
                lbSong.Items.Remove(lbSong.SelectedItem);
            }
        }
        //private void btDeselect_Click(object sender, EventArgs e)
        //{
        //    if (lbFavorite.SelectedItem != null)
        //    {
        //        lbFavorite.Items.Remove(lbFavorite.SelectedItem);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn một bài hát để bỏ chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                lbSong.Items.Add(lbFavorite.SelectedItem);
                lbFavorite.Items.Remove(lbFavorite.SelectedItem);
            }
        }
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();
            
            Song s =  new Song();
            s.Id = 53418;
            s.Name = "Giấc mơ cha pi";
            s.Author = "Trần Tiến";
            lst.Add(s);

            s = new Song();
            s.Id = 52616;
            s.Name = "Đôi mắt pleiku";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            s = new Song();
            s.Id = 51172;
            s.Name = "Em muốn sống bên anh trọn đời";
            s.Author = "Nguyễn Cường";
            lst.Add(s);
            return lst;
        }
    }
}
