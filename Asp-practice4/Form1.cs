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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var name1 = "joseph";
            textBox1.Text = name1;

            List<string> animals = new List<string>
            {
                "cat", "dog", "bird"
            };


            //Using remove
            animals.Remove("cat");



            //ToCharArray

            string name = "joseph";
            char[] character = name.ToCharArray();
            foreach(var item in character)
            {
                listBox1.Items.Add(item);
            }


            //For comparing stringf
            string str1 = "joseph";
            string str2 = "Daniel";

            bool result = str1.Equals(str2);
            textBox2.Text = result.ToString();

        }


    }
}
