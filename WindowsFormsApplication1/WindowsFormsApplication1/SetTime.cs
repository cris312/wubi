using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SetTime : Form
    {
        Main form1 = new Main();
        public SetTime(Main formFrm)
        {
            form1 = formFrm;
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            form1.Time = (int)timeNumber.Value;
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
