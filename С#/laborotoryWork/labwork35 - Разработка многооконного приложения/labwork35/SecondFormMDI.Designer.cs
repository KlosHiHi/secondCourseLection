namespace labwork35
{
    partial class SecondFormMDI
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
            MDIMenuStrip = new MenuStrip();
            OpenFormMenuItem = new ToolStripMenuItem();
            IceCreamFormMenuItem = new ToolStripMenuItem();
            WatermelonFormMenuItem = new ToolStripMenuItem();
            CloseFormsMenuItem = new ToolStripMenuItem();
            BeachSitMenuItem = new ToolStripMenuItem();
            MDIMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MDIMenuStrip
            // 
            MDIMenuStrip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MDIMenuStrip.ImageScalingSize = new Size(20, 20);
            MDIMenuStrip.Items.AddRange(new ToolStripItem[] { OpenFormMenuItem });
            MDIMenuStrip.Location = new Point(0, 0);
            MDIMenuStrip.Name = "MDIMenuStrip";
            MDIMenuStrip.Size = new Size(1582, 36);
            MDIMenuStrip.TabIndex = 0;
            MDIMenuStrip.Text = "menuStrip1";
            // 
            // OpenFormMenuItem
            // 
            OpenFormMenuItem.DropDownItems.AddRange(new ToolStripItem[] { IceCreamFormMenuItem, WatermelonFormMenuItem, BeachSitMenuItem, CloseFormsMenuItem });
            OpenFormMenuItem.Name = "OpenFormMenuItem";
            OpenFormMenuItem.Size = new Size(170, 32);
            OpenFormMenuItem.Text = "Открыть форму";
            // 
            // IceCreamFormMenuItem
            // 
            IceCreamFormMenuItem.Name = "IceCreamFormMenuItem";
            IceCreamFormMenuItem.Size = new Size(329, 32);
            IceCreamFormMenuItem.Text = "Фургончик с рисоженым";
            IceCreamFormMenuItem.Click += IceCreamFormMenuItem_Click;
            // 
            // WatermelonFormMenuItem
            // 
            WatermelonFormMenuItem.Name = "WatermelonFormMenuItem";
            WatermelonFormMenuItem.Size = new Size(329, 32);
            WatermelonFormMenuItem.Text = "Разбей арбуз";
            WatermelonFormMenuItem.Click += WatermelonFormMenuItem_Click;
            // 
            // CloseFormsMenuItem
            // 
            CloseFormsMenuItem.Name = "CloseFormsMenuItem";
            CloseFormsMenuItem.Size = new Size(329, 32);
            CloseFormsMenuItem.Text = "Закрыть формы";
            CloseFormsMenuItem.Click += CloseFormsMenuItem_Click;
            // 
            // BeachSitMenuItem
            // 
            BeachSitMenuItem.Name = "BeachSitMenuItem";
            BeachSitMenuItem.Size = new Size(329, 32);
            BeachSitMenuItem.Text = "Посиделки на пляже";
            BeachSitMenuItem.Click += BeachSitMenuItem_Click;
            // 
            // SecondFormMDI
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1582, 853);
            Controls.Add(MDIMenuStrip);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            IsMdiContainer = true;
            MainMenuStrip = MDIMenuStrip;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(900, 600);
            Name = "SecondFormMDI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MDI-форма";
            MDIMenuStrip.ResumeLayout(false);
            MDIMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MDIMenuStrip;
        private ToolStripMenuItem OpenFormMenuItem;
        private ToolStripMenuItem IceCreamFormMenuItem;
        private ToolStripMenuItem WatermelonFormMenuItem;
        private ToolStripMenuItem CloseFormsMenuItem;
        private ToolStripMenuItem BeachSitMenuItem;
    }
}