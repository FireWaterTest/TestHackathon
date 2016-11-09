using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FireWater.Test.Selenium
{
    public partial class Selenium : Form
    {
        public Selenium()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems.OfType<string>().ToList())
            {
                CaseTypes tip = (CaseTypes)Enum.Parse(typeof(CaseTypes), item);

                var cs = CaseFactory.getCase(tip);
                if (cs != null)
                {
                    cs.runTest();
                }
                else
                {
                    textBox1.AppendText("-->> " + item + "tipinde test bulunamadı. \n");
                }
            }
        }
    }
}
