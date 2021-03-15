using System;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GettAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            LoadProducts();
            MessageBox.Show("Product Added");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Test");
            textBox3.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            textBox1.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = textBox3.Text,
                UnitPrice = Convert.ToDecimal(textBox2.Text),
                StockAmount = Convert.ToInt32(textBox1.Text)
            };
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Product Update");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);

            _productDal.Delete(id);
            LoadProducts();
            MessageBox.Show("Product Deleted");
        }
    }
}
