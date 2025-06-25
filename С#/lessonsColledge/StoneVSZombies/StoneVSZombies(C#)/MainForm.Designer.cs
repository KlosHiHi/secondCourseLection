namespace StoneVSZombies_C__
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
            components = new System.ComponentModel.Container();
            MainMenuStrip = new MenuStrip();
            NewGameMenuItem = new ToolStripMenuItem();
            HealthPointMenuItem = new ToolStripMenuItem();
            ScoreMenuItem = new ToolStripMenuItem();
            HighScoreMenuItem = new ToolStripMenuItem();
            GameCycleTimer = new System.Windows.Forms.Timer(components);
            FieldPanel = new Panel();
            _hero = new Hero();
            MainMenuStrip.SuspendLayout();
            FieldPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.BackColor = SystemColors.ActiveCaption;
            MainMenuStrip.ImageScalingSize = new Size(20, 20);
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { NewGameMenuItem, HealthPointMenuItem, ScoreMenuItem, HighScoreMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Padding = new Padding(7, 3, 0, 3);
            MainMenuStrip.Size = new Size(553, 30);
            MainMenuStrip.TabIndex = 0;
            MainMenuStrip.Text = "menuStrip1";
            // 
            // NewGameMenuItem
            // 
            NewGameMenuItem.Name = "NewGameMenuItem";
            NewGameMenuItem.Size = new Size(103, 24);
            NewGameMenuItem.Text = "Новая игра";
            NewGameMenuItem.Click += NewGameMenuItem_Click;
            // 
            // HealthPointMenuItem
            // 
            HealthPointMenuItem.Name = "HealthPointMenuItem";
            HealthPointMenuItem.Size = new Size(42, 24);
            HealthPointMenuItem.Text = "HP";
            // 
            // ScoreMenuItem
            // 
            ScoreMenuItem.Name = "ScoreMenuItem";
            ScoreMenuItem.Size = new Size(60, 24);
            ScoreMenuItem.Text = "Score";
            // 
            // HighScoreMenuItem
            // 
            HighScoreMenuItem.Name = "HighScoreMenuItem";
            HighScoreMenuItem.Size = new Size(72, 24);
            HighScoreMenuItem.Text = "Рекорд";
            // 
            // GameCycleTimer
            // 
            GameCycleTimer.Interval = 30;
            GameCycleTimer.Tick += GameCycleTimer_Tick;
            // 
            // FieldPanel
            // 
            FieldPanel.BackColor = Color.Snow;
            FieldPanel.Controls.Add(_hero);
            FieldPanel.Dock = DockStyle.Fill;
            FieldPanel.ForeColor = SystemColors.ActiveCaptionText;
            FieldPanel.Location = new Point(0, 30);
            FieldPanel.Margin = new Padding(3, 4, 3, 4);
            FieldPanel.Name = "FieldPanel";
            FieldPanel.Size = new Size(553, 585);
            FieldPanel.TabIndex = 2;
            // 
            // _hero
            // 
            _hero.BackColor = Color.DimGray;
            _hero.Location = new Point(253, 265);
            _hero.Margin = new Padding(3, 4, 3, 4);
            _hero.Name = "_hero";
            _hero.Size = new Size(46, 53);
            _hero.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 615);
            Controls.Add(FieldPanel);
            Controls.Add(MainMenuStrip);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(112, 118);
            Name = "MainForm";
            Text = "Камни vs Зомби";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            KeyUp += MainForm_KeyUp;
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            FieldPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem NewGameMenuItem;
        private System.Windows.Forms.Timer GameCycleTimer;
        private Panel FieldPanel;
        private Hero _hero;
        private ToolStripMenuItem ScoreMenuItem;
        private ToolStripMenuItem HighScoreMenuItem;
        private ToolStripMenuItem HealthPointMenuItem;
    }
}
