/*
 *主窗口程序 
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        private static int sumMin = 10;
        public int Time 
        {
            get
            {
                return sumMin;
            }
            set
            {
                sumMin = value;
            }
        }
        private int sumSec = 0;
        private int currSec = 1;
        private int currMin = sumMin;
        public int input = 0; //输入的字数
        public int change = 0; //修改的字数
        public int error = 0; //错误的字数
        public int correct = 0; //错误的字数
        private bool last = true; //上一次输入的正确情况
        private int sum = 0; //总共输入的字数
        private string fName = "-1";
        private double speed = 0;
        private double accRate = 0;
        private double changeRate = 0;
        private Queue<double> dataQueue = new Queue<double>(50);
        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
                if(fName != "-1")
                    this.passage.Text = fName;
            }
        }
        public Main()
        {
            InitializeComponent();
            inputBox.ReadOnly = true;
            this.WindowState = FormWindowState.Maximized;
            initChart();
            loadConfig();
            InputLanguageCollection langs = InputLanguage.InstalledInputLanguages;
            foreach (InputLanguage lang in langs)
            {
                if (lang.LayoutName == "中文(简体，中国)微软拼音")
                {
                    InputLanguage.CurrentInputLanguage = lang;
                }
            }
        }
        //载入配置文件
        private void loadConfig()
        {
            string ssLine;
            ssLine = getConfigWithName("TIME");
            int time = Convert.ToInt32(ssLine);
            currMin = sumMin = time;

        }
        private string getConfigWithName(string name)
        {
            string path = Directory.GetCurrentDirectory() + "/config.cfg";
            string cfg = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                // 从文件读取并显示行，直到文件的末尾 
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Substring(0, line.IndexOf("=")) == name)
                    {
                        cfg = line.Substring(line.IndexOf("=") + 1); 
                    }
                }
            }
            return cfg;
        }
        //文本页面
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (fName != "-1") { 
                string path = Directory.GetCurrentDirectory() + "/files/" + fName;
                using (StreamReader sr = new StreamReader(path))
                {
                    string ssLine = "",line;
                    // 从文件读取并显示行，直到文件的末尾 
                    while ((line = sr.ReadLine()) != null)
                    {
                        ssLine += line;
                    }
                    passage.Text = ssLine;
                } 
            }
        }
        //文本输入
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //passage.Focus();
            passage.Select(0,input);
            passage.ScrollToCaret();
            inputBox.Focus();
            string ans = "", userAns = "";
            if (inputBox.TextLength > input)
            {
                sum++;
                input = inputBox.TextLength;
                if (input > 0)
                {
                    ans = passage.Text.Substring(input - 1, 1);
                    userAns = inputBox.Text.Substring(input - 1, 1);
                }
                else
                {
                    ans = userAns = "";
                }
                if (ans == userAns)
                {
                    correct++;
                    last = true;
                }
                else
                {
                    error++;
                    last = false;
                }
            }
            else {

                input = inputBox.TextLength;
                change++;
                if (last)
                    correct--;
                else
                    error--;
                if (input > 0)
                {
                    ans = passage.Text.Substring(input - 1, 1);
                    userAns = inputBox.Text.Substring(input - 1, 1);
                }
                else
                {
                    ans = userAns = "";
                }
                
                if (ans == userAns)
                    last = true;
                else
                    last = false;
            }
            show();
            //打完了
            if (inputBox.TextLength >= passage.TextLength)
                stop();
        }
        //显示各项指标
        private void show() {
            if (input == 0)
                accRate = 0.00;
            else
                accRate = 100 * (correct * 1.0 / input);
            changeRate = 100 * (change * 1.0 / sum);
            accuracyShow.Text = accRate.ToString("f2") + "%";
            reviseShow.Text = changeRate.ToString("f2") + "%";
            processBox.Text = input.ToString() + "/" + passage.TextLength.ToString();
        }
        //开始按扭
        private void startBt_Click(object sender, EventArgs e)
        {
            inputBox.Focus();
            currMin = sumMin = Time;
            if (startBt.Text == "开始")
            {
                if (fName == "-1")
                    MessageBox.Show("请选择试题");
                else { 
                    inputBox.ReadOnly = false;
                    startBt.Text = "暂停";
                    timer1.Start();
                }
                
            }
            else {
                timer1.Stop();
                startBt.Text = "开始";
                inputBox.ReadOnly = true;
            }  
        }
        //停止
        private void button2_Click(object sender, EventArgs e)
        {
            if (sumSec == 0)
            {
                MessageBox.Show("还没开始，请不要放弃");
            }
            else
            {
                stop();
            }
        }
        private void stop()
        {
            timer1.Stop();
            inputBox.ReadOnly = true;
            currSec = currMin = 0;
            fName = "-1";
            startBt.Text = "开始";
            writeRecord();
        }
        //记录成绩
        private void writeRecord()
        {
            //时期，用时，速度，准确率，修改率
            int time = sumSec / 60;
            bool flag = false; //是否超过1分钟
            string record = DateTime.Now.ToString("yyyy-MM-dd");
            if (time > 0)
            { 
                record += ('\n' + time.ToString() + '分');
                flag = true;
            }
            if (!flag)
                record += '\n';
            time = sumSec - time * 60;
            record += (time.ToString() + '秒');
            record += ('\n' + speed.ToString("f2"));
            record += ('\n' + accRate.ToString("f2"));
            record += ('\n' + changeRate.ToString("f2") + '\n');
            string recordFile = Directory.GetCurrentDirectory() + "/grade.txt";
            StreamWriter sw = File.AppendText(recordFile);
            sw.Write(record);
            sw.Flush();
            sw.Close();
            sw.Dispose();
        }
        //设置时间
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            SetTime setTime = new SetTime(this);
            setTime.Show();
        } 
        //选择试题
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            SelectPassage f2 = new SelectPassage(this);
            passage.Clear();
            inputBox.Clear();
            f2.Show();
        }
        //计时器
        private void timer1_Tick(object sender, EventArgs e)
        {
            sumSec++;
            speed = 60 * (correct * 1.0 / sumSec);
            speedShow.Text = speed.ToString("f2") + "字/分";
            //倒计时
            string t = "";
            currSec--;
            if (currSec == 0) {
                currMin--;
                if (currMin == 0)
                {
                    timer1.Stop();
                    inputBox.ReadOnly = true;
                    currSec = currMin = 0;
                    MessageBox.Show("时间到");
                }else
                    currSec = 59;   
            }
            
            if (currMin < 10)
            {
                t += "0";
                t += currMin.ToString();
            }
            else {
                t += currMin.ToString();
            }

            t += ":";
            if (currSec < 10)
            {
                t += "0";
                t += currSec.ToString();
            }
            else {
                t += currSec.ToString();
            }
            countDownTime.Text = t;
            //更新队列数据实时画图
            update_value();
            int QTail = sumSec >= 50 ? 50 : sumSec;
            this.speedChart.Series[0].Points.AddXY(sumSec - 1, dataQueue.ElementAt(QTail - 1));
        }
        //退出菜单按钮
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //显示成绩按钮
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Record r = new Record();
            r.Show();
        }
        //设置字体按钮
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (this.fontDialog.ShowDialog() == DialogResult.OK) {
                this.inputBox.Font = this.fontDialog.Font;
                this.passage.Font = this.fontDialog.Font;
                
            }
        }
        //更新图表队列数据
        private void update_value()
        {
            if (dataQueue.Count > 50)
                dataQueue.Dequeue();
            dataQueue.Enqueue(speed);
        }
        //初始化图表
        private void initChart()
        {
            this.speedChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            this.speedChart.Titles.Clear();
        }
    }
}
