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

        InventoryManager InventoryManager = new InventoryManager();

        //Create Button
        private void button1_Click(object sender, EventArgs e)
        {
            String Design = textBox1.Text;
            Boolean LongSleeve = checkBox1.Checked;
            String Size = textBox2.Text;
            String Color = textBox3.Text;
            int Quantity = 0;
            decimal Price = 0;

            if (Int32.TryParse(textBox4.Text, out int temp))
            {
                Quantity = temp;
            }
            else
            {
                MessageBox.Show("Enter a valid whole number for the quantity");
            }

            try
            {
                Price = decimal.Parse(textBox5.Text);
            }       
            catch (System.FormatException)
            {
                MessageBox.Show("Enter a valid amount of money for the price");
            }
            
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;

            InventoryManager.AddItem(Design, LongSleeve, Size, Color, Quantity, Price);
            RefreshList();
        }      
        
        //Restock Button
        private void button3_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox6.Text, out int temp))
            {
                InventoryManager.RestockItem(listBox1.SelectedIndex, temp);
            }
            else
            {
                MessageBox.Show("Enter a valid whole number to change the inventory");
            }
            RefreshList();
            textBox6.Text = String.Empty;
        }        

        //Remove Button
        private void button2_Click(object sender, EventArgs e)
        {
            InventoryManager.RemoveItem(listBox1.SelectedIndex);   
            RefreshList();            
        }

        //Search by Color
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox3.DataSource = null;
            listBox4.DataSource = null;
            listBox5.DataSource = null;
            listBox6.DataSource = null;
            listBox1.DataSource = InventoryManager.SearchByColor(textBox7.Text);
            listBox2.DataSource = InventoryManager.SearchByColor(textBox7.Text);
            listBox3.DataSource = InventoryManager.SearchByColor(textBox7.Text);
            listBox4.DataSource = InventoryManager.SearchByColor(textBox7.Text);
            listBox5.DataSource = InventoryManager.SearchByColor(textBox7.Text);
            listBox6.DataSource = InventoryManager.SearchByColor(textBox7.Text);
            listBox1.DisplayMember = "Design";
            listBox2.DisplayMember = "LongSleeve";
            listBox3.DisplayMember = "Size";
            listBox4.DisplayMember = "Color";
            listBox5.DisplayMember = "Quantity";
            listBox6.DisplayMember = "Price";
        }

        //Search by Name
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox3.DataSource = null;
            listBox4.DataSource = null;
            listBox5.DataSource = null;
            listBox6.DataSource = null;
            listBox1.DataSource = InventoryManager.SearchByName(textBox7.Text);
            listBox2.DataSource = InventoryManager.SearchByName(textBox7.Text);
            listBox3.DataSource = InventoryManager.SearchByName(textBox7.Text);
            listBox4.DataSource = InventoryManager.SearchByName(textBox7.Text);
            listBox5.DataSource = InventoryManager.SearchByName(textBox7.Text);
            listBox6.DataSource = InventoryManager.SearchByName(textBox7.Text);
            listBox1.DisplayMember = "Design";
            listBox2.DisplayMember = "LongSleeve";
            listBox3.DisplayMember = "Size";
            listBox4.DisplayMember = "Color";
            listBox5.DisplayMember = "Quantity";
            listBox6.DisplayMember = "Price";
        }

        //Clear Search
        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            RefreshList();
        }

        private void RefreshList()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox3.DataSource = null;
            listBox4.DataSource = null;
            listBox5.DataSource = null;
            listBox6.DataSource = null;
            listBox1.DataSource = InventoryManager.GetShirts();
            listBox2.DataSource = InventoryManager.GetShirts();
            listBox3.DataSource = InventoryManager.GetShirts();
            listBox4.DataSource = InventoryManager.GetShirts();
            listBox5.DataSource = InventoryManager.GetShirts();
            listBox6.DataSource = InventoryManager.GetShirts();
            listBox1.DisplayMember = "Design";
            listBox2.DisplayMember = "LongSleeve";
            listBox3.DisplayMember = "Size";
            listBox4.DisplayMember = "Color";
            listBox5.DisplayMember = "Quantity";
            listBox6.DisplayMember = "Price";
        }

        
    }
}
