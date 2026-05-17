using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ShoeStore.Data;

namespace ShoeStore
{
    public partial class ProductEditForm : Form
    {
        private readonly ProductRepository _repo = new ProductRepository();
        private readonly Product _editingProduct;
        private readonly bool _isEditMode;
        private string _imagePath = "";

        public ProductEditForm()
        {
            InitializeComponent();
            _isEditMode = false;
            _editingProduct = new Product();
            Text = "Добавление товара";
        }

        public ProductEditForm(Product product)
        {
            InitializeComponent();
            _isEditMode = true;
            _editingProduct = product;
            Text = "Редактирование товара";
            LoadProductData();
        }

        private void LoadProductData()
        {
            if (_editingProduct == null) return;

            textBoxArticule.Text = _editingProduct.Article;
            textBoxName.Text = _editingProduct.Name;
            comboBoxCategory.Text = _editingProduct.Category;
            textBoxDescription.Text = _editingProduct.Description;
            comboBoxManufacturer.Text = _editingProduct.Manufacturer;
            textBoxSupplier.Text = _editingProduct.Supplier;
            numPrice.Value = _editingProduct.Price;
            numQuantity.Value = _editingProduct.StockQty;
            numDiscount.Value = _editingProduct.DiscountPercent;

            if (!string.IsNullOrWhiteSpace(_editingProduct.Photo) && File.Exists(_editingProduct.Photo))
                pbPhoto.Image = Image.FromFile(_editingProduct.Photo);
            else
                pbPhoto.Image = null;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Введите наименование товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(comboBoxCategory.Text))
            {
                MessageBox.Show("Введите категорию товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxCategory.Focus();
                return false;
            }
            if (numQuantity.Value < 0)
            {
                MessageBox.Show("Количество не может быть отрицательным.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numQuantity.Focus();
                return false;
            }
            if (numPrice.Value < 0)
            {
                MessageBox.Show("Цена не может быть отрицательной.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numPrice.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                var product = new Product
                {
                    Id = _isEditMode ? _editingProduct.Id : 0,
                    Article = textBoxArticule.Text.Trim(),
                    Name = textBoxName.Text.Trim(),
                    Category = comboBoxCategory.Text.Trim(),
                    Description = textBoxDescription.Text.Trim(),
                    Manufacturer = comboBoxManufacturer.Text.Trim(),
                    Supplier = textBoxSupplier.Text.Trim(),
                    Unit = "шт.",
                    Price = numPrice.Value,
                    StockQty = (int)numQuantity.Value,
                    DiscountPercent = (int)numDiscount.Value,
                    Photo = _imagePath
                };

                if (_isEditMode)
                    _repo.Update(product);
                else
                    _repo.Add(product);

                MessageBox.Show("Данные товара сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _imagePath = ofd.FileName;
                pbPhoto.Image = Image.FromFile(_imagePath);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!_isEditMode || _editingProduct == null) return;

            var result = MessageBox.Show("Вы действительно хотите удалить товар?",
                "Подтверждение удаления", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes) return;

            try
            {
                _repo.Delete(_editingProduct.Id);
                MessageBox.Show("Товар удален.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Удаление невозможно", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}