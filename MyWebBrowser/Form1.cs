using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void расширенияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void приЗапускеБраузераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            приЗапускеБраузера newForm = new приЗапускеБраузера();
            newForm.Show();
        }
    }
}
