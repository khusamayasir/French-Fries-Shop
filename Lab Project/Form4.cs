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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listBox1.Hide();
            listBox1.Items.Clear();
            progressBar1.Hide();
            progressBar2.Hide();
        }
        Stack my_stack = new Stack();

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

            my_stack.Push(Convert.ToInt32(textBox1.Text));

            if (my_stack.n > 4)
            {
                string message = "Stack is OverFlow.";
                string title = "Alert";
                MessageBox.Show(message, title);
            }
            else
            {
                string message = "Stock added to inventory.";
                string title = "Thank You";
                MessageBox.Show(message, title);
            }
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar2.Show();
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 2000000;
            for (int i = 0; i <= 2000000; i++)
            {
                progressBar2.Value = i;
            }
            progressBar2.Hide();

            if (my_stack.n == 1)
            {
                my_stack.element = my_stack.stack[my_stack.n];
                my_stack.Pop();
                my_stack.Push1(my_stack.element);

                my_stack.element = my_stack.stack[my_stack.n];
                my_stack.Pop();
                my_stack.Push1(my_stack.element);

                my_stack.selectionsort();

                my_stack.element = my_stack.stack2[my_stack.n1];
                my_stack.Pop1();
                my_stack.Push(my_stack.element);

                my_stack.element = my_stack.stack2[my_stack.n1];
                my_stack.Pop1();
                my_stack.Push(my_stack.element);
            }

            else if (my_stack.n == 2)
            {
                my_stack.element = my_stack.stack[my_stack.n];
                my_stack.Pop();
                my_stack.Push1(my_stack.element);

                my_stack.element = my_stack.stack[my_stack.n];
                my_stack.Pop();
                my_stack.Push1(my_stack.element);

                my_stack.element = my_stack.stack[my_stack.n];
                my_stack.Pop();
                my_stack.Push1(my_stack.element);

                my_stack.selectionsort();

                my_stack.element = my_stack.stack2[my_stack.n1];
                my_stack.Pop1();
                my_stack.Push(my_stack.element);

                my_stack.element = my_stack.stack2[my_stack.n1];
                my_stack.Pop1();
                my_stack.Push(my_stack.element);

                my_stack.element = my_stack.stack2[my_stack.n1];
                my_stack.Pop1();
                my_stack.Push(my_stack.element);
            }

            else if (my_stack.n == 3)
            {
                my_stack.element = my_stack.stack[my_stack.n];
                my_stack.Pop();
                my_stack.Push1(my_stack.element);

                my_stack.element = my_stack.stack[my_stack.n];
                my_stack.Pop();
                my_stack.Push1(my_stack.element);

                my_stack.element = my_stack.stack[my_stack.n];
                my_stack.Pop();
                my_stack.Push1(my_stack.element);

                my_stack.element = my_stack.stack[my_stack.n];
                my_stack.Pop();
                my_stack.Push1(my_stack.element);

                my_stack.selectionsort();

                my_stack.element = my_stack.stack2[my_stack.n1];
                my_stack.Pop1();
                my_stack.Push(my_stack.element);

                my_stack.element = my_stack.stack2[my_stack.n1];
                my_stack.Pop1();
                my_stack.Push(my_stack.element);

                my_stack.element = my_stack.stack2[my_stack.n1];
                my_stack.Pop1();
                my_stack.Push(my_stack.element);

                my_stack.element = my_stack.stack2[my_stack.n1];
                my_stack.Pop1();
                my_stack.Push(my_stack.element);
            }
            else if (my_stack.n == 0)
            {
                for (int i = my_stack.n - 1; i >= 0; i--)
                {
                    int v;
                    v = my_stack.stack[i];
                    listBox1.Items.Add(v);
                }
                listBox1.Show();

            }

            if (my_stack.n > 0)
            {
                for (int i = my_stack.n; i >= 0; i--)
                {
                    int v;
                    v = my_stack.stack[i];
                    listBox1.Items.Add(v);
                }
                listBox1.Show();

            }
            else
            {
                listBox1.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
