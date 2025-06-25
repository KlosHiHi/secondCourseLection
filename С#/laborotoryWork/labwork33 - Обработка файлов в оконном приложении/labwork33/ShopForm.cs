using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace labwork33
{
    public partial class ShopForm : Form
    {
        public ShopForm()
        {
            InitializeComponent();
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            if (ShopFormSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filename = ShopFormSaveFileDialog.FileName;

                    for (int i = 0; i < ShopDataGridView.ColumnCount; i++)
                    {
                        File.AppendAllText(filename, ($"{(string)ShopDataGridView.Columns[i].HeaderCell.Value};"));
                    }
                    File.AppendAllText(filename, "\n");

                    for (int i = 0; i < ShopDataGridView.RowCount; i++)
                    {
                        for (int j = 0; j < ShopDataGridView.ColumnCount; j++)
                        {
                            File.AppendAllText(filename, ($"{(string)ShopDataGridView.Rows[i].Cells[j].Value};"));
                        }
                        File.AppendAllText(filename, "\n");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка сохранения");
                }
            }
        }
    }
}
