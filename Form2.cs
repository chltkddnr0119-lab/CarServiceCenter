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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static class CarInfo
        {
            public static string SavedCarNumber { get; set; }
            public static string SavedCarName { get; set; }
            public static string SavedStrOrder {  get; set; }
            public static DateTime InputTime { get; set; }
            public static int SavedTotalPrice {  get; set; }
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string strOrder = "";
            int TotalPrice = 0;
            if (checkBox1.Checked == true)
            {
                strOrder += checkBox1.Text + "\n";
                TotalPrice += 150000;
            }
            if (checkBox2.Checked == true)
            {
                strOrder += checkBox2.Text + "\n";
                TotalPrice += 100000;
            }
            if (checkBox3.Checked == true)
            {
                strOrder += checkBox3.Text + "\n";
                TotalPrice += 70000;
            }
            if (checkBox4.Checked == true)
            {
                strOrder += checkBox4.Text + "\n";
                TotalPrice += 50000;
            }
            if (checkBox5.Checked == true)
            {
                strOrder += checkBox5.Text + "\n";
                TotalPrice += 80000;
            }
            if (checkBox6.Checked == true)
            {
                strOrder += checkBox6.Text + "\n";
                TotalPrice += 50000;
            }
            if (checkBox7.Checked == true)
            {
                strOrder += checkBox7.Text + "\n";
               
            }
            if (checkBox8.Checked == true)
            {
                strOrder += checkBox8.Text + "\n";
                TotalPrice += 200000;
            }
            if (checkBox9.Checked == true)
            {
                strOrder += checkBox9.Text + "\n";
                TotalPrice += 180000;
            }
            if (checkBox10.Checked == true)
            {
                strOrder += checkBox10.Text + "\n";
                TotalPrice += 150000;
            }
            if (checkBox11.Checked == true)
            {
                strOrder += checkBox11.Text + "\n";
                TotalPrice += 130000;
            }
            if (checkBox12.Checked == true)
            {
                strOrder += checkBox12.Text + "\n";
              
            }
            if (checkBox13.Checked == true)
            {
                strOrder += checkBox13.Text + "\n";
                TotalPrice += 30000;
            }
            if (checkBox14.Checked == true)
            {
                strOrder += checkBox14.Text + "\n";
                TotalPrice += 50000;
            }
            if (tb_CarNumber.Text == "" || tb_CarName.Text == "")
            {
                MessageBox.Show("차량 번호와 차종을 다시 확인해 주세요.");
                return;
            }
            //else
            //{
            //    form7.listView1.Items.Add(new ListViewItem(new string[] {}))
            //}
            if (strOrder == "")
            {
                MessageBox.Show("정비서비스를 다시 확인해 주세요.");
                return;
            }
            CarInfo.SavedCarNumber = tb_CarNumber.Text;
            CarInfo.SavedCarName = tb_CarName.Text;
            CarInfo.SavedStrOrder = strOrder;
            CarInfo.InputTime = DateTime.Now;
            CarInfo.SavedTotalPrice = TotalPrice;
            
            string carNumber = tb_CarNumber.Text;
            string carName = tb_CarName.Text;

            

            string str = "차량 번호: " + tb_CarNumber.Text + "\n차량 모델: " + tb_CarName.Text + "\n정비서비스: " + strOrder+ "\n\n선택하셨습니다.";
            MessageBox.Show(str);



            Form7 form7 = new Form7();
            form7.AddRepairRequest(carNumber, carName, strOrder);
            form7.Show();
            this.Close();


        }

    

        
    }
}

