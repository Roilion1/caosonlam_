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
    public partial class CustomerGUI : Form
    {
        CustomerBAL cusBAL = new CustomerBAL();

        public CustomerGUI()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e) 
        {
            List<CustomerBEL> lstCus = cusBAL.ReadCustomer();
            //foreach (CustomerBEL cus in lstCus)
            //{
            //    dgvCustomer.Rows.Add(cus.Id, cus.Name, cus.AreaName);
            //}
        }
    }
}
