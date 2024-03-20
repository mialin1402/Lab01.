namespace LAB01
{
    partial class bai2
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnTim = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            txtso1 = new TextBox();
            txtso2 = new TextBox();
            txtso3 = new TextBox();
            txtsolon = new TextBox();
            txtsonho = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 66);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "So 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 66);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "So 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(558, 66);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "So 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 220);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "So lon nhat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(371, 216);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "So nho nhat";
            // 
            // btnTim
            // 
            btnTim.Location = new Point(171, 141);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 5;
            btnTim.Text = "Tim";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(336, 141);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(488, 141);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtso1
            // 
            txtso1.Location = new Point(125, 59);
            txtso1.Name = "txtso1";
            txtso1.Size = new Size(125, 27);
            txtso1.TabIndex = 8;
            // 
            // txtso2
            // 
            txtso2.Location = new Point(363, 63);
            txtso2.Name = "txtso2";
            txtso2.Size = new Size(125, 27);
            txtso2.TabIndex = 9;
            // 
            // txtso3
            // 
            txtso3.Location = new Point(614, 59);
            txtso3.Name = "txtso3";
            txtso3.Size = new Size(125, 27);
            txtso3.TabIndex = 10;
            // 
            // txtsolon
            // 
            txtsolon.Location = new Point(168, 213);
            txtsolon.Name = "txtsolon";
            txtsolon.Size = new Size(125, 27);
            txtsolon.TabIndex = 11;
            // 
            // txtsonho
            // 
            txtsonho.Location = new Point(465, 209);
            txtsonho.Name = "txtsonho";
            txtsonho.Size = new Size(125, 27);
            txtsonho.TabIndex = 12;
            // 
            // bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 303);
            Controls.Add(txtsonho);
            Controls.Add(txtsolon);
            Controls.Add(txtso3);
            Controls.Add(txtso2);
            Controls.Add(txtso1);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTim);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "bai2";
            Text = "bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnTim;
        private Button btnXoa;
        private Button btnThoat;
        private TextBox txtso1;
        private TextBox txtso2;
        private TextBox txtso3;
        private TextBox txtsolon;
        private TextBox txtsonho;
    }
}