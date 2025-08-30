namespace CarServiceCenter
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            tb_CarNumber2 = new TextBox();
            label2 = new Label();
            tb_CarName2 = new TextBox();
            btnCheck3 = new Button();
            pictureBox1 = new PictureBox();
            btnBack3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 71);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 0;
            label1.Text = "차량 번호";
            // 
            // tb_CarNumber2
            // 
            tb_CarNumber2.Location = new Point(144, 69);
            tb_CarNumber2.Name = "tb_CarNumber2";
            tb_CarNumber2.Size = new Size(177, 23);
            tb_CarNumber2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 119);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 2;
            label2.Text = "차량 모델";
            // 
            // tb_CarName2
            // 
            tb_CarName2.Location = new Point(144, 119);
            tb_CarName2.Name = "tb_CarName2";
            tb_CarName2.Size = new Size(177, 23);
            tb_CarName2.TabIndex = 3;
            // 
            // btnCheck3
            // 
            btnCheck3.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheck3.Location = new Point(198, 181);
            btnCheck3.Name = "btnCheck3";
            btnCheck3.Size = new Size(75, 23);
            btnCheck3.TabIndex = 4;
            btnCheck3.Text = "확인";
            btnCheck3.UseVisualStyleBackColor = true;
            btnCheck3.Click += btnCheck3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnBack3
            // 
            btnBack3.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack3.Location = new Point(94, 181);
            btnBack3.Name = "btnBack3";
            btnBack3.Size = new Size(75, 23);
            btnBack3.TabIndex = 4;
            btnBack3.Text = "뒤로";
            btnBack3.UseVisualStyleBackColor = true;
            btnBack3.Click += btnBack3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 330);
            Controls.Add(btnBack3);
            Controls.Add(btnCheck3);
            Controls.Add(tb_CarName2);
            Controls.Add(label2);
            Controls.Add(tb_CarNumber2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "정비내역서_로그인";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_CarNumber2;
        private Label label2;
        private TextBox tb_CarName2;
        private Button btnCheck3;
        private PictureBox pictureBox1;
        private Button btnBack3;
    }
}