namespace WinFormsApp
{
    partial class UsersForm
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
            components = new System.ComponentModel.Container();
            UserDataGridView = new DataGridView();
            loginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DeleteColumn = new DataGridViewButtonColumn();
            userBindingSource = new BindingSource(components);
            toRoleButton = new Button();
            SaveUserButton = new Button();
            LoadUserButton = new Button();
            UsersOpenFileDialog = new OpenFileDialog();
            UsersSaveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // UserDataGridView
            // 
            UserDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserDataGridView.AutoGenerateColumns = false;
            UserDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UserDataGridView.BackgroundColor = Color.Snow;
            UserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGridView.Columns.AddRange(new DataGridViewColumn[] { loginDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, birthDateDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, DeleteColumn });
            UserDataGridView.DataSource = userBindingSource;
            UserDataGridView.Location = new Point(14, 84);
            UserDataGridView.Margin = new Padding(5);
            UserDataGridView.Name = "UserDataGridView";
            UserDataGridView.ReadOnly = true;
            UserDataGridView.Size = new Size(746, 283);
            UserDataGridView.TabIndex = 0;
            UserDataGridView.CellClick += UserDataGridView_CellClick;
            UserDataGridView.DataError += UserDataGridView_DataError;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            birthDateDataGridViewTextBoxColumn.HeaderText = "День рождения";
            birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            genderDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Роль";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DeleteColumn
            // 
            DeleteColumn.HeaderText = "Удалить";
            DeleteColumn.Name = "DeleteColumn";
            DeleteColumn.ReadOnly = true;
            DeleteColumn.Resizable = DataGridViewTriState.True;
            DeleteColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // toRoleButton
            // 
            toRoleButton.BackColor = Color.Snow;
            toRoleButton.Location = new Point(14, 10);
            toRoleButton.Margin = new Padding(8);
            toRoleButton.Name = "toRoleButton";
            toRoleButton.Size = new Size(112, 70);
            toRoleButton.TabIndex = 4;
            toRoleButton.Text = "роли";
            toRoleButton.UseVisualStyleBackColor = false;
            toRoleButton.Click += toRoleButton_Click;
            // 
            // SaveUserButton
            // 
            SaveUserButton.Location = new Point(636, 10);
            SaveUserButton.Name = "SaveUserButton";
            SaveUserButton.Size = new Size(123, 36);
            SaveUserButton.TabIndex = 5;
            SaveUserButton.Text = "Сохранить";
            SaveUserButton.UseVisualStyleBackColor = true;
            SaveUserButton.Click += SaveUserButton_Click;
            // 
            // LoadUserButton
            // 
            LoadUserButton.Location = new Point(636, 42);
            LoadUserButton.Name = "LoadUserButton";
            LoadUserButton.Size = new Size(123, 36);
            LoadUserButton.TabIndex = 6;
            LoadUserButton.Text = "Загрузить";
            LoadUserButton.UseVisualStyleBackColor = true;
            LoadUserButton.Click += LoadUserButton_Click;
            // 
            // UsersOpenFileDialog
            // 
            UsersOpenFileDialog.Filter = "JSON|*.json";
            // 
            // UsersSaveFileDialog
            // 
            UsersSaveFileDialog.FileName = "users";
            UsersSaveFileDialog.Filter = "JSON|*.json";
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 392);
            Controls.Add(LoadUserButton);
            Controls.Add(SaveUserButton);
            Controls.Add(toRoleButton);
            Controls.Add(UserDataGridView);
            Margin = new Padding(8);
            Name = "UsersForm";
            Text = "Пользователи";
            Load += UsersForm_Load;
            Controls.SetChildIndex(UserDataGridView, 0);
            Controls.SetChildIndex(toRoleButton, 0);
            Controls.SetChildIndex(SaveUserButton, 0);
            Controls.SetChildIndex(LoadUserButton, 0);
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UserDataGridView;
        private BindingSource userBindingSource;
        private Button toRoleButton;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn DeleteColumn;
        private Button SaveUserButton;
        private Button LoadUserButton;
        private OpenFileDialog UsersOpenFileDialog;
        private SaveFileDialog UsersSaveFileDialog;
    }
}