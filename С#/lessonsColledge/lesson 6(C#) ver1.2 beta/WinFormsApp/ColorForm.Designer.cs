namespace WinFormsApp
{
    partial class ColorForm
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
            redTrackBar = new TrackBar();
            blueTrackBar = new TrackBar();
            greenTrackBar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            redNumericUpDown = new NumericUpDown();
            greenNumericUpDown = new NumericUpDown();
            blueNumericUpDown = new NumericUpDown();
            ColorComboBox = new ComboBox();
            SelectColorButton = new Button();
            SelectColorDialog = new ColorDialog();
            ConfirmButton = new Button();
            ((System.ComponentModel.ISupportInitialize)redTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // redTrackBar
            // 
            redTrackBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            redTrackBar.Location = new Point(36, 20);
            redTrackBar.Margin = new Padding(5);
            redTrackBar.Maximum = 255;
            redTrackBar.Name = "redTrackBar";
            redTrackBar.Size = new Size(411, 45);
            redTrackBar.TabIndex = 0;
            redTrackBar.ValueChanged += Color_ValueChanged;
            // 
            // blueTrackBar
            // 
            blueTrackBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            blueTrackBar.Location = new Point(36, 130);
            blueTrackBar.Margin = new Padding(5);
            blueTrackBar.Maximum = 255;
            blueTrackBar.Name = "blueTrackBar";
            blueTrackBar.Size = new Size(408, 45);
            blueTrackBar.TabIndex = 1;
            blueTrackBar.ValueChanged += Color_ValueChanged;
            // 
            // greenTrackBar
            // 
            greenTrackBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            greenTrackBar.Location = new Point(36, 75);
            greenTrackBar.Margin = new Padding(5);
            greenTrackBar.Maximum = 255;
            greenTrackBar.Name = "greenTrackBar";
            greenTrackBar.Size = new Size(408, 45);
            greenTrackBar.TabIndex = 2;
            greenTrackBar.ValueChanged += Color_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(0, 20);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 25);
            label1.TabIndex = 3;
            label1.Text = "R";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(-2, 75);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(26, 25);
            label2.TabIndex = 4;
            label2.Text = "G";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(0, 130);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(24, 25);
            label3.TabIndex = 5;
            label3.Text = "B";
            // 
            // redNumericUpDown
            // 
            redNumericUpDown.Anchor = AnchorStyles.Right;
            redNumericUpDown.BackColor = Color.Snow;
            redNumericUpDown.ForeColor = SystemColors.GrayText;
            redNumericUpDown.Location = new Point(457, 18);
            redNumericUpDown.Margin = new Padding(5);
            redNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            redNumericUpDown.Name = "redNumericUpDown";
            redNumericUpDown.Size = new Size(83, 33);
            redNumericUpDown.TabIndex = 6;
            redNumericUpDown.ValueChanged += Color_ValueChanged;
            // 
            // greenNumericUpDown
            // 
            greenNumericUpDown.Anchor = AnchorStyles.Right;
            greenNumericUpDown.BackColor = Color.Snow;
            greenNumericUpDown.ForeColor = SystemColors.GrayText;
            greenNumericUpDown.Location = new Point(457, 73);
            greenNumericUpDown.Margin = new Padding(5);
            greenNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            greenNumericUpDown.Name = "greenNumericUpDown";
            greenNumericUpDown.Size = new Size(83, 33);
            greenNumericUpDown.TabIndex = 7;
            greenNumericUpDown.ValueChanged += Color_ValueChanged;
            // 
            // blueNumericUpDown
            // 
            blueNumericUpDown.Anchor = AnchorStyles.Right;
            blueNumericUpDown.BackColor = Color.Snow;
            blueNumericUpDown.ForeColor = SystemColors.GrayText;
            blueNumericUpDown.Location = new Point(457, 130);
            blueNumericUpDown.Margin = new Padding(5);
            blueNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            blueNumericUpDown.Name = "blueNumericUpDown";
            blueNumericUpDown.Size = new Size(83, 33);
            blueNumericUpDown.TabIndex = 8;
            blueNumericUpDown.ValueChanged += Color_ValueChanged;
            // 
            // ColorComboBox
            // 
            ColorComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ColorComboBox.FormattingEnabled = true;
            ColorComboBox.Location = new Point(12, 172);
            ColorComboBox.Name = "ColorComboBox";
            ColorComboBox.Size = new Size(255, 33);
            ColorComboBox.TabIndex = 9;
            ColorComboBox.SelectedIndexChanged += ColorComboBox_SelectedIndexChanged;
            // 
            // SelectColorButton
            // 
            SelectColorButton.Location = new Point(273, 171);
            SelectColorButton.Name = "SelectColorButton";
            SelectColorButton.Size = new Size(269, 33);
            SelectColorButton.TabIndex = 10;
            SelectColorButton.Text = "Выбрать";
            SelectColorButton.UseVisualStyleBackColor = true;
            SelectColorButton.Click += SelectColorButton_Click;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(12, 208);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(530, 33);
            ConfirmButton.TabIndex = 11;
            ConfirmButton.Text = "Подтвердить";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // ColorForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 244);
            Controls.Add(ConfirmButton);
            Controls.Add(SelectColorButton);
            Controls.Add(ColorComboBox);
            Controls.Add(blueNumericUpDown);
            Controls.Add(greenNumericUpDown);
            Controls.Add(redNumericUpDown);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(greenTrackBar);
            Controls.Add(blueTrackBar);
            Controls.Add(redTrackBar);
            Margin = new Padding(8);
            MaximumSize = new Size(570, 283);
            Name = "ColorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выбор цвета";
            Load += ColorForm_Load;
            ((System.ComponentModel.ISupportInitialize)redTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)redNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar redTrackBar;
        private TrackBar blueTrackBar;
        private TrackBar greenTrackBar;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown redNumericUpDown;
        private NumericUpDown greenNumericUpDown;
        private NumericUpDown blueNumericUpDown;
        private ComboBox ColorComboBox;
        private Button SelectColorButton;
        private ColorDialog SelectColorDialog;
        private Button ConfirmButton;
    }
}