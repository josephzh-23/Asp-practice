using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Asp_practice4
{
    public partial class regularExpression : Form
    {
        public regularExpression()
        {
            InitializeComponent();
        }

        private void regularExpression_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Match for all numbers
            Regex reg = new Regex("[a.z]");
            bool result = reg.IsMatch(textBox1.Text);
            label1.Text = result.ToString();

            //Match for emails 323s
        }
    }
}
