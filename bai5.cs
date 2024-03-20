using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LAB01
{
    public partial class bai5 : Form
    {
        private string tenPhimChon;
        private string loaiVeChon;
        private string phongChieuChon;
        private int giaVeChuan;

        private readonly Dictionary<string, int> giaVePhim = new Dictionary<string, int>
        {
            { "Đào, phở và piano", 45000 },
            { "Mai", 100000 },
            { "Gặp lại chị bầu", 70000 },
            { "Tarot", 90000 }
        };

        public bai5()
        {
            InitializeComponent();
            LoadPhimData();

        }
        private void LoadPhimData()
        {
            cbophim.Items.AddRange(new string[] { "Đào, phở và piano", "Mai", "Gặp lại chị bầu", "Tarot" });

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string hoTen = txtten.Text.Trim();

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng.");
                return;
            }

            if (string.IsNullOrEmpty(tenPhimChon) || string.IsNullOrEmpty(loaiVeChon) || string.IsNullOrEmpty(phongChieuChon))
            {
                MessageBox.Show("Vui lòng chọn phim, loại vé và loại phòng trước khi tính toán.");
                return;
            }

            int giaVeChuan = giaVePhim[tenPhimChon];
            int giaVe = TinhGiaVe(giaVeChuan);

            string thongTinKhachHang = $"Họ và tên: {hoTen}\nVé đã chọn: {loaiVeChon}\nPhim: {tenPhimChon}\nPhòng chiếu: {phongChieuChon}\nSố tiền cần thanh toán: {giaVe.ToString("C")}";
            MessageBox.Show(thongTinKhachHang);
        }
        private int TinhGiaVe(int giaVeChuan)
        {
            switch (loaiVeChon)
            {
                case "Ve vot":
                    return giaVeChuan / 4;
                case "Ve thuong":
                    return giaVeChuan;
                case "Ve VIP":
                    return giaVeChuan * 2;
                default:
                    return 0;
            }
        }

        private void cbophim_SelectedIndexChanged(object sender, EventArgs e)
        {
            tenPhimChon = cbophim.SelectedItem.ToString();


            switch (tenPhimChon)
            {
                case "Đào, phở và piano":
                    giaVeChuan = 45000;
                    break;
                case "Mai":
                    giaVeChuan = 100000;
                    break;
                case "Gặp lại chị bầu":
                    giaVeChuan = 70000;
                    break;
                case "Tarot":
                    giaVeChuan = 90000;
                    break;
            }
        }

        private void rdovevot_CheckedChanged(object sender, EventArgs e)
        {
            if (rdovevot.Checked)
                loaiVeChon = "Ve vot";
        }

        private void rdovethuong_CheckedChanged(object sender, EventArgs e)
        {
            if (rdovethuong.Checked)
                loaiVeChon = "Ve thuong";
        }

        private void rdovevip_CheckedChanged(object sender, EventArgs e)
        {
            if (rdovevip.Checked)
                loaiVeChon = "Ve VIP";
        }

        private void rdoA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoA.Checked)
                phongChieuChon = "Phòng A";
        }

        private void rdoB_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoB.Checked)
                phongChieuChon = "Phòng B";
        }

        private void rdoC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoC.Checked)
                phongChieuChon = "Phòng C";
        }
    }
}



