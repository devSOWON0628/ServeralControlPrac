using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServeralControlPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Label label = new Label();
            label.Text = "원하는 글자 출력";
            label.Location = new Point(400,10);
            Controls.Add(label);

            LinkLabel l1 = new LinkLabel();
            l1.Text = "구글";
            l1.Location = new Point(230, 80);
            Controls.Add(l1);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
