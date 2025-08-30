using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceCenter
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            MessageBox.Show("결제가 완료되었습니다. \n영수증 출력을 원하시면 영수증 출력을 눌러주세요.");
        }

        private void btn_ReceiptOk_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Close();
        }

        private void btn_receiptNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이용해 주셔서 감사합니다.");
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();


        }
    }
}
