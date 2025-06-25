namespace WinFormsApp
{
    partial class MainForm1
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
            toAuthorizationButton = new Button();
            toColorFormButton = new Button();
            toRegistrationButton = new Button();
            SuspendLayout();
            // 
            // toAuthorizationButton
            // 
            toAuthorizationButton.Anchor = AnchorStyles.None;
            toAuthorizationButton.BackColor = Color.Snow;
            toAuthorizationButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toAuthorizationButton.Location = new Point(94, 98);
            toAuthorizationButton.Margin = new Padding(5);
            toAuthorizationButton.Name = "toAuthorizationButton";
            toAuthorizationButton.Size = new Size(231, 57);
            toAuthorizationButton.TabIndex = 0;
            toAuthorizationButton.Text = "Авторизация";
            toAuthorizationButton.UseVisualStyleBackColor = false;
            toAuthorizationButton.Click += toAuthorizationButton_Click;
            // 
            // toColorFormButton
            // 
            toColorFormButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            toColorFormButton.BackColor = Color.Snow;
            toColorFormButton.Location = new Point(340, 292);
            toColorFormButton.Margin = new Padding(5);
            toColorFormButton.Name = "toColorFormButton";
            toColorFormButton.Size = new Size(71, 38);
            toColorFormButton.TabIndex = 1;
            toColorFormButton.Text = "цвет";
            toColorFormButton.UseVisualStyleBackColor = false;
            toColorFormButton.Click += toColorFormButton_Click;
            // 
            // toRegistrationButton
            // 
            toRegistrationButton.Anchor = AnchorStyles.None;
            toRegistrationButton.BackColor = Color.Snow;
            toRegistrationButton.Location = new Point(94, 163);
            toRegistrationButton.Name = "toRegistrationButton";
            toRegistrationButton.Size = new Size(231, 57);
            toRegistrationButton.TabIndex = 2;
            toRegistrationButton.Text = "Регистрация";
            toRegistrationButton.UseVisualStyleBackColor = false;
            toRegistrationButton.Click += toRegistrationButton_Click;
            // 
            // MainForm1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(420, 344);
            Controls.Add(toRegistrationButton);
            Controls.Add(toColorFormButton);
            Controls.Add(toAuthorizationButton);
            Margin = new Padding(8);
            Name = "MainForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Начальная страница";
            Controls.SetChildIndex(toAuthorizationButton, 0);
            Controls.SetChildIndex(toColorFormButton, 0);
            Controls.SetChildIndex(toRegistrationButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button toAuthorizationButton;
        private Button toColorFormButton;
        private Button toRegistrationButton;
    }
}
