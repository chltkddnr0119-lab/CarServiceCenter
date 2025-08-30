namespace CarServiceCenter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnReceipt = new Button();
            btnReport = new Button();
            btnPay = new Button();
            pictureBox1 = new PictureBox();
            btn_PriceList = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnReceipt
            // 
            btnReceipt.BackColor = SystemColors.Control;
            btnReceipt.FlatAppearance.BorderSize = 0;
            btnReceipt.FlatStyle = FlatStyle.Flat;
            btnReceipt.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReceipt.Image = (Image)resources.GetObject("btnReceipt.Image");
            btnReceipt.Location = new Point(50, 401);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(225, 78);
            btnReceipt.TabIndex = 0;
            btnReceipt.Text = "접수";
            btnReceipt.UseVisualStyleBackColor = false;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = SystemColors.Control;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.Location = new Point(308, 401);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(225, 78);
            btnReport.TabIndex = 1;
            btnReport.Text = "정비내역서 출력";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = SystemColors.Control;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPay.Image = (Image)resources.GetObject("btnPay.Image");
            btnPay.Location = new Point(561, 401);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(225, 78);
            btnPay.TabIndex = 2;
            btnPay.Text = "결제";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(829, 558);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btn_PriceList
            // 
            btn_PriceList.FlatAppearance.BorderSize = 0;
            btn_PriceList.FlatStyle = FlatStyle.Flat;
            btn_PriceList.ForeColor = Color.Transparent;
            btn_PriceList.Image = (Image)resources.GetObject("btn_PriceList.Image");
            btn_PriceList.Location = new Point(747, 12);
            btn_PriceList.Name = "btn_PriceList";
            btn_PriceList.Size = new Size(70, 70);
            btn_PriceList.TabIndex = 4;
            btn_PriceList.UseVisualStyleBackColor = true;
            btn_PriceList.Click += btn_PriceList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(829, 558);
            Controls.Add(btn_PriceList);
            Controls.Add(btnPay);
            Controls.Add(btnReceipt);
            Controls.Add(btnReport);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "main";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnReceipt;
        private Button btnReport;
        private Button btnPay;
        private PictureBox pictureBox1;
        private Button btn_PriceList;
    }
}
