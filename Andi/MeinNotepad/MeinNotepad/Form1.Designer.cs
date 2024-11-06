namespace MeinNotepad
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
            menuStrip1 = new MenuStrip();
            dateiToolStripMenuItem = new ToolStripMenuItem();
            neuToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            öffnenToolStripMenuItem = new ToolStripMenuItem();
            speichernUnterToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            endeToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lbZeichen = new ToolStripStatusLabel();
            lbWoerter = new ToolStripStatusLabel();
            txTheText = new TextBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dateiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(920, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            dateiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { neuToolStripMenuItem, toolStripMenuItem1, öffnenToolStripMenuItem, speichernUnterToolStripMenuItem, toolStripMenuItem2, endeToolStripMenuItem });
            dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            dateiToolStripMenuItem.Size = new Size(46, 20);
            dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            neuToolStripMenuItem.Size = new Size(180, 22);
            neuToolStripMenuItem.Text = "Neu";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // öffnenToolStripMenuItem
            // 
            öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            öffnenToolStripMenuItem.Size = new Size(180, 22);
            öffnenToolStripMenuItem.Text = "Öffnen ...";
            öffnenToolStripMenuItem.Click += öffnenToolStripMenuItem_Click;
            // 
            // speichernUnterToolStripMenuItem
            // 
            speichernUnterToolStripMenuItem.Name = "speichernUnterToolStripMenuItem";
            speichernUnterToolStripMenuItem.Size = new Size(180, 22);
            speichernUnterToolStripMenuItem.Text = "Speichern unter ...";
            speichernUnterToolStripMenuItem.Click += speichernUnterToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(177, 6);
            // 
            // endeToolStripMenuItem
            // 
            endeToolStripMenuItem.Name = "endeToolStripMenuItem";
            endeToolStripMenuItem.Size = new Size(180, 22);
            endeToolStripMenuItem.Text = "Ende";
            endeToolStripMenuItem.Click += endeToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbZeichen, lbWoerter });
            statusStrip1.Location = new Point(0, 507);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(920, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbZeichen
            // 
            lbZeichen.Name = "lbZeichen";
            lbZeichen.Size = new Size(118, 17);
            lbZeichen.Text = "toolStripStatusLabel1";
            // 
            // lbWoerter
            // 
            lbWoerter.Name = "lbWoerter";
            lbWoerter.Size = new Size(118, 17);
            lbWoerter.Text = "toolStripStatusLabel1";
            // 
            // txTheText
            // 
            txTheText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txTheText.Location = new Point(12, 27);
            txTheText.Multiline = true;
            txTheText.Name = "txTheText";
            txTheText.ScrollBars = ScrollBars.Both;
            txTheText.Size = new Size(896, 477);
            txTheText.TabIndex = 2;
            txTheText.TextChanged += txTheText_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 529);
            Controls.Add(txTheText);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Mein Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem neuToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem öffnenToolStripMenuItem;
        private ToolStripMenuItem speichernUnterToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem endeToolStripMenuItem;
        private StatusStrip statusStrip1;
        private TextBox txTheText;
        private ToolStripStatusLabel lbZeichen;
        private ToolStripStatusLabel lbWoerter;
    }
}
