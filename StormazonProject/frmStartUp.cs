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
    public partial class frmStartUp : Form
    {
        public frmStartUp()
        {
            InitializeComponent();
        }

        //Declarations
        const double DBL_TAXRATE = .07;
        public double dblSubTotal = 0;



        //Button to Remove Item from List

        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeItem();

        }


        //Turn Shipping Costs On and Off

        private void chkShipOrder_CheckedChanged(object sender, EventArgs e)
        {
            updateTotals(dblSubTotal);
        }

        //Change Image When Different Item is Selected

        private void lstCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String strItem = "";
            int intSelectedIndex = lstCart.SelectedIndex;

            if (intSelectedIndex != -1)
            {
                strItem = lstCart.SelectedItem.ToString();
                if (string.Equals(strItem, "Phantom of the Woods"))
                    picPreview.Image = Properties.Resources.POTW;
                else if (string.Equals(strItem, "The Stray"))
                    picPreview.Image = Properties.Resources.STRAY;
                else if (string.Equals(strItem, "Made Guys"))
                    picPreview.Image = Properties.Resources.MADEGUYS;
                else if (string.Equals(strItem, "Schism"))
                    picPreview.Image = Properties.Resources.SCHISM;
                else
                    picPreview.Image = null;
            }

            else

                picPreview.Image = null;

        }

        //Menu Strip Options

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeItem();
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovies movies = new frmMovies();
            movies.Owner = this;
            movies.ShowDialog();
        }


        private void musicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusic music = new frmMusic();
            music.Owner = this;
            music.ShowDialog();
        }

        private void videoGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVideoGames games = new frmVideoGames();
            games.Owner = this;
            games.ShowDialog();
        }

        private void clearAllItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstCart.Items.Clear();
            picPreview.Image = null;
            updateTotals(dblSubTotal);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Owner = this;
            about.Show();
        }


        //Context Menu Code

        private void musicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMusic music = new frmMusic();
            music.Owner = this;
            music.ShowDialog();
        }

        private void moviesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMovies movies = new frmMovies();
            movies.Owner = this;
            movies.ShowDialog();
        }

        private void videoGamesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVideoGames games = new frmVideoGames();
            games.Owner = this;
            games.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeItem();
        }

        private void clearCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstCart.Items.Clear();
            picPreview.Image = null;
            updateTotals(dblSubTotal);
        }


        //Get the Price Method

        public double getPrice(String strItemName)
        {

            //declarations
            double dblItemPrice;

            // get item price
            if (strItemName == "Phantom of the Woods")
                dblItemPrice = 29.99;
            else if (strItemName == "The Stray")
                dblItemPrice = 24.99;
            else if (strItemName == "Made Guys")
                dblItemPrice = 22.99;
            else if (strItemName == "Schism")
                dblItemPrice = 20.99;
            else if (strItemName == "Doom")
                dblItemPrice = 19.99;
            else if (strItemName == "Myst")
                dblItemPrice = 14.99;
            else if (strItemName == "Half-Life")
                dblItemPrice = 12.99;
            else if (strItemName == "Return to Castle Wolfenstein")
                dblItemPrice = 10.99;
            else if (strItemName == "The Dark Side of the Moon")
                dblItemPrice = 9.99;
            else if (strItemName == "The Fragile")
                dblItemPrice = 4.99;
            else if (strItemName == "Hellbilly Deluxe")
                dblItemPrice = 2.99;
            else if (strItemName == "Atomic")
                dblItemPrice = 0.99;
            else
                dblItemPrice = 0;

            //return item price
            return dblItemPrice;

        }



        //Update Totals Method

        public void updateTotals(double dblSubTotal)
        {
            //declarations

            double dblShipping;
            double dblTax;
            double dblTotal;


            //Display Subtotal

            lblSubTotal.Text = dblSubTotal.ToString("c");

            //Calculate and Display Tax Owed

            dblTax = dblSubTotal * DBL_TAXRATE;
            lblTax.Text = dblTax.ToString("c");


            //Display Item Count

            lblCount.Text = lstCart.Items.Count.ToString("n0");


            //Calculate and Display Shipping

            if (chkShipOrder.Checked == true)
                dblShipping = getShipping(lstCart.Items.Count);
            else
                dblShipping = 0;

            lblShipping.Text = dblShipping.ToString("c");

            //Calculate and Display Total

            dblTotal = dblSubTotal + dblTax + dblShipping;
            lblTotal.Text = dblTotal.ToString("c");
        }



        //Calculate Shipping Method

        public double getShipping(int intCount)
        {
            //declarations
            double dblShipping;

            if (intCount < 1)
                dblShipping = 0;
            else if (intCount <= 3)
                dblShipping = 9;
            else if (intCount <= 6)
                dblShipping = 6;
            else
                dblShipping = 0;

            //return shipping price

            return dblShipping;
        }



        //Remove Item Method

        private void removeItem()
        {

            //call method to get price

            int intSelectedIndex = lstCart.SelectedIndex;
            double dblPrice = 0;
            String strItem = "";


            if (intSelectedIndex != -1)
            {
                strItem = lstCart.Items[intSelectedIndex].ToString();
                lstCart.SelectedIndex = intSelectedIndex - 1;
                lstCart.Items.RemoveAt(intSelectedIndex);

                dblPrice = getPrice(strItem); //call method

                //decrement total price from SubTotal

                dblSubTotal -= dblPrice;

                //Update and Display Totals


                lstCart.SelectedIndex = lstCart.Items.Count - 1;
                updateTotals(dblSubTotal);
            }
            else if (intSelectedIndex - 1 == -2)
            {
                MessageBox.Show("Nothing Selected!");
            }
            else
            {
            }

        }


        //Add Item Method

        public void addItem(String strItem)
        {

            double dblPrice = 0;

            lstCart.Items.Add(strItem);

            dblPrice = getPrice(strItem); //call method


            //decrement total price from SubTotal

            dblSubTotal += dblPrice;

            //Update and Display Totals

            lstCart.SelectedIndex = lstCart.Items.Count - 1;

            updateTotals(dblSubTotal);

        }



    }
}
