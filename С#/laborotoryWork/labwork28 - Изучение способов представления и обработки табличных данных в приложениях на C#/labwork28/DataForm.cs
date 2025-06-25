using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labwork28
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }
        private void DataForm_Load(object sender, EventArgs e)
        {
            TableDataGridView.RowCount = 9;
            TableDataGridView.ColumnCount = 9;

            for (int i = 0; i < 9; i++)
            {
                TableDataGridView.Columns[i].HeaderText = (i+2).ToString();
                TableDataGridView.Rows[i].HeaderCell.Value = (i+2).ToString();
                for (int j = 0; j < TableDataGridView.ColumnCount; j++)
                {
                    TableDataGridView.Rows[i].Cells[j].Value = (i + 2) * (j + 2);
                }
            }
        }
        private void TableDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"{TableDataGridView.CurrentCell.ColumnIndex +2} * {TableDataGridView.CurrentCell.RowIndex + 2} = {TableDataGridView.CurrentCell.Value}");
        }
    }
}
