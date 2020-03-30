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
    public partial class frmVideoGames : Form
    {
        public frmVideoGames()
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

            if (chkDoom.Checked)
            {
                strItemName = "Doom";
                startup.addItem(strItemName);
                startup.updateTotals(startup.dblSubTotal);
            }

            if (chkMyst.Checked)
            {
                strItemName = "Myst";
                startup.addItem(strItemName);
                startup.updateTotals(startup.dblSubTotal);
            }
            if (chkHalfLife.Checked)
            {
                strItemName = "Half-Life";
                startup.addItem(strItemName);
                startup.updateTotals(startup.dblSubTotal);
            }

            if (chkRtcw.Checked)
            {
                strItemName = "Return to Castle Wolfenstein";
                startup.addItem(strItemName);
                startup.updateTotals(startup.dblSubTotal);
            }
            if (!chkDoom.Checked && !chkMyst.Checked && !chkHalfLife.Checked && !chkRtcw.Checked)
            
                MessageBox.Show("Nothing Selected!");
        }
    }
}
