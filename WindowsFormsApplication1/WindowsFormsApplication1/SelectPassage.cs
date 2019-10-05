
/*
 *试题选择窗口
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
    public partial class SelectPassage : Form
    {
        Main form1 = new Main();
        public SelectPassage(Main formFrm)
        {
            form1 = formFrm;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string rootPath = Directory.GetCurrentDirectory() + "/files";
            DirectoryInfo folder = new DirectoryInfo(rootPath);
            foreach (FileInfo file in folder.GetFiles())
                listBox1.Items.Add(file.Name);
            listBox1.SetSelected(0,true);
        }
        public string fileName = "-1";
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileName = listBox1.SelectedItem.ToString();
            //Console.WriteLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.FName = fileName;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            form1.FName = "-1";
            this.Close();
        }
    }
}
