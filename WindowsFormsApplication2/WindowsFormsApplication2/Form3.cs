using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        Form1 form1;
        public Form3(Form1 from1)
        {
            this.form1 = from1;
            InitializeComponent();
            dataGridView1.Rows.Add();
        }
        
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.form1.Show();
        }
        public DataGridView Reff()
        {
            return this.dataGridView1;
        }

        
    }
}
