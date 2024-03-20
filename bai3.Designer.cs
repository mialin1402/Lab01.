namespace LAB01
{
    partial class bai3
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
            txtnhap = new TextBox();
            txtketqua = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 82);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhap so nguyen tu 0 den 9";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 223);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Ket qua";
            // 
            // txtnhap
            // 
            txtnhap.Location = new Point(79, 105);
            txtnhap.Name = "txtnhap";
            txtnhap.Size = new Size(125, 27);
            txtnhap.TabIndex = 2;
            // 
            // txtketqua
            // 
            txtketqua.Location = new Point(79, 246);
            txtketqua.Name = "txtketqua";
            txtketqua.Size = new Size(125, 27);
            txtketqua.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(387, 98);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Doc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(387, 171);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Xoa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(387, 246);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "Thoat";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtketqua);
            Controls.Add(txtnhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "bai3";
            Text = "bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnhap;
        private TextBox txtketqua;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}