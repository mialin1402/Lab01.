namespace LAB01
{
    partial class bai1
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
            txtso1 = new TextBox();
            txtso2 = new TextBox();
            txtketqua = new TextBox();
            btnTinh = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 37);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 0;
            label1.Text = "TINH TONG 2 SO NGUYEN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 121);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "SO THU 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 195);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "SO THU 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 265);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "KET QUA";
            // 
            // txtso1
            // 
            txtso1.Location = new Point(275, 121);
            txtso1.Name = "txtso1";
            txtso1.Size = new Size(125, 27);
            txtso1.TabIndex = 4;
            // 
            // txtso2
            // 
            txtso2.Location = new Point(275, 195);
            txtso2.Name = "txtso2";
            txtso2.Size = new Size(125, 27);
            txtso2.TabIndex = 5;
            // 
            // txtketqua
            // 
            txtketqua.Location = new Point(275, 258);
            txtketqua.Name = "txtketqua";
            txtketqua.Size = new Size(125, 27);
            txtketqua.TabIndex = 6;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(532, 257);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(94, 29);
            btnTinh.TabIndex = 7;
            btnTinh.Text = "TINH";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTinh);
            Controls.Add(txtketqua);
            Controls.Add(txtso2);
            Controls.Add(txtso1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "bai1";
            Text = "bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtso1;
        private TextBox txtso2;
        private TextBox txtketqua;
        private Button btnTinh;
    }
}