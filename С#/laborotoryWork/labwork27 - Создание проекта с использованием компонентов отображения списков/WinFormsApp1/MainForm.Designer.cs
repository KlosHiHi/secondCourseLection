namespace WinFormsApp1
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
            TicketButton = new Button();
            CourseButton = new Button();
            ListButton = new Button();
            SuspendLayout();
            // 
            // TicketButton
            // 
            TicketButton.BackColor = Color.PeachPuff;
            TicketButton.Location = new Point(121, 112);
            TicketButton.Name = "TicketButton";
            TicketButton.Size = new Size(148, 60);
            TicketButton.TabIndex = 0;
            TicketButton.Text = "Билеты";
            TicketButton.UseVisualStyleBackColor = false;
            TicketButton.Click += TicketButton_Click;
            // 
            // CourseButton
            // 
            CourseButton.BackColor = Color.PeachPuff;
            CourseButton.ForeColor = SystemColors.ActiveCaptionText;
            CourseButton.Location = new Point(121, 194);
            CourseButton.MaximumSize = new Size(148, 60);
            CourseButton.Name = "CourseButton";
            CourseButton.Size = new Size(148, 60);
            CourseButton.TabIndex = 1;
            CourseButton.Text = "Курсы";
            CourseButton.UseVisualStyleBackColor = false;
            CourseButton.Click += CourseButton_Click;
            // 
            // ListButton
            // 
            ListButton.BackColor = Color.PeachPuff;
            ListButton.Location = new Point(121, 279);
            ListButton.Name = "ListButton";
            ListButton.Size = new Size(148, 60);
            ListButton.TabIndex = 2;
            ListButton.Text = "Списки";
            ListButton.UseVisualStyleBackColor = false;
            ListButton.Click += ListButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(402, 450);
            Controls.Add(ListButton);
            Controls.Add(CourseButton);
            Controls.Add(TicketButton);
            MaximumSize = new Size(418, 489);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Начальная страница";
            ResumeLayout(false);
        }

        #endregion

        private Button TicketButton;
        private Button CourseButton;
        private Button ListButton;
    }
}
