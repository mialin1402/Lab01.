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
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnhap.Text = "";
            txtketqua.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtnhap.Text.Trim(), out int soNhap) && soNhap >= 0 && soNhap <= 9)
            {
                string chuoiChu = ChuyenSoThanhChu(soNhap);
                txtketqua.Text = chuoiChu;

            }
            else
            {
                MessageBox.Show ("Vui lòng nhập số nguyên từ 0 đến 9.");
            }
        }
        private string ChuyenSoThanhChu(int so)
        {
            switch (so)
            {
                case 0:
                    return "Không";
                case 1:
                    return "Một";
                case 2:
                    return "Hai";
                case 3:
                    return "Ba";
                case 4:
                    return "Bốn";
                case 5:
                    return "Năm";
                case 6:
                    return "Sáu";
                case 7:
                    return "Bảy";
                case 8:
                    return "Tám";
                case 9:
                    return "Chín";
                default:
                    return "";
            }
        }
    }
}
