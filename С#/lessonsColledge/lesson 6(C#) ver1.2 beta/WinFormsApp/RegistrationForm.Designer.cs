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
            maleRadioButton = new RadioButton();
            femaleRadioButton2 = new RadioButton();
            connfirmCheckBox = new CheckBox();
            RegCaptcha = new Captcha();
            RenewButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 106);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 188);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(233, 32);
            label3.TabIndex = 2;
            label3.Text = "Повторите пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 270);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(242, 32);
            label4.TabIndex = 3;
            label4.Text = "Электронная почта";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 352);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 4;
            label5.Text = "ФИО";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 434);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(199, 32);
            label6.TabIndex = 5;
            label6.Text = "Дата рождения";
            // 
            // loginTextBoxReg
            // 
            loginTextBoxReg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginTextBoxReg.BackColor = Color.Snow;
            loginTextBoxReg.Location = new Point(37, 60);
            loginTextBoxReg.Margin = new Padding(4);
            loginTextBoxReg.Name = "loginTextBoxReg";
            loginTextBoxReg.Size = new Size(586, 39);
            loginTextBoxReg.TabIndex = 6;
            // 
            // passwordTextBoxReg
            // 
            passwordTextBoxReg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBoxReg.BackColor = Color.Snow;
            passwordTextBoxReg.Location = new Point(37, 142);
            passwordTextBoxReg.Margin = new Padding(4);
            passwordTextBoxReg.Name = "passwordTextBoxReg";
            passwordTextBoxReg.Size = new Size(586, 39);
            passwordTextBoxReg.TabIndex = 7;
            passwordTextBoxReg.UseSystemPasswordChar = true;
            // 
            // passwordRepTextBoxReg
            // 
            passwordRepTextBoxReg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordRepTextBoxReg.BackColor = Color.Snow;
            passwordRepTextBoxReg.Location = new Point(37, 224);
            passwordRepTextBoxReg.Margin = new Padding(4);
            passwordRepTextBoxReg.Name = "passwordRepTextBoxReg";
            passwordRepTextBoxReg.Size = new Size(586, 39);
            passwordRepTextBoxReg.TabIndex = 8;
            passwordRepTextBoxReg.UseSystemPasswordChar = true;
            // 
            // eMailTextBoxReg
            // 
            eMailTextBoxReg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            eMailTextBoxReg.BackColor = Color.Snow;
            eMailTextBoxReg.Location = new Point(38, 306);
            eMailTextBoxReg.Margin = new Padding(4);
            eMailTextBoxReg.Name = "eMailTextBoxReg";
            eMailTextBoxReg.Size = new Size(584, 39);
            eMailTextBoxReg.TabIndex = 9;
            // 
            // fullNameTextBoxReg
            // 
            fullNameTextBoxReg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fullNameTextBoxReg.BackColor = Color.Snow;
            fullNameTextBoxReg.Location = new Point(38, 388);
            fullNameTextBoxReg.Margin = new Padding(4);
            fullNameTextBoxReg.Name = "fullNameTextBoxReg";
            fullNameTextBoxReg.Size = new Size(584, 39);
            fullNameTextBoxReg.TabIndex = 10;
            // 
            // birthDayDateTimePickerReg
            // 
            birthDayDateTimePickerReg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            birthDayDateTimePickerReg.CalendarForeColor = SystemColors.GrayText;
            birthDayDateTimePickerReg.CalendarMonthBackground = Color.Snow;
            birthDayDateTimePickerReg.CalendarTitleForeColor = SystemColors.GrayText;
            birthDayDateTimePickerReg.Location = new Point(38, 470);
            birthDayDateTimePickerReg.Margin = new Padding(4);
            birthDayDateTimePickerReg.Name = "birthDayDateTimePickerReg";
            birthDayDateTimePickerReg.Size = new Size(584, 39);
            birthDayDateTimePickerReg.TabIndex = 11;
            birthDayDateTimePickerReg.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // registrationButton
            // 
            registrationButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            registrationButton.BackColor = Color.Snow;
            registrationButton.Enabled = false;
            registrationButton.ForeColor = Color.Gray;
            registrationButton.Location = new Point(415, 755);
            registrationButton.Margin = new Padding(4);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(210, 45);
            registrationButton.TabIndex = 12;
            registrationButton.Text = "Регистрация";
            registrationButton.UseVisualStyleBackColor = false;
            registrationButton.Click += registrationButton_Click;
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Checked = true;
            maleRadioButton.Location = new Point(38, 532);
            maleRadioButton.Margin = new Padding(4);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(58, 36);
            maleRadioButton.TabIndex = 13;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "М";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton2
            // 
            femaleRadioButton2.AutoSize = true;
            femaleRadioButton2.Location = new Point(107, 532);
            femaleRadioButton2.Margin = new Padding(4);
            femaleRadioButton2.Name = "femaleRadioButton2";
            femaleRadioButton2.Size = new Size(59, 36);
            femaleRadioButton2.TabIndex = 14;
            femaleRadioButton2.Text = "Ж";
            femaleRadioButton2.UseVisualStyleBackColor = true;
            // 
            // connfirmCheckBox
            // 
            connfirmCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            connfirmCheckBox.AutoSize = true;
            connfirmCheckBox.Location = new Point(37, 761);
            connfirmCheckBox.Margin = new Padding(4);
            connfirmCheckBox.Name = "connfirmCheckBox";
            connfirmCheckBox.Size = new Size(348, 36);
            connfirmCheckBox.TabIndex = 15;
            connfirmCheckBox.Text = "Я прочитал(а) соглашение";
            connfirmCheckBox.UseVisualStyleBackColor = true;
            connfirmCheckBox.CheckedChanged += connfirmCheckBox_CheckedChanged;
            // 
            // RegCaptcha
            // 
            RegCaptcha.BackColor = SystemColors.AppWorkspace;
            RegCaptcha.BorderStyle = BorderStyle.FixedSingle;
            RegCaptcha.DataColor = Color.DarkBlue;
            RegCaptcha.Font = new Font("Consolas", 30F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegCaptcha.ForeColor = SystemColors.MenuHighlight;
            RegCaptcha.Length = 5;
            RegCaptcha.LinesColor = Color.Blue;
            RegCaptcha.Location = new Point(37, 567);
            RegCaptcha.Margin = new Padding(11, 12, 11, 12);
            RegCaptcha.MaximumSize = new Size(381, 127);
            RegCaptcha.MinimumSize = new Size(370, 125);
            RegCaptcha.Name = "RegCaptcha";
            RegCaptcha.Size = new Size(370, 127);
            RegCaptcha.TabIndex = 16;
            // 
            // RenewButton
            // 
            RenewButton.BackColor = Color.Snow;
            RenewButton.ForeColor = Color.Gray;
            RenewButton.Location = new Point(434, 611);
            RenewButton.Margin = new Padding(4);
            RenewButton.Name = "RenewButton";
            RenewButton.Size = new Size(148, 42);
            RenewButton.TabIndex = 17;
            RenewButton.Text = "Обновить";
            RenewButton.UseVisualStyleBackColor = false;
            RenewButton.Click += RenewButton_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(647, 818);
            Controls.Add(RenewButton);
            Controls.Add(RegCaptcha);
            Controls.Add(connfirmCheckBox);
            Controls.Add(femaleRadioButton2);
            Controls.Add(maleRadioButton);
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
            Margin = new Padding(10);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Регистрация";
            Load += RegistrationForm_Load;
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
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton2;
        private CheckBox connfirmCheckBox;
        private Captcha RegCaptcha;
        private Button RenewButton;
    }
}