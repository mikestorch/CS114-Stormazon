namespace StormazonProject
{
    partial class frmMovies
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
            this.radPotw = new System.Windows.Forms.RadioButton();
            this.radMadeGuys = new System.Windows.Forms.RadioButton();
            this.radSchism = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.radStray = new System.Windows.Forms.RadioButton();
            this.picSchism = new System.Windows.Forms.PictureBox();
            this.picMadeGuys = new System.Windows.Forms.PictureBox();
            this.picStray = new System.Windows.Forms.PictureBox();
            this.picPotw = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSchism)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMadeGuys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPotw)).BeginInit();
            this.SuspendLayout();
            // 
            // radPotw
            // 
            this.radPotw.AutoSize = true;
            this.radPotw.Location = new System.Drawing.Point(18, 27);
            this.radPotw.Name = "radPotw";
            this.radPotw.Size = new System.Drawing.Size(14, 13);
            this.radPotw.TabIndex = 5;
            this.radPotw.TabStop = true;
            this.toolTip1.SetToolTip(this.radPotw, "Click to Select!");
            this.radPotw.UseVisualStyleBackColor = true;
            // 
            // radMadeGuys
            // 
            this.radMadeGuys.AutoSize = true;
            this.radMadeGuys.Location = new System.Drawing.Point(18, 238);
            this.radMadeGuys.Name = "radMadeGuys";
            this.radMadeGuys.Size = new System.Drawing.Size(14, 13);
            this.radMadeGuys.TabIndex = 6;
            this.radMadeGuys.TabStop = true;
            this.toolTip1.SetToolTip(this.radMadeGuys, "Click to Select!");
            this.radMadeGuys.UseVisualStyleBackColor = true;
            // 
            // radSchism
            // 
            this.radSchism.AutoSize = true;
            this.radSchism.Location = new System.Drawing.Point(200, 238);
            this.radSchism.Name = "radSchism";
            this.radSchism.Size = new System.Drawing.Size(14, 13);
            this.radSchism.TabIndex = 7;
            this.radSchism.TabStop = true;
            this.toolTip1.SetToolTip(this.radSchism, "Click to Select!");
            this.radSchism.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(38, 452);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.btnAdd, "Click to add Selection to Cart!");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(220, 452);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Click to close Movies window!");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // radStray
            // 
            this.radStray.AutoSize = true;
            this.radStray.Location = new System.Drawing.Point(200, 27);
            this.radStray.Name = "radStray";
            this.radStray.Size = new System.Drawing.Size(14, 13);
            this.radStray.TabIndex = 10;
            this.radStray.TabStop = true;
            this.toolTip1.SetToolTip(this.radStray, "Click to Select!");
            this.radStray.UseVisualStyleBackColor = true;
            // 
            // picSchism
            // 
            this.picSchism.Image = global::StormazonProject.Properties.Resources.SCHISM;
            this.picSchism.Location = new System.Drawing.Point(220, 238);
            this.picSchism.Name = "picSchism";
            this.picSchism.Size = new System.Drawing.Size(135, 180);
            this.picSchism.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSchism.TabIndex = 3;
            this.picSchism.TabStop = false;
            this.toolTip1.SetToolTip(this.picSchism, "Schism");
            // 
            // picMadeGuys
            // 
            this.picMadeGuys.Image = global::StormazonProject.Properties.Resources.MADEGUYS;
            this.picMadeGuys.Location = new System.Drawing.Point(38, 238);
            this.picMadeGuys.Name = "picMadeGuys";
            this.picMadeGuys.Size = new System.Drawing.Size(135, 180);
            this.picMadeGuys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMadeGuys.TabIndex = 2;
            this.picMadeGuys.TabStop = false;
            this.toolTip1.SetToolTip(this.picMadeGuys, "Made Guys");
            // 
            // picStray
            // 
            this.picStray.Image = global::StormazonProject.Properties.Resources.STRAY;
            this.picStray.Location = new System.Drawing.Point(220, 27);
            this.picStray.Name = "picStray";
            this.picStray.Size = new System.Drawing.Size(135, 180);
            this.picStray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picStray.TabIndex = 1;
            this.picStray.TabStop = false;
            this.toolTip1.SetToolTip(this.picStray, "The Stray");
            // 
            // picPotw
            // 
            this.picPotw.Image = global::StormazonProject.Properties.Resources.POTW;
            this.picPotw.Location = new System.Drawing.Point(38, 27);
            this.picPotw.Name = "picPotw";
            this.picPotw.Size = new System.Drawing.Size(135, 180);
            this.picPotw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPotw.TabIndex = 0;
            this.picPotw.TabStop = false;
            this.toolTip1.SetToolTip(this.picPotw, "Phantom of the Woods");
            // 
            // frmMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 504);
            this.Controls.Add(this.radStray);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.radSchism);
            this.Controls.Add(this.radMadeGuys);
            this.Controls.Add(this.radPotw);
            this.Controls.Add(this.picSchism);
            this.Controls.Add(this.picMadeGuys);
            this.Controls.Add(this.picStray);
            this.Controls.Add(this.picPotw);
            this.Name = "frmMovies";
            this.Text = "Movies";
            ((System.ComponentModel.ISupportInitialize)(this.picSchism)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMadeGuys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPotw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPotw;
        private System.Windows.Forms.PictureBox picStray;
        private System.Windows.Forms.PictureBox picMadeGuys;
        private System.Windows.Forms.PictureBox picSchism;
        private System.Windows.Forms.RadioButton radPotw;
        private System.Windows.Forms.RadioButton radMadeGuys;
        private System.Windows.Forms.RadioButton radSchism;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radStray;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}