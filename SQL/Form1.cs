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
            customer = data.GetPeople(textBox1.Text);// we use customer because it is a list of Model which is the return type of the GetAll method.
            UpDateBinding();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess data = new DataAccess();
            data.Delete(textBox1.Text);// we don't use the customer variable here because the method's return type is void.
            UpDateBinding();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataAccess data = new DataAccess();
            customer = data.GetAll(); // we use customer because it is a list of Model which is the return type of the GetAll method.
            UpDateBinding();
        }
    }
}
