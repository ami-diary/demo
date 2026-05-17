namespace ShoeStore
{
    partial class ProductEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductEditForm));
            this.labelArticule = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCategories = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxArticule = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxSupplier = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btnLoadPhoto = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelArticule
            // 
            this.labelArticule.AutoSize = true;
            this.labelArticule.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.labelArticule.Location = new System.Drawing.Point(44, 37);
            this.labelArticule.Name = "labelArticule";
            this.labelArticule.Size = new System.Drawing.Size(74, 20);
            this.labelArticule.TabIndex = 0;
            this.labelArticule.Text = "Артикул";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.labelPrice.Location = new System.Drawing.Point(44, 321);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(48, 20);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Цена";
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.labelCategories.Location = new System.Drawing.Point(44, 116);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(88, 20);
            this.labelCategories.TabIndex = 2;
            this.labelCategories.Text = "Категория";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.labelName.Location = new System.Drawing.Point(44, 74);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Название";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.labelDescription.Location = new System.Drawing.Point(44, 152);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(86, 20);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Описание";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.labelManufacturer.Location = new System.Drawing.Point(41, 196);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(126, 20);
            this.labelManufacturer.TabIndex = 6;
            this.labelManufacturer.Text = "Производитель";
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.labelSupplier.Location = new System.Drawing.Point(46, 236);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(97, 20);
            this.labelSupplier.TabIndex = 7;
            this.labelSupplier.Text = "Поставщик";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.labelQuantity.Location = new System.Drawing.Point(44, 280);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(99, 20);
            this.labelQuantity.TabIndex = 8;
            this.labelQuantity.Text = "Количество";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.labelDiscount.Location = new System.Drawing.Point(44, 359);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(66, 20);
            this.labelDiscount.TabIndex = 9;
            this.labelDiscount.Text = "Скидка";
            // 
            // textBoxArticule
            // 
            this.textBoxArticule.Location = new System.Drawing.Point(173, 31);
            this.textBoxArticule.Name = "textBoxArticule";
            this.textBoxArticule.Size = new System.Drawing.Size(157, 26);
            this.textBoxArticule.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(173, 68);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(157, 26);
            this.textBoxName.TabIndex = 11;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(173, 146);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(157, 26);
            this.textBoxDescription.TabIndex = 12;
            // 
            // textBoxSupplier
            // 
            this.textBoxSupplier.Location = new System.Drawing.Point(173, 236);
            this.textBoxSupplier.Name = "textBoxSupplier";
            this.textBoxSupplier.Size = new System.Drawing.Size(157, 26);
            this.textBoxSupplier.TabIndex = 13;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(173, 107);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(157, 28);
            this.comboBoxCategory.TabIndex = 14;
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(173, 188);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(157, 28);
            this.comboBoxManufacturer.TabIndex = 15;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(173, 278);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(157, 26);
            this.numQuantity.TabIndex = 16;
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(173, 321);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(157, 26);
            this.numPrice.TabIndex = 17;
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(173, 357);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(157, 26);
            this.numDiscount.TabIndex = 18;
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(371, 31);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(227, 206);
            this.pbPhoto.TabIndex = 19;
            this.pbPhoto.TabStop = false;
            // 
            // btnLoadPhoto
            // 
            this.btnLoadPhoto.Location = new System.Drawing.Point(371, 261);
            this.btnLoadPhoto.Name = "btnLoadPhoto";
            this.btnLoadPhoto.Size = new System.Drawing.Size(227, 58);
            this.btnLoadPhoto.TabIndex = 20;
            this.btnLoadPhoto.Text = "Добавить изображение";
            this.btnLoadPhoto.UseVisualStyleBackColor = true;
            this.btnLoadPhoto.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(371, 329);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(227, 50);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(371, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 36);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(487, 395);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 36);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ProductEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 443);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoadPhoto);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.comboBoxManufacturer);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxSupplier);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxArticule);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCategories);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelArticule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductEditForm";
            this.Text = "Добавление/редактирование товара ";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelArticule;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxArticule;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxSupplier;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btnLoadPhoto;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}