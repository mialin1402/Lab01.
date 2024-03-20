namespace LAB01
{
    partial class bai6
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
            txtA = new TextBox();
            txtB = new TextBox();
            cboTinh = new ComboBox();
            btnTinh = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            txtkq = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 46);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhap A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 46);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhap B";
            // 
            // txtA
            // 
            txtA.Location = new Point(94, 39);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Location = new Point(369, 39);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 3;
            // 
            // cboTinh
            // 
            cboTinh.FormattingEnabled = true;
            cboTinh.Location = new Point(110, 103);
            cboTinh.Name = "cboTinh";
            cboTinh.Size = new Size(313, 28);
            cboTinh.TabIndex = 4;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(110, 172);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(94, 29);
            btnTinh.TabIndex = 5;
            btnTinh.Text = "Tinh";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(249, 172);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(400, 172);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtkq);
            groupBox1.Location = new Point(38, 237);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 88);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ket qua";
            // 
            // txtkq
            // 
            txtkq.Location = new Point(17, 37);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(415, 27);
            txtkq.TabIndex = 0;
            // 
            // bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 349);
            Controls.Add(groupBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTinh);
            Controls.Add(cboTinh);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "bai6";
            Text = "bai6";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtA;
        private TextBox txtB;
        private ComboBox cboTinh;
        private Button btnTinh;
        private Button btnXoa;
        private Button btnThoat;
        private GroupBox groupBox1;
        private TextBox txtkq;
    }
}