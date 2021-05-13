using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Icetask3
{
    public partial class Form1 : Form
    {
        private static string path = System.IO.Path.GetFullPath(@"..\..\..\")+"list.txt";
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            LineSplitter();
        }

        private void LineSplitter()
        {
            string wordInput = textBox1.Text;
            string[] array = wordInput.Split(",");

            foreach (var word in array)
            {
                listBox1.Items.Add(word);
            }
        }

        
    }

    


}

