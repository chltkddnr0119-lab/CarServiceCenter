namespace CarServiceCenter
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            btn_SamsungPay = new Button();
            btn_CardPay = new Button();
            btn_NaverPay = new Button();
            btn_KakaoPay = new Button();
            btn_ApplePay = new Button();
            label2 = new Label();
            lb_Price = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 114);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 2;
            label1.Text = "결제 방법";
            // 
            // btn_SamsungPay
            // 
            btn_SamsungPay.FlatAppearance.BorderSize = 0;
            btn_SamsungPay.FlatStyle = FlatStyle.Flat;
            btn_SamsungPay.Image = (Image)resources.GetObject("btn_SamsungPay.Image");
            btn_SamsungPay.Location = new Point(168, 153);
            btn_SamsungPay.Name = "btn_SamsungPay";
            btn_SamsungPay.Size = new Size(75, 62);
            btn_SamsungPay.TabIndex = 3;
            btn_SamsungPay.UseVisualStyleBackColor = true;
            btn_SamsungPay.Click += btn_SamsungPay_Click;
            // 
            // btn_CardPay
            // 
            btn_CardPay.FlatAppearance.BorderSize = 0;
            btn_CardPay.FlatStyle = FlatStyle.Flat;
            btn_CardPay.Image = (Image)resources.GetObject("btn_CardPay.Image");
            btn_CardPay.Location = new Point(59, 153);
            btn_CardPay.Name = "btn_CardPay";
            btn_CardPay.Size = new Size(75, 62);
            btn_CardPay.TabIndex = 4;
            btn_CardPay.UseVisualStyleBackColor = true;
            btn_CardPay.Click += btn_CardPay_Click;
            // 
            // btn_NaverPay
            // 
            btn_NaverPay.FlatAppearance.BorderSize = 0;
            btn_NaverPay.FlatStyle = FlatStyle.Flat;
            btn_NaverPay.Image = (Image)resources.GetObject("btn_NaverPay.Image");
            btn_NaverPay.Location = new Point(168, 244);
            btn_NaverPay.Name = "btn_NaverPay";
            btn_NaverPay.Size = new Size(75, 62);
            btn_NaverPay.TabIndex = 5;
            btn_NaverPay.UseVisualStyleBackColor = true;
            btn_NaverPay.Click += btn_NaverPay_Click;
            // 
            // btn_KakaoPay
            // 
            btn_KakaoPay.FlatAppearance.BorderSize = 0;
            btn_KakaoPay.FlatStyle = FlatStyle.Flat;
            btn_KakaoPay.Image = (Image)resources.GetObject("btn_KakaoPay.Image");
            btn_KakaoPay.Location = new Point(59, 244);
            btn_KakaoPay.Name = "btn_KakaoPay";
            btn_KakaoPay.Size = new Size(75, 62);
            btn_KakaoPay.TabIndex = 6;
            btn_KakaoPay.UseVisualStyleBackColor = true;
            btn_KakaoPay.Click += btn_KakaoPay_Click;
            // 
            // btn_ApplePay
            // 
            btn_ApplePay.FlatAppearance.BorderSize = 0;
            btn_ApplePay.FlatStyle = FlatStyle.Flat;
            btn_ApplePay.Image = (Image)resources.GetObject("btn_ApplePay.Image");
            btn_ApplePay.Location = new Point(284, 153);
            btn_ApplePay.Name = "btn_ApplePay";
            btn_ApplePay.Size = new Size(75, 62);
            btn_ApplePay.TabIndex = 7;
            btn_ApplePay.UseVisualStyleBackColor = true;
            btn_ApplePay.Click += btn_ApplePay_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(59, 57);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 8;
            label2.Text = "가격:";
            // 
            // lb_Price
            // 
            lb_Price.AutoSize = true;
            lb_Price.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Price.Location = new Point(117, 57);
            lb_Price.Name = "lb_Price";
            lb_Price.Size = new Size(17, 21);
            lb_Price.TabIndex = 9;
            lb_Price.Text = "-";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 353);
            Controls.Add(lb_Price);
            Controls.Add(label2);
            Controls.Add(btn_ApplePay);
            Controls.Add(btn_KakaoPay);
            Controls.Add(btn_NaverPay);
            Controls.Add(btn_CardPay);
            Controls.Add(btn_SamsungPay);
            Controls.Add(label1);
            Name = "Form5";
            Text = "결제";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btn_SamsungPay;
        private Button btn_CardPay;
        private Button btn_NaverPay;
        private Button btn_KakaoPay;
        private Button btn_ApplePay;
        private Label label2;
        private Label lb_Price;
    }
}