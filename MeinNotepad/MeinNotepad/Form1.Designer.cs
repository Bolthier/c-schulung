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
            toolStripMenuItem1 = new ToolStripMenuItem();
            neuToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            speichernToolStripMenuItem = new ToolStripMenuItem();
            öffnenToolStripMenuItem = new ToolStripMenuItem();
            endeToolStripMenuItem = new ToolStripMenuItem();
            txTextInput = new TextBox();
            statusStrip1 = new StatusStrip();
            LBZeichen = new ToolStripStatusLabel();
            lbWörter = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { neuToolStripMenuItem, toolStripSeparator1, speichernToolStripMenuItem, öffnenToolStripMenuItem, endeToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(46, 20);
            toolStripMenuItem1.Text = "Datei";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // neuToolStripMenuItem
            // 
            neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            neuToolStripMenuItem.Size = new Size(180, 22);
            neuToolStripMenuItem.Text = "Neu";
            neuToolStripMenuItem.Click += neuToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // speichernToolStripMenuItem
            // 
            speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            speichernToolStripMenuItem.Size = new Size(180, 22);
            speichernToolStripMenuItem.Text = "Speichern...";
            speichernToolStripMenuItem.Click += speichernToolStripMenuItem_Click;
            // 
            // öffnenToolStripMenuItem
            // 
            öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            öffnenToolStripMenuItem.Size = new Size(180, 22);
            öffnenToolStripMenuItem.Text = "Öffnen...";
            öffnenToolStripMenuItem.Click += öffnenToolStripMenuItem_Click;
            // 
            // endeToolStripMenuItem
            // 
            endeToolStripMenuItem.Name = "endeToolStripMenuItem";
            endeToolStripMenuItem.Size = new Size(180, 22);
            endeToolStripMenuItem.Text = "Ende";
            endeToolStripMenuItem.Click += endeToolStripMenuItem_Click;
            // 
            // txTextInput
            // 
            txTextInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txTextInput.Location = new Point(12, 27);
            txTextInput.Multiline = true;
            txTextInput.Name = "txTextInput";
            txTextInput.ScrollBars = ScrollBars.Both;
            txTextInput.Size = new Size(776, 401);
            txTextInput.TabIndex = 1;
            txTextInput.TextChanged += txTextInput_TextChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { LBZeichen, lbWörter });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // LBZeichen
            // 
            LBZeichen.Name = "LBZeichen";
            LBZeichen.Size = new Size(61, 17);
            LBZeichen.Text = "Zeichen: 0";
            LBZeichen.TextChanged += LBZeichen_TextChanged;
            // 
            // lbWörter
            // 
            lbWörter.Name = "lbWörter";
            lbWörter.Size = new Size(118, 17);
            lbWörter.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(txTextInput);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Mein Notepad";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem neuToolStripMenuItem;
        private ToolStripMenuItem speichernToolStripMenuItem;
        private ToolStripMenuItem öffnenToolStripMenuItem;
        private ToolStripMenuItem endeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private TextBox txTextInput;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LBZeichen;
        private ToolStripStatusLabel lbWörter;
        private VScrollBar vScrollBar1;
    }
}
