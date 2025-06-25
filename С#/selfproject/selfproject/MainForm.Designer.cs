namespace selfproject
{
    partial class MainForm
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
            MainStatusStrip = new StatusStrip();
            menuStrip1 = new MenuStrip();
            EditTextMenuItem = new ToolStripMenuItem();
            SomeThingMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.BackColor = Color.Snow;
            MainStatusStrip.ImageScalingSize = new Size(20, 20);
            MainStatusStrip.Location = new Point(0, 1011);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Size = new Size(1902, 22);
            MainStatusStrip.TabIndex = 2;
            MainStatusStrip.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { EditTextMenuItem, SomeThingMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 32);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // EditTextMenuItem
            // 
            EditTextMenuItem.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditTextMenuItem.ForeColor = Color.Black;
            EditTextMenuItem.Name = "EditTextMenuItem";
            EditTextMenuItem.Size = new Size(80, 28);
            EditTextMenuItem.Text = "ТЕКСТ";
            EditTextMenuItem.Click += EditTextMenuItem_Click;
            // 
            // SomeThingMenuItem
            // 
            SomeThingMenuItem.Name = "SomeThingMenuItem";
            SomeThingMenuItem.Size = new Size(101, 28);
            SomeThingMenuItem.Text = "ШАБЛОН";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1902, 1033);
            Controls.Add(MainStatusStrip);
            Controls.Add(menuStrip1);
            MinimumSize = new Size(700, 500);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Начальная страница";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private StatusStrip MainStatusStrip;
        private ToolStripMenuItem EditTextMenuItem;
        private ToolStripMenuItem SomeThingMenuItem;
    }
}
