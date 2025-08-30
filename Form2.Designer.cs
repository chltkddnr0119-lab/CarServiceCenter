namespace CarServiceCenter
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lb_CarNumber = new Label();
            lb_CarName = new Label();
            tb_CarNumber = new TextBox();
            tb_CarName = new TextBox();
            label1 = new Label();
            btnCheck = new Button();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tp_change = new TabPage();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            tp_Repair = new TabPage();
            checkBox12 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox8 = new CheckBox();
            tp_Inspection = new TabPage();
            checkBox14 = new CheckBox();
            checkBox13 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tp_change.SuspendLayout();
            tp_Repair.SuspendLayout();
            tp_Inspection.SuspendLayout();
            SuspendLayout();
            // 
            // lb_CarNumber
            // 
            lb_CarNumber.AutoSize = true;
            lb_CarNumber.BackColor = Color.Transparent;
            lb_CarNumber.FlatStyle = FlatStyle.Flat;
            lb_CarNumber.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_CarNumber.ForeColor = SystemColors.ControlText;
            lb_CarNumber.Location = new Point(59, 44);
            lb_CarNumber.Name = "lb_CarNumber";
            lb_CarNumber.Size = new Size(80, 21);
            lb_CarNumber.TabIndex = 0;
            lb_CarNumber.Text = "차량 번호";
            // 
            // lb_CarName
            // 
            lb_CarName.AutoSize = true;
            lb_CarName.FlatStyle = FlatStyle.Flat;
            lb_CarName.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_CarName.Location = new Point(59, 93);
            lb_CarName.Name = "lb_CarName";
            lb_CarName.Size = new Size(80, 21);
            lb_CarName.TabIndex = 1;
            lb_CarName.Text = "차량 모델";
            // 
            // tb_CarNumber
            // 
            tb_CarNumber.Location = new Point(166, 46);
            tb_CarNumber.Name = "tb_CarNumber";
            tb_CarNumber.Size = new Size(214, 23);
            tb_CarNumber.TabIndex = 2;
            // 
            // tb_CarName
            // 
            tb_CarName.Location = new Point(166, 91);
            tb_CarName.Name = "tb_CarName";
            tb_CarName.Size = new Size(214, 23);
            tb_CarName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 146);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 6;
            label1.Text = "정비 서비스";
            // 
            // btnCheck
            // 
            btnCheck.BackColor = SystemColors.Control;
            btnCheck.FlatAppearance.BorderSize = 0;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheck.Location = new Point(329, 514);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 8;
            btnCheck.Text = "접수";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 615);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tp_change);
            tabControl1.Controls.Add(tp_Repair);
            tabControl1.Controls.Add(tp_Inspection);
            tabControl1.Location = new Point(59, 188);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(245, 353);
            tabControl1.TabIndex = 10;
            // 
            // tp_change
            // 
            tp_change.Controls.Add(checkBox7);
            tp_change.Controls.Add(checkBox6);
            tp_change.Controls.Add(checkBox5);
            tp_change.Controls.Add(checkBox4);
            tp_change.Controls.Add(checkBox3);
            tp_change.Controls.Add(checkBox2);
            tp_change.Controls.Add(checkBox1);
            tp_change.Location = new Point(4, 24);
            tp_change.Name = "tp_change";
            tp_change.Padding = new Padding(3);
            tp_change.Size = new Size(237, 325);
            tp_change.TabIndex = 0;
            tp_change.Text = "소모품교체";
            tp_change.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(23, 261);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(50, 19);
            checkBox7.TabIndex = 2;
            checkBox7.Text = "기타";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(23, 221);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(103, 19);
            checkBox6.TabIndex = 1;
            checkBox6.Text = "워셔액/냉각수";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(23, 181);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(90, 19);
            checkBox5.TabIndex = 0;
            checkBox5.Text = "에어컨 냉매";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(23, 141);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(120, 19);
            checkBox4.TabIndex = 0;
            checkBox4.Text = "퓨즈/램프/배터리";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(23, 101);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(114, 19);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "와이퍼 블레이드";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(23, 61);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(86, 19);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "변속기오일";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(23, 21);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(118, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "엔진오일 및 필터";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // tp_Repair
            // 
            tp_Repair.Controls.Add(checkBox12);
            tp_Repair.Controls.Add(checkBox11);
            tp_Repair.Controls.Add(checkBox10);
            tp_Repair.Controls.Add(checkBox9);
            tp_Repair.Controls.Add(checkBox8);
            tp_Repair.Location = new Point(4, 24);
            tp_Repair.Name = "tp_Repair";
            tp_Repair.Padding = new Padding(3);
            tp_Repair.Size = new Size(237, 325);
            tp_Repair.TabIndex = 1;
            tp_Repair.Text = "일반/품질 관리";
            tp_Repair.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(25, 204);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(50, 19);
            checkBox12.TabIndex = 4;
            checkBox12.Text = "기타";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(25, 159);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(62, 19);
            checkBox11.TabIndex = 3;
            checkBox11.Text = "경고등";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(25, 114);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(79, 19);
            checkBox10.TabIndex = 2;
            checkBox10.Text = "소음/진동";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(25, 69);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(50, 19);
            checkBox9.TabIndex = 1;
            checkBox9.Text = "변속";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(25, 24);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(50, 19);
            checkBox8.TabIndex = 0;
            checkBox8.Text = "엔진";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // tp_Inspection
            // 
            tp_Inspection.Controls.Add(checkBox14);
            tp_Inspection.Controls.Add(checkBox13);
            tp_Inspection.Location = new Point(4, 24);
            tp_Inspection.Name = "tp_Inspection";
            tp_Inspection.Padding = new Padding(3);
            tp_Inspection.Size = new Size(237, 325);
            tp_Inspection.TabIndex = 2;
            tp_Inspection.Text = "정기점검";
            tp_Inspection.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Location = new Point(27, 64);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(74, 19);
            checkBox14.TabIndex = 1;
            checkBox14.Text = "종합검사";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Location = new Point(27, 26);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(74, 19);
            checkBox13.TabIndex = 0;
            checkBox13.Text = "정기검사";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 615);
            Controls.Add(btnCheck);
            Controls.Add(tabControl1);
            Controls.Add(tb_CarNumber);
            Controls.Add(lb_CarNumber);
            Controls.Add(label1);
            Controls.Add(tb_CarName);
            Controls.Add(lb_CarName);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "정비 접수";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tp_change.ResumeLayout(false);
            tp_change.PerformLayout();
            tp_Repair.ResumeLayout(false);
            tp_Repair.PerformLayout();
            tp_Inspection.ResumeLayout(false);
            tp_Inspection.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_CarNumber;
        private Label lb_CarName;
        private TextBox tb_CarNumber;
        private TextBox tb_CarName;
        private Label label1;
        private Button btnCheck;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tp_change;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TabPage tp_Repair;
        private CheckBox checkBox12;
        private CheckBox checkBox11;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private TabPage tp_Inspection;
        private CheckBox checkBox14;
        private CheckBox checkBox13;
    }
}