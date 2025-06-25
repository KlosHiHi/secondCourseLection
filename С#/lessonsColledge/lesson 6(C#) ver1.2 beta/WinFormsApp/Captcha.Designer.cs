namespace WinFormsApp
{
    partial class Captcha
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
            CaptchaPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CaptchaPictureBox).BeginInit();
            SuspendLayout();
            // 
            // CaptchaPictureBox
            // 
            CaptchaPictureBox.BackColor = SystemColors.Control;
            CaptchaPictureBox.Location = new Point(0, 0);
            CaptchaPictureBox.Margin = new Padding(9);
            CaptchaPictureBox.Name = "CaptchaPictureBox";
            CaptchaPictureBox.Size = new Size(300, 100);
            CaptchaPictureBox.TabIndex = 0;
            CaptchaPictureBox.TabStop = false;
            // 
            // Captcha
            // 
            AutoScaleDimensions = new SizeF(27F, 59F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            BackgroundImage = Properties.Resources.Безымянный;
            Controls.Add(CaptchaPictureBox);
            Font = new Font("Consolas", 30F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(9);
            MaximumSize = new Size(300, 100);
            MinimumSize = new Size(300, 100);
            Name = "Captcha";
            Size = new Size(300, 100);
            ((System.ComponentModel.ISupportInitialize)CaptchaPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox CaptchaPictureBox;
    }
}
