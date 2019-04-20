using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class ykea : Form
    {
        public ykea()
        {
            InitializeComponent();
            saloLabel.Text = "салоcoin : " + MagazinForm.money.ToString();
        }

        private void saloLabel_Click(object sender, EventArgs e)
        {
        }
    }
}
