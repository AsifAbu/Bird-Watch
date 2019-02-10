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
    public partial class Form1 : Form
    {
        Form2 form2;
        Form3 form3;
        public Form1()
        {
            InitializeComponent();
            
            form3 = new Form3(this);
            form2 = new Form2(form3, this);
        }

        private void registerBird_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.form2.Show();
        }

        private void viewListOfBird_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.form3.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
