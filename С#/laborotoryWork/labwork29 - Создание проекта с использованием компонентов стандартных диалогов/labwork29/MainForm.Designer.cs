namespace labwork29
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
            MainMenuStrip = new MenuStrip();
            afFileMenuItem = new ToolStripMenuItem();
            OpenFileMenuItem = new ToolStripMenuItem();
            SaveFileMenuItem = new ToolStripMenuItem();
            SettingsMenuItem = new ToolStripMenuItem();
            ChangeColorMenuItem = new ToolStripMenuItem();
            ChangeFontMenuItem = new ToolStripMenuItem();
            DefaultFolderMenuItem = new ToolStripMenuItem();
            TextFileRichTextBox = new RichTextBox();
            MainOpenFileDialog = new OpenFileDialog();
            MainSaveFileDialog = new SaveFileDialog();
            MainColorDialog = new ColorDialog();
            MainFontDialog = new FontDialog();
            MainFolderBrowserDialog = new FolderBrowserDialog();
            MainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.BackColor = Color.NavajoWhite;
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { afFileMenuItem, SettingsMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(434, 24);
            MainMenuStrip.TabIndex = 0;
            MainMenuStrip.Text = "menuStrip1";
            // 
            // afFileMenuItem
            // 
            afFileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenFileMenuItem, SaveFileMenuItem });
            afFileMenuItem.Name = "afFileMenuItem";
            afFileMenuItem.Size = new Size(48, 20);
            afFileMenuItem.Text = "Файл";
            // 
            // OpenFileMenuItem
            // 
            OpenFileMenuItem.BackColor = SystemColors.Control;
            OpenFileMenuItem.Name = "OpenFileMenuItem";
            OpenFileMenuItem.Size = new Size(133, 22);
            OpenFileMenuItem.Text = "Открыть";
            OpenFileMenuItem.Click += OpenFileMenuItem_Click;
            // 
            // SaveFileMenuItem
            // 
            SaveFileMenuItem.BackColor = SystemColors.Control;
            SaveFileMenuItem.Name = "SaveFileMenuItem";
            SaveFileMenuItem.Size = new Size(133, 22);
            SaveFileMenuItem.Text = "Сохранить";
            SaveFileMenuItem.Click += SaveFileMenuItem_Click;
            // 
            // SettingsMenuItem
            // 
            SettingsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ChangeColorMenuItem, ChangeFontMenuItem, DefaultFolderMenuItem });
            SettingsMenuItem.Name = "SettingsMenuItem";
            SettingsMenuItem.Size = new Size(79, 20);
            SettingsMenuItem.Text = "Настройки";
            // 
            // ChangeColorMenuItem
            // 
            ChangeColorMenuItem.Name = "ChangeColorMenuItem";
            ChangeColorMenuItem.Size = new Size(194, 22);
            ChangeColorMenuItem.Text = "Цвет";
            ChangeColorMenuItem.Click += ChangeColorMenuItem_Click;
            // 
            // ChangeFontMenuItem
            // 
            ChangeFontMenuItem.Name = "ChangeFontMenuItem";
            ChangeFontMenuItem.Size = new Size(194, 22);
            ChangeFontMenuItem.Text = "Шрифт";
            ChangeFontMenuItem.Click += ChangeFontMenuItem_Click;
            // 
            // DefaultFolderMenuItem
            // 
            DefaultFolderMenuItem.Name = "DefaultFolderMenuItem";
            DefaultFolderMenuItem.Size = new Size(194, 22);
            DefaultFolderMenuItem.Text = "Папка по умолчанию";
            DefaultFolderMenuItem.Click += DefaultFolderMenuItem_Click;
            // 
            // TextFileRichTextBox
            // 
            TextFileRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextFileRichTextBox.BackColor = Color.Snow;
            TextFileRichTextBox.Location = new Point(0, 27);
            TextFileRichTextBox.Name = "TextFileRichTextBox";
            TextFileRichTextBox.Size = new Size(432, 422);
            TextFileRichTextBox.TabIndex = 1;
            TextFileRichTextBox.Text = "";
            // 
            // MainOpenFileDialog
            // 
            MainOpenFileDialog.Filter = "Текстовые файлы|*.txt|Текст в формате|*.rtf|Все файлы|*.*";
            // 
            // MainSaveFileDialog
            // 
            MainSaveFileDialog.FileName = "text.txt";
            MainSaveFileDialog.Filter = "Текстовые файлы|*.txt|Текст в формате|*.rtf";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 451);
            Controls.Add(TextFileRichTextBox);
            Controls.Add(MainMenuStrip);
            MinimumSize = new Size(450, 490);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Работа с текстом";
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem afFileMenuItem;
        private ToolStripMenuItem OpenFileMenuItem;
        private RichTextBox TextFileRichTextBox;
        private OpenFileDialog MainOpenFileDialog;
        private ToolStripMenuItem SaveFileMenuItem;
        private SaveFileDialog MainSaveFileDialog;
        private ToolStripMenuItem SettingsMenuItem;
        private ToolStripMenuItem ChangeColorMenuItem;
        private ToolStripMenuItem ChangeFontMenuItem;
        private ColorDialog MainColorDialog;
        private FontDialog MainFontDialog;
        private ToolStripMenuItem DefaultFolderMenuItem;
        private FolderBrowserDialog MainFolderBrowserDialog;
    }
}
