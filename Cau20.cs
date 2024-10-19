using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EX01
{
    public partial class Cau20 : Form
    {
        public Cau20()
        {
            InitializeComponent();
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            dgvCustomer.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, tbGT.Checked);

        }



        private void btDelete_Click(object sender, EventArgs e)
        {
            int idx = dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows.RemoveAt(idx);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            int idx = dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows[idx].Cells[0].Value = tbId.Text;
            dgvCustomer.Rows[idx].Cells[1].Value = tbName.Text;
            dgvCustomer.Rows[idx].Cells[2].Value = tbAge.Text;
            dgvCustomer.Rows[idx].Cells[3].Value = tbGT.Checked;
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idx = e.RowIndex;

                if (dgvCustomer.Rows[idx].Cells[0].Value != null)
                {
                    tbId.Text = dgvCustomer.Rows[idx].Cells[0].Value.ToString();
                }
                else
                {
                    tbId.Text = string.Empty;
                }

                if (dgvCustomer.Rows[idx].Cells[1].Value != null)
                {
                    tbName.Text = dgvCustomer.Rows[idx].Cells[1].Value.ToString();
                }
                else
                {
                    tbName.Text = string.Empty;
                }
                if (dgvCustomer.Rows[idx].Cells[2].Value != null)
                {
                    tbAge.Text = dgvCustomer.Rows[idx].Cells[2].Value.ToString();
                }
                else
                {
                    tbAge.Text = string.Empty;
                }
                if (dgvCustomer.Rows[idx].Cells[3].Value != null)
                {
                    tbGT.Checked = bool.Parse(dgvCustomer.Rows[idx].Cells[3].Value.ToString());
                }
                else
                {
                    tbGT.Checked = false;
                }

            }
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
