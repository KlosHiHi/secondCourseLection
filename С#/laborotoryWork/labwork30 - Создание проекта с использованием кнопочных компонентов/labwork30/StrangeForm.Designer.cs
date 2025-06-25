namespace labwork30
{
    partial class StrangeForm
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
            SayHelloButton = new Button();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // SayHelloButton
            // 
            SayHelloButton.BackColor = Color.ForestGreen;
            SayHelloButton.FlatStyle = FlatStyle.Flat;
            SayHelloButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SayHelloButton.ForeColor = SystemColors.ButtonHighlight;
            SayHelloButton.Location = new Point(39, 64);
            SayHelloButton.Name = "SayHelloButton";
            SayHelloButton.Size = new Size(135, 54);
            SayHelloButton.TabIndex = 0;
            SayHelloButton.Text = "🖐Привет🖐";
            SayHelloButton.UseVisualStyleBackColor = false;
            SayHelloButton.Click += SayHelloButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Firebrick;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.ForeColor = SystemColors.ButtonHighlight;
            CloseButton.Location = new Point(213, 64);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(135, 54);
            CloseButton.TabIndex = 1;
            CloseButton.Text = " ❌ЗАКРЫТЬ❌";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // StrangeForm
            // 
            AcceptButton = SayHelloButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            CancelButton = CloseButton;
            ClientSize = new Size(384, 236);
            Controls.Add(CloseButton);
            Controls.Add(SayHelloButton);
            MaximumSize = new Size(400, 275);
            MinimumSize = new Size(400, 275);
            Name = "StrangeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Форма общения";
            ResumeLayout(false);
        }

        #endregion

        private Button SayHelloButton;
        private Button CloseButton;
    }
}