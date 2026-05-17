namespace ShoeStore
{
    partial class Tovar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tovar));
            this.pTools = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.ComboBoxSurplus = new System.Windows.Forms.ComboBox();
            this.ComboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.ostatok = new System.Windows.Forms.Label();
            this.postavshik = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.Label();
            this.flTovar = new System.Windows.Forms.FlowLayoutPanel();
            this.pTop = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.pTools.SuspendLayout();
            this.pTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTools
            // 
            this.pTools.Controls.Add(this.btnOrders);
            this.pTools.Controls.Add(this.btnAddProduct);
            this.pTools.Controls.Add(this.textBoxSearch);
            this.pTools.Controls.Add(this.ComboBoxSurplus);
            this.pTools.Controls.Add(this.ComboBoxSupplier);
            this.pTools.Controls.Add(this.ostatok);
            this.pTools.Controls.Add(this.postavshik);
            this.pTools.Controls.Add(this.txtSearch);
            this.pTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTools.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.pTools.Location = new System.Drawing.Point(0, 50);
            this.pTools.Name = "pTools";
            this.pTools.Size = new System.Drawing.Size(1172, 50);
            this.pTools.TabIndex = 2;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(92, 11);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(168, 26);
            this.textBoxSearch.TabIndex = 0;
            // 
            // ComboBoxSurplus
            // 
            this.ComboBoxSurplus.FormattingEnabled = true;
            this.ComboBoxSurplus.Location = new System.Drawing.Point(670, 12);
            this.ComboBoxSurplus.Name = "ComboBoxSurplus";
            this.ComboBoxSurplus.Size = new System.Drawing.Size(131, 27);
            this.ComboBoxSurplus.TabIndex = 7;
            // 
            // ComboBoxSupplier
            // 
            this.ComboBoxSupplier.FormattingEnabled = true;
            this.ComboBoxSupplier.Location = new System.Drawing.Point(394, 10);
            this.ComboBoxSupplier.Name = "ComboBoxSupplier";
            this.ComboBoxSupplier.Size = new System.Drawing.Size(174, 27);
            this.ComboBoxSupplier.TabIndex = 6;
            // 
            // ostatok
            // 
            this.ostatok.AutoSize = true;
            this.ostatok.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.ostatok.Location = new System.Drawing.Point(585, 13);
            this.ostatok.Name = "ostatok";
            this.ostatok.Size = new System.Drawing.Size(79, 22);
            this.ostatok.TabIndex = 2;
            this.ostatok.Text = "Остаток";
            // 
            // postavshik
            // 
            this.postavshik.AutoSize = true;
            this.postavshik.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.postavshik.Location = new System.Drawing.Point(283, 12);
            this.postavshik.Name = "postavshik";
            this.postavshik.Size = new System.Drawing.Size(105, 22);
            this.postavshik.TabIndex = 1;
            this.postavshik.Text = "Поставщик";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoSize = true;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtSearch.Location = new System.Drawing.Point(22, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(64, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Поиск";
            // 
            // flTovar
            // 
            this.flTovar.AutoScroll = true;
            this.flTovar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flTovar.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.flTovar.Location = new System.Drawing.Point(0, 100);
            this.flTovar.Name = "flTovar";
            this.flTovar.Size = new System.Drawing.Size(1172, 450);
            this.flTovar.TabIndex = 3;
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.btnLogout);
            this.pTop.Controls.Add(this.lblUser);
            this.pTop.Controls.Add(this.label1);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(1172, 50);
            this.pTop.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.btnLogout.Location = new System.Drawing.Point(1059, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 33);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Выход";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblUser.Location = new System.Drawing.Point(666, 16);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(118, 20);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Пользователь:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список товаров";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnAddProduct.Location = new System.Drawing.Point(820, 7);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(149, 35);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Добавить товар ";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnOrders.Location = new System.Drawing.Point(988, 5);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(144, 35);
            this.btnOrders.TabIndex = 9;
            this.btnOrders.Text = "Заказы";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // Tovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 550);
            this.Controls.Add(this.flTovar);
            this.Controls.Add(this.pTools);
            this.Controls.Add(this.pTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tovar";
            this.Text = "Список товаров";
            this.Load += new System.EventHandler(this.Tovar_Load);
            this.pTools.ResumeLayout(false);
            this.pTools.PerformLayout();
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pTools;
        private System.Windows.Forms.FlowLayoutPanel flTovar;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label ostatok;
        private System.Windows.Forms.Label postavshik;
        private System.Windows.Forms.Label txtSearch;
        private System.Windows.Forms.ComboBox ComboBoxSupplier;
        private System.Windows.Forms.ComboBox ComboBoxSurplus;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnAddProduct;
    }
}