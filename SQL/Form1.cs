using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL
{
    public partial class Form1 : Form
    {
        private List<Model> customer = new List<Model>();
        public Form1()
        {
            InitializeComponent();
        }

        private void UpDateBinding()
        {
            listBox1.DataSource = customer;
            listBox1.DisplayMember = "Display";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess data = new DataAccess();
            customer = data.GetPeople(textBox1.Text);
            UpDateBinding();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess data = new DataAccess();
            data.Delete(textBox1.Text);
            UpDateBinding();
        }
    }
}
