using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += LoadEvent;
            Text = "Hello World!";
            this.BackColor = Color.Aquamarine;
            this.Width = 250;
            this.Height = 250;
            //this.Size = new Size(200, 150);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.Azure;
            this.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button helloButton = new Button();
            helloButton.BackColor = Color.LightGray;
            helloButton.ForeColor = Color.DarkGray;
            helloButton.Location = new Point(10, 10);
            helloButton.Text = "Привет";
            this.Controls.Add(helloButton);
            //this.Controls.Remove(helloButton);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            newForm1.Show();

            Form2 newForm = new Form2(this);
            newForm.Show();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Violet;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Azure;
        }

        private void LoadEvent(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }


    }
}
