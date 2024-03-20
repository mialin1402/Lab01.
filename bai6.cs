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
    public partial class bai6 : Form
    {
        private string luaChonPhepToan;
        public bai6()
        {
            InitializeComponent();
            LoadNoiDungComboBox();
        }
        private void LoadNoiDungComboBox()
        {
            cboTinh.Items.AddRange(new string[] { "(A - B)!", "Tổng S = A^1 + A^2 + A^3 + ... + A^B" });
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtkq.Text = "";
            cboTinh.Items.Clear();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtA.Text, out int A) && int.TryParse(txtB.Text, out int B))
            {
                luaChonPhepToan = cboTinh.SelectedItem.ToString();

                switch (luaChonPhepToan)
                {
                    case "(A - B)!":
                        long ketQuaGiaiThua = TinhGiaiThua(A - B);
                        HienThiKetQua(ketQuaGiaiThua.ToString());
                        break;

                    case "Tổng S = A^1 + A^2 + A^3 + ... + A^B":
                        double ketQuaTong = TinhTong(A, B);
                        HienThiKetQua(ketQuaTong.ToString());
                        break;

                    default:
                        MessageBox.Show("Vui lòng chọn phép toán.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho A và B.");
            }
        }
        private long TinhGiaiThua(int n)
        {
            if (n < 0)
            {
                return 0; // Giả sử 0! = 0 khi n < 0
            }

            long ketQua = 1;
            for (int i = 1; i <= n; i++)
            {
                ketQua *= i;
            }

            return ketQua;
        }

        private double TinhTong(int A, int B)
        {
            double ketQua = 0;
            for (int i = 1; i <= B; i++)
            {
                ketQua += Math.Pow(A, i);
            }

            return ketQua;
        }

        private void HienThiKetQua(string ketQua)
        {
            txtkq.Text = $"Kết quả {luaChonPhepToan}: {ketQua}";
        }
    }
}
