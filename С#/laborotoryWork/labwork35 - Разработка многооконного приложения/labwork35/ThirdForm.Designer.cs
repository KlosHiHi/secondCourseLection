namespace labwork35
{
    partial class ThirdForm
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
            WatermelonPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)WatermelonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // WatermelonPictureBox
            // 
            WatermelonPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WatermelonPictureBox.BackColor = Color.Transparent;
            WatermelonPictureBox.Image = Properties.Resources.Actual_watermelon_smashing;
            WatermelonPictureBox.Location = new Point(-14, -6);
            WatermelonPictureBox.Name = "WatermelonPictureBox";
            WatermelonPictureBox.Size = new Size(693, 461);
            WatermelonPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            WatermelonPictureBox.TabIndex = 0;
            WatermelonPictureBox.TabStop = false;
            // 
            // ThirdForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(682, 453);
            Controls.Add(WatermelonPictureBox);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MaximumSize = new Size(700, 500);
            MinimumSize = new Size(200, 150);
            Name = "ThirdForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Инцидент с арбузом";
            ((System.ComponentModel.ISupportInitialize)WatermelonPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox WatermelonPictureBox;
    }
}