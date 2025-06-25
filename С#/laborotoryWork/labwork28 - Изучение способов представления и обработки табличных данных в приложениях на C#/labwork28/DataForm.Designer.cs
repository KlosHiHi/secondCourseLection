namespace labwork28
{
    partial class DataForm
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
            TableDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TableDataGridView).BeginInit();
            SuspendLayout();
            // 
            // TableDataGridView
            // 
            TableDataGridView.AllowUserToAddRows = false;
            TableDataGridView.AllowUserToDeleteRows = false;
            TableDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TableDataGridView.BackgroundColor = Color.DarkSeaGreen;
            TableDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableDataGridView.Location = new Point(14, 93);
            TableDataGridView.Margin = new Padding(3, 4, 3, 4);
            TableDataGridView.Name = "TableDataGridView";
            TableDataGridView.ReadOnly = true;
            TableDataGridView.RowHeadersWidth = 51;
            TableDataGridView.Size = new Size(887, 433);
            TableDataGridView.TabIndex = 0;
            TableDataGridView.CellContentDoubleClick += TableDataGridView_CellContentDoubleClick;
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(912, 571);
            Controls.Add(TableDataGridView);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(930, 618);
            MinimumSize = new Size(930, 618);
            Name = "DataForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataForm";
            Load += DataForm_Load;
            ((System.ComponentModel.ISupportInitialize)TableDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TableDataGridView;
    }
}