namespace CarServiceCenter
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            pictureBox1 = new PictureBox();
            btn_ReceiptOk = new Button();
            btn_receiptNo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 299);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_ReceiptOk
            // 
            btn_ReceiptOk.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ReceiptOk.Location = new Point(244, 311);
            btn_ReceiptOk.Name = "btn_ReceiptOk";
            btn_ReceiptOk.Size = new Size(100, 23);
            btn_ReceiptOk.TabIndex = 1;
            btn_ReceiptOk.Text = "영수증 출력";
            btn_ReceiptOk.UseVisualStyleBackColor = true;
            btn_ReceiptOk.Click += btn_ReceiptOk_Click;
            // 
            // btn_receiptNo
            // 
            btn_receiptNo.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_receiptNo.Location = new Point(350, 311);
            btn_receiptNo.Name = "btn_receiptNo";
            btn_receiptNo.Size = new Size(100, 23);
            btn_receiptNo.TabIndex = 2;
            btn_receiptNo.Text = "영수증 출력X";
            btn_receiptNo.UseVisualStyleBackColor = true;
            btn_receiptNo.Click += btn_receiptNo_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 346);
            Controls.Add(btn_receiptNo);
            Controls.Add(btn_ReceiptOk);
            Controls.Add(pictureBox1);
            Name = "Form8";
            Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_ReceiptOk;
        private Button btn_receiptNo;
    }
}