using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai15_SoThocTrenBanCo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int soO;


            if (!int.TryParse(txto.Text, out soO))
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (soO > 64)
            {
                MessageBox.Show("Số ô cờ phải nhỏ hơn hoặc bằng 64", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double tongsothoc = 0;


            lsto.Items.Clear();


            for (int i = 0; i < soO; i++)
            {
                double soThoc = Math.Pow(2, i);
                tongsothoc += soThoc;
                lsto.Items.Add("Ô thứ " + (i + 1) + " có " + soThoc + " thóc");
            }

            // Hiển thị tổng số thóc
            lsto.Items.Add("Tổng số thóc: " + tongsothoc);
        }
    }
}



