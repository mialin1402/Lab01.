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
    public partial class bai4 : Form
    {
        public bai4()
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
            if (long.TryParse(txtnhap.Text.Trim(), out long soNhap) && soNhap >= 0)
            {
                string chuoiChu = ChuyenSoThanhChu(soNhap);

                txtketqua.Text = chuoiChu;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương có tối đa 12 chữ số.");
            }
        }
        private string ChuyenSoThanhChu(long so)
        {
            if (so == 0)
            {
                return "Không";
            }

            string[] donVi = { "", "nghìn", "triệu", "tỷ" };
            string chuoiChu = "";
            int i = 0;

            while (so > 0)
            {
                int soHienTai = (int)(so % 1000);
                if (soHienTai > 0)
                {
                    if (chuoiChu != "")
                    {
                        chuoiChu = " " + chuoiChu;
                    }
                    chuoiChu = DocSoHaiChuSo(soHienTai) + " " + donVi[i] + chuoiChu;
                }
                so /= 1000;
                i++;
            }

            return chuoiChu.Trim();
        }

        private string DocSoHaiChuSo(int so)
        {
            string[] chuSo1Den9 = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hangChuc = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };

            int donVi = so % 10;
            int hangChucIndex = (so / 10) % 10;

            string chuoiSo = chuSo1Den9[donVi];

            if (hangChucIndex > 1)
            {
                chuoiSo = hangChuc[hangChucIndex] + " " + chuoiSo;
            }
            else if (hangChucIndex == 1)
            {
                chuoiSo = hangChuc[hangChucIndex] + chuoiSo.Substring(1);
            }

            return chuoiSo;
        }
    }
    }

