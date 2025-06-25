namespace selfproject
{
    partial class ChangeFileNameUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            FileNameButton = new Button();
            FileNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // FileNameButton
            // 
            FileNameButton.Enabled = false;
            FileNameButton.Location = new Point(3, 56);
            FileNameButton.Name = "FileNameButton";
            FileNameButton.Size = new Size(274, 33);
            FileNameButton.TabIndex = 0;
            FileNameButton.Text = "Изменить";
            FileNameButton.UseVisualStyleBackColor = true;
            FileNameButton.Click += FileNameButton_Click;
            // 
            // FileNameTextBox
            // 
            FileNameTextBox.Location = new Point(3, 20);
            FileNameTextBox.Name = "FileNameTextBox";
            FileNameTextBox.Size = new Size(274, 30);
            FileNameTextBox.TabIndex = 1;
            FileNameTextBox.TextAlign = HorizontalAlignment.Center;
            FileNameTextBox.TextChanged += FileNameTextBox_TextChanged;
            // 
            // ChangeFileNameUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.HotPink;
            Controls.Add(FileNameTextBox);
            Controls.Add(FileNameButton);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MaximumSize = new Size(280, 115);
            MinimumSize = new Size(280, 110);
            Name = "ChangeFileNameUserControl";
            Size = new Size(280, 110);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FileNameButton;
        private TextBox FileNameTextBox;
    }
}
