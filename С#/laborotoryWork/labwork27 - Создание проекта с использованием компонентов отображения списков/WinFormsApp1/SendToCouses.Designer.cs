namespace WinFormsApp1
{
    partial class CourseForm
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
            CourseCheckedListBox = new CheckedListBox();
            ConfirmButton = new Button();
            SuspendLayout();
            // 
            // CourseCheckedListBox
            // 
            CourseCheckedListBox.BackColor = Color.PeachPuff;
            CourseCheckedListBox.FormattingEnabled = true;
            CourseCheckedListBox.Items.AddRange(new object[] { "Курсы шитья", "Курсы рукопашного боя", "Курсы фехтования", "Кондитерские курсы", "Курсы графики", "Курсы баллистики", "Курсы литературы", "Курсы музыки", "Курсы кулинарии", "Инженерные курсы" });
            CourseCheckedListBox.Location = new Point(12, 12);
            CourseCheckedListBox.Name = "CourseCheckedListBox";
            CourseCheckedListBox.Size = new Size(287, 184);
            CourseCheckedListBox.TabIndex = 0;
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = Color.PeachPuff;
            ConfirmButton.Location = new Point(77, 254);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(155, 36);
            ConfirmButton.TabIndex = 1;
            ConfirmButton.Text = "Подтвердить";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(311, 302);
            Controls.Add(ConfirmButton);
            Controls.Add(CourseCheckedListBox);
            MaximumSize = new Size(327, 341);
            Name = "CourseForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Выбор курса обучения";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox CourseCheckedListBox;
        private Button ConfirmButton;
    }
}