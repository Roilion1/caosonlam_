using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EX01
{
    public partial class Cau01 : Form
    {
        string path = @"D:\form1.xml";
        public Cau01()
        {
            InitializeComponent();
        }
        public void Write(InfoWindows iw) 
        {
            XmlSerializer Write = new XmlSerializer(typeof(InfoWindows));
            StreamWriter file = new StreamWriter(path);
            Write.Serialize(file, iw );
            file.Close();
        }

        private void Cau01_Load(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }

        private void Cau01_ResizeEnd(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }
    }
}
