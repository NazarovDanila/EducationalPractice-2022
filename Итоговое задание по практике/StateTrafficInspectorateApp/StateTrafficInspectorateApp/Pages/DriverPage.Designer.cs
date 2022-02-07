
namespace StateTrafficInspectorateApp.Pages
{
    partial class DriverPage
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.DownCheckBox = new System.Windows.Forms.CheckBox();
            this.LabelSorting = new System.Windows.Forms.Label();
            this.SortingComboBox = new System.Windows.Forms.ComboBox();
            this.LabelFiltr = new System.Windows.Forms.Label();
            this.FiltrComboBox = new System.Windows.Forms.ComboBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.PageName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentialAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.jobNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.registrationAddressDataGridViewTextBoxColumn,
            this.residentialAddressDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.jobNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.driverBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(958, 503);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.btnEditProduct.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.Black;
            this.btnEditProduct.Location = new System.Drawing.Point(317, 591);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(250, 50);
            this.btnEditProduct.TabIndex = 3;
            this.btnEditProduct.Text = "Изменить";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.btnDelProduct.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelProduct.ForeColor = System.Drawing.Color.Black;
            this.btnDelProduct.Location = new System.Drawing.Point(620, 591);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(250, 50);
            this.btnDelProduct.TabIndex = 2;
            this.btnDelProduct.Text = "Удалить";
            this.btnDelProduct.UseVisualStyleBackColor = false;
            this.btnDelProduct.Click += new System.EventHandler(this.btnDelProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.Location = new System.Drawing.Point(12, 591);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(250, 50);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Добавить";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LabelSearch.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.LabelSearch.ForeColor = System.Drawing.Color.Black;
            this.LabelSearch.Location = new System.Drawing.Point(243, 9);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(47, 17);
            this.LabelSearch.TabIndex = 8;
            this.LabelSearch.Text = "Поиск";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.SearchTextBox.Location = new System.Drawing.Point(246, 33);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(465, 23);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // DownCheckBox
            // 
            this.DownCheckBox.AutoSize = true;
            this.DownCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.DownCheckBox.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.DownCheckBox.ForeColor = System.Drawing.Color.Black;
            this.DownCheckBox.Location = new System.Drawing.Point(147, 35);
            this.DownCheckBox.Name = "DownCheckBox";
            this.DownCheckBox.Size = new System.Drawing.Size(93, 21);
            this.DownCheckBox.TabIndex = 6;
            this.DownCheckBox.Text = "убывание";
            this.DownCheckBox.UseVisualStyleBackColor = false;
            this.DownCheckBox.CheckedChanged += new System.EventHandler(this.DownCheckBox_CheckedChanged);
            // 
            // LabelSorting
            // 
            this.LabelSorting.AutoSize = true;
            this.LabelSorting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LabelSorting.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.LabelSorting.ForeColor = System.Drawing.Color.Black;
            this.LabelSorting.Location = new System.Drawing.Point(38, 9);
            this.LabelSorting.Name = "LabelSorting";
            this.LabelSorting.Size = new System.Drawing.Size(86, 17);
            this.LabelSorting.TabIndex = 5;
            this.LabelSorting.Text = "Сортировка";
            // 
            // SortingComboBox
            // 
            this.SortingComboBox.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.SortingComboBox.FormattingEnabled = true;
            this.SortingComboBox.Items.AddRange(new object[] {
            "Без сортировки",
            "Фамилия",
            "Имя",
            "Отчество"});
            this.SortingComboBox.Location = new System.Drawing.Point(20, 32);
            this.SortingComboBox.Name = "SortingComboBox";
            this.SortingComboBox.Size = new System.Drawing.Size(121, 24);
            this.SortingComboBox.TabIndex = 4;
            this.SortingComboBox.SelectedIndexChanged += new System.EventHandler(this.SortingComboBox_SelectedIndexChanged);
            // 
            // LabelFiltr
            // 
            this.LabelFiltr.AutoSize = true;
            this.LabelFiltr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LabelFiltr.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.LabelFiltr.ForeColor = System.Drawing.Color.Black;
            this.LabelFiltr.Location = new System.Drawing.Point(762, 9);
            this.LabelFiltr.Name = "LabelFiltr";
            this.LabelFiltr.Size = new System.Drawing.Size(72, 17);
            this.LabelFiltr.TabIndex = 3;
            this.LabelFiltr.Text = "Компании";
            // 
            // FiltrComboBox
            // 
            this.FiltrComboBox.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.FiltrComboBox.FormattingEnabled = true;
            this.FiltrComboBox.Items.AddRange(new object[] {
            "Все компании",
            "3M",
            "AT&T",
            "Adidas",
            "Adobe Systems",
            "Allianz",
            "Amazon.com",
            "American Express",
            "Apple Inc.",
            "Audi",
            "Avon",
            "BMW",
            "Bank of America",
            "Beko",
            "BlackBerry",
            "Budweiser Stag Brewing Company",
            "Burberry",
            "Canon",
            "Cartier SA",
            "Caterpillar Inc.",
            "Chase",
            "Cisco Systems, Inc.",
            "Citigroup",
            "Coca-Cola",
            "Corona",
            "Credit Suisse",
            "Deere & Company",
            "eBay",
            "Facebook, Inc.",
            "Ferrari S.p.A.",
            "Gap Inc.",
            "General Electric",
            "Global Gillette",
            "Google",
            "Gucci",
            "H&M",
            "HSBC",
            "Harley-Davidson Motor Company",
            "Heineken Brewery",
            "Hermès",
            "Hewlett-Packard",
            "Home Depot",
            "Honda Motor Company, Ltd",
            "Hyundai",
            "IBM",
            "IKEA",
            "Intel Corporation",
            "Jack Daniel\'s",
            "Johnnie Walker",
            "Johnson & Johnson",
            "KFC",
            "Kellogg Company",
            "Kia Motors",
            "Kleenex",
            "L\'Oréal",
            "Louis Vuitton",
            "MTV",
            "MasterCard",
            "McDonald\'s",
            "Mercedes-Benz",
            "Microsoft",
            "Mitsubishi",
            "Morgan Stanley",
            "Moët et Chandon",
            "NTT Data",
            "Nescafé",
            "Nike, Inc.",
            "Nintendo",
            "Nissan Motor Co., Ltd.",
            "Nokia",
            "Oracle Corporation",
            "Pampers",
            "Panasonic Corporation",
            "PepsiCo",
            "Pizza Hut",
            "Porsche",
            "Prada",
            "Ralph Lauren Corporation",
            "SAP",
            "Samsung Group",
            "Shell Oil Company",
            "Siemens AG",
            "Smirnoff",
            "Sony",
            "Sprite",
            "Starbucks",
            "Tesco Corporation",
            "The Walt Disney Company",
            "Tiffany & Co.",
            "Toyota Motor Corporation",
            "United Parcel Service",
            "VISA",
            "Verizon Communications",
            "Vodafone",
            "Volkswagen Group",
            "Wal-Mart",
            "Wells Fargo",
            "Xerox",
            "Yahoo!",
            "Zara"});
            this.FiltrComboBox.Location = new System.Drawing.Point(731, 33);
            this.FiltrComboBox.Name = "FiltrComboBox";
            this.FiltrComboBox.Size = new System.Drawing.Size(139, 24);
            this.FiltrComboBox.TabIndex = 2;
            this.FiltrComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrComboBox_SelectedIndexChanged);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btnGoBack.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnGoBack.ForeColor = System.Drawing.Color.Black;
            this.btnGoBack.Location = new System.Drawing.Point(890, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(80, 45);
            this.btnGoBack.TabIndex = 1;
            this.btnGoBack.Text = "Назад";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // PageName
            // 
            this.PageName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.PageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageName.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageName.ForeColor = System.Drawing.Color.Black;
            this.PageName.Location = new System.Drawing.Point(0, 0);
            this.PageName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PageName.Name = "PageName";
            this.PageName.Size = new System.Drawing.Size(982, 75);
            this.PageName.TabIndex = 0;
            this.PageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnEditProduct);
            this.panel1.Controls.Add(this.btnDelProduct);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 653);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.LabelSearch);
            this.panel2.Controls.Add(this.SearchTextBox);
            this.panel2.Controls.Add(this.DownCheckBox);
            this.panel2.Controls.Add(this.LabelSorting);
            this.panel2.Controls.Add(this.SortingComboBox);
            this.panel2.Controls.Add(this.LabelFiltr);
            this.panel2.Controls.Add(this.FiltrComboBox);
            this.panel2.Controls.Add(this.btnGoBack);
            this.panel2.Controls.Add(this.PageName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 75);
            this.panel2.TabIndex = 0;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StateTrafficInspectorateApp.ModelEF.Company);
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(StateTrafficInspectorateApp.ModelEF.Job);
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataSource = typeof(StateTrafficInspectorateApp.ModelEF.Driver);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.patronymicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.Width = 125;
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "Passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.passportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            this.passportDataGridViewTextBoxColumn.Width = 125;
            // 
            // registrationAddressDataGridViewTextBoxColumn
            // 
            this.registrationAddressDataGridViewTextBoxColumn.DataPropertyName = "RegistrationAddress";
            this.registrationAddressDataGridViewTextBoxColumn.HeaderText = "Адрес регистрации";
            this.registrationAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registrationAddressDataGridViewTextBoxColumn.Name = "registrationAddressDataGridViewTextBoxColumn";
            this.registrationAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // residentialAddressDataGridViewTextBoxColumn
            // 
            this.residentialAddressDataGridViewTextBoxColumn.DataPropertyName = "ResidentialAddress";
            this.residentialAddressDataGridViewTextBoxColumn.HeaderText = "Адрес проживания";
            this.residentialAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.residentialAddressDataGridViewTextBoxColumn.Name = "residentialAddressDataGridViewTextBoxColumn";
            this.residentialAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.DataSource = this.companyBindingSource;
            this.companyDataGridViewTextBoxColumn.DisplayMember = "CompanyName";
            this.companyDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.companyDataGridViewTextBoxColumn.HeaderText = "Компания";
            this.companyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.companyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.companyDataGridViewTextBoxColumn.ValueMember = "ID";
            this.companyDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobNameDataGridViewTextBoxColumn
            // 
            this.jobNameDataGridViewTextBoxColumn.DataPropertyName = "JobName";
            this.jobNameDataGridViewTextBoxColumn.DataSource = this.jobBindingSource;
            this.jobNameDataGridViewTextBoxColumn.DisplayMember = "JobName";
            this.jobNameDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.jobNameDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.jobNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobNameDataGridViewTextBoxColumn.Name = "jobNameDataGridViewTextBoxColumn";
            this.jobNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.jobNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.jobNameDataGridViewTextBoxColumn.ValueMember = "ID";
            this.jobNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Фото";
            this.photoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            this.photoDataGridViewTextBoxColumn.Width = 125;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Дополнение";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 125;
            // 
            // DriverPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel1);
            this.Name = "DriverPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverPage";
            this.Load += new System.EventHandler(this.DriverPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.CheckBox DownCheckBox;
        private System.Windows.Forms.Label LabelSorting;
        private System.Windows.Forms.ComboBox SortingComboBox;
        private System.Windows.Forms.Label LabelFiltr;
        private System.Windows.Forms.ComboBox FiltrComboBox;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label PageName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentialAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn jobNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}