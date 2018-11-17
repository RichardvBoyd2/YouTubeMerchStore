using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerchStore
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<Shirt> shirts = new List<Shirt>();
        

        private void button1_Click(object sender, EventArgs e)
        {
            shirts.Add(new Shirt());
            shirts.Last().Design = textBox1.Text;
            shirts.Last().LongSleeve = checkBox1.Checked;
            shirts.Last().Size = textBox2.Text;
            shirts.Last().Color = textBox3.Text;

            if (Int32.TryParse(textBox4.Text, out int temp))
            {
                shirts.Last().Quantity = temp;
            }
            else
            {
                MessageBox.Show("Enter a valid whole number for the quantity");
            }

            try
            {
                shirts.Last().Price = decimal.Parse(textBox5.Text);
            }       
            catch (System.FormatException)
            {
                MessageBox.Show("Enter a valid amount of money for the price");
            }
            RefreshList();
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
        }      
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox6.Text, out int temp))
            {
                shirts[listBox1.SelectedIndex].AddInventory(temp);
            }
            else
            {
                MessageBox.Show("Enter a valid whole number to change the inventory");
            }
            RefreshList();
            textBox6.Text = String.Empty;
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox6.Text, out int temp))
            {
                shirts[listBox1.SelectedIndex].RemoveInventory(temp);
            }
            else
            {
                MessageBox.Show("Enter a valid whole number to change the inventory");
            }            
            RefreshList();
            textBox6.Text = String.Empty;
        }

        private void RefreshList()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox3.DataSource = null;
            listBox4.DataSource = null;
            listBox5.DataSource = null;
            listBox6.DataSource = null;
            listBox1.DataSource = shirts;
            listBox2.DataSource = shirts;
            listBox3.DataSource = shirts;
            listBox4.DataSource = shirts;
            listBox5.DataSource = shirts;
            listBox6.DataSource = shirts;
            listBox1.DisplayMember = "Design";
            listBox2.DisplayMember = "LongSleeve";
            listBox3.DisplayMember = "Size";
            listBox4.DisplayMember = "Color";
            listBox5.DisplayMember = "Quantity";
            listBox6.DisplayMember = "Price";
        }
    }
}
