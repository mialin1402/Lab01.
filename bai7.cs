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
    public partial class bai7 : Form
    {
        public bai7()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnhap.Text))
            {
                MessageBox.Show("Vui lòng nhập ngày sinh dưới dạng dd/MM/yyyy.");
                return;
            }

            if (!DateTime.TryParse(txtnhap.Text, out DateTime ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập lại.");
                return;
            }

            string cungHoangDao = XacDinhCungHoangDao(ngaySinh);

            txtkq.Text = $"Ngày sinh {ngaySinh:dd/MM/yyyy} thuộc cung hoàng đạo: {cungHoangDao}";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtnhap.Text = "";
            txtkq.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string XacDinhCungHoangDao(DateTime ngaySinh)
        {
            int ngay = ngaySinh.Day;
            int thang = ngaySinh.Month;

            switch (thang)
            {
                case 3:
                    return ngay >= 21 ? "Bạch Dương" : "Song Ngư";
                case 4:
                    return ngay <= 20 ? "Bạch Dương" : "Kim Ngưu";
                case 5:
                    return ngay <= 21 ? "Kim Ngưu" : "Song Tử";
                case 6:
                    return ngay <= 21 ? "Song Tử" : "Cự Giải";
                case 7:
                    return ngay <= 22 ? "Cự Giải" : "Sư Tử";
                case 8:
                    return ngay <= 22 ? "Sư Tử" : "Xử Nữ";
                case 9:
                    return ngay <= 23 ? "Xử Nữ" : "Thiên Bình";
                case 10:
                    return ngay <= 23 ? "Thiên Bình" : "Thần Nông";
                case 11:
                    return ngay <= 22 ? "Thần Nông" : "Nhân Mã";
                case 12:
                    return ngay <= 20 ? "Nhân Mã" : "Ma Kết";
                case 1:
                    return ngay <= 19 ? "Ma Kết" : "Bảo Bình";
                case 2:
                    return ngay <= 19 ? "Bảo Bình" : "Song Ngư";
                default:
                    return "Không xác định";
            }
        }
    }
}
