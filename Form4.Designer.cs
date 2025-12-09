namespace CarServiceCenter
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            tb_CarNumber3 = new TextBox();
            lb_CarNumber2 = new Label();
            lb_CarName2 = new Label();
            tb_CarName3 = new TextBox();
            btnCheck2 = new Button();
            pictureBox1 = new PictureBox();
            btnBack2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tb_CarNumber3
            // 
            tb_CarNumber3.Location = new Point(148, 71);
            tb_CarNumber3.Name = "tb_CarNumber3";
            tb_CarNumber3.Size = new Size(151, 23);
            tb_CarNumber3.TabIndex = 0;
            // 
            // lb_CarNumber2
            // 
            lb_CarNumber2.AutoSize = true;
            lb_CarNumber2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_CarNumber2.Location = new Point(53, 71);
            lb_CarNumber2.Name = "lb_CarNumber2";
            lb_CarNumber2.Size = new Size(80, 21);
            lb_CarNumber2.TabIndex = 1;
            lb_CarNumber2.Text = "차량 번호";
            // 
            // lb_CarName2
            // 
            lb_CarName2.AutoSize = true;
            lb_CarName2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_CarName2.Location = new Point(53, 126);
            lb_CarName2.Name = "lb_CarName2";
            lb_CarName2.Size = new Size(80, 21);
            lb_CarName2.TabIndex = 2;
            lb_CarName2.Text = "차량 모델";
            // 
            // tb_CarName3
            // 
            tb_CarName3.Location = new Point(148, 124);
            tb_CarName3.Name = "tb_CarName3";
            tb_CarName3.Size = new Size(151, 23);
            tb_CarName3.TabIndex = 3;
            // 
            // btnCheck2
            // 
            btnCheck2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheck2.Location = new Point(184, 177);
            btnCheck2.Name = "btnCheck2";
            btnCheck2.Size = new Size(75, 23);
            btnCheck2.TabIndex = 4;
            btnCheck2.Text = "확인";
            btnCheck2.UseVisualStyleBackColor = true;
            btnCheck2.Click += btnCheck2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnBack2
            // 
            btnBack2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack2.Location = new Point(86, 177);
            btnBack2.Name = "btnBack2";
            btnBack2.Size = new Size(75, 23);
            btnBack2.TabIndex = 4;
            btnBack2.Text = "뒤로";
            btnBack2.UseVisualStyleBackColor = true;
            btnBack2.Click += btnBack2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 280);
            Controls.Add(btnBack2);
            Controls.Add(btnCheck2);
            Controls.Add(tb_CarName3);
            Controls.Add(lb_CarName2);
            Controls.Add(lb_CarNumber2);
            Controls.Add(tb_CarNumber3);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "결제로그인";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_CarNumber3;
        private Label lb_CarNumber2;
        private Label lb_CarName2;
        private TextBox tb_CarName3;
        private Button btnCheck2;
        private PictureBox pictureBox1;
        private Button btnBack2;
    }
}