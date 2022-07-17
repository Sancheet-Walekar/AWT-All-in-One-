using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApplication
{
    public partial class Form1 : Form
    {
        //create account object
        Account a1;
        Frminput f1;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblacno_Click(object sender, EventArgs e)
        {

        }

        private void lblacname_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnopen_Click(object sender, EventArgs e)
        {
            //create account object
            a1 = new Account();
            //fetch and set the values
            a1.AcNo = int.Parse(txtacno.Text);
            a1.AcName = txtname.Text;
            a1.AcBalance = double.Parse(txtbalance.Text);

            //toggle buttons
            btnopen.Enabled = false;
            btnwid.Enabled = true;
            btndep.Enabled = true;
            btnche.Enabled = true;

            txtmsg.Text += " Welcome to dena bank... "+a1.AcName;
        }

        private void btnche_Click(object sender, EventArgs e)
        {
            txtmsg.Text+=Environment.NewLine+" Account Number : "+a1.AcNo+Environment.NewLine+" Account Balance : "+a1.AcBalance;
        }

        private void btndep_Click(object sender, EventArgs e)
        {
            f1 = new Frminput();
            f1.Text = "Deposite form";
            if(f1.ShowDialog() == DialogResult.OK)
            {
                a1.Deposite(f1.Amt);
                txtmsg.Text += Environment.NewLine + " Deposite sucessfully ";
            }
            else
            {
                txtmsg.Text += Environment.NewLine + " user has cancelled the deposite process";
            }
        }
        private void btnexi_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnwid_Click(object sender, EventArgs e)
        {
            f1 = new Frminput();
            f1.Text = "Withdraw form";
            if (f1.ShowDialog() == DialogResult.OK)
            {
                if (a1.Withdraw(f1.Amt))
                     {
                    txtmsg.Text += Environment.NewLine + " Withdraw sucessfully ";
                }
            }
            else
            {
                txtmsg.Text += Environment.NewLine + " user has cancelled the Withdraw process";
            }
        }
    }
}
