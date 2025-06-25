namespace labwork24
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
            loginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            repeatPasswordTextBox = new TextBox();
            InformationTextBox = new TextBox();
            cancelButton = new Button();
            registrationButton = new Button();
            CountryTextBox = new TextBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(13, 72);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(14, 135);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 2;
            label3.Text = "Повторите пароль";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(14, 224);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(159, 23);
            label4.TabIndex = 3;
            label4.Text = "Страна проживания";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(14, 283);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 23);
            label5.TabIndex = 4;
            label5.Text = "Информация о себе";
            // 
            // loginTextBox
            // 
            loginTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            loginTextBox.Location = new Point(13, 37);
            loginTextBox.Margin = new Padding(4, 5, 4, 5);
            loginTextBox.MaxLength = 16;
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(358, 30);
            loginTextBox.TabIndex = 5;
            loginTextBox.TextChanged += loginTextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.Location = new Point(14, 100);
            PasswordTextBox.Margin = new Padding(4, 5, 4, 5);
            PasswordTextBox.MaxLength = 20;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(358, 30);
            PasswordTextBox.TabIndex = 6;
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // repeatPasswordTextBox
            // 
            repeatPasswordTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            repeatPasswordTextBox.Location = new Point(14, 163);
            repeatPasswordTextBox.Margin = new Padding(4, 5, 4, 5);
            repeatPasswordTextBox.MaxLength = 20;
            repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            repeatPasswordTextBox.Size = new Size(358, 30);
            repeatPasswordTextBox.TabIndex = 7;
            repeatPasswordTextBox.UseSystemPasswordChar = true;
            repeatPasswordTextBox.TextChanged += repeatPasswordTextBox_TextChanged;
            // 
            // InformationTextBox
            // 
            InformationTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            InformationTextBox.Location = new Point(14, 311);
            InformationTextBox.Margin = new Padding(4, 5, 4, 5);
            InformationTextBox.MaxLength = 500;
            InformationTextBox.Multiline = true;
            InformationTextBox.Name = "InformationTextBox";
            InformationTextBox.Size = new Size(358, 110);
            InformationTextBox.TabIndex = 8;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.BackColor = SystemColors.ButtonHighlight;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.Location = new Point(283, 447);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(87, 31);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // registrationButton
            // 
            registrationButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            registrationButton.BackColor = SystemColors.ButtonHighlight;
            registrationButton.Cursor = Cursors.Hand;
            registrationButton.Location = new Point(13, 447);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(174, 31);
            registrationButton.TabIndex = 11;
            registrationButton.Text = "Зарегистрироваться";
            registrationButton.UseVisualStyleBackColor = false;
            registrationButton.Click += registrationButton_Click;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CountryTextBox.Location = new Point(14, 250);
            CountryTextBox.MaxLength = 30;
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(356, 30);
            CountryTextBox.TabIndex = 12;
            CountryTextBox.KeyPress += CountryTextBox_KeyPress;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(213, 201);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(159, 27);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Показать пароль";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(384, 490);
            Controls.Add(checkBox1);
            Controls.Add(CountryTextBox);
            Controls.Add(registrationButton);
            Controls.Add(cancelButton);
            Controls.Add(InformationTextBox);
            Controls.Add(repeatPasswordTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox loginTextBox;
        private TextBox PasswordTextBox;
        private TextBox repeatPasswordTextBox;
        private TextBox InformationTextBox;
        private Button cancelButton;
        private Button registrationButton;
        private TextBox CountryTextBox;
        private CheckBox checkBox1;
    }
}