namespace WinFormsApp
{
    partial class AuthorizationForm
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
            label1 = new Label();
            label2 = new Label();
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            AuthButton = new Button();
            showPasswordCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 19);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 87);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // loginTextBox
            // 
            loginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginTextBox.BackColor = Color.Snow;
            loginTextBox.Location = new Point(39, 49);
            loginTextBox.Margin = new Padding(5);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(356, 33);
            loginTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.BackColor = Color.Snow;
            passwordTextBox.Location = new Point(39, 117);
            passwordTextBox.Margin = new Padding(5);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(356, 33);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // AuthButton
            // 
            AuthButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AuthButton.BackColor = Color.Snow;
            AuthButton.Location = new Point(268, 189);
            AuthButton.Margin = new Padding(5);
            AuthButton.Name = "AuthButton";
            AuthButton.Size = new Size(127, 34);
            AuthButton.TabIndex = 4;
            AuthButton.Text = "Войти";
            AuthButton.UseVisualStyleBackColor = false;
            AuthButton.Click += AuthButton_Click;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Location = new Point(39, 158);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(191, 29);
            showPasswordCheckBox.TabIndex = 5;
            showPasswordCheckBox.Text = "Показать пароль";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(430, 237);
            Controls.Add(showPasswordCheckBox);
            Controls.Add(AuthButton);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "AuthorizationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = " Авторизация";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(loginTextBox, 0);
            Controls.SetChildIndex(passwordTextBox, 0);
            Controls.SetChildIndex(AuthButton, 0);
            Controls.SetChildIndex(showPasswordCheckBox, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Button AuthButton;
        private CheckBox showPasswordCheckBox;
    }
}