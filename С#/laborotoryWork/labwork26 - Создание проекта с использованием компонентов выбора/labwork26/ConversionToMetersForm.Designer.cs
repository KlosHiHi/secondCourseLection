namespace labwork26
{
    partial class ConversionToMetersForm
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
            InchesRadioButton = new RadioButton();
            KilometersRadioButton = new RadioButton();
            SantimetersRadioButton = new RadioButton();
            FeetRadioButton = new RadioButton();
            label1 = new Label();
            ConvertButton = new Button();
            FinalValueLable = new Label();
            StartValNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)StartValNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // InchesRadioButton
            // 
            InchesRadioButton.AutoSize = true;
            InchesRadioButton.Location = new Point(34, 130);
            InchesRadioButton.Margin = new Padding(4);
            InchesRadioButton.Name = "InchesRadioButton";
            InchesRadioButton.Size = new Size(83, 25);
            InchesRadioButton.TabIndex = 0;
            InchesRadioButton.Text = "Дюймы";
            InchesRadioButton.UseVisualStyleBackColor = true;
            // 
            // KilometersRadioButton
            // 
            KilometersRadioButton.AutoSize = true;
            KilometersRadioButton.Checked = true;
            KilometersRadioButton.Location = new Point(187, 97);
            KilometersRadioButton.Margin = new Padding(4);
            KilometersRadioButton.Name = "KilometersRadioButton";
            KilometersRadioButton.Size = new Size(109, 25);
            KilometersRadioButton.TabIndex = 1;
            KilometersRadioButton.TabStop = true;
            KilometersRadioButton.Text = "Километры";
            KilometersRadioButton.UseVisualStyleBackColor = true;
            // 
            // SantimetersRadioButton
            // 
            SantimetersRadioButton.AutoSize = true;
            SantimetersRadioButton.Location = new Point(187, 130);
            SantimetersRadioButton.Margin = new Padding(4);
            SantimetersRadioButton.Name = "SantimetersRadioButton";
            SantimetersRadioButton.Size = new Size(117, 25);
            SantimetersRadioButton.TabIndex = 2;
            SantimetersRadioButton.Text = "Сантиметры";
            SantimetersRadioButton.UseVisualStyleBackColor = true;
            // 
            // FeetRadioButton
            // 
            FeetRadioButton.AutoSize = true;
            FeetRadioButton.Location = new Point(34, 97);
            FeetRadioButton.Margin = new Padding(4);
            FeetRadioButton.Name = "FeetRadioButton";
            FeetRadioButton.Size = new Size(66, 25);
            FeetRadioButton.TabIndex = 3;
            FeetRadioButton.Text = "Футы";
            FeetRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 5;
            label1.Text = "Исходное значение";
            // 
            // ConvertButton
            // 
            ConvertButton.BackColor = Color.Snow;
            ConvertButton.Location = new Point(34, 188);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(104, 36);
            ConvertButton.TabIndex = 6;
            ConvertButton.Text = "Перевести";
            ConvertButton.UseVisualStyleBackColor = false;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // FinalValueLable
            // 
            FinalValueLable.AutoSize = true;
            FinalValueLable.Location = new Point(34, 237);
            FinalValueLable.Name = "FinalValueLable";
            FinalValueLable.Size = new Size(83, 21);
            FinalValueLable.TabIndex = 7;
            FinalValueLable.Text = "Результат:";
            // 
            // StartValNumericUpDown
            // 
            StartValNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StartValNumericUpDown.DecimalPlaces = 2;
            StartValNumericUpDown.Location = new Point(34, 61);
            StartValNumericUpDown.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            StartValNumericUpDown.Name = "StartValNumericUpDown";
            StartValNumericUpDown.Size = new Size(263, 29);
            StartValNumericUpDown.TabIndex = 8;
            // 
            // ConversionToMetersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(334, 276);
            Controls.Add(StartValNumericUpDown);
            Controls.Add(FinalValueLable);
            Controls.Add(ConvertButton);
            Controls.Add(label1);
            Controls.Add(FeetRadioButton);
            Controls.Add(SantimetersRadioButton);
            Controls.Add(KilometersRadioButton);
            Controls.Add(InchesRadioButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MaximumSize = new Size(350, 315);
            Name = "ConversionToMetersForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Перевод длинны в метры";
            ((System.ComponentModel.ISupportInitialize)StartValNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton InchesRadioButton;
        private RadioButton KilometersRadioButton;
        private RadioButton SantimetersRadioButton;
        private RadioButton FeetRadioButton;
        private Label label1;
        private Button ConvertButton;
        private Label FinalValueLable;
        private NumericUpDown StartValNumericUpDown;
    }
}