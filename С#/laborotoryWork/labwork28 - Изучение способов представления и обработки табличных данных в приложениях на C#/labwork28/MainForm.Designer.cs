namespace labwork28
{
    partial class MainForm
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
            DataButton = new Button();
            PetButton = new Button();
            ToShopFormButton = new Button();
            SuspendLayout();
            // 
            // DataButton
            // 
            DataButton.BackColor = Color.OliveDrab;
            DataButton.Location = new Point(72, 43);
            DataButton.Margin = new Padding(3, 4, 3, 4);
            DataButton.Name = "DataButton";
            DataButton.Size = new Size(118, 77);
            DataButton.TabIndex = 1;
            DataButton.Text = "Данные";
            DataButton.UseVisualStyleBackColor = false;
            DataButton.Click += DataButton_Click;
            // 
            // PetButton
            // 
            PetButton.BackColor = Color.OliveDrab;
            PetButton.Location = new Point(72, 156);
            PetButton.Margin = new Padding(3, 4, 3, 4);
            PetButton.Name = "PetButton";
            PetButton.Size = new Size(118, 77);
            PetButton.TabIndex = 2;
            PetButton.Text = "Питомцы";
            PetButton.UseVisualStyleBackColor = false;
            PetButton.Click += PetButton_Click;
            // 
            // ToShopFormButton
            // 
            ToShopFormButton.BackColor = Color.OliveDrab;
            ToShopFormButton.Location = new Point(72, 264);
            ToShopFormButton.Margin = new Padding(3, 4, 3, 4);
            ToShopFormButton.Name = "ToShopFormButton";
            ToShopFormButton.Size = new Size(118, 77);
            ToShopFormButton.TabIndex = 3;
            ToShopFormButton.Text = "Магазин";
            ToShopFormButton.UseVisualStyleBackColor = false;
            ToShopFormButton.Click += ToShopFormButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(265, 577);
            Controls.Add(ToShopFormButton);
            Controls.Add(PetButton);
            Controls.Add(DataButton);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(283, 624);
            MinimumSize = new Size(283, 624);
            Name = "MainForm";
            Text = "MaingForm";
            ResumeLayout(false);
        }

        #endregion

        private Button DataButton;
        private Button PetButton;
        private Button ToShopFormButton;
    }
}