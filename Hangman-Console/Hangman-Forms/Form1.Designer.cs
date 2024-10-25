namespace Hangman_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbTheView = new Label();
            menuStrip1 = new MenuStrip();
            neuesSpielToolStripMenuItem = new ToolStripMenuItem();
            neuToolStripMenuItem = new ToolStripMenuItem();
            endeToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            Spiele = new ToolStripStatusLabel();
            Siege = new ToolStripStatusLabel();
            Niederlagen = new ToolStripStatusLabel();
            pTastatur = new FlowLayoutPanel();
            lbFehler = new Label();
            pbFehler = new PictureBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFehler).BeginInit();
            SuspendLayout();
            // 
            // lbTheView
            // 
            lbTheView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTheView.BorderStyle = BorderStyle.Fixed3D;
            lbTheView.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTheView.Location = new Point(12, 20);
            lbTheView.Name = "lbTheView";
            lbTheView.Size = new Size(776, 134);
            lbTheView.TabIndex = 0;
            lbTheView.Text = "--------";
            lbTheView.TextAlign = ContentAlignment.MiddleCenter;
            lbTheView.Click += TheView_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { neuesSpielToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // neuesSpielToolStripMenuItem
            // 
            neuesSpielToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { neuToolStripMenuItem, endeToolStripMenuItem });
            neuesSpielToolStripMenuItem.Name = "neuesSpielToolStripMenuItem";
            neuesSpielToolStripMenuItem.Size = new Size(44, 20);
            neuesSpielToolStripMenuItem.Text = "Spiel";
            neuesSpielToolStripMenuItem.Click += neuesSpielToolStripMenuItem_Click;
            // 
            // neuToolStripMenuItem
            // 
            neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            neuToolStripMenuItem.Size = new Size(100, 22);
            neuToolStripMenuItem.Text = "Neu";
            neuToolStripMenuItem.Click += neuToolStripMenuItem_Click;
            // 
            // endeToolStripMenuItem
            // 
            endeToolStripMenuItem.Name = "endeToolStripMenuItem";
            endeToolStripMenuItem.Size = new Size(100, 22);
            endeToolStripMenuItem.Text = "Ende";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { Spiele, Siege, Niederlagen });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // Spiele
            // 
            Spiele.Name = "Spiele";
            Spiele.Size = new Size(50, 17);
            Spiele.Text = "Spiele: 0";
            // 
            // Siege
            // 
            Siege.Name = "Siege";
            Siege.Size = new Size(47, 17);
            Siege.Text = "Siege: 0";
            // 
            // Niederlagen
            // 
            Niederlagen.Name = "Niederlagen";
            Niederlagen.Size = new Size(83, 17);
            Niederlagen.Text = "Niederlagen: 0";
            // 
            // pTastatur
            // 
            pTastatur.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pTastatur.BorderStyle = BorderStyle.FixedSingle;
            pTastatur.Location = new Point(12, 157);
            pTastatur.Name = "pTastatur";
            pTastatur.Size = new Size(776, 131);
            pTastatur.TabIndex = 3;
            // 
            // lbFehler
            // 
            lbFehler.BorderStyle = BorderStyle.FixedSingle;
            lbFehler.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFehler.Location = new Point(12, 291);
            lbFehler.Name = "lbFehler";
            lbFehler.Size = new Size(381, 137);
            lbFehler.TabIndex = 4;
            lbFehler.Text = "0";
            lbFehler.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbFehler
            // 
            pbFehler.BorderStyle = BorderStyle.FixedSingle;
            pbFehler.Location = new Point(399, 291);
            pbFehler.Name = "pbFehler";
            pbFehler.Size = new Size(389, 137);
            pbFehler.SizeMode = PictureBoxSizeMode.Zoom;
            pbFehler.TabIndex = 5;
            pbFehler.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbFehler);
            Controls.Add(lbFehler);
            Controls.Add(pTastatur);
            Controls.Add(statusStrip1);
            Controls.Add(lbTheView);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Hangman 3002";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFehler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTheView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem neuesSpielToolStripMenuItem;
        private ToolStripMenuItem neuToolStripMenuItem;
        private ToolStripMenuItem endeToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel Spiele;
        private ToolStripStatusLabel Siege;
        private ToolStripStatusLabel Niederlagen;
        private FlowLayoutPanel pTastatur;
        private Label lbFehler;
        private PictureBox pbFehler;
    }
}
