namespace LAB01
{
    partial class bai9
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
            label2 = new Label();
            txtmon = new TextBox();
            txtnhap = new TextBox();
            label3 = new Label();
            txtkq = new TextBox();
            btnThem = new Button();
            btnTim = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 39);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Thêm món";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 296);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // txtmon
            // 
            txtmon.Location = new Point(397, 32);
            txtmon.Multiline = true;
            txtmon.Name = "txtmon";
            txtmon.Size = new Size(265, 161);
            txtmon.TabIndex = 2;
            // 
            // txtnhap
            // 
            txtnhap.Location = new Point(135, 32);
            txtnhap.Name = "txtnhap";
            txtnhap.Size = new Size(241, 27);
            txtnhap.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 296);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 4;
            label3.Text = "Vedette hôm nay là";
            // 
            // txtkq
            // 
            txtkq.Location = new Point(282, 319);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(181, 27);
            txtkq.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(282, 84);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(135, 214);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 7;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(333, 214);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(512, 214);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // bai9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 408);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTim);
            Controls.Add(btnThem);
            Controls.Add(txtkq);
            Controls.Add(label3);
            Controls.Add(txtnhap);
            Controls.Add(txtmon);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "bai9";
            Text = "bai9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtmon;
        private TextBox txtnhap;
        private Label label3;
        private TextBox txtkq;
        private Button btnThem;
        private Button btnTim;
        private Button btnXoa;
        private Button btnThoat;
    }
}