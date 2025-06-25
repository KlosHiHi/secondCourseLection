namespace labwork30
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
            MainFormMenuStrip = new MenuStrip();
            FileParentMenuItem = new ToolStripMenuItem();
            CreateChildMenuItem = new ToolStripMenuItem();
            OpenChildMenuItem = new ToolStripMenuItem();
            SaveChildMenuItem = new ToolStripMenuItem();
            CloseChildMenuItem = new ToolStripMenuItem();
            ViewParentMenuItem = new ToolStripMenuItem();
            NigthThemeChildMenuItem = new ToolStripMenuItem();
            ToStrangeFormMenuItem = new ToolStripMenuItem();
            MainRichTextBox = new RichTextBox();
            MainOpenFileDialog = new OpenFileDialog();
            MainSaveFileDialog = new SaveFileDialog();
            MainFormMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainFormMenuStrip
            // 
            MainFormMenuStrip.BackColor = Color.White;
            MainFormMenuStrip.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainFormMenuStrip.Items.AddRange(new ToolStripItem[] { FileParentMenuItem, ViewParentMenuItem, ToStrangeFormMenuItem });
            MainFormMenuStrip.Location = new Point(0, 0);
            MainFormMenuStrip.Name = "MainFormMenuStrip";
            MainFormMenuStrip.Size = new Size(664, 25);
            MainFormMenuStrip.TabIndex = 0;
            MainFormMenuStrip.Text = "menuStrip1";
            // 
            // FileParentMenuItem
            // 
            FileParentMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateChildMenuItem, OpenChildMenuItem, SaveChildMenuItem, CloseChildMenuItem });
            FileParentMenuItem.Name = "FileParentMenuItem";
            FileParentMenuItem.Size = new Size(50, 21);
            FileParentMenuItem.Text = "Файл";
            // 
            // CreateChildMenuItem
            // 
            CreateChildMenuItem.Name = "CreateChildMenuItem";
            CreateChildMenuItem.Size = new Size(139, 22);
            CreateChildMenuItem.Text = "Создать";
            CreateChildMenuItem.Click += CreateChildMenuItem_Click;
            // 
            // OpenChildMenuItem
            // 
            OpenChildMenuItem.Name = "OpenChildMenuItem";
            OpenChildMenuItem.Size = new Size(139, 22);
            OpenChildMenuItem.Text = "Открыть";
            OpenChildMenuItem.Click += OpenChildMenuItem_Click;
            // 
            // SaveChildMenuItem
            // 
            SaveChildMenuItem.Name = "SaveChildMenuItem";
            SaveChildMenuItem.Size = new Size(139, 22);
            SaveChildMenuItem.Text = "Сохранить";
            SaveChildMenuItem.Click += SaveChildMenuItem_Click;
            // 
            // CloseChildMenuItem
            // 
            CloseChildMenuItem.Name = "CloseChildMenuItem";
            CloseChildMenuItem.Size = new Size(139, 22);
            CloseChildMenuItem.Text = "Закрыть";
            CloseChildMenuItem.Click += CloseChildMenuItem_Click;
            // 
            // ViewParentMenuItem
            // 
            ViewParentMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NigthThemeChildMenuItem });
            ViewParentMenuItem.Name = "ViewParentMenuItem";
            ViewParentMenuItem.Size = new Size(41, 21);
            ViewParentMenuItem.Text = "Вид";
            // 
            // NigthThemeChildMenuItem
            // 
            NigthThemeChildMenuItem.CheckOnClick = true;
            NigthThemeChildMenuItem.Name = "NigthThemeChildMenuItem";
            NigthThemeChildMenuItem.Size = new Size(180, 22);
            NigthThemeChildMenuItem.Text = "Ночная тема";
            NigthThemeChildMenuItem.Click += NigthThemeChildMenuItem_Click;
            // 
            // ToStrangeFormMenuItem
            // 
            ToStrangeFormMenuItem.Name = "ToStrangeFormMenuItem";
            ToStrangeFormMenuItem.Size = new Size(121, 21);
            ToStrangeFormMenuItem.Text = "Странная форма";
            ToStrangeFormMenuItem.Click += ToStrangeFormMenuItem_Click;
            // 
            // MainRichTextBox
            // 
            MainRichTextBox.BackColor = Color.OldLace;
            MainRichTextBox.Dock = DockStyle.Fill;
            MainRichTextBox.Location = new Point(0, 25);
            MainRichTextBox.Name = "MainRichTextBox";
            MainRichTextBox.Size = new Size(664, 456);
            MainRichTextBox.TabIndex = 1;
            MainRichTextBox.Text = "";
            // 
            // MainOpenFileDialog
            // 
            MainOpenFileDialog.FileName = "text.txt";
            MainOpenFileDialog.Filter = "Текстовый файл|*.txt|Текстовый файл формата rtf|*.rtf";
            // 
            // MainSaveFileDialog
            // 
            MainSaveFileDialog.DefaultExt = "txt";
            MainSaveFileDialog.Filter = "Текстовый файл|*.txt|Текстовый файл формата rtf|*.rtf";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 481);
            Controls.Add(MainRichTextBox);
            Controls.Add(MainFormMenuStrip);
            MainMenuStrip = MainFormMenuStrip;
            MinimumSize = new Size(400, 300);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная";
            MainFormMenuStrip.ResumeLayout(false);
            MainFormMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainFormMenuStrip;
        private ToolStripMenuItem FileParentMenuItem;
        private ToolStripMenuItem CreateChildMenuItem;
        private ToolStripMenuItem OpenChildMenuItem;
        private ToolStripMenuItem SaveChildMenuItem;
        private ToolStripMenuItem CloseChildMenuItem;
        private RichTextBox MainRichTextBox;
        private OpenFileDialog MainOpenFileDialog;
        private SaveFileDialog MainSaveFileDialog;
        private ToolStripMenuItem ViewParentMenuItem;
        private ToolStripMenuItem NigthThemeChildMenuItem;
        private ToolStripMenuItem ToStrangeFormMenuItem;
    }
}
