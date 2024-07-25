namespace mau
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
            groupBox2 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(464, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(423, 278);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin đăng nhập";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.KHOA;
            pictureBox3.Location = new Point(49, 137);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.nguoidung;
            pictureBox1.Location = new Point(49, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(262, 195);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(102, 195);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(92, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 27);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(159, 47);
            label4.Name = "label4";
            label4.Size = new Size(618, 39);
            label4.TabIndex = 11;
            label4.Text = "Đăng nhập hệ thống quản lý Booking";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(60, 223);
            label1.Name = "label1";
            label1.Size = new Size(361, 59);
            label1.TabIndex = 13;
            label1.Text = "BOOKING.COM";
            // 
            // button3
            // 
            button3.Location = new Point(60, 152);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 14;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(189, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 27);
            textBox3.TabIndex = 15;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(135, 192);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(932, 484);
            Controls.Add(checkBox1);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label1;
        private Button button3;
        private TextBox textBox3;
        private CheckBox checkBox1;
    }
}
