namespace LAB01
{
    partial class bai8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtnhap = new TextBox();
            btnTinh = new Button();
            label2 = new Label();
            txtdtb = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtmoncao = new TextBox();
            txtmonthap = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtmondau = new TextBox();
            txtmonrot = new TextBox();
            txtxeploai = new TextBox();
            label7 = new Label();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 46);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhap ten va diem";
            // 
            // txtnhap
            // 
            txtnhap.Location = new Point(183, 39);
            txtnhap.Name = "txtnhap";
            txtnhap.Size = new Size(452, 27);
            txtnhap.TabIndex = 1;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(641, 37);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(94, 29);
            btnTinh.TabIndex = 2;
            btnTinh.Text = "Tinh";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 95);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Ket qua";
            // 
            // txtdtb
            // 
            txtdtb.Location = new Point(116, 88);
            txtdtb.Name = "txtdtb";
            txtdtb.Size = new Size(99, 27);
            txtdtb.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 146);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 5;
            label3.Text = "Mon cao nhat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 146);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 6;
            label4.Text = "Mon thap nhat";
            // 
            // txtmoncao
            // 
            txtmoncao.Location = new Point(158, 139);
            txtmoncao.Name = "txtmoncao";
            txtmoncao.Size = new Size(124, 27);
            txtmoncao.TabIndex = 7;
            // 
            // txtmonthap
            // 
            txtmonthap.Location = new Point(456, 139);
            txtmonthap.Name = "txtmonthap";
            txtmonthap.Size = new Size(124, 27);
            txtmonthap.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 197);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 9;
            label5.Text = "So mon dau";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(344, 197);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 10;
            label6.Text = "So mon rot";
            // 
            // txtmondau
            // 
            txtmondau.Location = new Point(156, 190);
            txtmondau.Name = "txtmondau";
            txtmondau.Size = new Size(124, 27);
            txtmondau.TabIndex = 11;
            // 
            // txtmonrot
            // 
            txtmonrot.Location = new Point(456, 190);
            txtmonrot.Name = "txtmonrot";
            txtmonrot.Size = new Size(124, 27);
            txtmonrot.TabIndex = 12;
            // 
            // txtxeploai
            // 
            txtxeploai.Location = new Point(344, 265);
            txtxeploai.Name = "txtxeploai";
            txtxeploai.Size = new Size(124, 27);
            txtxeploai.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(274, 272);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 13;
            label7.Text = "Xep loai";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(641, 91);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(641, 146);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // bai8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 374);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(txtxeploai);
            Controls.Add(label7);
            Controls.Add(txtmonrot);
            Controls.Add(txtmondau);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtmonthap);
            Controls.Add(txtmoncao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtdtb);
            Controls.Add(label2);
            Controls.Add(btnTinh);
            Controls.Add(txtnhap);
            Controls.Add(label1);
            Name = "bai8";
            Text = "bai8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnhap;
        private Button btnTinh;
        private Label label2;
        private TextBox txtdtb;
        private Label label3;
        private Label label4;
        private TextBox txtmoncao;
        private TextBox txtmonthap;
        private Label label5;
        private Label label6;
        private TextBox txtmondau;
        private TextBox txtmonrot;
        private TextBox txtxeploai;
        private Label label7;
        private Button btnXoa;
        private Button btnThoat;
    }
}