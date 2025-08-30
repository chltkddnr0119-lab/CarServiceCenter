using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarServiceCenter.Form2;

namespace CarServiceCenter
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

        }

        private void btn_CardPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("카드 결제를 선택하셨습니다.");
            Form8 form8 = new Form8();
            form8.Show();
            this.Close();
        }

        private void btn_SamsungPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("삼성 페이를 선택하셨습니다.");
            Form8 form8 = new Form8();
            form8.Show();
            this.Close();
        }

        private void btn_ApplePay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("애플 페이를 선택하셨습니다.");
            Form8 form8 = new Form8();
            form8.Show();
            this.Close();
        }

        private void btn_KakaoPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("카카오 페이를 선택하셨습니다.");
            Form8 form8 = new Form8();
            form8.Show();
            this.Close();
        }

        private void btn_NaverPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("네이버 페이를 선택하셨습니다.");
            Form8 form8 = new Form8();
            form8.Show();
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            lb_Price.Text = CarInfo.SavedTotalPrice.ToString()+"원";
        }
    }
}
