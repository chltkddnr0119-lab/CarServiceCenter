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
using static System.Windows.Forms.DataFormats;

namespace CarServiceCenter
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        //public Form6( string carNumber, string carName, string strOrder)
        //{
        //    InitializeComponent(); 
        //    lb_CarNumber.Text = carNumber;
        //    lb_CarName.Text = carName;
        //    lb_Repair.Text = strOrder;
        //    lb_Repair2.Text = strOrder;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            lb_CarNumber.Text = CarInfo.SavedCarNumber;
            lb_CarName.Text = CarInfo.SavedCarName;
            lb_Repair.Text = CarInfo.SavedStrOrder;
            lb_Repair2.Text = CarInfo.SavedStrOrder;
            lb_Time.Text = CarInfo.InputTime.ToString();
            lb_Time2.Text= DateTime.Now.ToString();
            lb_TotalPrice.Text= CarInfo.SavedTotalPrice.ToString();
        }
        


    }
}
