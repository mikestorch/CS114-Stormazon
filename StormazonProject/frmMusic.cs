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
    public partial class frmMusic : Form
    {
        public frmMusic()
        {
            InitializeComponent();
        }

        //declarations

        String strItemName;

        
        //Exit Form Button

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        //Button Code for Clicking on Pictures to Add to Cart

        private void picDarkSide_Click(object sender, EventArgs e)
        {
            frmStartUp startup = (frmStartUp)this.Owner;

            strItemName = "The Dark Side of the Moon";
            startup.addItem(strItemName);
            startup.updateTotals(startup.dblSubTotal);
        }


        private void picFragile_Click(object sender, EventArgs e)
        {
            frmStartUp startup = (frmStartUp)this.Owner;

            strItemName = "The Fragile";
            startup.addItem(strItemName);
            startup.updateTotals(startup.dblSubTotal);
        }

        private void picHellbilly_Click(object sender, EventArgs e)
        {
            frmStartUp startup = (frmStartUp)this.Owner;

            strItemName = "Hellbilly Deluxe";
            startup.addItem(strItemName);
            startup.updateTotals(startup.dblSubTotal);
        }

        private void picAtomic_Click(object sender, EventArgs e)
        {
            frmStartUp startup = (frmStartUp)this.Owner;

            strItemName = "Atomic";
            startup.addItem(strItemName);
            startup.updateTotals(startup.dblSubTotal);
        }

        //Button Animation Code

        private void picDarkSide_MouseDown(object sender, MouseEventArgs e)
        {
            picDarkSide.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picDarkSide_MouseUp(object sender, MouseEventArgs e)
        {
            picDarkSide.BorderStyle = BorderStyle.None;
        }

        private void picFragile_MouseDown(object sender, MouseEventArgs e)
        {
            picFragile.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picFragile_MouseUp(object sender, MouseEventArgs e)
        {
            picFragile.BorderStyle = BorderStyle.None;
        }

        private void picHellbilly_MouseDown(object sender, MouseEventArgs e)
        {
            picHellbilly.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picHellbilly_MouseUp(object sender, MouseEventArgs e)
        {
            picHellbilly.BorderStyle = BorderStyle.None;
        }

        private void picAtomic_MouseDown(object sender, MouseEventArgs e)
        {
            picAtomic.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picAtomic_MouseUp(object sender, MouseEventArgs e)
        {
            picAtomic.BorderStyle = BorderStyle.None;
        }


    }
}
