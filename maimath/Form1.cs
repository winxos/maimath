using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace maimath
{
    public partial class Form1 : Form
    {
        int right, wrong, score;
        int op1, op2;
        int time_left;
        int ans, prob_score;
        public Form1()
        {
            InitializeComponent();
        }
        void prob1(out string txt, out int ans, out int score)
        {
            Random random = new Random();
            op1 = random.Next(8) + 2;
            op2 = random.Next(7) + 3;
            txt = string.Format("{0}+{1}=?", op1, op2);
            ans = op1 + op2;
            score = 5;
        }
        void prob2(out string txt, out int ans, out int score)
        {
            Random random = new Random();
            op1 = random.Next(10) + 5;
            op2 = random.Next(7) + 8;
            txt = string.Format("{0}+{1}=?", op1, op2);
            ans = op1 + op2;
            score = 8;
        }
        void prob3(out string txt, out int ans, out int score)
        {
            Random random = new Random();
            op1 = random.Next(4) + 2;
            op2 = random.Next(4) + 2;
            txt = string.Format("{0}x{1}=?", op1, op2);
            ans = op1 * op2;
            score = 10;
        }
        void prob4(out string txt, out int ans, out int score)
        {
            Random random = new Random();
            op1 = random.Next(7) + 3;
            op2 = random.Next(3) + 7;
            txt = string.Format("{0}x{1}=?", op1, op2);
            ans = op1 * op2;
            score = 15;
        }
        delegate void Fun(out string txt, out int ans, out int score);
        private void create_prob()
        {
            List<Fun> funs = new List<Fun>() { };
            if (checkBox2.Checked)
            {
                funs.Add(prob2);
            }
            if (checkBox3.Checked)
            {
                funs.Add(prob3);
            }
            if (checkBox4.Checked)
            {
                funs.Add(prob4);
            }
            if(funs.Count == 0)
            {
                funs.Add(prob1);
            }
            Random random = new Random();
            Fun f = funs[random.Next(funs.Count)];
            string tt;
            f(out tt, out ans, out prob_score);
            lbl_problem.Text = tt;
            time_left = 15;
            timer1.Enabled = true;
        }
        class Record
        {
            public int Rank { get; set; }
            public string Name { get; set; }
            public int Score { get; set; }
            public long Time { get; set; }
        }
        List<Record> records;
        private void button1_Click(object sender, EventArgs e)
        {
            right = 0;
            wrong = 0;
            score = 0;
            create_prob();
            txt_input.Focus();
        }
        private void save_score()
        {
            // 按分数从高到低排序
            records = records.OrderByDescending(r => r.Score).ToList();
            if (records[records.Count - 1].Score < score)
            {
                Record r = new Record
                {
                    Score = score,
                    Time = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
                };
                r.Name = Microsoft.VisualBasic.Interaction.InputBox("恭喜你进入了排行榜\r\n请输入您的名字：", "输入名字");
                records.Add(r);
                records = records.OrderByDescending(r => r.Score).ToList();
                records = records.Take(5).ToList();
                // 更新排名
                for (int i = 0; i < records.Count; i++)
                {
                    records[i].Rank = i + 1;
                }
                // 将更新后的数据写回到 JSON 文件中
                var jsonText = JsonConvert.SerializeObject(records, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("score.json", jsonText);
                show_score();
            }


        }
        private void show_score()
        {
            listView1.Items.Clear();
            foreach (var record in records)
            {
                var item = new ListViewItem(new[] { record.Rank.ToString(), record.Name, record.Score.ToString(),
                    DateTimeOffset.FromUnixTimeSeconds(record.Time).LocalDateTime.ToString() });
                listView1.Items.Add(item);
            }
        }
        private void txt_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int a = int.Parse(txt_input.Text);
                    if (a == ans)
                    {
                        lbl_info.Text = "真棒，答对了！";
                        right++;
                        score += prob_score;
                        create_prob();
                        txt_input.Text = "";
                        time_left = 15;
                    }
                    else
                    {
                        lbl_info.Text = "不对哦，再试一次吧！";
                        wrong++;
                        score -= prob_score;
                        if (score < 0)
                        {
                            score = 0;
                        }
                        txt_input.Text = "";
                    }
                }
                catch
                {
                    if (txt_input.Text == "*" || txt_input.Text == ".")
                    {
                        timer1.Enabled = false;
                        save_score();
                    }
                }
                update_view();
            }
        }
        private void update_view()
        {
            lbl_score.Text = string.Format("答对{0,4}题\n答错{1,4}题\n得分{2,4}分", right, wrong, score);
            lbl_time.Text = string.Format("剩余\n{0}秒", time_left);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            update_view();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("排名", 40);
            listView1.Columns.Add("名字", 60);
            listView1.Columns.Add("得分", 60);
            listView1.Columns.Add("时间", 150);
            // 读取 JSON 文件并解析数据
            var jsonText = File.ReadAllText("score.json");
            records = JsonConvert.DeserializeObject<List<Record>>(jsonText);
            show_score();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time_left > 0)
            {
                time_left--;
            }
            else
            {
                lbl_info.Text = "时间到了！";
                wrong++;
                if (score > 5)
                {
                    score -= 5;
                }
                create_prob();
            }
            update_view();
        }

        private void txt_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}