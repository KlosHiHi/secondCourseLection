namespace labwork33
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
            AuthButton = new Button();
            LoginTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // AuthButton
            // 
            AuthButton.BackColor = Color.Snow;
            AuthButton.FlatStyle = FlatStyle.Flat;
            AuthButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AuthButton.Location = new Point(143, 259);
            AuthButton.Margin = new Padding(3, 4, 3, 4);
            AuthButton.Name = "AuthButton";
            AuthButton.Size = new Size(206, 65);
            AuthButton.TabIndex = 0;
            AuthButton.Text = "Авторизироваться";
            AuthButton.UseVisualStyleBackColor = false;
            AuthButton.Click += AuthButton_Click;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginTextBox.Location = new Point(14, 101);
            LoginTextBox.Margin = new Padding(3, 4, 3, 4);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(468, 34);
            LoginTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(14, 69);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 2;
            label1.Text = "Введите логин";
            // 
            // AuthorizationForm
            // 
            AcceptButton = AuthButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 337);
            Controls.Add(label1);
            Controls.Add(LoginTextBox);
            Controls.Add(AuthButton);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(512, 384);
            MinimumSize = new Size(512, 384);
            Name = "AuthorizationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            Load += AuthorizationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AuthButton;
        private TextBox LoginTextBox;
        private Label label1;
    }
}