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
    public partial class ShopForm : Form
    {
        private string titles = "";
        private double totalC = 0;
        private bool check = false;
        public ShopForm()
        {
            InitializeComponent();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            ShopDataGridView.Rows.Add(1, "Молоко", 69.49, false);
            ShopDataGridView.Rows.Add(2, "Масло", 99.99, false);
            ShopDataGridView.Rows.Add(3, "Творог", 109.5, false);
            ShopDataGridView.Rows.Add(4, "Чай", 99.0, false);
            ShopDataGridView.Rows.Add(5, "Кофе", 199.99, false);
            ShopDataGridView.Rows.Add(6, "Рис", 79.99, false);
            ShopDataGridView.Rows.Add(7, "Гречка", 49.0, false);
            ShopDataGridView.Rows.Add(8, "Огурчики 1кг", 99.0, false);
            ShopDataGridView.Rows.Add(9, "Помидоры 1кг", 129.9, false);
            ShopDataGridView.Rows.Add(10, "Яблоки 1кг", 89.99, false);
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    ShopDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.DarkGoldenrod;
                }
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (ShopDataGridView[3, i].Value != null && (bool)ShopDataGridView[3, i].Value)
                {
                    check = true;
                    break;
                }
                else
                {
                    check = false;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if(ShopDataGridView[3, i].Value != null && (bool)ShopDataGridView[3, i].Value)
                {
                    totalC += (double)ShopDataGridView[2, i].Value;
                }
            }

            totalC = Math.Round(totalC * 100) / 100;

            if (!check)
            {
                MessageBox.Show("Вы ничего не выбрали", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                totalC = 0;
            }
            else
            {
                MessageBox.Show($"{totalC}₽", "Успех");
                totalC = 0;
            }
        }

        private void ShopDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (ShopDataGridView[3, i].Value != null && (bool)ShopDataGridView[3, i].Value)
                {
                    titles += ShopDataGridView[1, i].Value + " ";
                    check = true;
                    //totalC += (float)ShopDataGridView[2, i].Value;
                }
                else
                {
                    titles += "";
                }
            }
            TotalCountLabel.Text = $"ИТОГ: {titles}";
            titles = "";
        }

        private void ShopDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
