using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D1amondDa5h_Bot
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {

        }

        public void AddLine(string line)
        {
            textBox1.Text += "\n" + line;
        }

        public string InfoText
        {
            get
            {
                return this.textBox1.Text;
            }
            set
            {
                this.textBox1.Text += Environment.NewLine + value;
            }
        }
    }
}
