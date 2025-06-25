namespace labwork26
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
            ToSubFormButton = new Button();
            button1 = new Button();
            ToBuyFlightTicketFormButton = new Button();
            SuspendLayout();
            // 
            // ToSubFormButton
            // 
            ToSubFormButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ToSubFormButton.BackColor = Color.Snow;
            ToSubFormButton.Location = new Point(64, 45);
            ToSubFormButton.Margin = new Padding(4);
            ToSubFormButton.Name = "ToSubFormButton";
            ToSubFormButton.Size = new Size(228, 32);
            ToSubFormButton.TabIndex = 0;
            ToSubFormButton.Text = "Подписаться на рассылку";
            ToSubFormButton.UseVisualStyleBackColor = false;
            ToSubFormButton.Click += ToSubFormButton_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Snow;
            button1.Location = new Point(64, 104);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(228, 32);
            button1.TabIndex = 1;
            button1.Text = "Перевод длины в метры";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ToBuyFlightTicketFormButton
            // 
            ToBuyFlightTicketFormButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ToBuyFlightTicketFormButton.BackColor = Color.Snow;
            ToBuyFlightTicketFormButton.Location = new Point(64, 164);
            ToBuyFlightTicketFormButton.Margin = new Padding(4);
            ToBuyFlightTicketFormButton.Name = "ToBuyFlightTicketFormButton";
            ToBuyFlightTicketFormButton.Size = new Size(228, 32);
            ToBuyFlightTicketFormButton.TabIndex = 2;
            ToBuyFlightTicketFormButton.Text = "Купить билеты на рейс";
            ToBuyFlightTicketFormButton.UseVisualStyleBackColor = false;
            ToBuyFlightTicketFormButton.Click += ToBuyFlightTicketFormButton_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Bisque;
            ClientSize = new Size(364, 361);
            Controls.Add(ToBuyFlightTicketFormButton);
            Controls.Add(button1);
            Controls.Add(ToSubFormButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MaximumSize = new Size(380, 400);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Начальная страница";
            ResumeLayout(false);
        }

        #endregion

        private Button ToSubFormButton;
        private Button button1;
        private Button ToBuyFlightTicketFormButton;
    }
}
