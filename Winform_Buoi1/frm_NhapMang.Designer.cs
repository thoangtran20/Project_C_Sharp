
namespace Winform_Buoi1
{
    partial class frm_NhapMang
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
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Tinh = new System.Windows.Forms.Button();
            this.txt_TongChan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TongLe = new System.Windows.Forms.TextBox();
            this.txt_NhapMang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TongMang = new System.Windows.Forms.TextBox();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Thoat.Location = new System.Drawing.Point(544, 297);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(135, 42);
            this.btn_Thoat.TabIndex = 29;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Tinh
            // 
            this.btn_Tinh.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Tinh.Location = new System.Drawing.Point(190, 297);
            this.btn_Tinh.Name = "btn_Tinh";
            this.btn_Tinh.Size = new System.Drawing.Size(142, 42);
            this.btn_Tinh.TabIndex = 28;
            this.btn_Tinh.Text = "Tính toán";
            this.btn_Tinh.UseVisualStyleBackColor = true;
            this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click);
            // 
            // txt_TongChan
            // 
            this.txt_TongChan.Location = new System.Drawing.Point(396, 170);
            this.txt_TongChan.Name = "txt_TongChan";
            this.txt_TongChan.Size = new System.Drawing.Size(283, 27);
            this.txt_TongChan.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(170, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tổng các số mảng A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(170, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tổng các số chẵn";
            // 
            // txt_TongLe
            // 
            this.txt_TongLe.Location = new System.Drawing.Point(396, 109);
            this.txt_TongLe.Name = "txt_TongLe";
            this.txt_TongLe.Size = new System.Drawing.Size(283, 27);
            this.txt_TongLe.TabIndex = 22;
            // 
            // txt_NhapMang
            // 
            this.txt_NhapMang.Location = new System.Drawing.Point(306, 41);
            this.txt_NhapMang.Name = "txt_NhapMang";
            this.txt_NhapMang.Size = new System.Drawing.Size(373, 27);
            this.txt_NhapMang.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(170, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tổng các số lẻ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(170, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mảng A";
            // 
            // txt_TongMang
            // 
            this.txt_TongMang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_TongMang.Location = new System.Drawing.Point(396, 237);
            this.txt_TongMang.Name = "txt_TongMang";
            this.txt_TongMang.Size = new System.Drawing.Size(283, 27);
            this.txt_TongMang.TabIndex = 30;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_LamMoi.Location = new System.Drawing.Point(363, 297);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(142, 42);
            this.btn_LamMoi.TabIndex = 31;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // frm_NhapMang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.txt_TongMang);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Tinh);
            this.Controls.Add(this.txt_TongChan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_TongLe);
            this.Controls.Add(this.txt_NhapMang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frm_NhapMang";
            this.Text = "frm_NhapMang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Tinh;
        private System.Windows.Forms.TextBox txt_TongChan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TongLe;
        private System.Windows.Forms.TextBox txt_NhapMang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TongMang;
        private System.Windows.Forms.Button btn_LamMoi;
    }
}