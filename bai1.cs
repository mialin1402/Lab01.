using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB01
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtso1.Text.Trim(), out int num1) && int.TryParse(txtso2.Text.Trim(), out int num2))
            {
                // Nếu là số nguyên, thực hiện tính toán
                long sum = num1 + num2;
                txtketqua.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ vào ô số.");
            }

        }
    }
}
