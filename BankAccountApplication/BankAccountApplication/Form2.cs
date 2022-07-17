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
    public partial class Frminput : Form
    {
        public Frminput()
        {
            InitializeComponent();
        }

        public double Amt
        {
            get
            {
                return double.Parse(txtamt.Text);
            }
        }

        private void lblamt_Click(object sender, EventArgs e)
        {

        }
    }
}
