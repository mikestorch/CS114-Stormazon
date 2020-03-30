namespace StormazonProject
{
    partial class frmMusic
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
            this.label1 = new System.Windows.Forms.Label();
            this.picFragile = new System.Windows.Forms.PictureBox();
            this.picDarkSide = new System.Windows.Forms.PictureBox();
            this.picAtomic = new System.Windows.Forms.PictureBox();
            this.picHellbilly = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFragile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtomic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHellbilly)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(35, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dark Side of the Moon";
            // 
            // picFragile
            // 
            this.picFragile.Image = global::StormazonProject.Properties.Resources.NIN_FRAGILE;
            this.picFragile.Location = new System.Drawing.Point(211, 82);
            this.picFragile.Name = "picFragile";
            this.picFragile.Size = new System.Drawing.Size(135, 135);
            this.picFragile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFragile.TabIndex = 10;
            this.picFragile.TabStop = false;
            this.toolTip1.SetToolTip(this.picFragile, "Click to Select and Add to Cart!");
            this.picFragile.Click += new System.EventHandler(this.picFragile_Click);
            this.picFragile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picFragile_MouseDown);
            this.picFragile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picFragile_MouseUp);
            // 
            // picDarkSide
            // 
            this.picDarkSide.Image = global::StormazonProject.Properties.Resources.PF_DARKSIDE;
            this.picDarkSide.Location = new System.Drawing.Point(43, 82);
            this.picDarkSide.Name = "picDarkSide";
            this.picDarkSide.Size = new System.Drawing.Size(135, 135);
            this.picDarkSide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDarkSide.TabIndex = 9;
            this.picDarkSide.TabStop = false;
            this.toolTip1.SetToolTip(this.picDarkSide, "Click to Select and Add to Cart!");
            this.picDarkSide.Click += new System.EventHandler(this.picDarkSide_Click);
            this.picDarkSide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDarkSide_MouseDown);
            this.picDarkSide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDarkSide_MouseUp);
            // 
            // picAtomic
            // 
            this.picAtomic.Image = global::StormazonProject.Properties.Resources.MW_ATOMIC;
            this.picAtomic.Location = new System.Drawing.Point(547, 82);
            this.picAtomic.Name = "picAtomic";
            this.picAtomic.Size = new System.Drawing.Size(135, 135);
            this.picAtomic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAtomic.TabIndex = 3;
            this.picAtomic.TabStop = false;
            this.toolTip1.SetToolTip(this.picAtomic, "Click to Select and Add to Cart!");
            this.picAtomic.Click += new System.EventHandler(this.picAtomic_Click);
            this.picAtomic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picAtomic_MouseDown);
            this.picAtomic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picAtomic_MouseUp);
            // 
            // picHellbilly
            // 
            this.picHellbilly.Image = global::StormazonProject.Properties.Resources.HD_ROBZOMBIE;
            this.picHellbilly.Location = new System.Drawing.Point(379, 82);
            this.picHellbilly.Name = "picHellbilly";
            this.picHellbilly.Size = new System.Drawing.Size(135, 135);
            this.picHellbilly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHellbilly.TabIndex = 2;
            this.picHellbilly.TabStop = false;
            this.toolTip1.SetToolTip(this.picHellbilly, "Click to Select and Add to Cart!");
            this.picHellbilly.Click += new System.EventHandler(this.picHellbilly_Click);
            this.picHellbilly.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picHellbilly_MouseDown);
            this.picHellbilly.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picHellbilly_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(578, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Click to close Music window!");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(39, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Click on Album Art to Select!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(65, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "- Pink Floyd -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(220, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "- Nine Inch Nails -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(241, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "The Fragile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(395, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "- Rob Zombie -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(392, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hellbilly Deluxe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(578, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "- Mogwai -";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(590, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Atomic";
            // 
            // frmMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 305);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picFragile);
            this.Controls.Add(this.picDarkSide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAtomic);
            this.Controls.Add(this.picHellbilly);
            this.Name = "frmMusic";
            this.Text = "Muisc";
            ((System.ComponentModel.ISupportInitialize)(this.picFragile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtomic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHellbilly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHellbilly;
        private System.Windows.Forms.PictureBox picAtomic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picDarkSide;
        private System.Windows.Forms.PictureBox picFragile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}