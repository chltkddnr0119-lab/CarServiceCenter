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

        // =========================================================
        // 1. 확인 버튼 (btnCheck3): 대기 목록 검색 후 내역서 출력
        // =========================================================
        private void btnCheck3_Click(object sender, EventArgs e)
        {
            string inputNumber = tb_CarNumber2.Text;
            string inputModel = tb_CarName2.Text;

            // (1) 입력값 비었는지 확인
            if (string.IsNullOrEmpty(inputNumber) || string.IsNullOrEmpty(inputModel))
            {
                MessageBox.Show("차량 번호와 모델을 모두 입력해주세요.");
                return;
            }

            // (2) 대기 목록(Form7.SavedRepairs)에서 조건에 맞는 차량 검색
            //     (이제 접수 순서와 상관없이, 입력한 정보와 일치하는 차를 찾습니다)
            var targetItem = Form7.SavedRepairs.Find(item => item.CarNumber == inputNumber && item.CarName == inputModel);

            if (targetItem != null)
            {
                // (3) 찾았다면? -> Form6(내역서 화면)에 보여줄 정보를 업데이트
                CarInfo.SavedCarNumber = targetItem.CarNumber;
                CarInfo.SavedCarName = targetItem.CarName;
                CarInfo.SavedStrOrder = targetItem.RepairOrder;
                // (필요하다면 시간 정보도 업데이트: CarInfo.InputTime ...)

                MessageBox.Show("차량 확인 성공! 정비 내역서를 출력합니다.");

                // 내역서 창 열기
                var form6 = new Form6();
                form6.Show();
                this.Close(); // 현재 검색창 닫기
            }
            else
            {
                // (4) 못 찾았을 때
                MessageBox.Show("대기 목록에 일치하는 차량이 없습니다.\n차량 번호와 모델명을 다시 확인해주세요.");
                // 입력창 비워주기 (선택사항)
                tb_CarNumber2.Text = "";
                tb_CarName2.Text = "";
            }
        }

        // =========================================================
        // 2. 뒤로 가기 버튼 (btnBack3): 메인 화면으로 이동
        // =========================================================
        private void btnBack3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
