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
    public partial class bai9 : Form
    {
        private List<string> danhSachMonAn = new List<string> { "Phở", "Bún", "Hủ tíu trộn", "Miến trộn" };
        public bai9()
        {
            InitializeComponent();
            HienThiDanhSachMonAn();
        }
        private void HienThiDanhSachMonAn()
        {
            txtmon.Text = string.Join(", ", danhSachMonAn);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtkq.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string monMoi = txtnhap.Text.Trim();

            if (!string.IsNullOrEmpty(monMoi))
            {
                danhSachMonAn.Add(monMoi);
                HienThiDanhSachMonAn();
                txtnhap.Text = "";
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (danhSachMonAn.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn đang trống. Vui lòng thêm món ăn trước khi tìm.");
                return;
            }

            Random random = new Random();
            int index = random.Next(0, danhSachMonAn.Count);
            string monAnHomNay = danhSachMonAn[index];

            txtkq.Text = $"{monAnHomNay}";
        }
    }
}
