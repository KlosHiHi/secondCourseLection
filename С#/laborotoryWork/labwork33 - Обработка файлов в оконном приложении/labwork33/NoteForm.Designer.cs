namespace labwork33
{
    partial class NoteForm
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
            NotesTextBox = new TextBox();
            WriteTextButton = new Button();
            SuspendLayout();
            // 
            // NotesTextBox
            // 
            NotesTextBox.Dock = DockStyle.Bottom;
            NotesTextBox.Location = new Point(0, 80);
            NotesTextBox.Margin = new Padding(3, 4, 3, 4);
            NotesTextBox.Multiline = true;
            NotesTextBox.Name = "NotesTextBox";
            NotesTextBox.Size = new Size(896, 508);
            NotesTextBox.TabIndex = 0;
            // 
            // WriteTextButton
            // 
            WriteTextButton.BackColor = Color.Snow;
            WriteTextButton.FlatStyle = FlatStyle.Flat;
            WriteTextButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WriteTextButton.Location = new Point(14, 16);
            WriteTextButton.Margin = new Padding(3, 4, 3, 4);
            WriteTextButton.Name = "WriteTextButton";
            WriteTextButton.Size = new Size(110, 55);
            WriteTextButton.TabIndex = 1;
            WriteTextButton.Text = "Записать";
            WriteTextButton.UseVisualStyleBackColor = false;
            WriteTextButton.Click += WriteTextButton_Click;
            // 
            // NoteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(896, 588);
            Controls.Add(WriteTextButton);
            Controls.Add(NotesTextBox);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(912, 624);
            Name = "NoteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Записки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NotesTextBox;
        private Button WriteTextButton;
    }
}