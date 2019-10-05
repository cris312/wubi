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
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
            loadRecord();
        }
        private void loadRecord()
        {
            int itemNum = 5,currL = 0;
            string title = "时期\t\t用时\t速度\t准确率\t修改率";
            gradeRecord.Items.Add(title);
            string path = @"C:/Users/wk/Desktop/test2/WindowsFormsApplication1/WindowsFormsApplication1/grade.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string ssLine = "", line;
                // 从文件读取并显示行，直到文件的末尾 
                while ((line = sr.ReadLine()) != null)
                {
                    currL++;
                    ssLine += (line + '\t');
                    if (currL % itemNum == 0) { 
                        gradeRecord.Items.Add(ssLine);
                        currL = 0;
                        ssLine = "";
                    }
                }
            } 
        }
    }
}
