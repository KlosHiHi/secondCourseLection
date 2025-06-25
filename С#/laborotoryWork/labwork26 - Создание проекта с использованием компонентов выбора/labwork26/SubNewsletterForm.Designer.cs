namespace labwork26
{
    partial class SubNewsletterForm
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
            AcceptToSubButton = new Button();
            SubLoginTextBox = new TextBox();
            SubEmailTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            AcceptToSubСheckBox = new CheckBox();
            SuspendLayout();
            // 
            // AcceptToSubButton
            // 
            AcceptToSubButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AcceptToSubButton.BackColor = Color.Snow;
            AcceptToSubButton.Enabled = false;
            AcceptToSubButton.Location = new Point(207, 255);
            AcceptToSubButton.Margin = new Padding(3, 4, 3, 4);
            AcceptToSubButton.Name = "AcceptToSubButton";
            AcceptToSubButton.Size = new Size(109, 31);
            AcceptToSubButton.TabIndex = 0;
            AcceptToSubButton.Text = "Подписаться";
            AcceptToSubButton.UseVisualStyleBackColor = false;
            // 
            // SubLoginTextBox
            // 
            SubLoginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SubLoginTextBox.BackColor = Color.Snow;
            SubLoginTextBox.Location = new Point(26, 42);
            SubLoginTextBox.Margin = new Padding(3, 4, 3, 4);
            SubLoginTextBox.Name = "SubLoginTextBox";
            SubLoginTextBox.Size = new Size(290, 27);
            SubLoginTextBox.TabIndex = 1;
            // 
            // SubEmailTextBox
            // 
            SubEmailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SubEmailTextBox.BackColor = Color.Snow;
            SubEmailTextBox.Location = new Point(26, 114);
            SubEmailTextBox.Margin = new Padding(3, 4, 3, 4);
            SubEmailTextBox.Name = "SubEmailTextBox";
            SubEmailTextBox.Size = new Size(290, 27);
            SubEmailTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 90);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 18);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 4;
            label2.Text = "Логин";
            // 
            // AcceptToSubСheckBox
            // 
            AcceptToSubСheckBox.AutoSize = true;
            AcceptToSubСheckBox.Location = new Point(26, 149);
            AcceptToSubСheckBox.Margin = new Padding(3, 4, 3, 4);
            AcceptToSubСheckBox.Name = "AcceptToSubСheckBox";
            AcceptToSubСheckBox.Size = new Size(306, 24);
            AcceptToSubСheckBox.TabIndex = 5;
            AcceptToSubСheckBox.Text = "Я согласен(а) подписаться на рассылку ";
            AcceptToSubСheckBox.UseVisualStyleBackColor = true;
            AcceptToSubСheckBox.CheckedChanged += AcceptToSubСheckBox_CheckedChanged;
            // 
            // SubNewsletterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(344, 301);
            Controls.Add(AcceptToSubСheckBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SubEmailTextBox);
            Controls.Add(SubLoginTextBox);
            Controls.Add(AcceptToSubButton);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(360, 340);
            Name = "SubNewsletterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Подписка на рассылку";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AcceptToSubButton;
        private TextBox SubLoginTextBox;
        private TextBox SubEmailTextBox;
        private Label label1;
        private Label label2;
        private CheckBox AcceptToSubСheckBox;
    }
}