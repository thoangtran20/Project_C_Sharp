using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Winform_Buoi1
{
    public partial class frm_TimThu : Form
    {
        public frm_TimThu()
        {
            InitializeComponent();
        }

        private void txt_Thu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            int thu = int.Parse(txt_Thu.Text);
            string result;
            switch (thu)
            {
                case 2:
                    result = "Monday";
                    break;
                case 3:
                    result = "Tuesday";
                    break;
                case 4:
                    result = "Wednesday";
                    break;
                case 5:
                    result = "Thursday";
                    break;
                case 6:
                    result = "Friday";
                    break;
                case 7:
                    result = "Saturday";
                    break;
                case 8:
                    result = "Sunday";
                    break;
                default:
                    result = "Ban nhap chua dung, phai nhap dung tu 2 - 8";
                    break;
            }
            DialogResult dialog;
            dialog = MessageBox.Show("Ket qua: " + result);
            txt_Thu.Focus();
        }
    }
}
