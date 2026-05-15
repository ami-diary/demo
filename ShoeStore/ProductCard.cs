using System;
using System.Drawing;

using System.Windows.Forms;

namespace ShoeStore
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }
        public int ProductId { get; set; }

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
            //pictureBoxPhoto.Image = ...
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
    }
}
