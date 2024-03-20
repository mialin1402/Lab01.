using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01
{
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtso1.Text = "";
            txtso2.Text = "";
            txtso3.Text = "";
            txtsolon.Text = "";
            txtsonho.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int so1 = Convert.ToInt32(txtso1.Text);
            int so2 = Convert.ToInt32(txtso2.Text);
            int so3 = Convert.ToInt32(txtso3.Text);

            // Tìm số lớn nhất
            int max = so1;
            if (so2 > max) max = so2;
            if (so3 > max) max = so3;
            txtsolon.Text = Convert.ToString(max);

            // Tìm số nhỏ nhất
            int min = so1;
            if (so2 < min) min = so2;
            if (so3 < min) min = so3;
            txtsonho.Text = Convert.ToString(min);

        }
    }
}
