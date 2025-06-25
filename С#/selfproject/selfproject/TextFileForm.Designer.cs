namespace selfproject
{
    partial class TextFileForm
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
            TextFormMenuStrip = new MenuStrip();
            FileParentMenuItem = new ToolStripMenuItem();
            CreateFChildMenuItem = new ToolStripMenuItem();
            SaveFChildMenuItem = new ToolStripMenuItem();
            OpenFChildMenuItem = new ToolStripMenuItem();
            CloseFChildMenuItem = new ToolStripMenuItem();
            SettingsParentMenuItem = new ToolStripMenuItem();
            FontChildMenuItem = new ToolStripMenuItem();
            FileNameChildMenuItem = new ToolStripMenuItem();
            ForeColorChildMenuItem = new ToolStripMenuItem();
            DefPathForSaveFChildMenuItem = new ToolStripMenuItem();
            TextFormStatusStrip = new StatusStrip();
            AmountOfCharStatusLabel = new ToolStripStatusLabel();
            AmountOfCharWitoutSpaceStatusLabel = new ToolStripStatusLabel();
            TextFormRichTextBox = new RichTextBox();
            SettingContextMenu = new ContextMenuStrip(components);
            FontContextMenuItem = new ToolStripMenuItem();
            ForeColorContextMenuItem = new ToolStripMenuItem();
            TextFormSaveFileDialog = new SaveFileDialog();
            TextFormOpenFileDialog = new OpenFileDialog();
            TextFormFolderDialog = new FolderBrowserDialog();
            TextFormFontDialog = new FontDialog();
            TextFormColorDialog = new ColorDialog();
            ChangeFileNameUserControl = new ChangeFileNameUserControl();
            TextFormMenuStrip.SuspendLayout();
            TextFormStatusStrip.SuspendLayout();
            SettingContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // TextFormMenuStrip
            // 
            TextFormMenuStrip.BackColor = Color.PaleVioletRed;
            TextFormMenuStrip.ImageScalingSize = new Size(20, 20);
            TextFormMenuStrip.Items.AddRange(new ToolStripItem[] { FileParentMenuItem, SettingsParentMenuItem });
            TextFormMenuStrip.Location = new Point(0, 0);
            TextFormMenuStrip.Name = "TextFormMenuStrip";
            TextFormMenuStrip.Padding = new Padding(8, 2, 0, 2);
            TextFormMenuStrip.Size = new Size(882, 28);
            TextFormMenuStrip.TabIndex = 0;
            TextFormMenuStrip.Text = "menuStrip1";
            // 
            // FileParentMenuItem
            // 
            FileParentMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateFChildMenuItem, SaveFChildMenuItem, OpenFChildMenuItem, CloseFChildMenuItem });
            FileParentMenuItem.Name = "FileParentMenuItem";
            FileParentMenuItem.Size = new Size(59, 24);
            FileParentMenuItem.Text = "Файл";
            // 
            // CreateFChildMenuItem
            // 
            CreateFChildMenuItem.BackColor = Color.Pink;
            CreateFChildMenuItem.Name = "CreateFChildMenuItem";
            CreateFChildMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            CreateFChildMenuItem.Size = new Size(224, 26);
            CreateFChildMenuItem.Text = "Создать";
            CreateFChildMenuItem.Click += CreateFChildMenuItem_Click;
            // 
            // SaveFChildMenuItem
            // 
            SaveFChildMenuItem.BackColor = Color.Pink;
            SaveFChildMenuItem.Name = "SaveFChildMenuItem";
            SaveFChildMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveFChildMenuItem.Size = new Size(224, 26);
            SaveFChildMenuItem.Text = "Сохранить";
            SaveFChildMenuItem.Click += SaveFChildMenuItem_Click;
            // 
            // OpenFChildMenuItem
            // 
            OpenFChildMenuItem.BackColor = Color.Pink;
            OpenFChildMenuItem.Name = "OpenFChildMenuItem";
            OpenFChildMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            OpenFChildMenuItem.Size = new Size(224, 26);
            OpenFChildMenuItem.Text = "Открыть";
            OpenFChildMenuItem.Click += OpenFChildMenuItem_Click;
            // 
            // CloseFChildMenuItem
            // 
            CloseFChildMenuItem.BackColor = Color.Pink;
            CloseFChildMenuItem.Name = "CloseFChildMenuItem";
            CloseFChildMenuItem.Size = new Size(224, 26);
            CloseFChildMenuItem.Text = "Закрыть";
            CloseFChildMenuItem.Click += CloseFChildMenuItem_Click;
            // 
            // SettingsParentMenuItem
            // 
            SettingsParentMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FontChildMenuItem, FileNameChildMenuItem, ForeColorChildMenuItem, DefPathForSaveFChildMenuItem });
            SettingsParentMenuItem.ForeColor = Color.Black;
            SettingsParentMenuItem.Name = "SettingsParentMenuItem";
            SettingsParentMenuItem.Size = new Size(98, 24);
            SettingsParentMenuItem.Text = "Настройки";
            // 
            // FontChildMenuItem
            // 
            FontChildMenuItem.BackColor = Color.Pink;
            FontChildMenuItem.Name = "FontChildMenuItem";
            FontChildMenuItem.Size = new Size(224, 26);
            FontChildMenuItem.Text = "Шрифт";
            FontChildMenuItem.Click += FontChildMenuItem_Click;
            // 
            // FileNameChildMenuItem
            // 
            FileNameChildMenuItem.BackColor = Color.Pink;
            FileNameChildMenuItem.Name = "FileNameChildMenuItem";
            FileNameChildMenuItem.Size = new Size(224, 26);
            FileNameChildMenuItem.Text = "Название";
            FileNameChildMenuItem.Click += FileNameChildMenuItem_Click;
            // 
            // ForeColorChildMenuItem
            // 
            ForeColorChildMenuItem.BackColor = Color.Pink;
            ForeColorChildMenuItem.Name = "ForeColorChildMenuItem";
            ForeColorChildMenuItem.Size = new Size(224, 26);
            ForeColorChildMenuItem.Text = "Цвет текста";
            ForeColorChildMenuItem.Click += ForeColorChildMenuItem_Click;
            // 
            // DefPathForSaveFChildMenuItem
            // 
            DefPathForSaveFChildMenuItem.BackColor = Color.Pink;
            DefPathForSaveFChildMenuItem.Name = "DefPathForSaveFChildMenuItem";
            DefPathForSaveFChildMenuItem.Size = new Size(224, 26);
            DefPathForSaveFChildMenuItem.Text = "Путь сохранения";
            DefPathForSaveFChildMenuItem.Click += DefPathForSaveFChildMenuItem_Click;
            // 
            // TextFormStatusStrip
            // 
            TextFormStatusStrip.BackColor = Color.White;
            TextFormStatusStrip.ImageScalingSize = new Size(20, 20);
            TextFormStatusStrip.Items.AddRange(new ToolStripItem[] { AmountOfCharStatusLabel, AmountOfCharWitoutSpaceStatusLabel });
            TextFormStatusStrip.Location = new Point(0, 619);
            TextFormStatusStrip.Name = "TextFormStatusStrip";
            TextFormStatusStrip.Padding = new Padding(1, 0, 18, 0);
            TextFormStatusStrip.Size = new Size(882, 34);
            TextFormStatusStrip.TabIndex = 1;
            // 
            // AmountOfCharStatusLabel
            // 
            AmountOfCharStatusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AmountOfCharStatusLabel.ForeColor = Color.DeepPink;
            AmountOfCharStatusLabel.Name = "AmountOfCharStatusLabel";
            AmountOfCharStatusLabel.Size = new Size(98, 28);
            AmountOfCharStatusLabel.Text = "Символы";
            // 
            // AmountOfCharWitoutSpaceStatusLabel
            // 
            AmountOfCharWitoutSpaceStatusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AmountOfCharWitoutSpaceStatusLabel.ForeColor = Color.DeepPink;
            AmountOfCharWitoutSpaceStatusLabel.Name = "AmountOfCharWitoutSpaceStatusLabel";
            AmountOfCharWitoutSpaceStatusLabel.Size = new Size(243, 28);
            AmountOfCharWitoutSpaceStatusLabel.Text = "Символы (без пробелов)";
            AmountOfCharWitoutSpaceStatusLabel.TextAlign = ContentAlignment.MiddleRight;
            AmountOfCharWitoutSpaceStatusLabel.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // TextFormRichTextBox
            // 
            TextFormRichTextBox.ContextMenuStrip = SettingContextMenu;
            TextFormRichTextBox.Dock = DockStyle.Fill;
            TextFormRichTextBox.Location = new Point(0, 28);
            TextFormRichTextBox.Name = "TextFormRichTextBox";
            TextFormRichTextBox.Size = new Size(882, 591);
            TextFormRichTextBox.TabIndex = 2;
            TextFormRichTextBox.Text = "";
            TextFormRichTextBox.TextChanged += TextFormRichTextBox_TextChanged;
            // 
            // SettingContextMenu
            // 
            SettingContextMenu.ImageScalingSize = new Size(20, 20);
            SettingContextMenu.Items.AddRange(new ToolStripItem[] { FontContextMenuItem, ForeColorContextMenuItem });
            SettingContextMenu.Name = "FileNameContextMenu";
            SettingContextMenu.Size = new Size(158, 52);
            SettingContextMenu.Text = "s";
            // 
            // FontContextMenuItem
            // 
            FontContextMenuItem.Name = "FontContextMenuItem";
            FontContextMenuItem.Size = new Size(157, 24);
            FontContextMenuItem.Text = "Шрифты";
            FontContextMenuItem.Click += FontContextMenuItem_Click;
            // 
            // ForeColorContextMenuItem
            // 
            ForeColorContextMenuItem.Name = "ForeColorContextMenuItem";
            ForeColorContextMenuItem.Size = new Size(157, 24);
            ForeColorContextMenuItem.Text = "Цвет текста";
            ForeColorContextMenuItem.Click += ForeColorContextMenuItem_Click;
            // 
            // TextFormSaveFileDialog
            // 
            TextFormSaveFileDialog.FileName = "text.txt";
            TextFormSaveFileDialog.Filter = "Текстовый файл|*.txt|Файл rtf|*.rtf";
            TextFormSaveFileDialog.InitialDirectory = "C:\\\\QOPTex\\\\";
            // 
            // TextFormOpenFileDialog
            // 
            TextFormOpenFileDialog.Filter = "Текстовый файл|*.txt|Файл rtf|*.rtf|Все файлы|*.*";
            TextFormOpenFileDialog.InitialDirectory = "C:\\\\QOPTex\\\\";
            // 
            // ChangeFileNameUserControl
            // 
            ChangeFileNameUserControl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ChangeFileNameUserControl.BackColor = Color.PaleVioletRed;
            ChangeFileNameUserControl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChangeFileNameUserControl.ForeColor = Color.Black;
            ChangeFileNameUserControl.Location = new Point(602, 31);
            ChangeFileNameUserControl.MaximumSize = new Size(280, 115);
            ChangeFileNameUserControl.MinimumSize = new Size(280, 110);
            ChangeFileNameUserControl.Name = "ChangeFileNameUserControl";
            ChangeFileNameUserControl.Size = new Size(280, 115);
            ChangeFileNameUserControl.TabIndex = 3;
            ChangeFileNameUserControl.Visible = false;
            // 
            // TextFileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 653);
            Controls.Add(ChangeFileNameUserControl);
            Controls.Add(TextFormRichTextBox);
            Controls.Add(TextFormStatusStrip);
            Controls.Add(TextFormMenuStrip);
            MainMenuStrip = TextFormMenuStrip;
            Margin = new Padding(5);
            MinimumSize = new Size(500, 500);
            Name = "TextFileForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Черновик";
            FormClosed += TextFileForm_FormClosed;
            TextFormMenuStrip.ResumeLayout(false);
            TextFormMenuStrip.PerformLayout();
            TextFormStatusStrip.ResumeLayout(false);
            TextFormStatusStrip.PerformLayout();
            SettingContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip TextFormMenuStrip;
        private StatusStrip TextFormStatusStrip;
        private RichTextBox TextFormRichTextBox;
        private ToolStripMenuItem FileParentMenuItem;
        private ToolStripMenuItem CreateFChildMenuItem;
        private ToolStripMenuItem SaveFChildMenuItem;
        private ToolStripMenuItem OpenFChildMenuItem;
        private ToolStripMenuItem CloseFChildMenuItem;
        private ToolStripMenuItem SettingsParentMenuItem;
        private ToolStripMenuItem FontChildMenuItem;
        private ToolStripMenuItem ForeColorChildMenuItem;
        private ToolStripMenuItem DefPathForSaveFChildMenuItem;
        private SaveFileDialog TextFormSaveFileDialog;
        private OpenFileDialog TextFormOpenFileDialog;
        private FolderBrowserDialog TextFormFolderDialog;
        private FontDialog TextFormFontDialog;
        private ColorDialog TextFormColorDialog;
        private ToolStripMenuItem FileNameChildMenuItem;
        private ContextMenuStrip SettingContextMenu;
        private ToolStripMenuItem ForeColorContextMenuItem;
        private ToolStripMenuItem FontContextMenuItem;
        private ChangeFileNameUserControl ChangeFileNameUserControl;
        private ToolStripStatusLabel AmountOfCharStatusLabel;
        private ToolStripStatusLabel AmountOfCharWitoutSpaceStatusLabel;
    }
}