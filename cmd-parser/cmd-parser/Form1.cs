using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cmd_parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParser_Click(object sender, EventArgs e)
        {
            tbTgt.Text = tbSrc.Text;
            tbTgt.Text = tbTgt.Text.Replace("@", "^@");
            tbTgt.Text = tbTgt.Text.Replace("%", "%%");
            tbTgt.Text = tbTgt.Text.Replace(">", "^>");
            tbTgt.Text = tbTgt.Text.Replace("<", "^<");
            tbTgt.Text = tbTgt.Text.Replace("&", "^&");
            tbTgt.Text = tbTgt.Text.Replace("|", "^|");
            tbTgt.Text = tbTgt.Text.Replace("(", "^(");
            tbTgt.Text = tbTgt.Text.Replace("\"", "\"\"\"");
            tbTgt.Text = tbTgt.Text.Replace(")", "^)");
            tbTgt.Text = tbTgt.Text.Replace("!", "^!");
        }

        private void btnUnParser_Click(object sender, EventArgs e)
        {
            tbSrc.Text = tbTgt.Text;
            tbSrc.Text = tbSrc.Text.Replace("^@", "@");
            tbSrc.Text = tbSrc.Text.Replace("%%", "%");
            tbSrc.Text = tbSrc.Text.Replace("^>", ">");
            tbSrc.Text = tbSrc.Text.Replace("^<", "<");
            tbSrc.Text = tbSrc.Text.Replace("^&", "&");
            tbSrc.Text = tbSrc.Text.Replace("^|", "|");
            tbSrc.Text = tbSrc.Text.Replace("^(", "(");
            tbSrc.Text = tbSrc.Text.Replace("\"\"\"", "\"");
            tbSrc.Text = tbSrc.Text.Replace("^)", ")");
            tbSrc.Text = tbSrc.Text.Replace("^!", "!");
        }
    }
}
