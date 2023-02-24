using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Winform_Buoi1
{
    public partial class frm_NhapMang : Form
    {
        public frm_NhapMang()
        {
            InitializeComponent();
        }

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            // Chuyển mảng được nhập ở ô Nhập mảng (rawArray - string) thành mảng resultArray (string)
            string[] resultArray;
            string rawArray = txt_NhapMang.Text;
            // Loại bỏ các khoảng trắng đầu cuối không cần thiết
            rawArray = rawArray.TrimStart(' ');
            rawArray = rawArray.TrimEnd(' ');
            resultArray = rawArray.Split(' ');

            // Kiểm tra mảng nhập vào là hợp lệ
            bool isValidArray = true;
            for (int i = 0; i < resultArray.Length; i++)
            {
                double x;
                isValidArray = isValidArray && double.TryParse(resultArray[i], out x);
            }

            // Nếu không hợp lệ thì hiển thị MessageBox và reset ô nhập mảng
            if (!isValidArray)
            {
                MessageBox.Show("Bạn nhập mảng không hợp lệ, vui lòng nhập lại!");
                txt_NhapMang.Text = "";
                txt_NhapMang.Focus();
            } 
            else
            {
                // Ngược lại, nếu hợp lệ thì thực hiện tính toán
                double sum = 0, sumle = 0, sumchan = 0;
                for (int i = 0; i < resultArray.Length; i++)
                {
                    double x;
                    // Thực hiện chuyển đổi các element có trong mảng sang double
                    x = double.Parse(resultArray[i]);
                    if (x % 2 != 0) sumle += x;
                    if (x % 2 == 0) sumchan += x;
                    sum += x;
                }
                // Đưa kết quả lên form controls
                txt_TongChan.Text = sumchan.ToString();
                txt_TongLe.Text = sumle.ToString();
                txt_TongMang.Text = sum.ToString();
            }
        }


        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có chắc chắn muốn thoát hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_NhapMang.Text = "";
            txt_TongLe.Text = "";
            txt_TongChan.Text = "";
            txt_TongMang.Text = "";
            txt_NhapMang.Focus();
        }

    }
}
