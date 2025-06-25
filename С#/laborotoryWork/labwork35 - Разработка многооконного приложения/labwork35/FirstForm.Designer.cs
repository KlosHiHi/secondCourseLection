namespace labwork35
{
    partial class FirstForm
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
            IcecreamCarPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)IcecreamCarPictureBox).BeginInit();
            SuspendLayout();
            // 
            // IcecreamCarPictureBox
            // 
            IcecreamCarPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IcecreamCarPictureBox.Image = Properties.Resources.I_committed_a_crime_by_forgetting_to_include_the_RiceCream_truck;
            IcecreamCarPictureBox.Location = new Point(-3, -5);
            IcecreamCarPictureBox.Name = "IcecreamCarPictureBox";
            IcecreamCarPictureBox.Size = new Size(709, 457);
            IcecreamCarPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            IcecreamCarPictureBox.TabIndex = 0;
            IcecreamCarPictureBox.TabStop = false;
            // 
            // FirstForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(662, 453);
            Controls.Add(IcecreamCarPictureBox);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MaximumSize = new Size(680, 500);
            MinimumSize = new Size(340, 250);
            Name = "FirstForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Фургон мороженного";
            ((System.ComponentModel.ISupportInitialize)IcecreamCarPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox IcecreamCarPictureBox;
    }
}