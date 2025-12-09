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
    // [중요] Form 클래스가 파일의 가장 위에 있어야 디자인 화면이 열립니다!
    public partial class Form7 : Form
    {
        // 프로그램 실행 중 데이터가 유지되도록 static 리스트 생성 (DB 역할)
        public static List<RepairItem> SavedRepairs = new List<RepairItem>();

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // 리스트뷰 초기화
            listView1.Items.Clear();

            // 저장된 리스트(SavedRepairs)에 있는 모든 데이터를 불러와 리스트뷰에 추가
            foreach (var item in SavedRepairs)
            {
                ListViewItem lvItem = new ListViewItem(item.CarNumber);
                lvItem.SubItems.Add(item.CarName);
                lvItem.SubItems.Add(item.RepairOrder);
                lvItem.SubItems.Add(item.Time);

                listView1.Items.Add(lvItem);
            }
        }

        // 외부에서 데이터를 추가할 때 사용하는 static 메서드
        public static void AddRepairRequest(string carNumber, string carName, string strOrder)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            // 새로운 정비 내역 객체 생성
            RepairItem newItem = new RepairItem()
            {
                CarNumber = carNumber,
                CarName = carName,
                RepairOrder = strOrder,
                Time = time
            };

            // static 리스트에 저장 (메모리에 계속 남음)
            SavedRepairs.Add(newItem);
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            // 메인 폼(Form1)을 찾아서 다시 보여줌
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Name == "Form1")
                {
                    openForm.Show();
                    break;
                }
            }
            // 현재 대기 목록 창은 닫음
            this.Close();
        }
    }

    // [이동됨] RepairItem 클래스를 Form7 클래스 밖, 아래쪽으로 내렸습니다.
    public class RepairItem
    {
        public string CarNumber { get; set; }
        public string CarName { get; set; }
        public string RepairOrder { get; set; }
        public string Time { get; set; }
    }
}
