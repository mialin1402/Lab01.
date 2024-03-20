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
    public partial class bai8 : Form
    {
        public bai8()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtnhap.Text = "";
            txtdtb.Text = "";
            txtmoncao.Text = "";
            txtmonthap.Text = "";
            txtmondau.Text = "";
            txtmonrot.Text = "";
            txtxeploai.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string[] diemArray = txtnhap.Text.Split(',');

            if (diemArray.Length < 2)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng nhập ít nhất họ tên và một điểm.");
                return;
            }

            string hoTen = diemArray[0].Trim();
            string[] diemStringArray = diemArray.Skip(1).ToArray();
            double[] diemArrayDouble;

            try
            {
                diemArrayDouble = diemStringArray.Select(double.Parse).ToArray();
            }
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu điểm không hợp lệ. Vui lòng kiểm tra lại.");
                return;
            }

            string message = $"Họ và tên: {hoTen}\nDanh sách điểm theo môn: ";
            for (int i = 0; i < diemArrayDouble.Length; i++)
            {
                message += $"Môn {i + 1}: {diemArrayDouble[i]} ";
            }

            MessageBox.Show(message);


            // Tính điểm trung bình
            double diemTrungBinh = diemArrayDouble.Length > 0 ? diemArrayDouble.Average() : 0;
            txtdtb.Text = diemTrungBinh.ToString("0.00");

            // Tìm môn có điểm cao nhất và thấp nhất
            double diemCaoNhat = diemArrayDouble.Length > 0 ? diemArrayDouble.Max() : 0;
            double diemThapNhat = diemArrayDouble.Length > 0 ? diemArrayDouble.Min() : 0;
            txtmoncao.Text = diemCaoNhat.ToString("0.00");
            txtmonthap.Text = diemThapNhat.ToString("0.00");

            // Tìm số môn đậu và không đậu
            int soMonDau = diemArrayDouble.Count(diem => diem >= 5);
            int soMonRot = diemArrayDouble.Count(diem => diem < 5);
            txtmondau.Text = soMonDau.ToString();
            txtmonrot.Text = soMonRot.ToString();

            // Xếp loại sinh viên
            if (diemTrungBinh >= 8 && diemArrayDouble.All(diem => diem >= 6.5))
            {
                txtxeploai.Text = "Giỏi";
            }
            else if (diemTrungBinh >= 6.5 && diemArrayDouble.All(diem => diem >= 5))
            {
                txtxeploai.Text = "Khá";
            }
            else if (diemTrungBinh >= 5 && diemArrayDouble.All(diem => diem >= 3.5))
            {
                txtxeploai.Text = "Trung bình";
            }
            else if (diemTrungBinh >= 3.5 && diemArrayDouble.All(diem => diem >= 2))
            {
                txtxeploai.Text = "Yếu";
            }
            else
            {
                txtxeploai.Text = "Kém";
            }
        }
    }
}
