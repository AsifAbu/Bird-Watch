using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        Form3 form3;
        Form1 form1;
        static int count = 0;
        string a, b;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form3 form3, Form1 form1)
        {
            InitializeComponent();
            this.form3 = form3;
            this.form1 = form1;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (!string.IsNullOrEmpty(comboBox1.Text))
                {
                    a = textBox1.Text;
                    b = comboBox1.Text;
                    form3.dataGridView1.Rows.Add();
                    form3.dataGridView1.Rows[count].Cells[0].Value = a;
                    form3.dataGridView1.Rows[count].Cells[1].Value = b;
                    //MemoryStream ms = new MemoryStream();
                    //form3.pictureBox1.Image.Save(ms, form3.pictureBox1.Image.RawFormat);
                    //byte[] img = ms.ToArray();
                    //form3.dataGridView1.Rows.Add(textBox1.Text, img);
                    

                    MessageBox.Show("Insert Successfully");
                    count++;
                }
                else
                {
                    MessageBox.Show("Seen At Where? This Box Not Fill Up.");
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(comboBox1.Text))
                {
                    MessageBox.Show("Type The Name Of The Bird");
                }
                else
                {
                    MessageBox.Show("The Containing Boxes Not Fill Up. Please Fill Up Successfuly.");
                }
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.form1.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter ="Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                form3.pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
