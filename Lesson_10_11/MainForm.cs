using Lesson_10_11.Models;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Lesson_10_11
{
    public partial class MainForm : Form
    {
        List<Category> category;
        List<Product> products;
        public MainForm()
        {
            InitializeComponent();

        }

        private async void GetData(ComboBox cb, ListBox lb)
        {
            string pathToServer = @$"https://53e9-188-163-101-141.ngrok.io/products?IdCategory={cb.SelectedIndex + 1}";

            var client = new HttpClient();
            var response = await client.GetAsync(pathToServer);
            if (response != null && response.IsSuccessStatusCode)
            {
                
                string jsonContext = await response.Content.ReadAsStringAsync();
                products = JsonConvert.DeserializeObject<List<Product>>(jsonContext);

                FillData();
                //comboBoxCategory.DisplayMember = "Name";
                //comboBoxCategory.ValueMember = "Id";
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            listBoxProducts.SelectionMode = SelectionMode.MultiExtended;
            category = Seeder.InitCategory();
            comboBoxCategory.DataSource = category;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
            comboBoxCategory.SelectedIndex = 0;
        }
        private void FillData()
        {
            listBoxProducts.Items.Clear();

            foreach (var product in products)
            {
                listBoxProducts.Items.Add(product);
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FillData();

            GetData(comboBoxCategory, listBoxProducts);

        }

        private void AddCartBtn_Click(object sender, EventArgs e)
        {
            var selectedProducts = listBoxProducts
                .SelectedItems
                .OfType<Product>().ToList();
            if (selectedProducts != null)
            {
                foreach (var el in selectedProducts)
                {
                    listBoxCart.Items.Add(el);

                }
                textBoxTotalPay.Text = listBoxCart.Items.OfType<Product>().Sum(e => e.Price).ToString();
                textBoxCount.Text = listBoxCart.Items.Count.ToString();
            }

        }
    }
}