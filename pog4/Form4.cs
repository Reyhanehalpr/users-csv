using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pog4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
          string[] User =  File.ReadAllLines("user.csv");

            for(int i = 0; i < User.Length; i++)
            {
                string[] a = User[i].Split(new char[] {','});
                listBox1.Items.Add(a[0] + " " +a[1]);

            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
