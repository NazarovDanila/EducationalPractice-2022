
namespace BeautiesShopApp.Pages
{
    partial class ProductPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.DownCheckBox = new System.Windows.Forms.CheckBox();
            this.LabelSorting = new System.Windows.Forms.Label();
            this.SortingComboBox = new System.Windows.Forms.ComboBox();
            this.LabelFiltr = new System.Windows.Forms.Label();
            this.FiltrComboBox = new System.Windows.Forms.ComboBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PageName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainImagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.manufacturerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.PageName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 75);
            this.panel2.TabIndex = 0;
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.LabelSearch.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.LabelSearch.ForeColor = System.Drawing.Color.Black;
            this.LabelSearch.Location = new System.Drawing.Point(314, 9);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(47, 17);
            this.LabelSearch.TabIndex = 8;
            this.LabelSearch.Text = "Поиск";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.SearchTextBox.Location = new System.Drawing.Point(317, 33);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(394, 23);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // DownCheckBox
            // 
            this.DownCheckBox.AutoSize = true;
            this.DownCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.DownCheckBox.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.DownCheckBox.ForeColor = System.Drawing.Color.Black;
            this.DownCheckBox.Location = new System.Drawing.Point(216, 36);
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
            this.LabelSorting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.LabelSorting.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.LabelSorting.ForeColor = System.Drawing.Color.Black;
            this.LabelSorting.Location = new System.Drawing.Point(107, 10);
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
            "Наименование",
            "Стоимость"});
            this.SortingComboBox.Location = new System.Drawing.Point(89, 33);
            this.SortingComboBox.Name = "SortingComboBox";
            this.SortingComboBox.Size = new System.Drawing.Size(121, 24);
            this.SortingComboBox.TabIndex = 4;
            this.SortingComboBox.SelectedIndexChanged += new System.EventHandler(this.SortingComboBox_SelectedIndexChanged);
            // 
            // LabelFiltr
            // 
            this.LabelFiltr.AutoSize = true;
            this.LabelFiltr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.LabelFiltr.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.LabelFiltr.ForeColor = System.Drawing.Color.Black;
            this.LabelFiltr.Location = new System.Drawing.Point(746, 10);
            this.LabelFiltr.Name = "LabelFiltr";
            this.LabelFiltr.Size = new System.Drawing.Size(109, 17);
            this.LabelFiltr.TabIndex = 3;
            this.LabelFiltr.Text = "Производители";
            // 
            // FiltrComboBox
            // 
            this.FiltrComboBox.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.FiltrComboBox.FormattingEnabled = true;
            this.FiltrComboBox.Items.AddRange(new object[] {
            "Все производители",
            "Natura Siberica",
            "Биопин ФАРМА",
            "Milotto",
            "Лаборатория натуральной косметики MIXIT",
            "Малавит",
            "ANDALOU",
            "Agent Netty PRO",
            "ЕвроТек",
            "Blue Beautifly",
            "MATSESTA",
            "АЙРОН БАРБЕР",
            "РУСХИМТЕХ",
            "НИКОЛЬ",
            "Аравия",
            "Алтэя",
            "SHELK Cosmetics",
            "Русская косметика",
            "MAGIC HERBS",
            "Natura Botanica",
            "Bel Savon",
            "ИРИДА-НЕВА",
            "Славяна",
            "АЛВА",
            "Альпика",
            "Жерминаль",
            "Арт-Визаж",
            "Валери-Д",
            "Мастерская Fitoland Organic",
            "ДОМ ПРИРОДЫ",
            "Флора",
            "ЭКО ТАВРИДА",
            "АлтайЯ",
            "Weleda",
            "ANTI AGE",
            "Колорит",
            "SATIVA",
            "Фитокосметик",
            "Клеона",
            "Живая косметика Сибири",
            "SLAVIC HAIR Company",
            "Green era",
            "SIBERINA",
            "Green Mama",
            "Altanya",
            "Черный бриллиант",
            "BIOSelect",
            "АромаВятка",
            "VIQQO — производитель инновационной уходовой косметики",
            "DIONY",
            "AMSARVEDA"});
            this.FiltrComboBox.Location = new System.Drawing.Point(731, 33);
            this.FiltrComboBox.Name = "FiltrComboBox";
            this.FiltrComboBox.Size = new System.Drawing.Size(139, 24);
            this.FiltrComboBox.TabIndex = 2;
            this.FiltrComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrComboBox_SelectedIndexChanged);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.btnGoBack.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(890, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(80, 45);
            this.btnGoBack.TabIndex = 1;
            this.btnGoBack.Text = "Назад";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Image = global::BeautiesShopApp.Properties.Resources.beauty_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PageName
            // 
            this.PageName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
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
            this.panel1.BackColor = System.Drawing.Color.White;
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
            this.panel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.mainImagePathDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.manufacturerIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(958, 503);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.btnEditProduct.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
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
            this.btnDelProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.btnDelProduct.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelProduct.ForeColor = System.Drawing.Color.White;
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
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(12, 591);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(250, 50);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Добавить";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 101;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 107;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание товара";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 140;
            // 
            // mainImagePathDataGridViewTextBoxColumn
            // 
            this.mainImagePathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mainImagePathDataGridViewTextBoxColumn.DataPropertyName = "MainImagePath";
            this.mainImagePathDataGridViewTextBoxColumn.HeaderText = "Изображение";
            this.mainImagePathDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mainImagePathDataGridViewTextBoxColumn.Name = "mainImagePathDataGridViewTextBoxColumn";
            this.mainImagePathDataGridViewTextBoxColumn.Width = 127;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "Активен/Неактивен";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.Width = 143;
            // 
            // manufacturerIDDataGridViewTextBoxColumn
            // 
            this.manufacturerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.manufacturerIDDataGridViewTextBoxColumn.DataPropertyName = "ManufacturerID";
            this.manufacturerIDDataGridViewTextBoxColumn.DataSource = this.manufacturerBindingSource;
            this.manufacturerIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.manufacturerIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.manufacturerIDDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.manufacturerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturerIDDataGridViewTextBoxColumn.Name = "manufacturerIDDataGridViewTextBoxColumn";
            this.manufacturerIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.manufacturerIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.manufacturerIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.manufacturerIDDataGridViewTextBoxColumn.Width = 139;
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataSource = typeof(BeautiesShopApp.ModelEF.Manufacturer);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(BeautiesShopApp.ModelEF.Product);
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ProductPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label PageName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainImagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn manufacturerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox FiltrComboBox;
        private System.Windows.Forms.Label LabelFiltr;
        private System.Windows.Forms.ComboBox SortingComboBox;
        private System.Windows.Forms.Label LabelSorting;
        private System.Windows.Forms.CheckBox DownCheckBox;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}