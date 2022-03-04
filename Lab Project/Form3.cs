using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Queue my_queue = new Queue();

        private void Form3_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
            progressBar2.Hide();
            label6.Hide();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Show();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 2000000;
            for (int i = 0; i <= 2000000; i++)
            {
                progressBar1.Value = i;
            }
            progressBar1.Hide();

            //WITH ARRAY
            string t = textBox1.Text;
            int a = my_queue.insertQ(t);

            if (my_queue.i >= 5)
            {
                string message = "Queue is OverFlow.";
                string title = "Alert";
                MessageBox.Show(message, title);
            }
            else
            {
               
                string message = "Order placed succefully.";
                string title = "Thank You";
                MessageBox.Show(message, title);
            }
            my_queue.i++;
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar2.Show();
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 2000000;
            for (int i = 0; i <= 2000000; i++)
            {
                progressBar2.Value = i;
            }
            progressBar2.Hide();

            //WITH ARRAY
            string d;
            d = my_queue.printQueue();
            label6.Text = d;
            label6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Hide();
            progressBar2.Show();
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 2000000;
            for (int i = 0; i <= 2000000; i++)
            {
                progressBar2.Value = i;
            }
            progressBar2.Hide();

            //WITH ARRAY
            int a = my_queue.dequeue();
            if (my_queue.front == my_queue.rear)
            {
                string message = "Queue is Empty";
                string title = "Alert";
                MessageBox.Show(message, title);
            }
            else
            {
                string message = "Congratulation!! You pay the bill of your order (" + my_queue.record[my_queue.front] + ") succefully.";
                string title = "Enjoy Your Snacks";
                MessageBox.Show(message, title);
                my_queue.record[my_queue.front] = my_queue.record[my_queue.front++];
            }
            label6.Hide();
        }

    }
}
