namespace WinFormsApp1
{
    partial class ListForm
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
            FirstListBox = new ListBox();
            SecondListBox = new ListBox();
            InputTextBox = new TextBox();
            EnterButton = new Button();
            ChooseElementRigthButton = new Button();
            AllElemtnsLeftButton = new Button();
            ChooseElementLeftButton = new Button();
            AllElemtnsRightButton = new Button();
            SuspendLayout();
            // 
            // FirstListBox
            // 
            FirstListBox.BackColor = Color.PeachPuff;
            FirstListBox.FormattingEnabled = true;
            FirstListBox.ItemHeight = 15;
            FirstListBox.Items.AddRange(new object[] { "Плоскогубцы", "Отвёртка", "Молоток", "Кувалда", "Шуруповёрт" });
            FirstListBox.Location = new Point(12, 46);
            FirstListBox.Name = "FirstListBox";
            FirstListBox.Size = new Size(120, 184);
            FirstListBox.TabIndex = 0;
            // 
            // SecondListBox
            // 
            SecondListBox.BackColor = Color.PeachPuff;
            SecondListBox.FormattingEnabled = true;
            SecondListBox.ItemHeight = 15;
            SecondListBox.Items.AddRange(new object[] { "Венчик", "Дуршлаг", "Скалка", "Поварёшка", "Миксер" });
            SecondListBox.Location = new Point(209, 46);
            SecondListBox.Name = "SecondListBox";
            SecondListBox.Size = new Size(120, 184);
            SecondListBox.TabIndex = 1;
            // 
            // InputTextBox
            // 
            InputTextBox.BackColor = Color.PeachPuff;
            InputTextBox.Location = new Point(12, 332);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(317, 23);
            InputTextBox.TabIndex = 2;
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.White;
            EnterButton.Location = new Point(116, 361);
            EnterButton.MaximumSize = new Size(115, 23);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(115, 23);
            EnterButton.TabIndex = 3;
            EnterButton.Text = "Добавить";
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // ChooseElementRigthButton
            // 
            ChooseElementRigthButton.BackColor = Color.White;
            ChooseElementRigthButton.Location = new Point(133, 64);
            ChooseElementRigthButton.Name = "ChooseElementRigthButton";
            ChooseElementRigthButton.Size = new Size(75, 23);
            ChooseElementRigthButton.TabIndex = 4;
            ChooseElementRigthButton.Text = ">";
            ChooseElementRigthButton.UseVisualStyleBackColor = false;
            ChooseElementRigthButton.Click += ChooseElementRigthButton_Click;
            // 
            // AllElemtnsLeftButton
            // 
            AllElemtnsLeftButton.BackColor = Color.White;
            AllElemtnsLeftButton.Location = new Point(133, 151);
            AllElemtnsLeftButton.Name = "AllElemtnsLeftButton";
            AllElemtnsLeftButton.Size = new Size(75, 23);
            AllElemtnsLeftButton.TabIndex = 5;
            AllElemtnsLeftButton.Text = "<<";
            AllElemtnsLeftButton.UseVisualStyleBackColor = false;
            AllElemtnsLeftButton.Click += AllElemtnsLeftButton_Click;
            // 
            // ChooseElementLeftButton
            // 
            ChooseElementLeftButton.BackColor = Color.White;
            ChooseElementLeftButton.Location = new Point(133, 122);
            ChooseElementLeftButton.Name = "ChooseElementLeftButton";
            ChooseElementLeftButton.Size = new Size(75, 23);
            ChooseElementLeftButton.TabIndex = 6;
            ChooseElementLeftButton.Text = "<";
            ChooseElementLeftButton.UseVisualStyleBackColor = false;
            ChooseElementLeftButton.Click += ChooseElementLeftButton_Click;
            // 
            // AllElemtnsRightButton
            // 
            AllElemtnsRightButton.BackColor = Color.White;
            AllElemtnsRightButton.Location = new Point(133, 93);
            AllElemtnsRightButton.Name = "AllElemtnsRightButton";
            AllElemtnsRightButton.Size = new Size(75, 23);
            AllElemtnsRightButton.TabIndex = 7;
            AllElemtnsRightButton.Text = ">>";
            AllElemtnsRightButton.UseVisualStyleBackColor = false;
            AllElemtnsRightButton.Click += AllElemtnsRightButton_Click;
            // 
            // ListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 411);
            Controls.Add(AllElemtnsRightButton);
            Controls.Add(ChooseElementLeftButton);
            Controls.Add(AllElemtnsLeftButton);
            Controls.Add(ChooseElementRigthButton);
            Controls.Add(EnterButton);
            Controls.Add(InputTextBox);
            Controls.Add(SecondListBox);
            Controls.Add(FirstListBox);
            MaximumSize = new Size(355, 450);
            Name = "ListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Списки всего";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox FirstListBox;
        private ListBox SecondListBox;
        private TextBox InputTextBox;
        private Button EnterButton;
        private Button ChooseElementRigthButton;
        private Button AllElemtnsLeftButton;
        private Button ChooseElementLeftButton;
        private Button AllElemtnsRightButton;
    }
}