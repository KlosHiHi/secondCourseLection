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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainFormMenuStrip = new MenuStrip();
            FileParentMenuItem = new ToolStripMenuItem();
            CreateChildMenuItem = new ToolStripMenuItem();
            OpenChildMenuItem = new ToolStripMenuItem();
            SaveChildMenuItem = new ToolStripMenuItem();
            CloseChildMenuItem = new ToolStripMenuItem();
            ViewParentMenuItem = new ToolStripMenuItem();
            NigthThemeChildMenuItem = new ToolStripMenuItem();
            FormattingMenuItem = new ToolStripMenuItem();
            SettingsContextMenuStrip = new ContextMenuStrip(components);
            ColorStripMenuItem = new ToolStripMenuItem();
            FontStripMenuItem = new ToolStripMenuItem();
            MainRichTextBox = new RichTextBox();
            MainOpenFileDialog = new OpenFileDialog();
            MainSaveFileDialog = new SaveFileDialog();
            MainFontDialog = new FontDialog();
            MainColorDialog = new ColorDialog();
            TextSettingsToolStrip = new ToolStrip();
            TSToolStripListOfFont = new ToolStripComboBox();
            ChangeFontButtonTwo = new ToolStripButton();
            TSToolStripChangeFont = new ToolStripTextBox();
            ChangeFontButton = new ToolStripButton();
            ToolStripButtonLeftSide = new ToolStripButton();
            ToolStripButtonMiddel = new ToolStripButton();
            ToolStripButtonRigthSide = new ToolStripButton();
            StatusLabelTimeNow = new ToolStripStatusLabel();
            MainStatusStrip = new StatusStrip();
            StatusLabelQuantityOfCharEmpty = new ToolStripStatusLabel();
            StatusLabelQuantityOfChar = new ToolStripStatusLabel();
            TimeTimer = new System.Windows.Forms.Timer(components);
            MainFormMenuStrip.SuspendLayout();
            SettingsContextMenuStrip.SuspendLayout();
            TextSettingsToolStrip.SuspendLayout();
            MainStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainFormMenuStrip
            // 
            MainFormMenuStrip.BackColor = Color.White;
            MainFormMenuStrip.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainFormMenuStrip.Items.AddRange(new ToolStripItem[] { FileParentMenuItem, ViewParentMenuItem, FormattingMenuItem });
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
            CreateChildMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            CreateChildMenuItem.Size = new Size(183, 22);
            CreateChildMenuItem.Text = "Создать";
            CreateChildMenuItem.Click += CreateChildMenuItem_Click;
            // 
            // OpenChildMenuItem
            // 
            OpenChildMenuItem.Name = "OpenChildMenuItem";
            OpenChildMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            OpenChildMenuItem.Size = new Size(183, 22);
            OpenChildMenuItem.Text = "Открыть";
            OpenChildMenuItem.Click += OpenChildMenuItem_Click;
            // 
            // SaveChildMenuItem
            // 
            SaveChildMenuItem.Name = "SaveChildMenuItem";
            SaveChildMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveChildMenuItem.Size = new Size(183, 22);
            SaveChildMenuItem.Text = "Сохранить";
            SaveChildMenuItem.Click += SaveChildMenuItem_Click;
            // 
            // CloseChildMenuItem
            // 
            CloseChildMenuItem.Name = "CloseChildMenuItem";
            CloseChildMenuItem.Size = new Size(183, 22);
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
            NigthThemeChildMenuItem.Size = new Size(153, 22);
            NigthThemeChildMenuItem.Text = "Ночная тема";
            NigthThemeChildMenuItem.Click += NigthThemeChildMenuItem_Click;
            // 
            // FormattingMenuItem
            // 
            FormattingMenuItem.DropDown = SettingsContextMenuStrip;
            FormattingMenuItem.Name = "FormattingMenuItem";
            FormattingMenuItem.Size = new Size(124, 21);
            FormattingMenuItem.Text = "Форматирование";
            // 
            // SettingsContextMenuStrip
            // 
            SettingsContextMenuStrip.ImeMode = ImeMode.NoControl;
            SettingsContextMenuStrip.Items.AddRange(new ToolStripItem[] { ColorStripMenuItem, FontStripMenuItem });
            SettingsContextMenuStrip.Name = "contextMenuStrip1";
            SettingsContextMenuStrip.OwnerItem = FormattingMenuItem;
            SettingsContextMenuStrip.ShowImageMargin = false;
            SettingsContextMenuStrip.Size = new Size(89, 48);
            SettingsContextMenuStrip.Text = "Настройки";
            // 
            // ColorStripMenuItem
            // 
            ColorStripMenuItem.Name = "ColorStripMenuItem";
            ColorStripMenuItem.Size = new Size(88, 22);
            ColorStripMenuItem.Text = "Цвет";
            ColorStripMenuItem.Click += ColorStripMenuItem_Click;
            // 
            // FontStripMenuItem
            // 
            FontStripMenuItem.Name = "FontStripMenuItem";
            FontStripMenuItem.Size = new Size(88, 22);
            FontStripMenuItem.Text = "Шрифт";
            FontStripMenuItem.Click += FontStripMenuItem_Click;
            // 
            // MainRichTextBox
            // 
            MainRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainRichTextBox.BackColor = Color.OldLace;
            MainRichTextBox.ContextMenuStrip = SettingsContextMenuStrip;
            MainRichTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainRichTextBox.Location = new Point(0, 53);
            MainRichTextBox.Name = "MainRichTextBox";
            MainRichTextBox.Size = new Size(664, 428);
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
            // TextSettingsToolStrip
            // 
            TextSettingsToolStrip.BackColor = Color.White;
            TextSettingsToolStrip.Items.AddRange(new ToolStripItem[] { TSToolStripListOfFont, ChangeFontButtonTwo, TSToolStripChangeFont, ChangeFontButton, ToolStripButtonLeftSide, ToolStripButtonMiddel, ToolStripButtonRigthSide });
            TextSettingsToolStrip.Location = new Point(0, 25);
            TextSettingsToolStrip.Name = "TextSettingsToolStrip";
            TextSettingsToolStrip.Size = new Size(664, 25);
            TextSettingsToolStrip.TabIndex = 2;
            // 
            // TSToolStripListOfFont
            // 
            TSToolStripListOfFont.Name = "TSToolStripListOfFont";
            TSToolStripListOfFont.Size = new Size(121, 25);
            // 
            // ChangeFontButtonTwo
            // 
            ChangeFontButtonTwo.BackColor = Color.Lime;
            ChangeFontButtonTwo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ChangeFontButtonTwo.ForeColor = SystemColors.ControlText;
            ChangeFontButtonTwo.Image = (Image)resources.GetObject("ChangeFontButtonTwo.Image");
            ChangeFontButtonTwo.ImageTransparentColor = Color.Magenta;
            ChangeFontButtonTwo.Name = "ChangeFontButtonTwo";
            ChangeFontButtonTwo.Size = new Size(23, 22);
            ChangeFontButtonTwo.Text = "✔";
            ChangeFontButtonTwo.Click += ChangeFontButtonTwo_Click;
            // 
            // TSToolStripChangeFont
            // 
            TSToolStripChangeFont.Name = "TSToolStripChangeFont";
            TSToolStripChangeFont.Size = new Size(100, 25);
            // 
            // ChangeFontButton
            // 
            ChangeFontButton.BackColor = Color.Lime;
            ChangeFontButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ChangeFontButton.ImageTransparentColor = Color.Magenta;
            ChangeFontButton.Name = "ChangeFontButton";
            ChangeFontButton.Size = new Size(23, 22);
            ChangeFontButton.Text = "✔";
            ChangeFontButton.Click += ChangeFontButton_Click;
            // 
            // ToolStripButtonLeftSide
            // 
            ToolStripButtonLeftSide.Checked = true;
            ToolStripButtonLeftSide.CheckOnClick = true;
            ToolStripButtonLeftSide.CheckState = CheckState.Checked;
            ToolStripButtonLeftSide.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripButtonLeftSide.ImageTransparentColor = Color.Magenta;
            ToolStripButtonLeftSide.Name = "ToolStripButtonLeftSide";
            ToolStripButtonLeftSide.Size = new Size(103, 22);
            ToolStripButtonLeftSide.Text = "По левому краю";
            // 
            // ToolStripButtonMiddel
            // 
            ToolStripButtonMiddel.CheckOnClick = true;
            ToolStripButtonMiddel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripButtonMiddel.Image = (Image)resources.GetObject("ToolStripButtonMiddel.Image");
            ToolStripButtonMiddel.ImageTransparentColor = Color.Magenta;
            ToolStripButtonMiddel.Name = "ToolStripButtonMiddel";
            ToolStripButtonMiddel.Size = new Size(68, 22);
            ToolStripButtonMiddel.Text = "По центру";
            // 
            // ToolStripButtonRigthSide
            // 
            ToolStripButtonRigthSide.CheckOnClick = true;
            ToolStripButtonRigthSide.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripButtonRigthSide.Image = (Image)resources.GetObject("ToolStripButtonRigthSide.Image");
            ToolStripButtonRigthSide.ImageTransparentColor = Color.Magenta;
            ToolStripButtonRigthSide.Name = "ToolStripButtonRigthSide";
            ToolStripButtonRigthSide.RightToLeftAutoMirrorImage = true;
            ToolStripButtonRigthSide.Size = new Size(110, 22);
            ToolStripButtonRigthSide.Text = "По правому краю";
            // 
            // StatusLabelTimeNow
            // 
            StatusLabelTimeNow.Name = "StatusLabelTimeNow";
            StatusLabelTimeNow.Size = new Size(0, 17);
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.BackColor = Color.Snow;
            MainStatusStrip.Items.AddRange(new ToolStripItem[] { StatusLabelTimeNow, StatusLabelQuantityOfCharEmpty, StatusLabelQuantityOfChar });
            MainStatusStrip.Location = new Point(0, 459);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Size = new Size(664, 22);
            MainStatusStrip.TabIndex = 3;
            MainStatusStrip.Text = "statusStrip1";
            // 
            // StatusLabelQuantityOfCharEmpty
            // 
            StatusLabelQuantityOfCharEmpty.Name = "StatusLabelQuantityOfCharEmpty";
            StatusLabelQuantityOfCharEmpty.Size = new Size(185, 17);
            StatusLabelQuantityOfCharEmpty.Text = " символ(ов)  с учётом пробелов";
            // 
            // StatusLabelQuantityOfChar
            // 
            StatusLabelQuantityOfChar.Name = "StatusLabelQuantityOfChar";
            StatusLabelQuantityOfChar.Size = new Size(141, 17);
            StatusLabelQuantityOfChar.Text = "символ(ов) без пробела";
            // 
            // TimeTimer
            // 
            TimeTimer.Tick += TimeTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 481);
            Controls.Add(MainStatusStrip);
            Controls.Add(TextSettingsToolStrip);
            Controls.Add(MainRichTextBox);
            Controls.Add(MainFormMenuStrip);
            MainMenuStrip = MainFormMenuStrip;
            MinimumSize = new Size(400, 300);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная";
            FormClosed += MainForm_FormClosed_1;
            Load += MainForm_Load;
            MainFormMenuStrip.ResumeLayout(false);
            MainFormMenuStrip.PerformLayout();
            SettingsContextMenuStrip.ResumeLayout(false);
            TextSettingsToolStrip.ResumeLayout(false);
            TextSettingsToolStrip.PerformLayout();
            MainStatusStrip.ResumeLayout(false);
            MainStatusStrip.PerformLayout();
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
        private ContextMenuStrip SettingsContextMenuStrip;
        private ToolStripMenuItem ColorStripMenuItem;
        private ToolStripMenuItem FontStripMenuItem;
        private FontDialog MainFontDialog;
        private ColorDialog MainColorDialog;
        private ToolStripMenuItem FormattingMenuItem;
        private ToolStrip TextSettingsToolStrip;
        private ToolStripComboBox TSToolStripListOfFont;
        private ToolStripTextBox TSToolStripChangeFont;
        private ToolStripButton ToolStripButtonLeftSide;
        private ToolStripButton ToolStripButtonMiddel;
        private ToolStripButton ToolStripButtonRigthSide;
        private ToolStripStatusLabel StatusLabelTimeNow;
        private StatusStrip MainStatusStrip;
        private ToolStripStatusLabel StatusLabelQuantityOfCharEmpty;
        private ToolStripButton ChangeFontButton;
        private ToolStripButton ChangeFontButtonTwo;
        private System.Windows.Forms.Timer TimeTimer;
        private ToolStripStatusLabel StatusLabelQuantityOfChar;
    }
}
