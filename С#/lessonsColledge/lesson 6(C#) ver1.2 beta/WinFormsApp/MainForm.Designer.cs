namespace WinFormsApp
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
            AuthorizationMenuItem = new ToolStripMenuItem();
            RagistrationMenuItem = new ToolStripMenuItem();
            ColorMenuItem = new ToolStripMenuItem();
            MainStatusStrip = new StatusStrip();
            DayTimeStatusLabel = new ToolStripStatusLabel();
            CurrentTimeTimer = new System.Windows.Forms.Timer(components);
            MainMenuStrip.SuspendLayout();
            MainStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.BackColor = Color.Snow;
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { AuthorizationMenuItem, RagistrationMenuItem, ColorMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(1021, 24);
            MainMenuStrip.TabIndex = 1;
            MainMenuStrip.Text = "menuStrip1";
            // 
            // AuthorizationMenuItem
            // 
            AuthorizationMenuItem.Name = "AuthorizationMenuItem";
            AuthorizationMenuItem.Size = new Size(52, 20);
            AuthorizationMenuItem.Text = "Войти";
            AuthorizationMenuItem.Click += toAuthorizationButton_Click;
            // 
            // RagistrationMenuItem
            // 
            RagistrationMenuItem.Name = "RagistrationMenuItem";
            RagistrationMenuItem.Size = new Size(131, 20);
            RagistrationMenuItem.Text = "Зарегистрироваться";
            RagistrationMenuItem.Click += toRegistrationButton_Click;
            // 
            // ColorMenuItem
            // 
            ColorMenuItem.Name = "ColorMenuItem";
            ColorMenuItem.Size = new Size(45, 20);
            ColorMenuItem.Text = "Цвет";
            ColorMenuItem.Click += toColorFormButton_Click;
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.BackColor = Color.Snow;
            MainStatusStrip.Items.AddRange(new ToolStripItem[] { DayTimeStatusLabel });
            MainStatusStrip.Location = new Point(0, 514);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Size = new Size(1021, 22);
            MainStatusStrip.TabIndex = 2;
            MainStatusStrip.Text = "statusStrip1";
            // 
            // DayTimeStatusLabel
            // 
            DayTimeStatusLabel.BackColor = Color.Snow;
            DayTimeStatusLabel.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DayTimeStatusLabel.Name = "DayTimeStatusLabel";
            DayTimeStatusLabel.Size = new Size(87, 17);
            DayTimeStatusLabel.Text = "Дата и время";
            // 
            // CurrentTimeTimer
            // 
            CurrentTimeTimer.Interval = 1000;
            CurrentTimeTimer.Tick += CurrentTimeTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1021, 536);
            Controls.Add(MainStatusStrip);
            Controls.Add(MainMenuStrip);
            IsMdiContainer = true;
            Margin = new Padding(8);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Начальная страница";
            WindowState = FormWindowState.Maximized;
            FormClosed += MainForm1_FormClosed;
            Load += MainForm1_Load;
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            MainStatusStrip.ResumeLayout(false);
            MainStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenuStrip;
        private StatusStrip MainStatusStrip;
        private ToolStripMenuItem AuthorizationMenuItem;
        private ToolStripMenuItem RagistrationMenuItem;
        private ToolStripMenuItem ColorMenuItem;
        private ToolStripStatusLabel DayTimeStatusLabel;
        private System.Windows.Forms.Timer CurrentTimeTimer;
    }
}
