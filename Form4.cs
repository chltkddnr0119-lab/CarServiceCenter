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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarServiceCenter
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            string inputNumber = tb_CarNumber3.Text;
            string inputModel = tb_CarName3.Text;
            if (inputNumber == CarInfo.SavedCarNumber && inputModel == CarInfo.SavedCarName)
            {
                MessageBox.Show("로그인 성공! 결제창으로 넘어갑니다.");
                // 다음 동작 예: 확인서 폼 열기, PDF 생성 등
                Form5 form5 = new Form5();
                form5.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("차량 번호 또는 모델이 일치하지 않습니다.");
                tb_CarNumber3.Text = "";
                tb_CarName3.Text = "";
            }
            //Form5 form5 = new Form5();
            //form5.Show();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
