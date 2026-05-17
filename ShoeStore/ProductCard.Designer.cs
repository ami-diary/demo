namespace ShoeStore
{
    partial class ProductCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pRight = new System.Windows.Forms.Panel();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.TableLayoutPanel();
            this.lblCount = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.labelEd = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.lblSupplierValue = new System.Windows.Forms.Label();
            this.labelPostavshik = new System.Windows.Forms.Label();
            this.lblManufacturerValue = new System.Windows.Forms.Label();
            this.labelProizvod = new System.Windows.Forms.Label();
            this.lblDescValue = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelOpisanie = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.TableLayoutPanel();
            this.lblOldPrice = new System.Windows.Forms.Label();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.pRight.SuspendLayout();
            this.tip.SuspendLayout();
            this.lblPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pRight
            // 
            this.pRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pRight.Controls.Add(this.lblDiscountValue);
            this.pRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRight.Location = new System.Drawing.Point(903, 0);
            this.pRight.Name = "pRight";
            this.pRight.Size = new System.Drawing.Size(269, 345);
            this.pRight.TabIndex = 0;
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.AutoSize = true;
            this.lblDiscountValue.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscountValue.Location = new System.Drawing.Point(4, 4);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(196, 22);
            this.lblDiscountValue.TabIndex = 0;
            this.lblDiscountValue.Text = "Действующая скидка:";
            // 
            // tip
            // 
            this.tip.ColumnCount = 2;
            this.tip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7537F));
            this.tip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.2463F));
            this.tip.Controls.Add(this.lblCount, 1, 6);
            this.tip.Controls.Add(this.labelCount, 0, 6);
            this.tip.Controls.Add(this.lblUnit, 1, 5);
            this.tip.Controls.Add(this.labelEd, 0, 5);
            this.tip.Controls.Add(this.labelPrice, 0, 4);
            this.tip.Controls.Add(this.lblSupplierValue, 1, 3);
            this.tip.Controls.Add(this.labelPostavshik, 0, 3);
            this.tip.Controls.Add(this.lblManufacturerValue, 1, 2);
            this.tip.Controls.Add(this.labelProizvod, 0, 2);
            this.tip.Controls.Add(this.lblDescValue, 1, 1);
            this.tip.Controls.Add(this.lblHeader, 1, 0);
            this.tip.Controls.Add(this.labelHeader, 0, 0);
            this.tip.Controls.Add(this.labelOpisanie, 0, 1);
            this.tip.Controls.Add(this.lblPrice, 1, 4);
            this.tip.Location = new System.Drawing.Point(285, 0);
            this.tip.Name = "tip";
            this.tip.RowCount = 7;
            this.tip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.52174F));
            this.tip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tip.Size = new System.Drawing.Size(609, 342);
            this.tip.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.Location = new System.Drawing.Point(306, 296);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(99, 20);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = "Количество";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(3, 296);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(99, 20);
            this.labelCount.TabIndex = 12;
            this.labelCount.Text = "Количество";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUnit.Location = new System.Drawing.Point(306, 248);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(77, 20);
            this.lblUnit.TabIndex = 11;
            this.lblUnit.Text = "Единица";
            // 
            // labelEd
            // 
            this.labelEd.AutoSize = true;
            this.labelEd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEd.Location = new System.Drawing.Point(3, 248);
            this.labelEd.Name = "labelEd";
            this.labelEd.Size = new System.Drawing.Size(77, 20);
            this.labelEd.TabIndex = 10;
            this.labelEd.Text = "Единица";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(3, 195);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(48, 20);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Цена";
            // 
            // lblSupplierValue
            // 
            this.lblSupplierValue.AutoSize = true;
            this.lblSupplierValue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSupplierValue.Location = new System.Drawing.Point(306, 143);
            this.lblSupplierValue.Name = "lblSupplierValue";
            this.lblSupplierValue.Size = new System.Drawing.Size(97, 20);
            this.lblSupplierValue.TabIndex = 7;
            this.lblSupplierValue.Text = "Поставщик";
            // 
            // labelPostavshik
            // 
            this.labelPostavshik.AutoSize = true;
            this.labelPostavshik.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPostavshik.Location = new System.Drawing.Point(3, 143);
            this.labelPostavshik.Name = "labelPostavshik";
            this.labelPostavshik.Size = new System.Drawing.Size(97, 20);
            this.labelPostavshik.TabIndex = 6;
            this.labelPostavshik.Text = "Поставщик";
            // 
            // lblManufacturerValue
            // 
            this.lblManufacturerValue.AutoSize = true;
            this.lblManufacturerValue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblManufacturerValue.Location = new System.Drawing.Point(306, 88);
            this.lblManufacturerValue.Name = "lblManufacturerValue";
            this.lblManufacturerValue.Size = new System.Drawing.Size(126, 20);
            this.lblManufacturerValue.TabIndex = 5;
            this.lblManufacturerValue.Text = "Производитель";
            // 
            // labelProizvod
            // 
            this.labelProizvod.AutoSize = true;
            this.labelProizvod.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProizvod.Location = new System.Drawing.Point(3, 88);
            this.labelProizvod.Name = "labelProizvod";
            this.labelProizvod.Size = new System.Drawing.Size(126, 20);
            this.labelProizvod.TabIndex = 4;
            this.labelProizvod.Text = "Производитель";
            // 
            // lblDescValue
            // 
            this.lblDescValue.AutoSize = true;
            this.lblDescValue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescValue.Location = new System.Drawing.Point(306, 38);
            this.lblDescValue.Name = "lblDescValue";
            this.lblDescValue.Size = new System.Drawing.Size(86, 20);
            this.lblDescValue.TabIndex = 3;
            this.lblDescValue.Text = "Описание";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(306, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(291, 20);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Категория | Наименование товара";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.labelHeader.Location = new System.Drawing.Point(3, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(291, 20);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Категория | Наименование товара";
            // 
            // labelOpisanie
            // 
            this.labelOpisanie.AutoSize = true;
            this.labelOpisanie.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpisanie.Location = new System.Drawing.Point(3, 38);
            this.labelOpisanie.Name = "labelOpisanie";
            this.labelOpisanie.Size = new System.Drawing.Size(86, 20);
            this.labelOpisanie.TabIndex = 2;
            this.labelOpisanie.Text = "Описание";
            // 
            // lblPrice
            // 
            this.lblPrice.ColumnCount = 2;
            this.lblPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lblPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lblPrice.Controls.Add(this.lblOldPrice, 0, 0);
            this.lblPrice.Controls.Add(this.lblNewPrice, 1, 0);
            this.lblPrice.Location = new System.Drawing.Point(306, 198);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RowCount = 2;
            this.lblPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.97872F));
            this.lblPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.02128F));
            this.lblPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.lblPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.lblPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.lblPrice.Size = new System.Drawing.Size(300, 47);
            this.lblPrice.TabIndex = 14;
            // 
            // lblOldPrice
            // 
            this.lblOldPrice.AutoSize = true;
            this.lblOldPrice.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOldPrice.Location = new System.Drawing.Point(3, 0);
            this.lblOldPrice.Name = "lblOldPrice";
            this.lblOldPrice.Size = new System.Drawing.Size(92, 19);
            this.lblOldPrice.TabIndex = 0;
            this.lblOldPrice.Text = "Старая цена";
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewPrice.Location = new System.Drawing.Point(153, 0);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(86, 19);
            this.lblNewPrice.TabIndex = 1;
            this.lblNewPrice.Text = "Новая цена";
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(279, 345);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 2;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.pRight);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(1172, 345);
            this.pRight.ResumeLayout(false);
            this.pRight.PerformLayout();
            this.tip.ResumeLayout(false);
            this.tip.PerformLayout();
            this.lblPrice.ResumeLayout(false);
            this.lblPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pRight;
        private System.Windows.Forms.TableLayoutPanel tip;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label labelOpisanie;
        private System.Windows.Forms.Label lblDescValue;
        private System.Windows.Forms.Label labelEd;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label lblSupplierValue;
        private System.Windows.Forms.Label labelPostavshik;
        private System.Windows.Forms.Label lblManufacturerValue;
        private System.Windows.Forms.Label labelProizvod;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.TableLayoutPanel lblPrice;
        private System.Windows.Forms.Label lblOldPrice;
        private System.Windows.Forms.Label lblNewPrice;
    }
}
