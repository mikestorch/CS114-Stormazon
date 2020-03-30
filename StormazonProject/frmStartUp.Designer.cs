namespace StormazonProject
{
    partial class frmStartUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.chkShipOrder = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.mnuCart = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblCount = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuStartUp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.productsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.videoGamesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mnuCart.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.mnuStartUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCart
            // 
            this.lstCart.ContextMenuStrip = this.mnuCart;
            this.lstCart.FormattingEnabled = true;
            this.lstCart.Location = new System.Drawing.Point(30, 69);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(283, 147);
            this.lstCart.TabIndex = 0;
            this.lstCart.SelectedIndexChanged += new System.EventHandler(this.lstCart_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(30, 226);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(283, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Selected";
            this.toolTip1.SetToolTip(this.btnRemove, "Click to Remove Selected Item\r\n");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // chkShipOrder
            // 
            this.chkShipOrder.AutoSize = true;
            this.chkShipOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShipOrder.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chkShipOrder.Location = new System.Drawing.Point(218, 319);
            this.chkShipOrder.Name = "chkShipOrder";
            this.chkShipOrder.Size = new System.Drawing.Size(209, 28);
            this.chkShipOrder.TabIndex = 2;
            this.chkShipOrder.Text = "Please ship this order";
            this.toolTip1.SetToolTip(this.chkShipOrder, "Select if you would like your order shipped. Additional charges may be added.");
            this.chkShipOrder.UseVisualStyleBackColor = true;
            this.chkShipOrder.CheckedChanged += new System.EventHandler(this.chkShipOrder_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subtotal:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(98, 277);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(38, 15);
            this.lblSubTotal.TabIndex = 4;
            this.lblSubTotal.Text = "$0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tax:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(98, 302);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(38, 15);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "$0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Shipping:";
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipping.Location = new System.Drawing.Point(98, 326);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(38, 15);
            this.lblShipping.TabIndex = 8;
            this.lblShipping.Text = "$0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(215, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(264, 285);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 18);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "$0.00";
            // 
            // mnuCart
            // 
            this.mnuCart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeSelectedToolStripMenuItem,
            this.clearCartToolStripMenuItem});
            this.mnuCart.Name = "contextMenuStrip1";
            this.mnuCart.Size = new System.Drawing.Size(165, 48);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Red;
            this.lblCount.Location = new System.Drawing.Point(168, 41);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(17, 18);
            this.lblCount.TabIndex = 14;
            this.lblCount.Text = "0";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(534, 24);
            this.mnuMain.TabIndex = 15;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllItemsToolStripMenuItem,
            this.removeItemToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearAllItemsToolStripMenuItem
            // 
            this.clearAllItemsToolStripMenuItem.Name = "clearAllItemsToolStripMenuItem";
            this.clearAllItemsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.clearAllItemsToolStripMenuItem.Text = "Clear All Items";
            this.clearAllItemsToolStripMenuItem.Click += new System.EventHandler(this.clearAllItemsToolStripMenuItem_Click);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.removeItemToolStripMenuItem.Text = "Remove Item";
            this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.removeItemToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicToolStripMenuItem,
            this.moviesToolStripMenuItem,
            this.videoGamesToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.musicToolStripMenuItem.Text = "Music";
            this.musicToolStripMenuItem.Click += new System.EventHandler(this.musicToolStripMenuItem_Click);
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.moviesToolStripMenuItem.Text = "Movies";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.moviesToolStripMenuItem_Click);
            // 
            // videoGamesToolStripMenuItem
            // 
            this.videoGamesToolStripMenuItem.Name = "videoGamesToolStripMenuItem";
            this.videoGamesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.videoGamesToolStripMenuItem.Text = "Video Games";
            this.videoGamesToolStripMenuItem.Click += new System.EventHandler(this.videoGamesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(26, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Items in Cart:";
            // 
            // mnuStartUp
            // 
            this.mnuStartUp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.mnuStartUp.Name = "mnuStartUp";
            this.mnuStartUp.Size = new System.Drawing.Size(122, 48);
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(359, 69);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(100, 126);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPreview.TabIndex = 11;
            this.picPreview.TabStop = false;
            // 
            // productsToolStripMenuItem1
            // 
            this.productsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicToolStripMenuItem1,
            this.moviesToolStripMenuItem1,
            this.videoGamesToolStripMenuItem1});
            this.productsToolStripMenuItem1.Name = "productsToolStripMenuItem1";
            this.productsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.productsToolStripMenuItem1.Text = "Products";
            // 
            // musicToolStripMenuItem1
            // 
            this.musicToolStripMenuItem1.Name = "musicToolStripMenuItem1";
            this.musicToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.musicToolStripMenuItem1.Text = "Music";
            this.musicToolStripMenuItem1.Click += new System.EventHandler(this.musicToolStripMenuItem1_Click);
            // 
            // moviesToolStripMenuItem1
            // 
            this.moviesToolStripMenuItem1.Name = "moviesToolStripMenuItem1";
            this.moviesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.moviesToolStripMenuItem1.Text = "Movies";
            this.moviesToolStripMenuItem1.Click += new System.EventHandler(this.moviesToolStripMenuItem1_Click);
            // 
            // videoGamesToolStripMenuItem1
            // 
            this.videoGamesToolStripMenuItem1.Name = "videoGamesToolStripMenuItem1";
            this.videoGamesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.videoGamesToolStripMenuItem1.Text = "Video Games";
            this.videoGamesToolStripMenuItem1.Click += new System.EventHandler(this.videoGamesToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove Selected";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedToolStripMenuItem_Click);
            // 
            // clearCartToolStripMenuItem
            // 
            this.clearCartToolStripMenuItem.Name = "clearCartToolStripMenuItem";
            this.clearCartToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.clearCartToolStripMenuItem.Text = "Clear Cart";
            this.clearCartToolStripMenuItem.Click += new System.EventHandler(this.clearCartToolStripMenuItem_Click);
            // 
            // frmStartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 369);
            this.ContextMenuStrip = this.mnuStartUp;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkShipOrder);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstCart);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmStartUp";
            this.Text = "Stormazon";
            this.mnuCart.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.mnuStartUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox chkShipOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.ContextMenuStrip mnuCart;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip mnuStartUp;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem videoGamesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCartToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

