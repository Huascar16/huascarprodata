using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        matriz m = new matriz();
        public void limpiar()
        {
            /*textBox1.Clear();
              textBox2.Clear();
              textBox3.Clear();
              textBox4.Clear();
              */
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matriz m = new matriz();
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.Adicionar(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            listBox1.Items.Add("CODIGO "+  m.arreglo1[0, 0] + " NOMBRE " + m.arreglo1[0, 1] + " SEXO " + m.arreglo1[0, 2] + " SALARIO " + m.arreglo1[0, 3]);
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string item in listBox1.Items)
            {
                MessageBox.Show(item);
            }


        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            m.Adicionar(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.ultimo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            m.PRINCIPAL();
        }

        private void button5_Click(object sender, EventArgs e)
        {           
            for (int i = 0; i < listBox1.Items.Count / 2; i++)
            {
                var tmp = listBox1.Items[i];
                listBox1.Items[i] = listBox1.Items[listBox1.Items.Count - i - 1];
                listBox1.Items[listBox1.Items.Count - i - 1] = tmp;
                MessageBox.Show(tmp.ToString());
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
