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
            l1.Click += LabelClick;

            CheckBox cb1 = new CheckBox();
            CheckBox cb2 = new CheckBox();
            CheckBox cb3 = new CheckBox();
            Button btn1 = new Button();

            cb1.Location = new Point(10, 10);
            cb2.Location = new Point(10, 40);
            cb3.Location = new Point(10, 70);
            btn1.Location = new Point(10, 100);
            btn1.Size = new Size(120, 40);

            cb1.Text = "고구려";
            cb2.Text = "김치";
            cb3.Text = "토마토";
            btn1.Text = "감자";

            btn1.Name = "combo";
            btn1.Click += btn1Click;

            Controls.Add(cb1);
            Controls.Add(cb2);
            Controls.Add(cb3);
            Controls.Add(btn1);

        }

        private void btn1Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach(var item in Controls)
            {
                if((item is CheckBox)&&(((CheckBox)item).Checked))
                {
                    list.Add(((CheckBox)item).Text);
                }
            }
      
        }

        private void LabelClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://google.co.kr");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
