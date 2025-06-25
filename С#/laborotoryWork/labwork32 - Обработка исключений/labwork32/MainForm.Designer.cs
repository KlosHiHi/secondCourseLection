namespace labwork32
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ConfirmButton = new Button();
            SetXNumericUpDown = new NumericUpDown();
            SetZNumericUpDown = new NumericUpDown();
            SetANumericUpDown = new NumericUpDown();
            SetBNumericUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AnswerLabel = new Label();
            FormulaPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)SetXNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SetZNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SetANumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SetBNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FormulaPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = Color.Khaki;
            ConfirmButton.Cursor = Cursors.Hand;
            ConfirmButton.FlatStyle = FlatStyle.Popup;
            ConfirmButton.Location = new Point(8, 294);
            ConfirmButton.Margin = new Padding(4);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(118, 32);
            ConfirmButton.TabIndex = 0;
            ConfirmButton.Text = "Подсчитать";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // SetXNumericUpDown
            // 
            SetXNumericUpDown.Location = new Point(48, 135);
            SetXNumericUpDown.Margin = new Padding(4);
            SetXNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            SetXNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            SetXNumericUpDown.Name = "SetXNumericUpDown";
            SetXNumericUpDown.Size = new Size(78, 29);
            SetXNumericUpDown.TabIndex = 1;
            // 
            // SetZNumericUpDown
            // 
            SetZNumericUpDown.Location = new Point(48, 176);
            SetZNumericUpDown.Margin = new Padding(4);
            SetZNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            SetZNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            SetZNumericUpDown.Name = "SetZNumericUpDown";
            SetZNumericUpDown.Size = new Size(78, 29);
            SetZNumericUpDown.TabIndex = 2;
            // 
            // SetANumericUpDown
            // 
            SetANumericUpDown.Location = new Point(48, 216);
            SetANumericUpDown.Margin = new Padding(4);
            SetANumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            SetANumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            SetANumericUpDown.Name = "SetANumericUpDown";
            SetANumericUpDown.Size = new Size(78, 29);
            SetANumericUpDown.TabIndex = 3;
            // 
            // SetBNumericUpDown
            // 
            SetBNumericUpDown.Location = new Point(48, 257);
            SetBNumericUpDown.Margin = new Padding(4);
            SetBNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            SetBNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            SetBNumericUpDown.Name = "SetBNumericUpDown";
            SetBNumericUpDown.Size = new Size(78, 29);
            SetBNumericUpDown.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 138);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 21);
            label1.TabIndex = 5;
            label1.Text = "x =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 179);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 21);
            label2.TabIndex = 6;
            label2.Text = "z =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 257);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 21);
            label3.TabIndex = 7;
            label3.Text = "b =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 219);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(33, 21);
            label4.TabIndex = 8;
            label4.Text = "a =";
            // 
            // AnswerLabel
            // 
            AnswerLabel.AutoSize = true;
            AnswerLabel.BackColor = Color.Transparent;
            AnswerLabel.Location = new Point(133, 300);
            AnswerLabel.Name = "AnswerLabel";
            AnswerLabel.Size = new Size(52, 21);
            AnswerLabel.TabIndex = 9;
            AnswerLabel.Text = "Ответ";
            // 
            // FormulaPictureBox
            // 
            FormulaPictureBox.BackColor = Color.Black;
            FormulaPictureBox.BackgroundImageLayout = ImageLayout.Center;
            FormulaPictureBox.BorderStyle = BorderStyle.FixedSingle;
            FormulaPictureBox.Image = Properties.Resources.Снимок;
            FormulaPictureBox.InitialImage = (Image)resources.GetObject("FormulaPictureBox.InitialImage");
            FormulaPictureBox.Location = new Point(12, 12);
            FormulaPictureBox.Name = "FormulaPictureBox";
            FormulaPictureBox.Size = new Size(405, 114);
            FormulaPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            FormulaPictureBox.TabIndex = 10;
            FormulaPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(424, 331);
            Controls.Add(FormulaPictureBox);
            Controls.Add(AnswerLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SetBNumericUpDown);
            Controls.Add(SetANumericUpDown);
            Controls.Add(SetZNumericUpDown);
            Controls.Add(SetXNumericUpDown);
            Controls.Add(ConfirmButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MaximumSize = new Size(440, 370);
            MinimumSize = new Size(440, 370);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Решение выражения";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)SetXNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)SetZNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)SetANumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)SetBNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)FormulaPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConfirmButton;
        private NumericUpDown SetXNumericUpDown;
        private NumericUpDown SetZNumericUpDown;
        private NumericUpDown SetANumericUpDown;
        private NumericUpDown SetBNumericUpDown;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label AnswerLabel;
        private PictureBox FormulaPictureBox;
    }
}
