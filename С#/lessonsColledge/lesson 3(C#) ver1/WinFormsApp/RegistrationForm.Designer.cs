namespace WinFormsApp
{
    partial class RegistrationForm
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            loginTextBoxReg = new TextBox();
            passwordTextBoxReg = new TextBox();
            passwordRepTextBoxReg = new TextBox();
            eMailTextBoxReg = new TextBox();
            fullNameTextBoxReg = new TextBox();
            birthDayDateTimePickerReg = new DateTimePicker();
            registrationButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(29, 108);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(29, 186);
            label3.Name = "label3";
            label3.Size = new Size(187, 25);
            label3.TabIndex = 2;
            label3.Text = "Повторите пароль";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(29, 263);
            label4.Name = "label4";
            label4.Size = new Size(193, 25);
            label4.TabIndex = 3;
            label4.Text = "Электронная почта";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(29, 339);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 4;
            label5.Text = "ФИО";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(29, 417);
            label6.Name = "label6";
            label6.Size = new Size(158, 25);
            label6.TabIndex = 5;
            label6.Text = "Дата рождения";
            // 
            // loginTextBoxReg
            // 
            loginTextBoxReg.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            loginTextBoxReg.Location = new Point(29, 58);
            loginTextBoxReg.Name = "loginTextBoxReg";
            loginTextBoxReg.Size = new Size(461, 33);
            loginTextBoxReg.TabIndex = 6;
            // 
            // passwordTextBoxReg
            // 
            passwordTextBoxReg.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBoxReg.Location = new Point(29, 136);
            passwordTextBoxReg.Name = "passwordTextBoxReg";
            passwordTextBoxReg.Size = new Size(461, 33);
            passwordTextBoxReg.TabIndex = 7;
            // 
            // passwordRepTextBoxReg
            // 
            passwordRepTextBoxReg.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordRepTextBoxReg.Location = new Point(29, 214);
            passwordRepTextBoxReg.Name = "passwordRepTextBoxReg";
            passwordRepTextBoxReg.Size = new Size(461, 33);
            passwordRepTextBoxReg.TabIndex = 8;
            // 
            // eMailTextBoxReg
            // 
            eMailTextBoxReg.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            eMailTextBoxReg.Location = new Point(29, 291);
            eMailTextBoxReg.Name = "eMailTextBoxReg";
            eMailTextBoxReg.Size = new Size(461, 33);
            eMailTextBoxReg.TabIndex = 9;
            // 
            // fullNameTextBoxReg
            // 
            fullNameTextBoxReg.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fullNameTextBoxReg.Location = new Point(29, 367);
            fullNameTextBoxReg.Name = "fullNameTextBoxReg";
            fullNameTextBoxReg.Size = new Size(461, 33);
            fullNameTextBoxReg.TabIndex = 10;
            // 
            // birthDayDateTimePickerReg
            // 
            birthDayDateTimePickerReg.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            birthDayDateTimePickerReg.Location = new Point(29, 445);
            birthDayDateTimePickerReg.Name = "birthDayDateTimePickerReg";
            birthDayDateTimePickerReg.Size = new Size(461, 33);
            birthDayDateTimePickerReg.TabIndex = 11;
            birthDayDateTimePickerReg.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // registrationButton
            // 
            registrationButton.BackColor = Color.Snow;
            registrationButton.ForeColor = Color.Gray;
            registrationButton.Location = new Point(314, 547);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(165, 35);
            registrationButton.TabIndex = 12;
            registrationButton.Text = "Регистрация";
            registrationButton.UseVisualStyleBackColor = false;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(508, 594);
            Controls.Add(registrationButton);
            Controls.Add(birthDayDateTimePickerReg);
            Controls.Add(fullNameTextBoxReg);
            Controls.Add(eMailTextBoxReg);
            Controls.Add(passwordRepTextBoxReg);
            Controls.Add(passwordTextBoxReg);
            Controls.Add(loginTextBoxReg);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(8);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox loginTextBoxReg;
        private TextBox passwordTextBoxReg;
        private TextBox passwordRepTextBoxReg;
        private TextBox eMailTextBoxReg;
        private TextBox fullNameTextBoxReg;
        private DateTimePicker birthDayDateTimePickerReg;
        private Button registrationButton;
    }
}