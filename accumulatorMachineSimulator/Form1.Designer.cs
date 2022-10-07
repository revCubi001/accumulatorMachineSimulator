
namespace accumulatorMachineSimulator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plLeft = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.plPlayer = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plCpu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plInfo = new System.Windows.Forms.Panel();
            this.console = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plTopMenu = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VariablexTxt = new System.Windows.Forms.TextBox();
            this.VariableYtxt = new System.Windows.Forms.TextBox();
            this.VariableZtxt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuACC1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vARIABLESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEMORIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCodif = new System.Windows.Forms.RichTextBox();
            this.plLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.plPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.panel1.SuspendLayout();
            this.plCpu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plInfo.SuspendLayout();
            this.plTopMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plLeft
            // 
            this.plLeft.BackColor = System.Drawing.SystemColors.Control;
            this.plLeft.Controls.Add(this.splitContainer1);
            this.plLeft.Controls.Add(this.plPlayer);
            this.plLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.plLeft.Location = new System.Drawing.Point(0, 0);
            this.plLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plLeft.Name = "plLeft";
            this.plLeft.Size = new System.Drawing.Size(741, 605);
            this.plLeft.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 73);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtCodif);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.VariableZtxt);
            this.splitContainer1.Panel2.Controls.Add(this.VariableYtxt);
            this.splitContainer1.Panel2.Controls.Add(this.VariablexTxt);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(741, 532);
            this.splitContainer1.SplitterDistance = 355;
            this.splitContainer1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codificación";
            // 
            // plPlayer
            // 
            this.plPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.plPlayer.Controls.Add(this.btnStop);
            this.plPlayer.Controls.Add(this.btnPause);
            this.plPlayer.Controls.Add(this.btnPlay);
            this.plPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.plPlayer.Location = new System.Drawing.Point(0, 0);
            this.plPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plPlayer.Name = "plPlayer";
            this.plPlayer.Size = new System.Drawing.Size(741, 73);
            this.plPlayer.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStop.Image = global::accumulatorMachineSimulator.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(128, 0);
            this.btnStop.Margin = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(64, 73);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnStop.TabIndex = 2;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPause.Image = global::accumulatorMachineSimulator.Properties.Resources.pause;
            this.btnPause.Location = new System.Drawing.Point(64, 0);
            this.btnPause.Margin = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(64, 73);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnPause.TabIndex = 1;
            this.btnPause.TabStop = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(0, 0);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(20, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(64, 73);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.plCpu);
            this.panel1.Controls.Add(this.plInfo);
            this.panel1.Controls.Add(this.plTopMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(741, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 605);
            this.panel1.TabIndex = 1;
            // 
            // plCpu
            // 
            this.plCpu.Controls.Add(this.pictureBox1);
            this.plCpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plCpu.Location = new System.Drawing.Point(0, 73);
            this.plCpu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plCpu.Name = "plCpu";
            this.plCpu.Size = new System.Drawing.Size(299, 297);
            this.plCpu.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // plInfo
            // 
            this.plInfo.BackColor = System.Drawing.Color.White;
            this.plInfo.Controls.Add(this.console);
            this.plInfo.Controls.Add(this.label1);
            this.plInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plInfo.Location = new System.Drawing.Point(0, 370);
            this.plInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plInfo.Name = "plInfo";
            this.plInfo.Size = new System.Drawing.Size(299, 235);
            this.plInfo.TabIndex = 1;
            // 
            // console
            // 
            this.console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.console.Location = new System.Drawing.Point(12, 36);
            this.console.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(277, 187);
            this.console.TabIndex = 1;
            this.console.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consola";
            // 
            // plTopMenu
            // 
            this.plTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.plTopMenu.Controls.Add(this.menuStrip1);
            this.plTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTopMenu.Location = new System.Drawing.Point(0, 0);
            this.plTopMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plTopMenu.Name = "plTopMenu";
            this.plTopMenu.Size = new System.Drawing.Size(299, 73);
            this.plTopMenu.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Variables:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(3, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "x = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(3, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "y = ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(3, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "z = ";
            // 
            // VariablexTxt
            // 
            this.VariablexTxt.Location = new System.Drawing.Point(61, 383);
            this.VariablexTxt.Multiline = true;
            this.VariablexTxt.Name = "VariablexTxt";
            this.VariablexTxt.Size = new System.Drawing.Size(155, 23);
            this.VariablexTxt.TabIndex = 6;
            // 
            // VariableYtxt
            // 
            this.VariableYtxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.VariableYtxt.Location = new System.Drawing.Point(61, 424);
            this.VariableYtxt.Name = "VariableYtxt";
            this.VariableYtxt.Size = new System.Drawing.Size(155, 22);
            this.VariableYtxt.TabIndex = 7;
            this.VariableYtxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // VariableZtxt
            // 
            this.VariableZtxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.VariableZtxt.Location = new System.Drawing.Point(61, 463);
            this.VariableZtxt.Name = "VariableZtxt";
            this.VariableZtxt.Size = new System.Drawing.Size(155, 22);
            this.VariableZtxt.TabIndex = 8;
            this.VariableZtxt.TextChanged += new System.EventHandler(this.VariableZtxt_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuACC1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(299, 68);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuACC1
            // 
            this.MenuACC1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vARIABLESToolStripMenuItem,
            this.mEMORIAToolStripMenuItem,
            this.sTOREToolStripMenuItem});
            this.MenuACC1.Font = new System.Drawing.Font("Segoe UI Symbol", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuACC1.Image = ((System.Drawing.Image)(resources.GetObject("MenuACC1.Image")));
            this.MenuACC1.Name = "MenuACC1";
            this.MenuACC1.Size = new System.Drawing.Size(255, 64);
            this.MenuACC1.Text = "Ver mas...";
            // 
            // vARIABLESToolStripMenuItem
            // 
            this.vARIABLESToolStripMenuItem.Name = "vARIABLESToolStripMenuItem";
            this.vARIABLESToolStripMenuItem.Size = new System.Drawing.Size(345, 64);
            this.vARIABLESToolStripMenuItem.Text = "VARIABLES";
            // 
            // mEMORIAToolStripMenuItem
            // 
            this.mEMORIAToolStripMenuItem.Name = "mEMORIAToolStripMenuItem";
            this.mEMORIAToolStripMenuItem.Size = new System.Drawing.Size(345, 64);
            this.mEMORIAToolStripMenuItem.Text = "MEMORIA";
            // 
            // sTOREToolStripMenuItem
            // 
            this.sTOREToolStripMenuItem.Name = "sTOREToolStripMenuItem";
            this.sTOREToolStripMenuItem.Size = new System.Drawing.Size(345, 64);
            this.sTOREToolStripMenuItem.Text = "STORE";
            // 
            // txtCodif
            // 
            this.txtCodif.Location = new System.Drawing.Point(11, 42);
            this.txtCodif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodif.Name = "txtCodif";
            this.txtCodif.Size = new System.Drawing.Size(341, 729);
            this.txtCodif.TabIndex = 2;
            this.txtCodif.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plLeft);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.plLeft.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.plPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.plCpu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plInfo.ResumeLayout(false);
            this.plInfo.PerformLayout();
            this.plTopMenu.ResumeLayout(false);
            this.plTopMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plPlayer;
        private System.Windows.Forms.Panel plCpu;
        private System.Windows.Forms.Panel plInfo;
        private System.Windows.Forms.Panel plTopMenu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnPause;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox VariableZtxt;
        private System.Windows.Forms.TextBox VariableYtxt;
        private System.Windows.Forms.TextBox VariablexTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuACC1;
        private System.Windows.Forms.ToolStripMenuItem vARIABLESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEMORIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTOREToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtCodif;
    }
}

