namespace labwork37
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
            FieldPanel = new Panel();
            WinLabel = new Label();
            ContestLabel = new Label();
            LostBallLabel = new Label();
            ScoreLabel = new Label();
            GameFrameTimer = new System.Windows.Forms.Timer(components);
            FieldPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FieldPanel
            // 
            FieldPanel.Controls.Add(WinLabel);
            FieldPanel.Controls.Add(ContestLabel);
            FieldPanel.Controls.Add(LostBallLabel);
            FieldPanel.Controls.Add(ScoreLabel);
            FieldPanel.Cursor = Cursors.Cross;
            FieldPanel.Dock = DockStyle.Fill;
            FieldPanel.ForeColor = Color.White;
            FieldPanel.Location = new Point(0, 0);
            FieldPanel.Name = "FieldPanel";
            FieldPanel.Size = new Size(894, 611);
            FieldPanel.TabIndex = 0;
            // 
            // WinLabel
            // 
            WinLabel.AutoSize = true;
            WinLabel.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WinLabel.Location = new Point(84, 84);
            WinLabel.Name = "WinLabel";
            WinLabel.Size = new Size(730, 128);
            WinLabel.TabIndex = 3;
            WinLabel.Text = "ВЫ ПОБЕДИЛИ";
            // 
            // ContestLabel
            // 
            ContestLabel.AutoSize = true;
            ContestLabel.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ContestLabel.Location = new Point(272, 260);
            ContestLabel.Name = "ContestLabel";
            ContestLabel.Size = new Size(352, 128);
            ContestLabel.TabIndex = 2;
            ContestLabel.Text = "ПАУЗА";
            // 
            // LostBallLabel
            // 
            LostBallLabel.AutoSize = true;
            LostBallLabel.ForeColor = Color.White;
            LostBallLabel.Location = new Point(12, 9);
            LostBallLabel.Name = "LostBallLabel";
            LostBallLabel.Size = new Size(88, 19);
            LostBallLabel.TabIndex = 1;
            LostBallLabel.Text = "ПОТЕРЯНО: ";
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.ForeColor = Color.White;
            ScoreLabel.Location = new Point(12, 32);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(48, 19);
            ScoreLabel.TabIndex = 0;
            ScoreLabel.Text = "СЧЁТ: ";
            // 
            // GameFrameTimer
            // 
            GameFrameTimer.Interval = 10;
            GameFrameTimer.Tick += GameFrameTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(894, 611);
            Controls.Add(FieldPanel);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyPreview = true;
            MaximumSize = new Size(910, 650);
            MinimumSize = new Size(910, 650);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game of the Year";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            FieldPanel.ResumeLayout(false);
            FieldPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel FieldPanel;
        private Label ScoreLabel;
        private Label LostBallLabel;
        private System.Windows.Forms.Timer GameFrameTimer;
        private Label ContestLabel;
        private Label WinLabel;
    }
}
