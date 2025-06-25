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
    public partial class PetsForm : Form
    {
        private Pets _petClass;
        public PetsForm()
        {
            InitializeComponent();
            _petClass = new Pets();
            PetDataGridView.DataSource = _petClass.all;
        }
    }
}
