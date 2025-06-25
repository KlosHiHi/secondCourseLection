namespace WinFormsApp
{
    partial class TemplateForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateForm));
            timer = new System.Windows.Forms.Timer(components);
            timeLabel = new Label();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Dock = DockStyle.Bottom;
            timeLabel.Font = new Font("SimSun", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            timeLabel.Location = new Point(0, 323);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(15, 13);
            timeLabel.TabIndex = 0;
            timeLabel.Text = "a";
            timeLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // TemplateForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(578, 336);
            Controls.Add(timeLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.GrayText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "TemplateForm";
            Text = " ";
            Load += TemplateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private Label timeLabel;
    }
}