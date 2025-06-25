namespace labWork25
{
    partial class labWork25
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
            BirthDateTimePicker = new DateTimePicker();
            label1 = new Label();
            AgeLabel = new Label();
            TemperatureTrackBar = new TrackBar();
            TemperatureLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SquareLabel = new Label();
            VolumeLabel = new Label();
            RadiusNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)TemperatureTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadiusNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // BirthDateTimePicker
            // 
            BirthDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BirthDateTimePicker.CalendarMonthBackground = Color.Ivory;
            BirthDateTimePicker.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BirthDateTimePicker.Location = new Point(27, 78);
            BirthDateTimePicker.Margin = new Padding(4);
            BirthDateTimePicker.Name = "BirthDateTimePicker";
            BirthDateTimePicker.Size = new Size(256, 27);
            BirthDateTimePicker.TabIndex = 0;
            BirthDateTimePicker.ValueChanged += BirthDateTimePicker_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F);
            label1.Location = new Point(27, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 1;
            label1.Text = "Дата рождения";
            // 
            // AgeLabel
            // 
            AgeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AgeLabel.AutoSize = true;
            AgeLabel.Font = new Font("Impact", 12F);
            AgeLabel.Location = new Point(336, 78);
            AgeLabel.Margin = new Padding(4, 0, 4, 0);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(71, 20);
            AgeLabel.TabIndex = 2;
            AgeLabel.Text = "Возраст: ";
            // 
            // TemperatureTrackBar
            // 
            TemperatureTrackBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TemperatureTrackBar.Location = new Point(27, 207);
            TemperatureTrackBar.Margin = new Padding(4);
            TemperatureTrackBar.Maximum = 50;
            TemperatureTrackBar.Minimum = 10;
            TemperatureTrackBar.Name = "TemperatureTrackBar";
            TemperatureTrackBar.Size = new Size(257, 45);
            TemperatureTrackBar.TabIndex = 3;
            TemperatureTrackBar.Value = 10;
            TemperatureTrackBar.Scroll += TemperatureTrackBar_Scroll;
            // 
            // TemperatureLabel
            // 
            TemperatureLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TemperatureLabel.AutoSize = true;
            TemperatureLabel.Font = new Font("Impact", 12F);
            TemperatureLabel.Location = new Point(336, 207);
            TemperatureLabel.Margin = new Padding(4, 0, 4, 0);
            TemperatureLabel.Name = "TemperatureLabel";
            TemperatureLabel.Size = new Size(104, 20);
            TemperatureLabel.TabIndex = 4;
            TemperatureLabel.Text = "Температура: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F);
            label2.Location = new Point(27, 182);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 5;
            label2.Text = "Комнатная температура";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 12F);
            label3.Location = new Point(9, 224);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 6;
            label3.Text = "10";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 12F);
            label4.Location = new Point(276, 224);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 7;
            label4.Text = "50";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 12F);
            label5.Location = new Point(27, 322);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 9;
            label5.Text = "Радиус сферы";
            // 
            // SquareLabel
            // 
            SquareLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SquareLabel.AutoSize = true;
            SquareLabel.Font = new Font("Impact", 12F);
            SquareLabel.Location = new Point(336, 340);
            SquareLabel.Margin = new Padding(4, 0, 4, 0);
            SquareLabel.Name = "SquareLabel";
            SquareLabel.Size = new Size(77, 20);
            SquareLabel.TabIndex = 10;
            SquareLabel.Text = "Площадь:";
            // 
            // VolumeLabel
            // 
            VolumeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VolumeLabel.AutoSize = true;
            VolumeLabel.Font = new Font("Impact", 12F);
            VolumeLabel.Location = new Point(336, 361);
            VolumeLabel.Margin = new Padding(4, 0, 4, 0);
            VolumeLabel.Name = "VolumeLabel";
            VolumeLabel.Size = new Size(57, 20);
            VolumeLabel.TabIndex = 11;
            VolumeLabel.Text = "Объём:";
            // 
            // RadiusNumericUpDown
            // 
            RadiusNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RadiusNumericUpDown.BackColor = Color.White;
            RadiusNumericUpDown.DecimalPlaces = 3;
            RadiusNumericUpDown.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RadiusNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            RadiusNumericUpDown.Location = new Point(27, 348);
            RadiusNumericUpDown.Margin = new Padding(5, 6, 5, 6);
            RadiusNumericUpDown.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            RadiusNumericUpDown.Name = "RadiusNumericUpDown";
            RadiusNumericUpDown.Size = new Size(256, 27);
            RadiusNumericUpDown.TabIndex = 12;
            RadiusNumericUpDown.ValueChanged += RadiusNumericUpDown_ValueChanged;
            // 
            // labWork25
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(606, 503);
            Controls.Add(RadiusNumericUpDown);
            Controls.Add(VolumeLabel);
            Controls.Add(SquareLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TemperatureLabel);
            Controls.Add(TemperatureTrackBar);
            Controls.Add(AgeLabel);
            Controls.Add(label1);
            Controls.Add(BirthDateTimePicker);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "labWork25";
            Text = "Начальная страница";
            Load += labWork25_Load;
            ((System.ComponentModel.ISupportInitialize)TemperatureTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadiusNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker BirthDateTimePicker;
        private Label label1;
        private Label AgeLabel;
        private TrackBar TemperatureTrackBar;
        private Label TemperatureLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label SquareLabel;
        private Label VolumeLabel;
        private NumericUpDown RadiusNumericUpDown;
    }
}
