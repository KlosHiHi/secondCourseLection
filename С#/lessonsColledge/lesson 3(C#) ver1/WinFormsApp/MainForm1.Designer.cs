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
            Template = new Button();
            toRegistrationButton = new Button();
            SuspendLayout();
            // 
            // toAuthorizationButton
            // 
            toAuthorizationButton.Anchor = AnchorStyles.None;
            toAuthorizationButton.BackColor = Color.Snow;
            toAuthorizationButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toAuthorizationButton.Location = new Point(95, 142);
            toAuthorizationButton.Margin = new Padding(5);
            toAuthorizationButton.Name = "toAuthorizationButton";
            toAuthorizationButton.Size = new Size(231, 57);
            toAuthorizationButton.TabIndex = 0;
            toAuthorizationButton.Text = "Авторизация";
            toAuthorizationButton.UseVisualStyleBackColor = false;
            toAuthorizationButton.Click += toAuthorizationButton_Click;
            // 
            // Template
            // 
            Template.Anchor = AnchorStyles.None;
            Template.BackColor = Color.Snow;
            Template.Location = new Point(158, 272);
            Template.Margin = new Padding(5);
            Template.Name = "Template";
            Template.Size = new Size(118, 38);
            Template.TabIndex = 1;
            Template.Text = "template";
            Template.UseVisualStyleBackColor = false;
            // 
            // toRegistrationButton
            // 
            toRegistrationButton.Anchor = AnchorStyles.None;
            toRegistrationButton.BackColor = Color.Snow;
            toRegistrationButton.Location = new Point(95, 207);
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
            Controls.Add(Template);
            Controls.Add(toAuthorizationButton);
            Margin = new Padding(8);
            Name = "MainForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Начальная страница";
            ResumeLayout(false);
        }

        #endregion

        private Button toAuthorizationButton;
        private Button Template;
        private Button toRegistrationButton;
    }
}
