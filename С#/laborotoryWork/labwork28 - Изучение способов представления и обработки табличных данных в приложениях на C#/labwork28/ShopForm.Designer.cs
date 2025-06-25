namespace labwork28
{
    partial class ShopForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ShopDataGridView = new DataGridView();
            Code = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Сount = new DataGridViewTextBoxColumn();
            InBasket = new DataGridViewCheckBoxColumn();
            TotalCountLabel = new Label();
            OrderButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ShopDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ShopDataGridView
            // 
            ShopDataGridView.AllowUserToAddRows = false;
            ShopDataGridView.AllowUserToDeleteRows = false;
            ShopDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ShopDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ShopDataGridView.BackgroundColor = Color.DarkSeaGreen;
            ShopDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ShopDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ShopDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShopDataGridView.Columns.AddRange(new DataGridViewColumn[] { Code, Title, Сount, InBasket });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ShopDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            ShopDataGridView.GridColor = Color.DarkSlateGray;
            ShopDataGridView.Location = new Point(14, 85);
            ShopDataGridView.Margin = new Padding(3, 4, 3, 4);
            ShopDataGridView.Name = "ShopDataGridView";
            ShopDataGridView.RowHeadersWidth = 51;
            ShopDataGridView.Size = new Size(885, 499);
            ShopDataGridView.TabIndex = 0;
            ShopDataGridView.CellContentClick += ShopDataGridView_CellContentClick;
            ShopDataGridView.CellValueChanged += ShopDataGridView_CellValueChanged;
            // 
            // Code
            // 
            Code.HeaderText = "Код";
            Code.MinimumWidth = 6;
            Code.Name = "Code";
            // 
            // Title
            // 
            Title.HeaderText = "Название";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            // 
            // Сount
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            Сount.DefaultCellStyle = dataGridViewCellStyle2;
            Сount.HeaderText = "Цена";
            Сount.MinimumWidth = 6;
            Сount.Name = "Сount";
            // 
            // InBasket
            // 
            InBasket.HeaderText = "В корзину";
            InBasket.MinimumWidth = 6;
            InBasket.Name = "InBasket";
            InBasket.Resizable = DataGridViewTriState.True;
            InBasket.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // TotalCountLabel
            // 
            TotalCountLabel.AutoSize = true;
            TotalCountLabel.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalCountLabel.Location = new Point(14, 31);
            TotalCountLabel.Name = "TotalCountLabel";
            TotalCountLabel.Size = new Size(64, 23);
            TotalCountLabel.TabIndex = 1;
            TotalCountLabel.Text = "ИТОГ:";
            // 
            // OrderButton
            // 
            OrderButton.BackColor = Color.OliveDrab;
            OrderButton.Location = new Point(739, 16);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(139, 51);
            OrderButton.TabIndex = 2;
            OrderButton.Text = "Заказать";
            OrderButton.UseVisualStyleBackColor = false;
            OrderButton.Click += OrderButton_Click;
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(912, 603);
            Controls.Add(OrderButton);
            Controls.Add(TotalCountLabel);
            Controls.Add(ShopDataGridView);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(930, 650);
            MinimumSize = new Size(930, 650);
            Name = "ShopForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список Товаров";
            Load += ShopForm_Load;
            ((System.ComponentModel.ISupportInitialize)ShopDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ShopDataGridView;
        private Label TotalCountLabel;
        private Button OrderButton;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Сount;
        private DataGridViewCheckBoxColumn InBasket;
    }
}