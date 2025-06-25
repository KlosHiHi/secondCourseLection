namespace labwork33
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
            ShopDataGridView = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            SaveFileButton = new Button();
            ShopFormSaveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)ShopDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ShopDataGridView
            // 
            ShopDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ShopDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ShopDataGridView.BackgroundColor = Color.Snow;
            ShopDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShopDataGridView.Columns.AddRange(new DataGridViewColumn[] { Product, Price, Quantity });
            ShopDataGridView.Dock = DockStyle.Top;
            ShopDataGridView.Location = new Point(0, 0);
            ShopDataGridView.Margin = new Padding(3, 4, 3, 4);
            ShopDataGridView.Name = "ShopDataGridView";
            ShopDataGridView.RowHeadersWidth = 51;
            ShopDataGridView.Size = new Size(896, 528);
            ShopDataGridView.TabIndex = 0;
            // 
            // Product
            // 
            Product.HeaderText = "Товар";
            Product.MinimumWidth = 6;
            Product.Name = "Product";
            // 
            // Price
            // 
            Price.HeaderText = "Цена";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Количество";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // SaveFileButton
            // 
            SaveFileButton.BackColor = Color.White;
            SaveFileButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaveFileButton.Location = new Point(760, 553);
            SaveFileButton.Margin = new Padding(3, 4, 3, 4);
            SaveFileButton.Name = "SaveFileButton";
            SaveFileButton.Size = new Size(122, 45);
            SaveFileButton.TabIndex = 1;
            SaveFileButton.Text = "Сохранить";
            SaveFileButton.UseVisualStyleBackColor = false;
            SaveFileButton.Click += SaveFileButton_Click;
            // 
            // ShopFormSaveFileDialog
            // 
            ShopFormSaveFileDialog.FileName = "table.csv";
            ShopFormSaveFileDialog.Filter = "Файл csv|*.csv|Текстовый файл|*.txt";
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(896, 615);
            Controls.Add(SaveFileButton);
            Controls.Add(ShopDataGridView);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(912, 651);
            Name = "ShopForm";
            Text = "Магазин";
            ((System.ComponentModel.ISupportInitialize)ShopDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ShopDataGridView;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private Button SaveFileButton;
        private SaveFileDialog ShopFormSaveFileDialog;
    }
}