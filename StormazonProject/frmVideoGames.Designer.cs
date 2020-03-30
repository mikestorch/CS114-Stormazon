namespace StormazonProject
{
    partial class frmVideoGames
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chkDoom = new System.Windows.Forms.CheckBox();
            this.chkMyst = new System.Windows.Forms.CheckBox();
            this.chkHalfLife = new System.Windows.Forms.CheckBox();
            this.chkRtcw = new System.Windows.Forms.CheckBox();
            this.picRtcw = new System.Windows.Forms.PictureBox();
            this.picHalfLife = new System.Windows.Forms.PictureBox();
            this.picMyst = new System.Windows.Forms.PictureBox();
            this.picDoom = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picRtcw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHalfLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMyst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(220, 452);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Click to close Video Games window!");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(38, 452);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.btnAdd, "Click to add Selection(s) to Cart!");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkDoom
            // 
            this.chkDoom.AutoSize = true;
            this.chkDoom.Location = new System.Drawing.Point(13, 27);
            this.chkDoom.Name = "chkDoom";
            this.chkDoom.Size = new System.Drawing.Size(15, 14);
            this.chkDoom.TabIndex = 16;
            this.toolTip1.SetToolTip(this.chkDoom, "Click to Select!");
            this.chkDoom.UseVisualStyleBackColor = true;
            // 
            // chkMyst
            // 
            this.chkMyst.AutoSize = true;
            this.chkMyst.Location = new System.Drawing.Point(198, 27);
            this.chkMyst.Name = "chkMyst";
            this.chkMyst.Size = new System.Drawing.Size(15, 14);
            this.chkMyst.TabIndex = 17;
            this.toolTip1.SetToolTip(this.chkMyst, "Click to Select!");
            this.chkMyst.UseVisualStyleBackColor = true;
            // 
            // chkHalfLife
            // 
            this.chkHalfLife.AutoSize = true;
            this.chkHalfLife.Location = new System.Drawing.Point(13, 238);
            this.chkHalfLife.Name = "chkHalfLife";
            this.chkHalfLife.Size = new System.Drawing.Size(15, 14);
            this.chkHalfLife.TabIndex = 18;
            this.toolTip1.SetToolTip(this.chkHalfLife, "Click to Select!");
            this.chkHalfLife.UseVisualStyleBackColor = true;
            // 
            // chkRtcw
            // 
            this.chkRtcw.AutoSize = true;
            this.chkRtcw.Location = new System.Drawing.Point(198, 238);
            this.chkRtcw.Name = "chkRtcw";
            this.chkRtcw.Size = new System.Drawing.Size(15, 14);
            this.chkRtcw.TabIndex = 19;
            this.toolTip1.SetToolTip(this.chkRtcw, "Click to Select!");
            this.chkRtcw.UseVisualStyleBackColor = true;
            // 
            // picRtcw
            // 
            this.picRtcw.Image = global::StormazonProject.Properties.Resources.RTCW;
            this.picRtcw.Location = new System.Drawing.Point(219, 238);
            this.picRtcw.Name = "picRtcw";
            this.picRtcw.Size = new System.Drawing.Size(135, 180);
            this.picRtcw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRtcw.TabIndex = 3;
            this.picRtcw.TabStop = false;
            this.toolTip1.SetToolTip(this.picRtcw, "Return to Castle Wolfenstein");
            // 
            // picHalfLife
            // 
            this.picHalfLife.Image = global::StormazonProject.Properties.Resources.HALFLIFE;
            this.picHalfLife.Location = new System.Drawing.Point(38, 238);
            this.picHalfLife.Name = "picHalfLife";
            this.picHalfLife.Size = new System.Drawing.Size(135, 180);
            this.picHalfLife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHalfLife.TabIndex = 2;
            this.picHalfLife.TabStop = false;
            this.toolTip1.SetToolTip(this.picHalfLife, "Half-Life");
            // 
            // picMyst
            // 
            this.picMyst.Image = global::StormazonProject.Properties.Resources.MYST;
            this.picMyst.Location = new System.Drawing.Point(219, 27);
            this.picMyst.Name = "picMyst";
            this.picMyst.Size = new System.Drawing.Size(135, 180);
            this.picMyst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMyst.TabIndex = 1;
            this.picMyst.TabStop = false;
            this.toolTip1.SetToolTip(this.picMyst, "Myst");
            // 
            // picDoom
            // 
            this.picDoom.Image = global::StormazonProject.Properties.Resources.DOOM;
            this.picDoom.Location = new System.Drawing.Point(38, 27);
            this.picDoom.Name = "picDoom";
            this.picDoom.Size = new System.Drawing.Size(135, 180);
            this.picDoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDoom.TabIndex = 0;
            this.picDoom.TabStop = false;
            this.toolTip1.SetToolTip(this.picDoom, "Doom");
            // 
            // frmVideoGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 504);
            this.Controls.Add(this.chkRtcw);
            this.Controls.Add(this.chkHalfLife);
            this.Controls.Add(this.chkMyst);
            this.Controls.Add(this.chkDoom);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.picRtcw);
            this.Controls.Add(this.picHalfLife);
            this.Controls.Add(this.picMyst);
            this.Controls.Add(this.picDoom);
            this.Name = "frmVideoGames";
            this.Text = "Video Games";
            ((System.ComponentModel.ISupportInitialize)(this.picRtcw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHalfLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMyst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDoom;
        private System.Windows.Forms.PictureBox picMyst;
        private System.Windows.Forms.PictureBox picHalfLife;
        private System.Windows.Forms.PictureBox picRtcw;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chkDoom;
        private System.Windows.Forms.CheckBox chkMyst;
        private System.Windows.Forms.CheckBox chkHalfLife;
        private System.Windows.Forms.CheckBox chkRtcw;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}