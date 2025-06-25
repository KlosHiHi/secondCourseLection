namespace labwork35
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ToFirstFormDialogButton = new Button();
            ToFirstFormButton = new Button();
            ToSecondMDIFormButton = new Button();
            SuspendLayout();
            // 
            // ToFirstFormDialogButton
            // 
            ToFirstFormDialogButton.BackColor = Color.PaleTurquoise;
            ToFirstFormDialogButton.FlatStyle = FlatStyle.Flat;
            ToFirstFormDialogButton.Location = new Point(250, 70);
            ToFirstFormDialogButton.Name = "ToFirstFormDialogButton";
            ToFirstFormDialogButton.Size = new Size(400, 40);
            ToFirstFormDialogButton.TabIndex = 0;
            ToFirstFormDialogButton.Text = "открыть форму в диалоговом режиме";
            ToFirstFormDialogButton.UseVisualStyleBackColor = false;
            ToFirstFormDialogButton.Click += ToFirstFormDialogButton_Click;
            // 
            // ToFirstFormButton
            // 
            ToFirstFormButton.BackColor = Color.PaleTurquoise;
            ToFirstFormButton.FlatStyle = FlatStyle.Flat;
            ToFirstFormButton.Location = new Point(250, 25);
            ToFirstFormButton.Name = "ToFirstFormButton";
            ToFirstFormButton.Size = new Size(400, 40);
            ToFirstFormButton.TabIndex = 1;
            ToFirstFormButton.Text = "открыть форму";
            ToFirstFormButton.UseVisualStyleBackColor = false;
            ToFirstFormButton.Click += ToFirstFormButton_Click;
            // 
            // ToSecondMDIFormButton
            // 
            ToSecondMDIFormButton.BackColor = Color.PaleTurquoise;
            ToSecondMDIFormButton.FlatStyle = FlatStyle.Flat;
            ToSecondMDIFormButton.Location = new Point(250, 150);
            ToSecondMDIFormButton.Name = "ToSecondMDIFormButton";
            ToSecondMDIFormButton.Size = new Size(400, 40);
            ToSecondMDIFormButton.TabIndex = 2;
            ToSecondMDIFormButton.Text = "открыть mdi-форму";
            ToSecondMDIFormButton.UseVisualStyleBackColor = false;
            ToSecondMDIFormButton.Click += ToSecondMDIFormButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(882, 223);
            Controls.Add(ToSecondMDIFormButton);
            Controls.Add(ToFirstFormButton);
            Controls.Add(ToFirstFormDialogButton);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MaximumSize = new Size(900, 270);
            MinimumSize = new Size(900, 270);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная";
            ResumeLayout(false);
        }

        #endregion

        private Button ToFirstFormDialogButton;
        private Button ToFirstFormButton;
        private Button ToSecondMDIFormButton;
    }
}
