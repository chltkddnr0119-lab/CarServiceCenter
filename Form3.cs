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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            string inputNumber = tb_CarNumber2.Text;
            string inputModel = tb_CarName2.Text;
            if (inputNumber == CarInfo.SavedCarNumber && inputModel == CarInfo.SavedCarName)
            {
                MessageBox.Show("로그인 성공! 정비 내역서를 출력합니다.");
                var form6 = new Form6();
                form6.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("차량 번호 또는 모델이 일치하지 않습니다.");
                tb_CarNumber2.Text = "";
                tb_CarName2.Text = "";
            }
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }

}
