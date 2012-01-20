namespace AppLauncher
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFullDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.launcherMenuButton22 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton19 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton6 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton20 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton21 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton23 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton13 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton24 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton16 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton15 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton14 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton17 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton7 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton18 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton10 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton8 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton9 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton11 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton12 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton5 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton4 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton1 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton3 = new Keypad.LauncherMenuButton();
            this.launcherMenuButton2 = new Keypad.LauncherMenuButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editEntryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // editEntryToolStripMenuItem
            // 
            this.editEntryToolStripMenuItem.Name = "editEntryToolStripMenuItem";
            this.editEntryToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.editEntryToolStripMenuItem.Text = "Edit Entry";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitle.Location = new System.Drawing.Point(207, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 26);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Application Launcher";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(3, 3);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(89, 13);
            this.lblVersion.TabIndex = 33;
            this.lblVersion.Text = "Windows Version";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Yellow;
            this.lblInstructions.Location = new System.Drawing.Point(83, 73);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(508, 24);
            this.lblInstructions.TabIndex = 34;
            this.lblInstructions.Text = "Click button to launch application, Right Click to edit options.";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFullDate
            // 
            this.lblFullDate.AutoSize = true;
            this.lblFullDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullDate.ForeColor = System.Drawing.Color.Yellow;
            this.lblFullDate.Location = new System.Drawing.Point(19, 431);
            this.lblFullDate.Name = "lblFullDate";
            this.lblFullDate.Size = new System.Drawing.Size(96, 24);
            this.lblFullDate.TabIndex = 37;
            this.lblFullDate.Text = "Date Time";
            this.lblFullDate.Click += new System.EventHandler(this.lblFullDate_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(15, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 100);
            this.panel1.TabIndex = 40;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(606, 434);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 65;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppLauncher.Properties.Resources.arrow_left;
            this.pictureBox1.Location = new System.Drawing.Point(279, 431);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 38);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppLauncher.Properties.Resources.arrow_right;
            this.pictureBox2.Location = new System.Drawing.Point(400, 431);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 36);
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.ForeColor = System.Drawing.Color.White;
            this.lblPage.Location = new System.Drawing.Point(320, 439);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(62, 13);
            this.lblPage.TabIndex = 68;
            this.lblPage.Text = "Page 1 of 1";
            // 
            // launcherMenuButton22
            // 
            this.launcherMenuButton22.buttons = 0;
            this.launcherMenuButton22.Location = new System.Drawing.Point(0, 235);
            this.launcherMenuButton22.Name = "launcherMenuButton22";
            this.launcherMenuButton22.Size = new System.Drawing.Size(106, 75);
            this.launcherMenuButton22.TabIndex = 59;
            // 
            // launcherMenuButton19
            // 
            this.launcherMenuButton19.buttons = 0;
            this.launcherMenuButton19.Location = new System.Drawing.Point(567, 235);
            this.launcherMenuButton19.Name = "launcherMenuButton19";
            this.launcherMenuButton19.Size = new System.Drawing.Size(108, 75);
            this.launcherMenuButton19.TabIndex = 64;
            // 
            // launcherMenuButton6
            // 
            this.launcherMenuButton6.buttons = 0;
            this.launcherMenuButton6.Location = new System.Drawing.Point(567, 13);
            this.launcherMenuButton6.Name = "launcherMenuButton6";
            this.launcherMenuButton6.Size = new System.Drawing.Size(108, 78);
            this.launcherMenuButton6.TabIndex = 46;
            // 
            // launcherMenuButton20
            // 
            this.launcherMenuButton20.buttons = 0;
            this.launcherMenuButton20.Location = new System.Drawing.Point(453, 235);
            this.launcherMenuButton20.Name = "launcherMenuButton20";
            this.launcherMenuButton20.Size = new System.Drawing.Size(108, 75);
            this.launcherMenuButton20.TabIndex = 63;
            // 
            // launcherMenuButton21
            // 
            this.launcherMenuButton21.buttons = 0;
            this.launcherMenuButton21.Location = new System.Drawing.Point(339, 235);
            this.launcherMenuButton21.Name = "launcherMenuButton21";
            this.launcherMenuButton21.Size = new System.Drawing.Size(108, 75);
            this.launcherMenuButton21.TabIndex = 62;
            // 
            // launcherMenuButton23
            // 
            this.launcherMenuButton23.buttons = 0;
            this.launcherMenuButton23.Location = new System.Drawing.Point(225, 235);
            this.launcherMenuButton23.Name = "launcherMenuButton23";
            this.launcherMenuButton23.Size = new System.Drawing.Size(108, 75);
            this.launcherMenuButton23.TabIndex = 61;
            // 
            // launcherMenuButton13
            // 
            this.launcherMenuButton13.buttons = 0;
            this.launcherMenuButton13.Location = new System.Drawing.Point(567, 160);
            this.launcherMenuButton13.Name = "launcherMenuButton13";
            this.launcherMenuButton13.Size = new System.Drawing.Size(108, 79);
            this.launcherMenuButton13.TabIndex = 58;
            // 
            // launcherMenuButton24
            // 
            this.launcherMenuButton24.buttons = 0;
            this.launcherMenuButton24.Location = new System.Drawing.Point(112, 235);
            this.launcherMenuButton24.Name = "launcherMenuButton24";
            this.launcherMenuButton24.Size = new System.Drawing.Size(107, 75);
            this.launcherMenuButton24.TabIndex = 60;
            // 
            // launcherMenuButton16
            // 
            this.launcherMenuButton16.buttons = 0;
            this.launcherMenuButton16.Location = new System.Drawing.Point(0, 160);
            this.launcherMenuButton16.Name = "launcherMenuButton16";
            this.launcherMenuButton16.Size = new System.Drawing.Size(106, 79);
            this.launcherMenuButton16.TabIndex = 53;
            // 
            // launcherMenuButton15
            // 
            this.launcherMenuButton15.buttons = 0;
            this.launcherMenuButton15.Location = new System.Drawing.Point(339, 160);
            this.launcherMenuButton15.Name = "launcherMenuButton15";
            this.launcherMenuButton15.Size = new System.Drawing.Size(108, 79);
            this.launcherMenuButton15.TabIndex = 56;
            // 
            // launcherMenuButton14
            // 
            this.launcherMenuButton14.buttons = 0;
            this.launcherMenuButton14.Location = new System.Drawing.Point(453, 160);
            this.launcherMenuButton14.Name = "launcherMenuButton14";
            this.launcherMenuButton14.Size = new System.Drawing.Size(108, 79);
            this.launcherMenuButton14.TabIndex = 57;
            // 
            // launcherMenuButton17
            // 
            this.launcherMenuButton17.buttons = 0;
            this.launcherMenuButton17.Location = new System.Drawing.Point(225, 160);
            this.launcherMenuButton17.Name = "launcherMenuButton17";
            this.launcherMenuButton17.Size = new System.Drawing.Size(108, 79);
            this.launcherMenuButton17.TabIndex = 55;
            // 
            // launcherMenuButton7
            // 
            this.launcherMenuButton7.buttons = 0;
            this.launcherMenuButton7.Location = new System.Drawing.Point(567, 87);
            this.launcherMenuButton7.Name = "launcherMenuButton7";
            this.launcherMenuButton7.Size = new System.Drawing.Size(108, 76);
            this.launcherMenuButton7.TabIndex = 52;
            // 
            // launcherMenuButton18
            // 
            this.launcherMenuButton18.buttons = 0;
            this.launcherMenuButton18.Location = new System.Drawing.Point(112, 160);
            this.launcherMenuButton18.Name = "launcherMenuButton18";
            this.launcherMenuButton18.Size = new System.Drawing.Size(107, 79);
            this.launcherMenuButton18.TabIndex = 54;
            // 
            // launcherMenuButton10
            // 
            this.launcherMenuButton10.buttons = 0;
            this.launcherMenuButton10.Location = new System.Drawing.Point(0, 87);
            this.launcherMenuButton10.Name = "launcherMenuButton10";
            this.launcherMenuButton10.Size = new System.Drawing.Size(106, 76);
            this.launcherMenuButton10.TabIndex = 47;
            // 
            // launcherMenuButton8
            // 
            this.launcherMenuButton8.buttons = 0;
            this.launcherMenuButton8.Location = new System.Drawing.Point(453, 87);
            this.launcherMenuButton8.Name = "launcherMenuButton8";
            this.launcherMenuButton8.Size = new System.Drawing.Size(108, 76);
            this.launcherMenuButton8.TabIndex = 51;
            // 
            // launcherMenuButton9
            // 
            this.launcherMenuButton9.buttons = 0;
            this.launcherMenuButton9.Location = new System.Drawing.Point(339, 87);
            this.launcherMenuButton9.Name = "launcherMenuButton9";
            this.launcherMenuButton9.Size = new System.Drawing.Size(108, 76);
            this.launcherMenuButton9.TabIndex = 50;
            // 
            // launcherMenuButton11
            // 
            this.launcherMenuButton11.buttons = 0;
            this.launcherMenuButton11.Location = new System.Drawing.Point(225, 87);
            this.launcherMenuButton11.Name = "launcherMenuButton11";
            this.launcherMenuButton11.Size = new System.Drawing.Size(108, 76);
            this.launcherMenuButton11.TabIndex = 49;
            // 
            // launcherMenuButton12
            // 
            this.launcherMenuButton12.buttons = 0;
            this.launcherMenuButton12.Location = new System.Drawing.Point(112, 87);
            this.launcherMenuButton12.Name = "launcherMenuButton12";
            this.launcherMenuButton12.Size = new System.Drawing.Size(107, 76);
            this.launcherMenuButton12.TabIndex = 48;
            // 
            // launcherMenuButton5
            // 
            this.launcherMenuButton5.buttons = 0;
            this.launcherMenuButton5.Location = new System.Drawing.Point(453, 13);
            this.launcherMenuButton5.Name = "launcherMenuButton5";
            this.launcherMenuButton5.Size = new System.Drawing.Size(108, 78);
            this.launcherMenuButton5.TabIndex = 45;
            // 
            // launcherMenuButton4
            // 
            this.launcherMenuButton4.buttons = 0;
            this.launcherMenuButton4.Location = new System.Drawing.Point(339, 13);
            this.launcherMenuButton4.Name = "launcherMenuButton4";
            this.launcherMenuButton4.Size = new System.Drawing.Size(108, 78);
            this.launcherMenuButton4.TabIndex = 44;
            // 
            // launcherMenuButton1
            // 
            this.launcherMenuButton1.buttons = 0;
            this.launcherMenuButton1.Location = new System.Drawing.Point(0, 13);
            this.launcherMenuButton1.Name = "launcherMenuButton1";
            this.launcherMenuButton1.Size = new System.Drawing.Size(106, 78);
            this.launcherMenuButton1.TabIndex = 41;
            // 
            // launcherMenuButton3
            // 
            this.launcherMenuButton3.buttons = 0;
            this.launcherMenuButton3.Location = new System.Drawing.Point(225, 13);
            this.launcherMenuButton3.Name = "launcherMenuButton3";
            this.launcherMenuButton3.Size = new System.Drawing.Size(108, 78);
            this.launcherMenuButton3.TabIndex = 43;
            // 
            // launcherMenuButton2
            // 
            this.launcherMenuButton2.buttons = 0;
            this.launcherMenuButton2.Location = new System.Drawing.Point(112, 13);
            this.launcherMenuButton2.Name = "launcherMenuButton2";
            this.launcherMenuButton2.Size = new System.Drawing.Size(107, 78);
            this.launcherMenuButton2.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.launcherMenuButton22);
            this.panel2.Controls.Add(this.launcherMenuButton19);
            this.panel2.Controls.Add(this.launcherMenuButton6);
            this.panel2.Controls.Add(this.launcherMenuButton20);
            this.panel2.Controls.Add(this.launcherMenuButton21);
            this.panel2.Controls.Add(this.launcherMenuButton23);
            this.panel2.Controls.Add(this.launcherMenuButton13);
            this.panel2.Controls.Add(this.launcherMenuButton24);
            this.panel2.Controls.Add(this.launcherMenuButton16);
            this.panel2.Controls.Add(this.launcherMenuButton15);
            this.panel2.Controls.Add(this.launcherMenuButton14);
            this.panel2.Controls.Add(this.launcherMenuButton17);
            this.panel2.Controls.Add(this.launcherMenuButton7);
            this.panel2.Controls.Add(this.launcherMenuButton18);
            this.panel2.Controls.Add(this.launcherMenuButton10);
            this.panel2.Controls.Add(this.launcherMenuButton8);
            this.panel2.Controls.Add(this.launcherMenuButton9);
            this.panel2.Controls.Add(this.launcherMenuButton11);
            this.panel2.Controls.Add(this.launcherMenuButton12);
            this.panel2.Controls.Add(this.launcherMenuButton5);
            this.panel2.Controls.Add(this.launcherMenuButton4);
            this.panel2.Controls.Add(this.launcherMenuButton1);
            this.panel2.Controls.Add(this.launcherMenuButton3);
            this.panel2.Controls.Add(this.launcherMenuButton2);
            this.panel2.Location = new System.Drawing.Point(15, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 312);
            this.panel2.TabIndex = 69;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(711, 469);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFullDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppLauncher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFullDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editEntryToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private Keypad.LauncherMenuButton launcherMenuButton1;
        private Keypad.LauncherMenuButton launcherMenuButton2;
        private Keypad.LauncherMenuButton launcherMenuButton3;
        private Keypad.LauncherMenuButton launcherMenuButton4;
        private Keypad.LauncherMenuButton launcherMenuButton5;
        private Keypad.LauncherMenuButton launcherMenuButton6;
        private Keypad.LauncherMenuButton launcherMenuButton7;
        private Keypad.LauncherMenuButton launcherMenuButton8;
        private Keypad.LauncherMenuButton launcherMenuButton9;
        private Keypad.LauncherMenuButton launcherMenuButton10;
        private Keypad.LauncherMenuButton launcherMenuButton11;
        private Keypad.LauncherMenuButton launcherMenuButton12;
        private Keypad.LauncherMenuButton launcherMenuButton13;
        private Keypad.LauncherMenuButton launcherMenuButton14;
        private Keypad.LauncherMenuButton launcherMenuButton15;
        private Keypad.LauncherMenuButton launcherMenuButton16;
        private Keypad.LauncherMenuButton launcherMenuButton17;
        private Keypad.LauncherMenuButton launcherMenuButton18;
        private Keypad.LauncherMenuButton launcherMenuButton19;
        private Keypad.LauncherMenuButton launcherMenuButton20;
        private Keypad.LauncherMenuButton launcherMenuButton21;
        private Keypad.LauncherMenuButton launcherMenuButton22;
        private Keypad.LauncherMenuButton launcherMenuButton23;
        private Keypad.LauncherMenuButton launcherMenuButton24;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Panel panel2;
    }
}

