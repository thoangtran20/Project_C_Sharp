using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Winform_Buoi1
{
    public partial class frm_DangNhap : Form
    {
        int countfalse = 0;
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = (txt_TenTK.Text).ToLower();
            string password = txt_MatKhau.Text;
            if (username.Equals("admin") && password.Equals("123456"))
            {
                countfalse = 0;
                frm_QLSinhVien QLSinhVien = new frm_QLSinhVien();
                QLSinhVien.Show();
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                countfalse++;
                MessageBox.Show("Ten dang nhap hoac mat khau sai, Vui long kiem tra lai");
                if (countfalse == 3)
                {
                    MessageBox.Show("Ban nhap sai " + countfalse + " lan", "Canh bao");
                    Application.Exit();
                }
            }
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txt_TenTK.Text = "";
            txt_MatKhau.Text = "";
            txt_TenTK.Focus();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        { 
            DialogResult dialog;
            dialog = MessageBox.Show("Ban co that su muon thoat hay khong?", "Canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }
    }
}
