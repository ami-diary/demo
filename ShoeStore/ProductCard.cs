using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ShoeStore
{
    public partial class ProductCard : UserControl
    {
        public event EventHandler EditRequested;
        public event EventHandler DeleteRequested;
        public event EventHandler CardSelected;

        private bool _isSelected = false;

        public ProductCard()
        {
            InitializeComponent();
            this.Click += ProductCard_Click;
            this.DoubleClick += ProductCard_DoubleClick;
        }

        public int ProductId { get; set; }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                this.BorderStyle = _isSelected ? BorderStyle.FixedSingle : BorderStyle.None;
                if (_isSelected)
                    CardSelected?.Invoke(this, EventArgs.Empty);
            }
        }

        private void ProductCard_Click(object sender, EventArgs e)
        {
            IsSelected = true;
        }

        private void ProductCard_DoubleClick(object sender, EventArgs e)
        {
            EditRequested?.Invoke(this, EventArgs.Empty);
        }

        public void SetData(Product p)
        {
            if (p == null) throw new ArgumentNullException(nameof(p));
            ProductId = p.Id;
            lblHeader.Text = $"({p.Category}) | {p.Name}";
            lblDescValue.Text = p.Description;
            lblManufacturerValue.Text = p.Manufacturer;
            lblSupplierValue.Text = p.Supplier;
            lblUnit.Text = p.Unit;
            lblCount.Text = p.StockQty.ToString();
            lblDiscountValue.Text = $"Действующая скидка: {p.DiscountPercent:0.#}%";

            pictureBoxPhoto.Image = LoadPhotoOrStub(p.Photo);

            if (p.DiscountPercent > 0)
            {
                lblOldPrice.Visible = true;
                lblOldPrice.Text = $"{p.Price:0.00} руб.";
                lblOldPrice.ForeColor = Color.Red;
                lblOldPrice.Font = new Font(lblOldPrice.Font, FontStyle.Strikeout);

                var newPrice = p.Price * (1 - p.DiscountPercent / 100);
                lblNewPrice.Visible = true;
                lblNewPrice.Text = $"{newPrice:0.00} руб.";
                lblNewPrice.ForeColor = Color.Black;
            }
            else
            {
                lblOldPrice.Visible = false;
                lblNewPrice.Visible = true;
                lblNewPrice.Text = $"{p.Price:0.00} руб.";
                lblNewPrice.ForeColor = Color.Black;
            }

            if (p.StockQty <= 0)
                BackColor = Color.LightSkyBlue;
            else if (p.DiscountPercent > 15)
                BackColor = ColorTranslator.FromHtml("#2E8B57");
            else
                BackColor = Color.White;
        }

        private Image LoadPhotoOrStub(string path)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(path))
                {
                    string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                    string full = Path.Combine(baseDir, "Resources", "images", path);

                    // Если не нашли в Resources\images, ищем в корневой папке images
                    if (!File.Exists(full))
                        full = Path.Combine(baseDir, "images", path);

                    // Если не нашли, пробуем просто по имени файла
                    if (!File.Exists(full))
                        full = Path.Combine(baseDir, path);

                    if (File.Exists(full))
                    {
                        using (var fs = new FileStream(full, FileMode.Open, FileAccess.Read))
                        using (var img = Image.FromStream(fs))
                            return new Bitmap(img);
                    }
                    else
                    {
                        // Отладка: показываем какой путь искали
                        // MessageBox.Show("Фото не найдено: " + full);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки фото: " + ex.Message);
            }
            return null;
        }
    }
}