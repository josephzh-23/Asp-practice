using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asp_practice4
{
    public partial class dates : Form
    {
        public dates()
        {
            InitializeComponent();
        }

        private void dates_Load(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2042, 12, 24);
            textBox2.Text = dt.ToString();

            textBox3.Text = DateTime.Now.ToShortDateString();
        }
    }
}
