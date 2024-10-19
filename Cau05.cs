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

namespace EX01
{
    public partial class Cau05 : Form
    {
        public Cau05()
        {
            InitializeComponent();
            this.KeyPreview = true; // Đảm bảo form có thể lắng nghe các phím
            this.KeyUp += new KeyEventHandler(Cau05_KeyUp); // Gán sự kiện KeyUp cho form
        }

        private void Cau05_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"D:\Key_Logger.txt", true);
            sw.WriteLine(e.KeyCode);
            sw.Close();
        }
    }
}
