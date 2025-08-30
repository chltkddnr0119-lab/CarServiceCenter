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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        //private int timeColIndex = 3;
        //private SortOrder currentOrder = SortOrder.Ascending;

        private void Form7_Load(object sender, EventArgs e)
        {
            //listView1.View = View.Details;
            //listView1.FullRowSelect = true;
            //listView1.ListViewItemSorter = new ListViewDateComparer(timeColIndex, currentOrder);
        }
        public void AddRepairRequest(string carNumber, string carName, string strOrder)
        {

            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            ListViewItem item = new ListViewItem(carNumber);
            item.SubItems.Add(carName);

            item.SubItems.Add(strOrder);
            item.SubItems.Add(time);

            listView1.Items.Add(item);
            listView1.Sort();

            //string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            //ListViewItem item = new ListViewItem(carNumber);
            //item.SubItems.Add(carName);
            //item.SubItems.Add(strOrder);
            //item.SubItems.Add(time);
            //item.Tag = DateTime.Now; // 정렬기에서 사용할 수 있게

            //listView1.Items.Add(item);
            //listView1.Sort(); // 정렬기를 설정해두었다면 시간순 정렬 유지

        }
        
        private void btn_Home_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
