using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Winform_Buoi1
{
    public partial class frm_GiaiPTBac2 : Form
    {
        public frm_GiaiPTBac2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_GiaiPTBac2_Load(object sender, EventArgs e)
        {

        }

        private void btn_Giai_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0;
            bool check;
            check = double.TryParse(txta.Text, out a);
            check = check && double.TryParse(txtb.Text, out b);
            check = check && double.TryParse(txtc.Text, out c);
            if (!check)
            {
                MessageBox.Show("Ban nhap chua dung, vui long nhap lai", "Canh bao");
                txta.Text = "";
                txtb.Text = "";
                txtc.Text = "";
            }
            else
            {
                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                            txtkq.Text = "Phuong trinh co vo so nghiem";
                        else
                            txtkq.Text = "Phuong trinh vo nghiem";
                    }
                    else txtkq.Text = "x = " + (-c / b);
                }
                else
                {
                    double delta = (b * b) - (4 * a * c);
                    if (delta < 0) txtkq.Text = "Phuong trinh vo nghiem";
                    else if (delta == 0) txtkq.Text = "Phuong trinh co nghiem kep x = " + (-b / (2 * a));
                    else txtkq.Text = "Phuong trinh co 2 nghiem phan biet x1 = " + ((-b + Math.Sqrt(delta)) / (2 * a)) + ", x2 = " + ((-b - Math.Sqrt(delta)) / (2 * a));
                }
            }
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {

            DialogResult dialog;
            dialog = MessageBox.Show("Ban co that su muon thoat hay khong?", "Canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }
    }
}
