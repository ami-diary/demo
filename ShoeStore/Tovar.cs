using ShoeStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ShoeStore
{
    public partial class Tovar : Form
    {
        private List<Product> _allProducts = new List<Product>();
        private readonly ProductRepository _repo = new ProductRepository();

        public Tovar()
        {
            InitializeComponent();
        }

        private void Tovar_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Пользователь: " + LoginClass.UserName;
            ApplyRoleUi();
            SetupComboBoxes();
            ReloadProducts();
        }

        private void ApplyRoleUi()
        {
            bool allowed = LoginClass.Role == "Администратор" || LoginClass.Role == "Менеджер";
            pTools.Visible = allowed;

            
            bool isAdmin = LoginClass.Role == "Администратор";
            btnAddProduct.Visible = isAdmin;     
            btnOrders.Visible = allowed;           
        }

        private void SetupComboBoxes()
        {
            ComboBoxSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxSupplier.Items.Clear();
            ComboBoxSupplier.Items.Add("Без сортировки");
            ComboBoxSupplier.Items.Add("Поставщик А-Я");
            ComboBoxSupplier.Items.Add("Поставщик Я-А");
            ComboBoxSupplier.SelectedIndex = 0;
            ComboBoxSupplier.SelectedIndexChanged += (s, ev) => ApplySearchAndSort();

            ComboBoxSurplus.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxSurplus.Items.Clear();
            ComboBoxSurplus.Items.Add("Без сортировки");
            ComboBoxSurplus.Items.Add("По возрастанию");
            ComboBoxSurplus.Items.Add("По убыванию");
            ComboBoxSurplus.SelectedIndex = 0;
            ComboBoxSurplus.SelectedIndexChanged += (s, ev) => ApplySearchAndSort();

            textBoxSearch.TextChanged += (s, ev) => ApplySearchAndSort();
        }

        private void ReloadProducts()
        {
            _allProducts = _repo.GetAll();
            ApplySearchAndSort();
        }

        private void ShowProducts(List<Product> products)
        {
            flTovar.SuspendLayout();
            flTovar.Controls.Clear();

            foreach (var p in products)
            {
                var card = new ProductCard();
                card.SetData(p);
                flTovar.Controls.Add(card);
            }

            flTovar.ResumeLayout();
        }

        private bool Contains(string value, string token)
        {
            if (string.IsNullOrEmpty(value)) return false;
            return value.IndexOf(token, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private bool ContainsInAnyTextField(Product p, string token)
        {
            return Contains(p.Article, token) || Contains(p.Name, token) || Contains(p.Category, token) ||
                   Contains(p.Description, token) || Contains(p.Manufacturer, token) || Contains(p.Supplier, token);
        }

        private void ApplySearchAndSort()
        {
            IEnumerable<Product> query = _allProducts;

            string text = (textBoxSearch.Text ?? "").Trim();
            if (!string.IsNullOrWhiteSpace(text))
            {
                var tokens = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                query = query.Where(p => tokens.All(t => ContainsInAnyTextField(p, t)));
            }

            bool ordered = false;
            IOrderedEnumerable<Product> orderedQuery = null;

            string supplierSort = ComboBoxSupplier.SelectedItem?.ToString() ?? "Без сортировки";
            if (supplierSort.Contains("А-Я"))
            {
                orderedQuery = query.OrderBy(p => p.Supplier);
                ordered = true;
            }
            else if (supplierSort.Contains("Я-А"))
            {
                orderedQuery = query.OrderByDescending(p => p.Supplier);
                ordered = true;
            }

            string qtySort = ComboBoxSurplus.SelectedItem?.ToString() ?? "Без сортировки";
            if (qtySort.Contains("По возрастанию"))
            {
                orderedQuery = ordered ? orderedQuery.ThenBy(p => p.StockQty) : query.OrderBy(p => p.StockQty);
                ordered = true;
            }
            else if (qtySort.Contains("По убыванию"))
            {
                orderedQuery = ordered ? orderedQuery.ThenByDescending(p => p.StockQty) : query.OrderByDescending(p => p.StockQty);
                ordered = true;
            }

            ShowProducts((ordered ? orderedQuery : query).ToList());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка Добавить сработала!");
            // var editForm = new ProductEditForm();
            // if (editForm.ShowDialog() == DialogResult.OK)
            //     ReloadProducts();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Форма заказов будет добавлена в модуле 3");
           
        }
    }
}