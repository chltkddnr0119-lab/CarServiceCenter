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

        // ==========================================
        // [핵심] 결제 처리 로직 (함수로 분리함)
        // ==========================================
        private void RunPaymentProcess()
        {
            // 1. 입력한 차량 번호 가져오기 (알려주신 이름: tb_CarNumber3)
            string inputCarNumber = tb_CarNumber3.Text;

            // 입력값이 비어있는지 확인
            if (string.IsNullOrEmpty(inputCarNumber))
            {
                MessageBox.Show("차량 번호를 입력해주세요.");
                return;
            }

            // 2. 대기 목록(Form7.SavedRepairs)에서 해당 차량 찾기
            var targetItem = Form7.SavedRepairs.Find(item => item.CarNumber == inputCarNumber);

            // 3. 차량을 찾았는지 확인
            if (targetItem != null)
            {
                // (1) 결제 성공 메시지
                MessageBox.Show($"차량번호: {targetItem.CarNumber}\n차종: {targetItem.CarName}\n\n결제가 정상적으로 완료되었습니다.");

                // (2) 대기 목록 리스트에서 영구 삭제
                Form7.SavedRepairs.Remove(targetItem);

                // (3) Form5 (영수증/완료 화면) 실행! [수정됨: Form1 -> Form5]
                Form5 form5 = new Form5();
                form5.Show();

                // 현재 결제 입력창(Form4)은 닫기
                this.Close();
            }
            else
            {
                // 차량을 못 찾았을 때
                MessageBox.Show("대기 목록에 없는 차량 번호입니다.\n차량 번호를 다시 확인해주세요.");
            }
        }

        // ==========================================
        // [핵심] 뒤로 가기 로직 (함수로 분리함)
        // ==========================================
        private void GoBackToMain()
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close(); // 현재 창 닫기
        }

        // ==========================================
        // 버튼 이벤트 연결 (어떤 것이 연결되어 있어도 작동하도록 함)
        // ==========================================

        // 1. 확인(결제) 버튼이 이것과 연결되어 있을 경우
        private void btnCheck2_Click(object sender, EventArgs e)
        {
            RunPaymentProcess();
        }

        // 2. 혹시 확인 버튼이 이것과 연결되어 있을 경우 (비어있던 함수 채움)
        private void btnCheck2_Click_1(object sender, EventArgs e)
        {
            RunPaymentProcess();
        }

        // 3. 뒤로 가기 버튼이 이것과 연결되어 있을 경우
        private void btn_Home_Click(object sender, EventArgs e)
        {
            GoBackToMain();
        }

        // 4. 혹시 뒤로 버튼이 이것과 연결되어 있을 경우 (비어있던 함수 채움)
        private void btnBack2_Click(object sender, EventArgs e)
        {
            GoBackToMain();
        }
    }
}
