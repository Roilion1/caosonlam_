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
    public partial class Cau02 : Form
    {
        string path = @"D:\form.xml";

        public Cau02()
        {
            InitializeComponent();
        }
        public void Write(InfoWindows iw)
        {
            XmlSerializer writre = new XmlSerializer(typeof(InfoWindows));
            StreamWriter file = new StreamWriter(path);
            writre.Serialize(file, iw);
            file.Close();
        }
        //public InfoWindows Read()
        //{
        //    if (!File.Exists(path))
        //    {
        //        return null;
        //    }

        //    XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
        //    using (StreamReader file = new StreamReader(path)) // Use StreamReader for reading
        //    {
        //        return (InfoWindows)reader.Deserialize(file);
        //    }
        //}

        public InfoWindows Read()
        {
            XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
            StreamReader file = new StreamReader(path);
            InfoWindows iw = (InfoWindows)reader.Deserialize(file);
            file.Close();
            return iw;
        }

        private void Cau2_Load(object sender, System.EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw = Read();
            if(iw==null)
            {
                iw = new InfoWindows();
                Width = iw.Width;
                Height = iw.Height;
            }
            this.Width = iw.Width;
            this.Height = iw.Height;
        }

        private void Cau2_ResizeEnd(object sender, System.EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }
    }
}
