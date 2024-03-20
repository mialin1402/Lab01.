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
            string txtnhapText = txtnhap.Text.Trim();
            if (String.IsNullOrEmpty(txtnhapText))
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
                return;
            }

            long num;
            if (!long.TryParse(txtnhapText, out num))
            {
                MessageBox.Show("Sai định dạng");
                return;
            }

            string ketqua = "";
            if (num < 0)
            {
                ketqua += "Âm ";
                num *= -1;
            }

            if (num == 0)
            {
                txtketqua.Text = "Không";
                return;
            }

            if (num >= 1000000000)
            {
                ketqua = basecase(num / 1000000000, ketqua) + "Tỷ ";
                num %= 1000000000;
            }

            if (num >= 1000000)
            {
                ketqua = basecase(num / 1000000, ketqua) + "Triệu ";
                num %= 1000000;
            }

            if (num >= 1000)
            {
                ketqua = basecase(num / 1000, ketqua) + "Nghìn ";
                num %= 1000;
            }

            if (num > 0)
            {
                ketqua = basecase(num, ketqua);
            }

            txtketqua.Text = ketqua.Trim();
        }

        private string basecase(long num, string ketqua)
        {
            if (num > 99)
            {
                ketqua += $"{DocSoHaiChuSo((int)(num / 100))} Trăm ";
            }

            if (num > 9)
            {
                ketqua += $"{DocSoHaiChuSo((int)((num % 100) / 10))} Mươi ";
            }

            ketqua += $"{DocSoHaiChuSo((int)(num % 10))} ";

            return ketqua;
        }

        private string DocSoHaiChuSo(int so)
        {
            string[] chuSo1Den9 = { "", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };

            return chuSo1Den9[so];
        }
    }
    }

