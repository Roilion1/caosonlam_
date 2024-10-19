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
    public partial class Cau10 : Form
    {
        decimal workingMemory = 0;
        string opr = "";
        public Cau10()
        {
            InitializeComponent();
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt1.Text;
        }
        private void bt2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt2.Text;
        }
        private void bt3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt3.Text;
        }
        private void bt0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt0.Text;
        }
        private void btDecimal_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += btDecimal.Text;
        }


        private void btEquals_Click(object sender, EventArgs e)
        {
            decimal secondValue = decimal.Parse(tbDisplay.Text);
            if (opr == "+")
                tbDisplay.Text = (workingMemory + secondValue).ToString();
            if (opr == "*")
                tbDisplay.Text = (workingMemory * secondValue).ToString();
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            opr = btPlus.Text;
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            opr = btMul.Text;
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }
    }

    //public partial class Cau10 : Form
    //{
    //    decimal workingMemory = 0;
    //    string opr = "";
    //    bool isOperationPressed = false;

    //    public Cau10()
    //    {
    //        InitializeComponent();
    //    }

    //    private void bt1_Click(object sender, EventArgs e)
    //    {
    //        AppendNumber(bt1.Text);
    //    }

    //    private void bt2_Click(object sender, EventArgs e)
    //    {
    //        AppendNumber(bt2.Text);
    //    }

    //    private void bt3_Click(object sender, EventArgs e)
    //    {
    //        AppendNumber(bt3.Text);
    //    }

    //    private void bt0_Click(object sender, EventArgs e)
    //    {
    //        AppendNumber(bt0.Text);
    //    }

    //    private void btDecimal_Click(object sender, EventArgs e)
    //    {
    //        if (!tbDisplay.Text.Contains("."))
    //        {
    //            tbDisplay.Text += ".";
    //        }
    //    }

    //    private void AppendNumber(string number)
    //    {
    //        if (isOperationPressed)
    //        {
    //            tbDisplay.Clear();
    //            isOperationPressed = false;
    //        }
    //        tbDisplay.Text += number;
    //    }

    //    private void btEquals_Click(object sender, EventArgs e)
    //    {
    //        Calculate();
    //        opr = ""; // Reset operation after calculating result
    //    }

    //    private void btPlus_Click(object sender, EventArgs e)
    //    {
    //        Calculate();
    //        opr = "+";
    //        isOperationPressed = true;
    //    }

    //    private void btMul_Click(object sender, EventArgs e)
    //    {
    //        Calculate();
    //        opr = "*";
    //        isOperationPressed = true;
    //    }

    //    private void Calculate()
    //    {
    //        decimal secondValue = 0;
    //        if (!decimal.TryParse(tbDisplay.Text, out secondValue))
    //        {
    //            return;
    //        }

    //        switch (opr)
    //        {
    //            case "+":
    //                workingMemory += secondValue;
    //                break;
    //            case "*":
    //                workingMemory *= secondValue;
    //                break;
    //            default:
    //                workingMemory = secondValue;
    //                break;
    //        }

    //        tbDisplay.Text = workingMemory.ToString();
    //    }
    //}

}
