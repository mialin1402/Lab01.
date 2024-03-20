namespace LAB01
{
    partial class bai7
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
            label2 = new Label();
            txtkq = new TextBox();
            btnTim = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 54);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Ngay thang nam sinh";
            // 
            // txtnhap
            // 
            txtnhap.Location = new Point(256, 51);
            txtnhap.Name = "txtnhap";
            txtnhap.Size = new Size(270, 27);
            txtnhap.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 196);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 2;
            label2.Text = "Ket qua";
            // 
            // txtkq
            // 
            txtkq.Location = new Point(188, 189);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(484, 27);
            txtkq.TabIndex = 3;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(122, 120);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 4;
            btnTim.Text = "Tim";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(272, 120);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(432, 120);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // bai7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 277);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTim);
            Controls.Add(txtkq);
            Controls.Add(label2);
            Controls.Add(txtnhap);
            Controls.Add(label1);
            Name = "bai7";
            Text = "bai7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnhap;
        private Label label2;
        private TextBox txtkq;
        private Button btnTim;
        private Button btnXoa;
        private Button btnThoat;
    }
}