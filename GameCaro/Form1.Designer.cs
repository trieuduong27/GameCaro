namespace GameCaro
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
			this.pnlChessBoard = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pctbAvatar = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.binLAN = new System.Windows.Forms.Button();
			this.txbIP = new System.Windows.Forms.TextBox();
			this.pctbMark = new System.Windows.Forms.PictureBox();
			this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
			this.txbPlayerName = new System.Windows.Forms.TextBox();
			this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctbAvatar)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctbMark)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlChessBoard
			// 
			this.pnlChessBoard.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.pnlChessBoard.Location = new System.Drawing.Point(0, 40);
			this.pnlChessBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pnlChessBoard.Name = "pnlChessBoard";
			this.pnlChessBoard.Size = new System.Drawing.Size(1222, 1118);
			this.pnlChessBoard.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.pctbAvatar);
			this.panel2.Location = new System.Drawing.Point(1430, 19);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(404, 711);
			this.panel2.TabIndex = 1;
			// 
			// pctbAvatar
			// 
			this.pctbAvatar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pctbAvatar.BackgroundImage = global::GameCaro.Properties.Resources.picBig;
			this.pctbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pctbAvatar.Location = new System.Drawing.Point(0, 0);
			this.pctbAvatar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pctbAvatar.Name = "pctbAvatar";
			this.pctbAvatar.Size = new System.Drawing.Size(399, 416);
			this.pctbAvatar.TabIndex = 0;
			this.pctbAvatar.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.SystemColors.Control;
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.binLAN);
			this.panel3.Controls.Add(this.txbIP);
			this.panel3.Controls.Add(this.pctbMark);
			this.panel3.Controls.Add(this.prcbCoolDown);
			this.panel3.Controls.Add(this.txbPlayerName);
			this.panel3.Location = new System.Drawing.Point(1430, 448);
			this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(404, 386);
			this.panel3.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 270);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(338, 47);
			this.label1.TabIndex = 5;
			this.label1.Text = "5 in a line to win";
			// 
			// binLAN
			// 
			this.binLAN.Location = new System.Drawing.Point(4, 166);
			this.binLAN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.binLAN.Name = "binLAN";
			this.binLAN.Size = new System.Drawing.Size(189, 36);
			this.binLAN.TabIndex = 4;
			this.binLAN.Text = "LAN";
			this.binLAN.UseVisualStyleBackColor = true;
			// 
			// txbIP
			// 
			this.txbIP.Location = new System.Drawing.Point(4, 117);
			this.txbIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txbIP.Name = "txbIP";
			this.txbIP.Size = new System.Drawing.Size(187, 31);
			this.txbIP.TabIndex = 3;
			this.txbIP.Text = "127.0.0.1";
			// 
			// pctbMark
			// 
			this.pctbMark.BackColor = System.Drawing.SystemColors.Control;
			this.pctbMark.Location = new System.Drawing.Point(202, 14);
			this.pctbMark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pctbMark.Name = "pctbMark";
			this.pctbMark.Size = new System.Drawing.Size(196, 188);
			this.pctbMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctbMark.TabIndex = 2;
			this.pctbMark.TabStop = false;
			// 
			// prcbCoolDown
			// 
			this.prcbCoolDown.Location = new System.Drawing.Point(4, 72);
			this.prcbCoolDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.prcbCoolDown.Name = "prcbCoolDown";
			this.prcbCoolDown.Size = new System.Drawing.Size(189, 36);
			this.prcbCoolDown.TabIndex = 1;
			// 
			// txbPlayerName
			// 
			this.txbPlayerName.Location = new System.Drawing.Point(4, 14);
			this.txbPlayerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txbPlayerName.Name = "txbPlayerName";
			this.txbPlayerName.ReadOnly = true;
			this.txbPlayerName.Size = new System.Drawing.Size(187, 31);
			this.txbPlayerName.TabIndex = 0;
			// 
			// tmCoolDown
			// 
			this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1854, 40);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(97, 36);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
			this.newGameToolStripMenuItem.Text = "New Game";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
			this.undoToolStripMenuItem.Text = "Undo";
			this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1854, 1158);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pnlChessBoard);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Game Caro";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pctbAvatar)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctbMark)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pctbAvatar;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button binLAN;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.PictureBox pctbMark;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

