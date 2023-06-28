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

        public Form1()
        {
            InitializeComponent();
        }
        private void create_prob()
        {
            Random random = new Random();
            op1 = random.Next(8) + 2;
            op2 = random.Next(8) + 2;
            lbl_problem.Text = string.Format("{0}+{1}=?", op1, op2);
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
            // �������Ӹߵ�������
            records = records.OrderByDescending(r => r.Score).ToList();
            if(records[records.Count - 1].Score < score)
            {
                Record r = new Record {
                Score = score,
                Time = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
            };
                r.Name = Microsoft.VisualBasic.Interaction.InputBox("��ϲ����������а�\r\n�������������֣�", "��������");
                records.Add(r);
                records = records.OrderByDescending(r => r.Score).ToList();
                records = records.Take(5).ToList();
                // ��������
                for (int i = 0; i < records.Count; i++)
                {
                    records[i].Rank = i + 1;
                }
                // �����º������д�ص� JSON �ļ���
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
                    if (a == op1 + op2)
                    {
                        lbl_info.Text = "���������ˣ�";
                        right++;
                        score += 5;
                        create_prob();
                        txt_input.Text = "";
                        time_left = 15;
                    }
                    else
                    {
                        lbl_info.Text = "����Ŷ������һ�ΰɣ�";
                        wrong++;
                        if (score > 5)
                        {
                            score -= 5;
                        }
                        txt_input.Text = "";
                    }
                }
                catch
                {
                    if(txt_input.Text == "*")
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
            lbl_score.Text = string.Format("���{0,4}��\n���{1,4}��\n�÷�{2,4}��", right, wrong, score);
            lbl_time.Text = string.Format("ʣ��\n{0}��", time_left);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            update_view();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("����", 40);
            listView1.Columns.Add("����", 60);
            listView1.Columns.Add("�÷�", 60);
            listView1.Columns.Add("ʱ��", 150);
            // ��ȡ JSON �ļ�����������
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
                lbl_info.Text = "ʱ�䵽�ˣ�";
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
    }
}