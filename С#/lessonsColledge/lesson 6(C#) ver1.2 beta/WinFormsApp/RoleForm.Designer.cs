namespace WinFormsApp
{
    partial class RoleForm
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
            usersListBox = new ListBox();
            adminsListBox = new ListBox();
            ToAdminButton = new Button();
            ToUserButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // usersListBox
            // 
            usersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            usersListBox.BackColor = Color.Snow;
            usersListBox.DisplayMember = "Login";
            usersListBox.ForeColor = SystemColors.ControlDarkDark;
            usersListBox.FormattingEnabled = true;
            usersListBox.ItemHeight = 25;
            usersListBox.Location = new Point(19, 49);
            usersListBox.Margin = new Padding(5);
            usersListBox.Name = "usersListBox";
            usersListBox.Size = new Size(300, 279);
            usersListBox.TabIndex = 0;
            usersListBox.ValueMember = "Login";
            // 
            // adminsListBox
            // 
            adminsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            adminsListBox.BackColor = Color.Snow;
            adminsListBox.DisplayMember = "Login";
            adminsListBox.ForeColor = SystemColors.ControlDarkDark;
            adminsListBox.FormattingEnabled = true;
            adminsListBox.ItemHeight = 25;
            adminsListBox.Location = new Point(429, 49);
            adminsListBox.Margin = new Padding(5);
            adminsListBox.Name = "adminsListBox";
            adminsListBox.Size = new Size(300, 279);
            adminsListBox.TabIndex = 1;
            adminsListBox.ValueMember = "Login";
            // 
            // ToAdminButton
            // 
            ToAdminButton.Anchor = AnchorStyles.None;
            ToAdminButton.BackColor = Color.White;
            ToAdminButton.Location = new Point(329, 72);
            ToAdminButton.Margin = new Padding(5);
            ToAdminButton.Name = "ToAdminButton";
            ToAdminButton.Size = new Size(90, 60);
            ToAdminButton.TabIndex = 2;
            ToAdminButton.Text = "▶";
            ToAdminButton.UseVisualStyleBackColor = false;
            ToAdminButton.Click += ToAdminButton_Click;
            // 
            // ToUserButton
            // 
            ToUserButton.Anchor = AnchorStyles.None;
            ToUserButton.BackColor = Color.Snow;
            ToUserButton.Location = new Point(329, 142);
            ToUserButton.Margin = new Padding(5);
            ToUserButton.Name = "ToUserButton";
            ToUserButton.Size = new Size(90, 60);
            ToUserButton.TabIndex = 3;
            ToUserButton.Text = "◀";
            ToUserButton.UseVisualStyleBackColor = false;
            ToUserButton.Click += ToUserButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 19);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 4;
            label1.Text = "Челядь";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(429, 19);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 5;
            label2.Text = "Богатеи";
            // 
            // RoleForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 353);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ToUserButton);
            Controls.Add(ToAdminButton);
            Controls.Add(adminsListBox);
            Controls.Add(usersListBox);
            Margin = new Padding(8);
            Name = "RoleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Список пользователей";
            Load += RoleForm_Load;
            Controls.SetChildIndex(usersListBox, 0);
            Controls.SetChildIndex(adminsListBox, 0);
            Controls.SetChildIndex(ToAdminButton, 0);
            Controls.SetChildIndex(ToUserButton, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox usersListBox;
        private ListBox adminsListBox;
        private Button ToAdminButton;
        private Button ToUserButton;
        private Label label1;
        private Label label2;
    }
}