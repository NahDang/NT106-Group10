﻿namespace Lab01
{
    partial class Bai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxNhapA = new System.Windows.Forms.TextBox();
            this.txtboxNhapB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.KetQua = new System.Windows.Forms.GroupBox();
            this.btTinhCacGiaTri = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.KetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập A ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(669, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập B ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtboxNhapA
            // 
            this.txtboxNhapA.Location = new System.Drawing.Point(181, 67);
            this.txtboxNhapA.Name = "txtboxNhapA";
            this.txtboxNhapA.Size = new System.Drawing.Size(304, 57);
            this.txtboxNhapA.TabIndex = 2;
            this.txtboxNhapA.TextChanged += new System.EventHandler(this.txtboxNhapA_TextChanged);
            // 
            // txtboxNhapB
            // 
            this.txtboxNhapB.Location = new System.Drawing.Point(840, 67);
            this.txtboxNhapB.Name = "txtboxNhapB";
            this.txtboxNhapB.Size = new System.Drawing.Size(304, 57);
            this.txtboxNhapB.TabIndex = 3;
            this.txtboxNhapB.TextChanged += new System.EventHandler(this.txtboxNhapB_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bảng cửu chương",
            "Tính toán giá trị"});
            this.comboBox1.Location = new System.Drawing.Point(444, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 57);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // KetQua
            // 
            this.KetQua.Controls.Add(this.txtKetQua);
            this.KetQua.Location = new System.Drawing.Point(24, 390);
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(1164, 301);
            this.KetQua.TabIndex = 8;
            this.KetQua.TabStop = false;
            this.KetQua.Text = "KẾT QUẢ";
            this.KetQua.Enter += new System.EventHandler(this.KetQua_Enter);
            // 
            // btTinhCacGiaTri
            // 
            this.btTinhCacGiaTri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btTinhCacGiaTri.Location = new System.Drawing.Point(59, 304);
            this.btTinhCacGiaTri.Name = "btTinhCacGiaTri";
            this.btTinhCacGiaTri.Size = new System.Drawing.Size(360, 65);
            this.btTinhCacGiaTri.TabIndex = 9;
            this.btTinhCacGiaTri.Text = "Tinh cac gia tri";
            this.btTinhCacGiaTri.UseVisualStyleBackColor = false;
            this.btTinhCacGiaTri.Click += new System.EventHandler(this.btTinhCacGiaTri_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btXoa.Location = new System.Drawing.Point(567, 304);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(171, 65);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xoa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btThoat.Location = new System.Drawing.Point(879, 304);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(171, 65);
            this.btThoat.TabIndex = 11;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(17, 56);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(1129, 239);
            this.txtKetQua.TabIndex = 0;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(26F, 49F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btTinhCacGiaTri);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtboxNhapB);
            this.Controls.Add(this.txtboxNhapA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Bai2";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.KetQua.ResumeLayout(false);
            this.KetQua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxNhapA;
        private System.Windows.Forms.TextBox txtboxNhapB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox KetQua;
        private System.Windows.Forms.Button btTinhCacGiaTri;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}