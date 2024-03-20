namespace LAB01
{
    partial class bai5
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
            txtten = new TextBox();
            cbophim = new ComboBox();
            btnTinh = new Button();
            rdovevot = new RadioButton();
            rdovethuong = new RadioButton();
            rdovevip = new RadioButton();
            rdoA = new RadioButton();
            rdoB = new RadioButton();
            rdoC = new RadioButton();
            label3 = new Label();
            grpphong = new GroupBox();
            grpphong.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(53, 46);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên KH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(53, 83);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Phim";
            // 
            // txtten
            // 
            txtten.Location = new Point(109, 39);
            txtten.Name = "txtten";
            txtten.Size = new Size(125, 27);
            txtten.TabIndex = 2;
            // 
            // cbophim
            // 
            cbophim.FormattingEnabled = true;
            cbophim.Location = new Point(109, 80);
            cbophim.Name = "cbophim";
            cbophim.Size = new Size(187, 28);
            cbophim.TabIndex = 3;
            cbophim.SelectedIndexChanged += cbophim_SelectedIndexChanged;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(307, 280);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(94, 29);
            btnTinh.TabIndex = 4;
            btnTinh.Text = "Tinh";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // rdovevot
            // 
            rdovevot.AutoSize = true;
            rdovevot.Location = new Point(117, 140);
            rdovevot.Name = "rdovevot";
            rdovevot.Size = new Size(70, 24);
            rdovevot.TabIndex = 5;
            rdovevot.TabStop = true;
            rdovevot.Text = "vé vớt";
            rdovevot.UseVisualStyleBackColor = true;
            rdovevot.CheckedChanged += rdovevot_CheckedChanged;
            // 
            // rdovethuong
            // 
            rdovethuong.AutoSize = true;
            rdovethuong.Location = new Point(307, 140);
            rdovethuong.Name = "rdovethuong";
            rdovethuong.Size = new Size(97, 24);
            rdovethuong.TabIndex = 6;
            rdovethuong.TabStop = true;
            rdovethuong.Text = "vé thường";
            rdovethuong.UseVisualStyleBackColor = true;
            rdovethuong.CheckedChanged += rdovethuong_CheckedChanged;
            // 
            // rdovevip
            // 
            rdovevip.AutoSize = true;
            rdovevip.Location = new Point(511, 140);
            rdovevip.Name = "rdovevip";
            rdovevip.Size = new Size(70, 24);
            rdovevip.TabIndex = 7;
            rdovevip.TabStop = true;
            rdovevip.Text = "vé VIP";
            rdovevip.UseVisualStyleBackColor = true;
            rdovevip.CheckedChanged += rdovevip_CheckedChanged;
            // 
            // rdoA
            // 
            rdoA.AutoSize = true;
            rdoA.Location = new Point(6, 57);
            rdoA.Name = "rdoA";
            rdoA.Size = new Size(40, 24);
            rdoA.TabIndex = 8;
            rdoA.TabStop = true;
            rdoA.Text = "A";
            rdoA.UseVisualStyleBackColor = true;
            rdoA.CheckedChanged += rdoA_CheckedChanged;
            // 
            // rdoB
            // 
            rdoB.AutoSize = true;
            rdoB.Location = new Point(95, 57);
            rdoB.Name = "rdoB";
            rdoB.Size = new Size(39, 24);
            rdoB.TabIndex = 9;
            rdoB.TabStop = true;
            rdoB.Text = "B";
            rdoB.UseVisualStyleBackColor = true;
            rdoB.CheckedChanged += rdoB_CheckedChanged;
            // 
            // rdoC
            // 
            rdoC.AutoSize = true;
            rdoC.Location = new Point(178, 57);
            rdoC.Name = "rdoC";
            rdoC.Size = new Size(39, 24);
            rdoC.TabIndex = 10;
            rdoC.TabStop = true;
            rdoC.Text = "C";
            rdoC.UseVisualStyleBackColor = true;
            rdoC.CheckedChanged += rdoC_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(53, 140);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 11;
            label3.Text = "Loại vé";
            // 
            // grpphong
            // 
            grpphong.Controls.Add(rdoA);
            grpphong.Controls.Add(rdoB);
            grpphong.Controls.Add(rdoC);
            grpphong.Location = new Point(53, 175);
            grpphong.Name = "grpphong";
            grpphong.Size = new Size(250, 125);
            grpphong.TabIndex = 13;
            grpphong.TabStop = false;
            grpphong.Text = "Phong chieu";
            // 
            // bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 334);
            Controls.Add(grpphong);
            Controls.Add(label3);
            Controls.Add(rdovevip);
            Controls.Add(rdovethuong);
            Controls.Add(rdovevot);
            Controls.Add(btnTinh);
            Controls.Add(cbophim);
            Controls.Add(txtten);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "bai5";
            Text = "bai5";
            grpphong.ResumeLayout(false);
            grpphong.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label1;
        private Label label2;
        private TextBox txtten;
        private ComboBox cbophim;
        private Button btnTinh;
        private RadioButton rdovevot;
        private RadioButton rdovethuong;
        private RadioButton rdovevip;
        private RadioButton rdoA;
        private RadioButton rdoB;
        private RadioButton rdoC;
        private Label label3;
        private GroupBox grpphong;
    }
}