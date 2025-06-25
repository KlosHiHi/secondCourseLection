namespace labwork33
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
            ToNoteFormButton = new Button();
            ToAuthButton = new Button();
            ToShopFormButton = new Button();
            SuspendLayout();
            // 
            // ToNoteFormButton
            // 
            ToNoteFormButton.BackColor = Color.Moccasin;
            ToNoteFormButton.FlatStyle = FlatStyle.Flat;
            ToNoteFormButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ToNoteFormButton.Location = new Point(92, 27);
            ToNoteFormButton.Name = "ToNoteFormButton";
            ToNoteFormButton.Size = new Size(145, 40);
            ToNoteFormButton.TabIndex = 0;
            ToNoteFormButton.Text = "Заметки";
            ToNoteFormButton.UseVisualStyleBackColor = false;
            ToNoteFormButton.Click += ToNoteFormButton_Click;
            // 
            // ToAuthButton
            // 
            ToAuthButton.BackColor = Color.Moccasin;
            ToAuthButton.FlatStyle = FlatStyle.Flat;
            ToAuthButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ToAuthButton.Location = new Point(92, 97);
            ToAuthButton.Name = "ToAuthButton";
            ToAuthButton.Size = new Size(145, 40);
            ToAuthButton.TabIndex = 1;
            ToAuthButton.Text = "Авторизация";
            ToAuthButton.UseVisualStyleBackColor = false;
            ToAuthButton.Click += ToAuthButton_Click;
            // 
            // ToShopFormButton
            // 
            ToShopFormButton.BackColor = Color.Moccasin;
            ToShopFormButton.FlatStyle = FlatStyle.Flat;
            ToShopFormButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ToShopFormButton.Location = new Point(92, 165);
            ToShopFormButton.Name = "ToShopFormButton";
            ToShopFormButton.Size = new Size(145, 40);
            ToShopFormButton.TabIndex = 2;
            ToShopFormButton.Text = "Магазин";
            ToShopFormButton.UseVisualStyleBackColor = false;
            ToShopFormButton.Click += ToShopFormButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 431);
            Controls.Add(ToShopFormButton);
            Controls.Add(ToAuthButton);
            Controls.Add(ToNoteFormButton);
            MaximumSize = new Size(350, 470);
            MinimumSize = new Size(350, 470);
            Name = "MainForm";
            Text = "Начальная";
            ResumeLayout(false);
        }

        #endregion

        private Button ToNoteFormButton;
        private Button ToAuthButton;
        private Button ToShopFormButton;
    }
}
