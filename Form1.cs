using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace howto2002181
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton t = (RadioButton)sender;
            switch (t.Name)
            {
                case "btn1ShowRadio":
                    {
                        button1.Visible = true;
                        break;
                    }
                case "btn1HideRadio":
                    {
                        button1.Visible = false;
                        break;
                    }
                case "btn2ShowRadio":
                    {
                        button2.Visible = true;
                        break;
                    }
                case "btn2HideRadio":
                    {
                        button2.Visible = false;
                        break;
                    }
                case "btn3ShowRadio":
                    {
                        button3.Visible = true;
                        break;
                    }
                case "btn3HideRadio":
                    {
                        button3.Visible = false;
                        break;
                    }
                case "btn4ShowRadio":
                    {
                        button4.Visible = true;
                        break;
                    }
                case "btn4HideRadio":
                    {
                        button4.Visible = false;
                        break;
                    }
            }
        }
    }
}
