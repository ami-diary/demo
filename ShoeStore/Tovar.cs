using ShoeStore.Data;
using System;
using System.Collections.Generic;
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
            ReloadProducts();
        }

        private void ApplyRoleUi()
        {
            bool allowed = LoginClass.Role == "Администратор" || LoginClass.Role == "Менеджер";
            pTools.Visible = allowed;
        }

        private void ReloadProducts()
        {
            _allProducts = _repo.GetAll();
            ShowProducts(_allProducts);
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}