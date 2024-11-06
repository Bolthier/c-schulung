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
            spielToolStripMenuItem = new ToolStripMenuItem();
            neuToolStripMenuItem = new ToolStripMenuItem();
            pTastatur = new FlowLayoutPanel();
            lbFehler = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbTheView
            // 
            lbTheView.BorderStyle = BorderStyle.Fixed3D;
            lbTheView.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTheView.Location = new Point(12, 35);
            lbTheView.Name = "lbTheView";
            lbTheView.Size = new Size(776, 108);
            lbTheView.TabIndex = 0;
            lbTheView.Text = "----------";
            lbTheView.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { spielToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // spielToolStripMenuItem
            // 
            spielToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { neuToolStripMenuItem });
            spielToolStripMenuItem.Name = "spielToolStripMenuItem";
            spielToolStripMenuItem.Size = new Size(44, 20);
            spielToolStripMenuItem.Text = "Spiel";
            // 
            // neuToolStripMenuItem
            // 
            neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            neuToolStripMenuItem.Size = new Size(96, 22);
            neuToolStripMenuItem.Text = "Neu";
            neuToolStripMenuItem.Click += neuToolStripMenuItem_Click;
            // 
            // pTastatur
            // 
            pTastatur.BorderStyle = BorderStyle.FixedSingle;
            pTastatur.Location = new Point(12, 146);
            pTastatur.Name = "pTastatur";
            pTastatur.Size = new Size(776, 111);
            pTastatur.TabIndex = 2;
            // 
            // lbFehler
            // 
            lbFehler.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFehler.ForeColor = Color.Red;
            lbFehler.Location = new Point(12, 260);
            lbFehler.Name = "lbFehler";
            lbFehler.Size = new Size(290, 181);
            lbFehler.TabIndex = 3;
            lbFehler.Text = "0";
            lbFehler.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(448, 263);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lbFehler);
            Controls.Add(pTastatur);
            Controls.Add(lbTheView);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Hangman";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTheView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem spielToolStripMenuItem;
        private ToolStripMenuItem neuToolStripMenuItem;
        private FlowLayoutPanel pTastatur;
        private Label lbFehler;
        private PictureBox pictureBox1;
    }
}
