namespace labwork28
{
    partial class PetsForm
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
            components = new System.ComponentModel.Container();
            PetDataGridView = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kindDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            petClassBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)PetDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petClassBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PetDataGridView
            // 
            PetDataGridView.AllowUserToAddRows = false;
            PetDataGridView.AllowUserToDeleteRows = false;
            PetDataGridView.AutoGenerateColumns = false;
            PetDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PetDataGridView.BackgroundColor = Color.DarkSeaGreen;
            PetDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PetDataGridView.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, kindDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn });
            PetDataGridView.DataSource = petClassBindingSource;
            PetDataGridView.Location = new Point(14, 44);
            PetDataGridView.Margin = new Padding(3, 4, 3, 4);
            PetDataGridView.Name = "PetDataGridView";
            PetDataGridView.ReadOnly = true;
            PetDataGridView.RowHeadersWidth = 51;
            PetDataGridView.Size = new Size(765, 520);
            PetDataGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Кличка";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kindDataGridViewTextBoxColumn
            // 
            kindDataGridViewTextBoxColumn.DataPropertyName = "Kind";
            kindDataGridViewTextBoxColumn.HeaderText = "Вид";
            kindDataGridViewTextBoxColumn.MinimumWidth = 6;
            kindDataGridViewTextBoxColumn.Name = "kindDataGridViewTextBoxColumn";
            kindDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Возраст";
            ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // petClassBindingSource
            // 
            petClassBindingSource.DataSource = typeof(PetClass);
            // 
            // PetsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(795, 588);
            Controls.Add(PetDataGridView);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(813, 635);
            MinimumSize = new Size(813, 635);
            Name = "PetsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Питомцы";
            ((System.ComponentModel.ISupportInitialize)PetDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)petClassBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PetDataGridView;
        private BindingSource petClassBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kindDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    }
}