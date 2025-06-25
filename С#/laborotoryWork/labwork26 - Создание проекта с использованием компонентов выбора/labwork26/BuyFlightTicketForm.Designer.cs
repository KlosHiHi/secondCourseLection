namespace labwork26
{
    partial class BuyFlightTicketForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CityDepartTextBox = new TextBox();
            CityArriveTextBox = new TextBox();
            ArrivalDateTimePicker = new DateTimePicker();
            DateDepartureDateTimePicker = new DateTimePicker();
            OrderTicketButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 0;
            label1.Text = "Город вылета";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(205, 29);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 1;
            label2.Text = "Город прилёта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 2;
            label3.Text = "Дата вылета";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(203, 113);
            label4.Name = "label4";
            label4.Size = new Size(144, 21);
            label4.TabIndex = 3;
            label4.Text = "Дата возвращения";
            // 
            // CityDepartTextBox
            // 
            CityDepartTextBox.Location = new Point(12, 53);
            CityDepartTextBox.Name = "CityDepartTextBox";
            CityDepartTextBox.Size = new Size(185, 29);
            CityDepartTextBox.TabIndex = 4;
            // 
            // CityArriveTextBox
            // 
            CityArriveTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CityArriveTextBox.Location = new Point(205, 53);
            CityArriveTextBox.Name = "CityArriveTextBox";
            CityArriveTextBox.Size = new Size(185, 29);
            CityArriveTextBox.TabIndex = 5;
            // 
            // ArrivalDateTimePicker
            // 
            ArrivalDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ArrivalDateTimePicker.Location = new Point(203, 137);
            ArrivalDateTimePicker.Name = "ArrivalDateTimePicker";
            ArrivalDateTimePicker.ShowCheckBox = true;
            ArrivalDateTimePicker.Size = new Size(185, 29);
            ArrivalDateTimePicker.TabIndex = 6;
            // 
            // DateDepartureDateTimePicker
            // 
            DateDepartureDateTimePicker.Location = new Point(12, 137);
            DateDepartureDateTimePicker.MinDate = new DateTime(2024, 11, 19, 15, 49, 43, 0);
            DateDepartureDateTimePicker.Name = "DateDepartureDateTimePicker";
            DateDepartureDateTimePicker.Size = new Size(185, 29);
            DateDepartureDateTimePicker.TabIndex = 7;
            DateDepartureDateTimePicker.Value = new DateTime(2024, 11, 19, 15, 49, 43, 0);
            DateDepartureDateTimePicker.ValueChanged += DateDepartureDateTimePicker_ValueChanged;
            // 
            // OrderTicketButton
            // 
            OrderTicketButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OrderTicketButton.BackColor = Color.Snow;
            OrderTicketButton.Location = new Point(302, 217);
            OrderTicketButton.Name = "OrderTicketButton";
            OrderTicketButton.Size = new Size(88, 32);
            OrderTicketButton.TabIndex = 8;
            OrderTicketButton.Text = "Заказать";
            OrderTicketButton.UseVisualStyleBackColor = false;
            OrderTicketButton.Click += OrderTicketButton_Click;
            // 
            // BuyFlightTicketForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(414, 264);
            Controls.Add(OrderTicketButton);
            Controls.Add(DateDepartureDateTimePicker);
            Controls.Add(ArrivalDateTimePicker);
            Controls.Add(CityArriveTextBox);
            Controls.Add(CityDepartTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MaximumSize = new Size(430, 303);
            Name = "BuyFlightTicketForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Покупка билетов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox CityDepartTextBox;
        private TextBox CityArriveTextBox;
        private DateTimePicker ArrivalDateTimePicker;
        private DateTimePicker DateDepartureDateTimePicker;
        private Button OrderTicketButton;
    }
}