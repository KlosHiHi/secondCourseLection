namespace WinFormsApp1
{
    partial class TicketForm
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
            label1 = new Label();
            ToPlaceComboBox = new ComboBox();
            FromPlaceComboBox = new ComboBox();
            label2 = new Label();
            OrderButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 32);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Город вылета";
            // 
            // ToPlaceComboBox
            // 
            ToPlaceComboBox.BackColor = Color.PeachPuff;
            ToPlaceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ToPlaceComboBox.FormattingEnabled = true;
            ToPlaceComboBox.Items.AddRange(new object[] { "Абу-Даби", "Армавир", "Астрахань", "Бангладеш", "Иран", "Киото", "Кисловодск", "Лондон", "Мехико", "Москва", "Нью-Йорк", "Оренбург", "Санкт-Петербург", "Сингапур", "Токио" });
            ToPlaceComboBox.Location = new Point(117, 109);
            ToPlaceComboBox.Name = "ToPlaceComboBox";
            ToPlaceComboBox.Size = new Size(121, 23);
            ToPlaceComboBox.Sorted = true;
            ToPlaceComboBox.TabIndex = 1;
            // 
            // FromPlaceComboBox
            // 
            FromPlaceComboBox.BackColor = Color.PeachPuff;
            FromPlaceComboBox.Enabled = false;
            FromPlaceComboBox.FormattingEnabled = true;
            FromPlaceComboBox.Items.AddRange(new object[] { "Архангельск" });
            FromPlaceComboBox.Location = new Point(117, 50);
            FromPlaceComboBox.Name = "FromPlaceComboBox";
            FromPlaceComboBox.Size = new Size(121, 23);
            FromPlaceComboBox.TabIndex = 2;
            FromPlaceComboBox.Text = "Архангельск";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 91);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "Город прилёта";
            // 
            // OrderButton
            // 
            OrderButton.BackColor = Color.PeachPuff;
            OrderButton.Location = new Point(117, 215);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(121, 39);
            OrderButton.TabIndex = 4;
            OrderButton.Text = "Заказать";
            OrderButton.UseVisualStyleBackColor = false;
            OrderButton.Click += OrderButton_Click;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(360, 287);
            Controls.Add(OrderButton);
            Controls.Add(label2);
            Controls.Add(FromPlaceComboBox);
            Controls.Add(ToPlaceComboBox);
            Controls.Add(label1);
            MaximumSize = new Size(376, 326);
            Name = "TicketForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Заказ билета";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox ToPlaceComboBox;
        private ComboBox FromPlaceComboBox;
        private Label label2;
        private Button OrderButton;
    }
}