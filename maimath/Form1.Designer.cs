namespace maimath
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button1 = new Button();
            txt_input = new TextBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label3 = new Label();
            lbl_score = new Label();
            lbl_problem = new Label();
            lbl_time = new Label();
            lbl_info = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(344, 9);
            label1.Name = "label1";
            label1.Size = new Size(411, 64);
            label1.TabIndex = 0;
            label1.Text = "迈迈的数学大挑战";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(503, 345);
            button1.Name = "button1";
            button1.Size = new Size(289, 93);
            button1.TabIndex = 1;
            button1.Text = "开始挑战";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_input
            // 
            txt_input.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            txt_input.ForeColor = Color.RoyalBlue;
            txt_input.Location = new Point(655, 271);
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(137, 68);
            txt_input.TabIndex = 2;
            txt_input.TextChanged += txt_input_TextChanged;
            txt_input.KeyDown += txt_input_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(503, 290);
            label2.Name = "label2";
            label2.Size = new Size(146, 41);
            label2.TabIndex = 3;
            label2.Text = "答案是：";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.RoyalBlue;
            checkBox1.Location = new Point(12, 240);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(169, 39);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "十以内加法";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.ForeColor = Color.RoyalBlue;
            checkBox2.Location = new Point(12, 290);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(196, 39);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "十五以内加法";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.ForeColor = Color.RoyalBlue;
            checkBox3.Location = new Point(12, 340);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(169, 39);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "五以内乘法";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.ForeColor = Color.RoyalBlue;
            checkBox4.Location = new Point(12, 390);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(169, 39);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "十以内乘法";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 209);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 8;
            label3.Text = "题目选择";
            // 
            // lbl_score
            // 
            lbl_score.AutoSize = true;
            lbl_score.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_score.Location = new Point(655, 88);
            lbl_score.Name = "lbl_score";
            lbl_score.Size = new Size(100, 93);
            lbl_score.TabIndex = 9;
            lbl_score.Text = "答对0题\r\n答错0题\r\n得分0分";
            // 
            // lbl_problem
            // 
            lbl_problem.AutoSize = true;
            lbl_problem.Font = new Font("Microsoft YaHei UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_problem.ForeColor = Color.DarkCyan;
            lbl_problem.Location = new Point(344, 88);
            lbl_problem.Name = "lbl_problem";
            lbl_problem.Size = new Size(269, 83);
            lbl_problem.TabIndex = 10;
            lbl_problem.Text = "1+1=？";
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_time.ForeColor = Color.Gray;
            lbl_time.Location = new Point(344, 286);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(97, 82);
            lbl_time.TabIndex = 11;
            lbl_time.Text = "剩余 \r\n10 秒";
            // 
            // lbl_info
            // 
            lbl_info.AutoSize = true;
            lbl_info.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_info.ForeColor = Color.Goldenrod;
            lbl_info.Location = new Point(344, 203);
            lbl_info.Name = "lbl_info";
            lbl_info.Size = new Size(204, 35);
            lbl_info.TabIndex = 13;
            lbl_info.Text = "请开始挑战吧！";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Control;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Location = new Point(12, 9);
            listView1.Name = "listView1";
            listView1.Size = new Size(316, 182);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 450);
            Controls.Add(listView1);
            Controls.Add(lbl_info);
            Controls.Add(lbl_time);
            Controls.Add(lbl_problem);
            Controls.Add(lbl_score);
            Controls.Add(label3);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(txt_input);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txt_input;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label3;
        private Label lbl_score;
        private Label lbl_problem;
        private Label lbl_time;
        private Label lbl_info;
        private System.Windows.Forms.Timer timer1;
        private ListView listView1;
    }
}