using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazon1
{
    public partial class Form1 : Form
    {

        APD65_63011212004Entities5 context = new APD65_63011212004Entities5();


        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLICK1FRAPE");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLICK1HOT");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLICK1ICED");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            amazonOrderItemBindingSource.DataSource = context.AmazonOrderItems.ToList();

            amazonOrderBindingSource.DataSource = context.AmazonOrders.ToList();
        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //string datagrid = dataGridView1.SelectedRows[0];
            //var itemAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == datagrid).FirstOrDefault();

            //string[] items = new string[]

            //{
            //    itemAMZ.Id.ToString(),
            //    itemAMZ.ProductName.ToString(),
            //    itemAMZ.TypeID.ToString(),
            //    itemAMZ.UnitPrice.ToString(),
            //};
            //listView1.Items.Add(new ListViewItem(items));
            
            
         
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            /* select */

            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "1CA");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();



        }

        private double calTotal(ListView.ListViewItemCollection items)
        {
            double sum = 0;
            foreach (ListViewItem item in items)
            {
                sum += double.Parse(item.SubItems[5].Text);
            }
            return sum;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2CA");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "3CA");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            //string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            //var itemAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            //string[] items = new string[]

            //{
            //    itemAMZ.Id.ToString(),
            //    itemAMZ.ProductName.ToString(),
            //    itemAMZ.TypeM.ToString(),
            //    numericUpDown1.Value.ToString(),
            //    itemAMZ.UnitPrice.ToString(),
            //    (itemAMZ.UnitPrice * numericUpDown1.Value).ToString()
            //};
            //listView1.Items.Add(new ListViewItem(items));

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "1L");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2L");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "3L");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "1MOC");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2MOC");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "3MOC");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox21_Click_1(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "1E");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox32_Click_1(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2E");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox33_Click_1(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "3E");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2AMR");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2LAT");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2ML");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2FL");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2FCL");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2CM");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2LC");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "1WC");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2WC");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "3WC");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2CAMK");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "3CAMK");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "1BC");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2BC");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2BCH");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2BCHL");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox41_Click_1(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "1GT");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2GT");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "3GT");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "1TM");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "3TM");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "1T");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox43_Click_1(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2LT");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2TM");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2BT");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2GTH");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2BH");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "1FM");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2FM");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "3FM");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2FMT");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "1C");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2C");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "3C");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2DC");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "3MB");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2MH");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "1AMZ");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2AMZ");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "3AMZ");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2AMZX");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "2LJ");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "3LJ");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "3FF");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "3YF");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            /* select */

            var itemAMZ = context.AmazonProducts.Where(i => i.TypeID == "1CA");
            dataGridView1.DataSource = itemAMZ.ToList();

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var selAMZ = context.AmazonProducts.Where(i => i.Id.ToString() == id).FirstOrDefault();
            string[] items = new string[]

            {
                selAMZ.Id.ToString(),
                selAMZ.ProductName.ToString(),
                selAMZ.TypeM.ToString(),
                numericUpDown1.Value.ToString(),
                selAMZ.UnitPrice.ToString(),
                (selAMZ.UnitPrice * numericUpDown1.Value).ToString()
            };
            listView1.Items.Add(new ListViewItem(items));

            double sum = calTotal(listView1.Items);
            label7.Text = sum.ToString();

            

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //public string ConvertToString(listView1 l)
        //{
        //    StringBuilder list = new StringBuilder();

        //    foreach (string item in l.Items)
        //        list.AppendLine(item);

        //    return list.ToString();
        //}

        private void button3_Click_1(object sender, EventArgs e)
        {



            //string Iprice = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //string Pname = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //string Tname = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            //listView1.SelectedIndexChanged;

            int Cnum = 0;
            int Knum = 0;
            AmazonOrder order = new AmazonOrder();
            AmazonProduct product = new AmazonProduct();
            AmazonOrderItem orderItem = new AmazonOrderItem();
            Console.WriteLine("Start: "+Cnum);
            foreach (ListViewItem item in listView1.Items)
            {

                Knum += Cnum++;
                order.OrderDate = DateTime.Now;
                Console.WriteLine("loop if: " + Knum);
                Console.WriteLine("loop: " + Cnum);
                if (Knum == Knum)
                {
                    Knum += Cnum++;
                    Console.WriteLine("loop if: " + Knum);
                    Console.WriteLine("loop if: " + Cnum);
                }
                Console.WriteLine("end : " + Cnum);

                order.OrderNumber = Knum;
                Console.WriteLine(order.OrderNumber);
                
                order.Total = decimal.Parse(label7.Text);
            }


            context.AmazonOrders.Add(order);
            int change = context.SaveChanges();
            MessageBox.Show("Change: " + change + " records || Save Order");

            if (change > 0)
                foreach(ListViewItem items in listView1.Items)
                {
                    AmazonOrderItem orderItems = new AmazonOrderItem();

                    orderItems.OrderId = order.Id;
                    orderItems.ProductId = int.Parse(items.SubItems[0].Text);
                    orderItems.OrderitemName = items.SubItems[1].Text;
                    orderItems.OrderitemType = items.SubItems[2].Text;
                    orderItems.UnitPrice = decimal.Parse(items.SubItems[4].Text);
                    orderItems.Quantitiy = int.Parse(items.SubItems[3].Text);

                    context.AmazonOrderItems.Add(orderItem);
                    context.SaveChanges();
                    
                }
                MessageBox.Show("Save OredItem");

            this.dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            listView1.Items.Clear();
            //listView1 = new ListView();



            //listView1.DataBindings = context.AmazonProducts.ToList();
            //listView1.Columns.Clear();

            amazonOrderItemBindingSource.DataSource = context.AmazonOrderItems.ToList();
        }
           

        private void button4_Click(object sender, EventArgs e)
        {


            this.dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            listView1.Items.Clear();


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void amazonOrderItemBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void amazonOrderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
