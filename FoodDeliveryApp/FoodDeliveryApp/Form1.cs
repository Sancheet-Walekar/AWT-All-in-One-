using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliveryApp
{
    public partial class frmmain : Form
    {
        String[] columns = { "Name", "Rating", "Location", "Type" };
        Restaurant[] rest = new Restaurant[3];
        ListViewItem l1 = new ListViewItem();
        public frmmain()
        {
            InitializeComponent();
            rest[0] = new Lucky();
            rest[1] = new Bbqnation();
            rest[2] = new h2o();
            foreach (Restaurant r1 in rest)
            {
                imgbig.Images.Add(r1.GetPicture());
                imgsmall.Images.Add(r1.GetPicture());
            }
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            for(int i=0; i<columns.Length; i++)
            {
                lstdisplay.Columns.Add(columns[i]);
            }
            for(int i=0; i<rest.Length; i++)
            {
                l1 = new ListViewItem(rest[i].GetName());
                l1.SubItems.Add(rest[i].GetRating().ToString());
                l1.SubItems.Add(rest[i].GetLocation());
                l1.SubItems.Add(rest[i].GetRestType());
                l1.ImageIndex = i;
                lstdisplay.Items.Add(l1);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lstdisplay.View = View.LargeIcon;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lstdisplay.View = View.SmallIcon;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            lstdisplay.View = View.List;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            lstdisplay.View = View.Tile;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            lstdisplay.View = View.Details;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            lstdisplay.Items.Clear();
            for (int i = 0; i < rest.Length; i++)
            {
                if (rest[i].GetName().ToLower().Contains(txtsearch.Text.ToLower()))
                {
                    l1 = new ListViewItem(rest[i].GetName());
                    l1.SubItems.Add(rest[i].GetRating().ToString());
                    l1.SubItems.Add(rest[i].GetLocation());
                    l1.SubItems.Add(rest[i].GetRestType());
                    l1.ImageIndex = i;
                    lstdisplay.Items.Add(l1);
                }
            }
        }
    }
}
