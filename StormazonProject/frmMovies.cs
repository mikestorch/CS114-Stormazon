using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StormazonProject
{
    public partial class frmMovies : Form
    {
        public frmMovies()
        {
            InitializeComponent();
        }


        //Exit Form Button


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Code for Add Button

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //declarations
            frmStartUp startup = (frmStartUp)this.Owner;
            String strItemName;

            //calls methods to add items to Cart after Add button clicked

            if (radPotw.Checked)
            {
                strItemName = "Phantom of the Woods";
                startup.addItem(strItemName);
                startup.updateTotals(startup.dblSubTotal);
            }
            else if (radStray.Checked)
            {
                strItemName = "The Stray";
                startup.addItem(strItemName);
                startup.updateTotals(startup.dblSubTotal);
            }
            else if (radMadeGuys.Checked)
            {
                strItemName = "Made Guys";
                startup.addItem(strItemName);
                startup.updateTotals(startup.dblSubTotal);
            }

            else if (radSchism.Checked)
            {
                strItemName = "Schism";
                startup.addItem(strItemName);
                startup.updateTotals(startup.dblSubTotal);
            }
            else
                MessageBox.Show("Nothing Selected!");

        }

    }
}
