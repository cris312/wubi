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
        }
        //文本页面
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (fName != "-1") { 
                string path = @"C:/Users/wk/Desktop/test2/WindowsFormsApplication1/WindowsFormsApplication1/files/" + fName;
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        //文本输入
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            //passage.Focus();
            passage.Select(0,input);
            passage.ScrollToCaret();
            inputBox.Focus();
            if (inputBox.TextLength > input)
            {
                sum++;
                input = inputBox.TextLength;
                int start = input > 0 ? input - 1 : 0;
                string ans = passage.Text.Substring(start, 1);
                string userAns = inputBox.Text.Substring(start, 1);
                Console.WriteLine(ans + "," + userAns);
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
            
            }
            Console.WriteLine(timer1.ToString());
            show();
        }
        //显示各项指标
        private void show() {
            try {
                accRate = 100 * (correct * 1.0 / input);
                changeRate = 100 * (change * 1.0 / sum);
            }
            catch(DivideByZeroException){
                accRate = 0;
                changeRate = 0;
            }
            accuracyShow.Text = accRate.ToString("f2") + "%";
            reviseShow.Text = changeRate.ToString("f2") + "%";
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startBt_Click(object sender, EventArgs e)
        {
            inputBox.Focus();
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

        private void countDownTime_TextChanged(object sender, EventArgs e)
        {
            
        }
        //停止
        private void button2_Click(object sender, EventArgs e)
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
            string record = DateTime.Now.ToString("yyyy-MM-dd");
            if(time > 0)
                record += ('\n' + time.ToString() + '分');
            time = sumSec - time * 60;
            record += ('\n' + time.ToString() + '秒');
            record += ('\n' + speed.ToString("f2"));
            record += ('\n' + accRate.ToString("f2"));
            record += ('\n' + changeRate.ToString("f2") + '\n');
            string recordFile = @"C:/Users/wk/Desktop/test2/WindowsFormsApplication1/WindowsFormsApplication1/grade.txt";
            StreamWriter sw = File.AppendText(recordFile);
            sw.Write(record);
            sw.Flush();
            sw.Close();
            sw.Dispose();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
        //设置时间
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            SetTime setTime = new SetTime(this);
            setTime.Show();
            Console.WriteLine(sumMin.ToString());
        } 
        //选择试题
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            SelectPassage f2 = new SelectPassage(this);
            f2.Show();
        }

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
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void speedLabel_Click(object sender, EventArgs e)
        {

        }

        private void accLabel_Click(object sender, EventArgs e)
        {

        }

        private void speed_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Record r = new Record();
            r.Show();
        }
    }
}
