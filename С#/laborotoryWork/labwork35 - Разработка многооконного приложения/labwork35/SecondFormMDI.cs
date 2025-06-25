using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labwork35
{
    public partial class SecondFormMDI : Form
    {
        private FirstForm _firstForm;
        public FirstForm FirstForm
        {
            get
            {
                bool isNull = _firstForm == null || _firstForm.IsDisposed;
                return isNull ? _firstForm = new FirstForm() { MdiParent = this } : _firstForm;
            }
        }
        private ThirdForm _thirdForm;
        private ThirdForm ThirdForm
        {
            get
            {
                bool isNull = _thirdForm == null || _thirdForm.IsDisposed;
                return isNull ? _thirdForm = new ThirdForm() { MdiParent = this } : _thirdForm;
            }
        }

        private FourthForm _fourthForm;
        private FourthForm FourthForm
        {
            get
            {
                bool isNull = _fourthForm == null || _fourthForm.IsDisposed;
                return isNull ? _fourthForm = new FourthForm() { MdiParent = this } : _fourthForm;
            }
        }

        public SecondFormMDI()
        {
            InitializeComponent();
        }

        private void IceCreamFormMenuItem_Click(object sender, EventArgs e)
        {
            FirstForm.MdiParent = this;
            FirstForm.Show();
        }

        private void WatermelonFormMenuItem_Click(object sender, EventArgs e)
        {
            ThirdForm.MdiParent = this;
            ThirdForm.Show();
        }
        private void BeachSitMenuItem_Click(object sender, EventArgs e)
        {
            FourthForm.MdiParent = this;
            FourthForm.Show();
        }

        private void CloseFormsMenuItem_Click(object sender, EventArgs e)
        {
            FirstForm.Close();
            ThirdForm.Close();
            FourthForm.Close();
        }

    }
}
