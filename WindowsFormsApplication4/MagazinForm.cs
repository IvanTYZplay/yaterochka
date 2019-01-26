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
    public partial class MagazinForm : Form
    {
        public MagazinForm()
        {
            InitializeComponent();
        }

        private void MagazinForm_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(productsPanel1);
        }

        /// <summary>
        /// 1 страница
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(productsPanel1);
        }

        /// <summary>
        /// 2 страница
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(productsPanel2);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
