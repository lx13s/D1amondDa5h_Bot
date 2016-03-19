using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mshtml;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace D1amondDa5h_Bot
{
    public partial class Form1 : Form
    {
        Info info = new Info();
        const int gameSizeWidth = 760;
        const int gameSizeHeigth = 500;
        const int rigthColWidth = 278;
        //const int[] gameFrameSize = { 760, 500 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            info.Visible = true;
            info.AddLine("App started");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // insert game position getter here.
            IHTMLDocument2 doc2 = (IHTMLDocument2)webBrowser1.Document.DomDocument;
            IHTMLElement2 elem2 = (IHTMLElement2)doc2.body;
            int width = elem2.scrollWidth;
            info.InfoText = elem2.scrollWidth.ToString();
            int gamePosX = (width - gameSizeWidth - 278) / 2;
            info.InfoText = "Game x = " + gamePosX.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            info.InfoText = "test";
        }
    }
}
