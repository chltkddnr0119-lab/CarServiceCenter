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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이용해주셔서 감사합니다.");
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

            
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            lb_Date.Text = DateTime.Now.ToString();
            label4.Text = CarInfo.SavedStrOrder;
            lb_Price9.Text = CarInfo.SavedTotalPrice.ToString();
        }

       
    }
}
