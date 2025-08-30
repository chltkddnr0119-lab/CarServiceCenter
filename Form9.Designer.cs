namespace CarServiceCenter
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lb_Date = new Label();
            label4 = new Label();
            lb_Price9 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 482);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(247, 498);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "나가기";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 170);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 109);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 72);
            label1.Name = "label1";
            label1.Size = new Size(161, 21);
            label1.TabIndex = 3;
            label1.Text = "BMW ServiceCenter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(210, 100);
            label2.Name = "label2";
            label2.Size = new Size(101, 12);
            label2.TabIndex = 4;
            label2.Text = "충청남도 아산시 배방읍";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(210, 125);
            label3.Name = "label3";
            label3.Size = new Size(89, 12);
            label3.TabIndex = 5;
            label3.Text = "              000         ";
            // 
            // lb_Date
            // 
            lb_Date.AutoSize = true;
            lb_Date.Font = new Font("맑은 고딕", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Date.Location = new Point(208, 112);
            lb_Date.Name = "lb_Date";
            lb_Date.Size = new Size(111, 12);
            lb_Date.TabIndex = 6;
            lb_Date.Text = "                 -                 ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 182);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 7;
            label4.Text = "-";
            // 
            // lb_Price9
            // 
            lb_Price9.AutoSize = true;
            lb_Price9.Location = new Point(220, 306);
            lb_Price9.Name = "lb_Price9";
            lb_Price9.Size = new Size(12, 15);
            lb_Price9.TabIndex = 8;
            lb_Price9.Text = "-";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(211, 303);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 533);
            Controls.Add(lb_Price9);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(lb_Date);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnExit);
            Controls.Add(pictureBox1);
            Name = "Form9";
            Text = "영수증";
            Load += Form9_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnExit;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lb_Date;
        private Label label4;
        private Label lb_Price9;
        private TextBox textBox2;
    }
}