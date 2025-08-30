namespace CarServiceCenter
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            listView1 = new ListView();
            ch_CarNumber = new ColumnHeader();
            ch_CarName = new ColumnHeader();
            ch_Reapir = new ColumnHeader();
            ch_Time = new ColumnHeader();
            label1 = new Label();
            btn_Home = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ch_CarNumber, ch_CarName, ch_Reapir, ch_Time });
            listView1.GridLines = true;
            listView1.Location = new Point(46, 56);
            listView1.Name = "listView1";
            listView1.Size = new Size(456, 291);
            listView1.Sorting = SortOrder.Ascending;
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ch_CarNumber
            // 
            ch_CarNumber.Text = "차량 번호";
            ch_CarNumber.Width = 80;
            // 
            // ch_CarName
            // 
            ch_CarName.Text = "차량 모델";
            ch_CarName.Width = 80;
            // 
            // ch_Reapir
            // 
            ch_Reapir.Text = "정비항목";
            ch_Reapir.Width = 160;
            // 
            // ch_Time
            // 
            ch_Time.Text = "접수 시간";
            ch_Time.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 22);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 1;
            label1.Text = "정비 대기 목록";
            // 
            // btn_Home
            // 
            btn_Home.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Home.Location = new Point(427, 373);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(75, 23);
            btn_Home.TabIndex = 2;
            btn_Home.Text = "홈";
            btn_Home.UseVisualStyleBackColor = true;
            btn_Home.Click += btn_Home_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(557, 435);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 435);
            Controls.Add(btn_Home);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(pictureBox1);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader ch_CarNumber;
        private ColumnHeader ch_CarName;
        private ColumnHeader ch_Reapir;
        private ColumnHeader ch_Time;
        private Label label1;
        private Button btn_Home;
        private PictureBox pictureBox1;
    }
}