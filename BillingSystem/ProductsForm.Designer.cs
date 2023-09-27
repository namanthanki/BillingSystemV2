namespace BillingSystem
{
    partial class ProductsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.PIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new MaterialSkin.Controls.MaterialButton();
            this.PUpdateButton = new MaterialSkin.Controls.MaterialButton();
            this.PAddButton = new MaterialSkin.Controls.MaterialButton();
            this.PriceTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.PriceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.BillPage = new System.Windows.Forms.TabPage();
            this.BillProductsCB = new MaterialSkin.Controls.MaterialComboBox();
            this.FinishButton = new MaterialSkin.Controls.MaterialButton();
            this.BillDate = new MaterialSkin.Controls.MaterialTextBox();
            this.DateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.BillTotalButton = new MaterialSkin.Controls.MaterialTextBox();
            this.TotalLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CustNameTB = new MaterialSkin.Controls.MaterialTextBox();
            this.CustNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.BillDGV = new System.Windows.Forms.DataGridView();
            this.BillPNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillQtCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new MaterialSkin.Controls.MaterialButton();
            this.BillQtTB = new MaterialSkin.Controls.MaterialTextBox();
            this.BillQtLabel = new MaterialSkin.Controls.MaterialLabel();
            this.BillPriceTB = new MaterialSkin.Controls.MaterialTextBox();
            this.BillPriceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.BillPNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.billingSystemDataSet = new BillingSystem.BillingSystemDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new BillingSystem.BillingSystemDataSetTableAdapters.ProductsTableAdapter();
            this.BGSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.DPAccentSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.AmberAccentSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.GreyAccentSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.BillPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.BillPage);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ImageList = this.imageList1;
            this.TabControl.Location = new System.Drawing.Point(3, 64);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(822, 533);
            this.TabControl.TabIndex = 0;
            this.TabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PNameTextBox);
            this.tabPage1.Controls.Add(this.DGV);
            this.tabPage1.Controls.Add(this.DeleteButton);
            this.tabPage1.Controls.Add(this.PUpdateButton);
            this.tabPage1.Controls.Add(this.PAddButton);
            this.tabPage1.Controls.Add(this.PriceTextBox);
            this.tabPage1.Controls.Add(this.PriceLabel);
            this.tabPage1.Controls.Add(this.PNameLabel);
            this.tabPage1.ImageKey = "icons8-products-24.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(814, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PNameTextBox
            // 
            this.PNameTextBox.AnimateReadOnly = false;
            this.PNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PNameTextBox.Depth = 0;
            this.PNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PNameTextBox.LeadingIcon = null;
            this.PNameTextBox.Location = new System.Drawing.Point(137, 16);
            this.PNameTextBox.MaxLength = 50;
            this.PNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PNameTextBox.Multiline = false;
            this.PNameTextBox.Name = "PNameTextBox";
            this.PNameTextBox.Size = new System.Drawing.Size(185, 36);
            this.PNameTextBox.TabIndex = 9;
            this.PNameTextBox.Text = "";
            this.PNameTextBox.TrailingIcon = null;
            this.PNameTextBox.UseTallSize = false;
            // 
            // DGV
            // 
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PIDCol,
            this.PName,
            this.PPrice});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle20;
            this.DGV.Location = new System.Drawing.Point(21, 71);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(727, 409);
            this.DGV.TabIndex = 8;
            this.DGV.SelectionChanged += new System.EventHandler(this.DGV_SelectionChanged);
            // 
            // PIDCol
            // 
            this.PIDCol.HeaderText = "ID";
            this.PIDCol.Name = "PIDCol";
            // 
            // PName
            // 
            this.PName.HeaderText = "Product Name";
            this.PName.Name = "PName";
            // 
            // PPrice
            // 
            this.PPrice.HeaderText = "Price";
            this.PPrice.Name = "PPrice";
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.HighEmphasis = true;
            this.DeleteButton.Icon = null;
            this.DeleteButton.Location = new System.Drawing.Point(675, 16);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteButton.Size = new System.Drawing.Size(73, 36);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteButton.UseAccentColor = false;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PUpdateButton
            // 
            this.PUpdateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PUpdateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.PUpdateButton.Depth = 0;
            this.PUpdateButton.HighEmphasis = true;
            this.PUpdateButton.Icon = null;
            this.PUpdateButton.Location = new System.Drawing.Point(590, 16);
            this.PUpdateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PUpdateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PUpdateButton.Name = "PUpdateButton";
            this.PUpdateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PUpdateButton.Size = new System.Drawing.Size(77, 36);
            this.PUpdateButton.TabIndex = 5;
            this.PUpdateButton.Text = "Update";
            this.PUpdateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PUpdateButton.UseAccentColor = false;
            this.PUpdateButton.UseVisualStyleBackColor = true;
            this.PUpdateButton.Click += new System.EventHandler(this.PUpdateButton_Click);
            // 
            // PAddButton
            // 
            this.PAddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PAddButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.PAddButton.Depth = 0;
            this.PAddButton.HighEmphasis = true;
            this.PAddButton.Icon = null;
            this.PAddButton.Location = new System.Drawing.Point(518, 16);
            this.PAddButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PAddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PAddButton.Name = "PAddButton";
            this.PAddButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PAddButton.Size = new System.Drawing.Size(64, 36);
            this.PAddButton.TabIndex = 4;
            this.PAddButton.Text = "Add";
            this.PAddButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PAddButton.UseAccentColor = false;
            this.PAddButton.UseVisualStyleBackColor = true;
            this.PAddButton.Click += new System.EventHandler(this.PAddButton_Click);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.AnimateReadOnly = false;
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTextBox.Depth = 0;
            this.PriceTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PriceTextBox.LeadingIcon = null;
            this.PriceTextBox.Location = new System.Drawing.Point(395, 16);
            this.PriceTextBox.MaxLength = 50;
            this.PriceTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PriceTextBox.Multiline = false;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 36);
            this.PriceTextBox.TabIndex = 3;
            this.PriceTextBox.Text = "";
            this.PriceTextBox.TrailingIcon = null;
            this.PriceTextBox.UseTallSize = false;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Depth = 0;
            this.PriceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PriceLabel.Location = new System.Drawing.Point(340, 16);
            this.PriceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(36, 19);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "Price";
            // 
            // PNameLabel
            // 
            this.PNameLabel.AutoSize = true;
            this.PNameLabel.Depth = 0;
            this.PNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PNameLabel.Location = new System.Drawing.Point(18, 19);
            this.PNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PNameLabel.Name = "PNameLabel";
            this.PNameLabel.Size = new System.Drawing.Size(102, 19);
            this.PNameLabel.TabIndex = 0;
            this.PNameLabel.Text = "Product Name";
            // 
            // BillPage
            // 
            this.BillPage.Controls.Add(this.BillProductsCB);
            this.BillPage.Controls.Add(this.FinishButton);
            this.BillPage.Controls.Add(this.BillDate);
            this.BillPage.Controls.Add(this.DateLabel);
            this.BillPage.Controls.Add(this.BillTotalButton);
            this.BillPage.Controls.Add(this.TotalLabel);
            this.BillPage.Controls.Add(this.CustNameTB);
            this.BillPage.Controls.Add(this.CustNameLabel);
            this.BillPage.Controls.Add(this.BillDGV);
            this.BillPage.Controls.Add(this.AddButton);
            this.BillPage.Controls.Add(this.BillQtTB);
            this.BillPage.Controls.Add(this.BillQtLabel);
            this.BillPage.Controls.Add(this.BillPriceTB);
            this.BillPage.Controls.Add(this.BillPriceLabel);
            this.BillPage.Controls.Add(this.BillPNameLabel);
            this.BillPage.ImageKey = "icons8-bill-24.png";
            this.BillPage.Location = new System.Drawing.Point(4, 31);
            this.BillPage.Name = "BillPage";
            this.BillPage.Padding = new System.Windows.Forms.Padding(3);
            this.BillPage.Size = new System.Drawing.Size(814, 498);
            this.BillPage.TabIndex = 1;
            this.BillPage.Text = "Bill";
            this.BillPage.UseVisualStyleBackColor = true;
            // 
            // BillProductsCB
            // 
            this.BillProductsCB.AutoResize = false;
            this.BillProductsCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BillProductsCB.Depth = 0;
            this.BillProductsCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.BillProductsCB.DropDownHeight = 174;
            this.BillProductsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BillProductsCB.DropDownWidth = 121;
            this.BillProductsCB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BillProductsCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BillProductsCB.FormattingEnabled = true;
            this.BillProductsCB.IntegralHeight = false;
            this.BillProductsCB.ItemHeight = 43;
            this.BillProductsCB.Location = new System.Drawing.Point(126, 19);
            this.BillProductsCB.MaxDropDownItems = 4;
            this.BillProductsCB.MouseState = MaterialSkin.MouseState.OUT;
            this.BillProductsCB.Name = "BillProductsCB";
            this.BillProductsCB.Size = new System.Drawing.Size(121, 49);
            this.BillProductsCB.StartIndex = 0;
            this.BillProductsCB.TabIndex = 17;
            this.BillProductsCB.SelectedIndexChanged += new System.EventHandler(this.BillProductsCB_SelectedIndexChanged);
            // 
            // FinishButton
            // 
            this.FinishButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FinishButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.FinishButton.Depth = 0;
            this.FinishButton.HighEmphasis = true;
            this.FinishButton.Icon = null;
            this.FinishButton.Location = new System.Drawing.Point(658, 448);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FinishButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.FinishButton.Size = new System.Drawing.Size(68, 36);
            this.FinishButton.TabIndex = 16;
            this.FinishButton.Text = "Finish";
            this.FinishButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.FinishButton.UseAccentColor = false;
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // BillDate
            // 
            this.BillDate.AnimateReadOnly = false;
            this.BillDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillDate.Depth = 0;
            this.BillDate.Enabled = false;
            this.BillDate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BillDate.LeadingIcon = null;
            this.BillDate.Location = new System.Drawing.Point(456, 456);
            this.BillDate.MaxLength = 50;
            this.BillDate.MouseState = MaterialSkin.MouseState.OUT;
            this.BillDate.Multiline = false;
            this.BillDate.Name = "BillDate";
            this.BillDate.Size = new System.Drawing.Size(128, 36);
            this.BillDate.TabIndex = 15;
            this.BillDate.Text = "";
            this.BillDate.TrailingIcon = null;
            this.BillDate.UseTallSize = false;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Depth = 0;
            this.DateLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DateLabel.Location = new System.Drawing.Point(499, 434);
            this.DateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(34, 19);
            this.DateLabel.TabIndex = 14;
            this.DateLabel.Text = "Date";
            // 
            // BillTotalButton
            // 
            this.BillTotalButton.AnimateReadOnly = false;
            this.BillTotalButton.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillTotalButton.Depth = 0;
            this.BillTotalButton.Enabled = false;
            this.BillTotalButton.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BillTotalButton.LeadingIcon = null;
            this.BillTotalButton.Location = new System.Drawing.Point(205, 456);
            this.BillTotalButton.MaxLength = 50;
            this.BillTotalButton.MouseState = MaterialSkin.MouseState.OUT;
            this.BillTotalButton.Multiline = false;
            this.BillTotalButton.Name = "BillTotalButton";
            this.BillTotalButton.Size = new System.Drawing.Size(174, 36);
            this.BillTotalButton.TabIndex = 13;
            this.BillTotalButton.Text = "";
            this.BillTotalButton.TrailingIcon = null;
            this.BillTotalButton.UseTallSize = false;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Depth = 0;
            this.TotalLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TotalLabel.Location = new System.Drawing.Point(249, 434);
            this.TotalLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(98, 19);
            this.TotalLabel.TabIndex = 12;
            this.TotalLabel.Text = "Total Amount";
            // 
            // CustNameTB
            // 
            this.CustNameTB.AnimateReadOnly = false;
            this.CustNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustNameTB.Depth = 0;
            this.CustNameTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CustNameTB.LeadingIcon = null;
            this.CustNameTB.Location = new System.Drawing.Point(17, 456);
            this.CustNameTB.MaxLength = 50;
            this.CustNameTB.MouseState = MaterialSkin.MouseState.OUT;
            this.CustNameTB.Multiline = false;
            this.CustNameTB.Name = "CustNameTB";
            this.CustNameTB.Size = new System.Drawing.Size(112, 36);
            this.CustNameTB.TabIndex = 11;
            this.CustNameTB.Text = "";
            this.CustNameTB.TrailingIcon = null;
            this.CustNameTB.UseTallSize = false;
            // 
            // CustNameLabel
            // 
            this.CustNameLabel.AutoSize = true;
            this.CustNameLabel.Depth = 0;
            this.CustNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CustNameLabel.Location = new System.Drawing.Point(18, 434);
            this.CustNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustNameLabel.Name = "CustNameLabel";
            this.CustNameLabel.Size = new System.Drawing.Size(115, 19);
            this.CustNameLabel.TabIndex = 10;
            this.CustNameLabel.Text = "Customer Name";
            // 
            // BillDGV
            // 
            this.BillDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillPNameCol,
            this.BillPriceCol,
            this.BillQtCol,
            this.BillTotalCol});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillDGV.DefaultCellStyle = dataGridViewCellStyle18;
            this.BillDGV.Location = new System.Drawing.Point(21, 83);
            this.BillDGV.Name = "BillDGV";
            this.BillDGV.Size = new System.Drawing.Size(727, 334);
            this.BillDGV.TabIndex = 9;
            this.BillDGV.SelectionChanged += new System.EventHandler(this.BillDGV_SelectionChanged);
            // 
            // BillPNameCol
            // 
            this.BillPNameCol.HeaderText = "Product Name";
            this.BillPNameCol.Name = "BillPNameCol";
            // 
            // BillPriceCol
            // 
            this.BillPriceCol.HeaderText = "Price";
            this.BillPriceCol.Name = "BillPriceCol";
            // 
            // BillQtCol
            // 
            this.BillQtCol.HeaderText = "Quantity";
            this.BillQtCol.Name = "BillQtCol";
            // 
            // BillTotalCol
            // 
            this.BillTotalCol.HeaderText = "Total Amount";
            this.BillTotalCol.Name = "BillTotalCol";
            // 
            // AddButton
            // 
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddButton.Depth = 0;
            this.AddButton.HighEmphasis = true;
            this.AddButton.Icon = null;
            this.AddButton.Location = new System.Drawing.Point(660, 22);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddButton.Name = "AddButton";
            this.AddButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddButton.Size = new System.Drawing.Size(64, 36);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddButton.UseAccentColor = false;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BillQtTB
            // 
            this.BillQtTB.AnimateReadOnly = false;
            this.BillQtTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillQtTB.Depth = 0;
            this.BillQtTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BillQtTB.LeadingIcon = null;
            this.BillQtTB.Location = new System.Drawing.Point(542, 20);
            this.BillQtTB.MaxLength = 50;
            this.BillQtTB.MouseState = MaterialSkin.MouseState.OUT;
            this.BillQtTB.Multiline = false;
            this.BillQtTB.Name = "BillQtTB";
            this.BillQtTB.Size = new System.Drawing.Size(100, 36);
            this.BillQtTB.TabIndex = 7;
            this.BillQtTB.Text = "";
            this.BillQtTB.TrailingIcon = null;
            this.BillQtTB.UseTallSize = false;
            // 
            // BillQtLabel
            // 
            this.BillQtLabel.AutoSize = true;
            this.BillQtLabel.Depth = 0;
            this.BillQtLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BillQtLabel.Location = new System.Drawing.Point(475, 31);
            this.BillQtLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BillQtLabel.Name = "BillQtLabel";
            this.BillQtLabel.Size = new System.Drawing.Size(61, 19);
            this.BillQtLabel.TabIndex = 6;
            this.BillQtLabel.Text = "Quantity";
            // 
            // BillPriceTB
            // 
            this.BillPriceTB.AnimateReadOnly = false;
            this.BillPriceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillPriceTB.Depth = 0;
            this.BillPriceTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BillPriceTB.LeadingIcon = null;
            this.BillPriceTB.Location = new System.Drawing.Point(353, 22);
            this.BillPriceTB.MaxLength = 50;
            this.BillPriceTB.MouseState = MaterialSkin.MouseState.OUT;
            this.BillPriceTB.Multiline = false;
            this.BillPriceTB.Name = "BillPriceTB";
            this.BillPriceTB.Size = new System.Drawing.Size(100, 36);
            this.BillPriceTB.TabIndex = 5;
            this.BillPriceTB.Text = "";
            this.BillPriceTB.TrailingIcon = null;
            this.BillPriceTB.UseTallSize = false;
            // 
            // BillPriceLabel
            // 
            this.BillPriceLabel.AutoSize = true;
            this.BillPriceLabel.Depth = 0;
            this.BillPriceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BillPriceLabel.Location = new System.Drawing.Point(311, 31);
            this.BillPriceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BillPriceLabel.Name = "BillPriceLabel";
            this.BillPriceLabel.Size = new System.Drawing.Size(36, 19);
            this.BillPriceLabel.TabIndex = 4;
            this.BillPriceLabel.Text = "Price";
            // 
            // BillPNameLabel
            // 
            this.BillPNameLabel.AutoSize = true;
            this.BillPNameLabel.Depth = 0;
            this.BillPNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BillPNameLabel.Location = new System.Drawing.Point(18, 31);
            this.BillPNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BillPNameLabel.Name = "BillPNameLabel";
            this.BillPNameLabel.Size = new System.Drawing.Size(102, 19);
            this.BillPNameLabel.TabIndex = 0;
            this.BillPNameLabel.Text = "Product Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.GreyAccentSwitch);
            this.tabPage3.Controls.Add(this.AmberAccentSwitch);
            this.tabPage3.Controls.Add(this.DPAccentSwitch);
            this.tabPage3.Controls.Add(this.BGSwitch);
            this.tabPage3.ImageKey = "icons8-settings-24.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(814, 498);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-bill-24.png");
            this.imageList1.Images.SetKeyName(1, "icons8-products-24.png");
            this.imageList1.Images.SetKeyName(2, "icons8-settings-24.png");
            // 
            // billingSystemDataSet
            // 
            this.billingSystemDataSet.DataSetName = "BillingSystemDataSet";
            this.billingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.billingSystemDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // BGSwitch
            // 
            this.BGSwitch.AutoSize = true;
            this.BGSwitch.Depth = 0;
            this.BGSwitch.Location = new System.Drawing.Point(20, 28);
            this.BGSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.BGSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.BGSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.BGSwitch.Name = "BGSwitch";
            this.BGSwitch.Ripple = true;
            this.BGSwitch.Size = new System.Drawing.Size(196, 37);
            this.BGSwitch.TabIndex = 0;
            this.BGSwitch.Text = "Background Theme";
            this.BGSwitch.UseVisualStyleBackColor = true;
            this.BGSwitch.CheckedChanged += new System.EventHandler(this.BGSwitch_CheckedChanged);
            // 
            // DPAccentSwitch
            // 
            this.DPAccentSwitch.AutoSize = true;
            this.DPAccentSwitch.Depth = 0;
            this.DPAccentSwitch.Location = new System.Drawing.Point(20, 87);
            this.DPAccentSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.DPAccentSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DPAccentSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.DPAccentSwitch.Name = "DPAccentSwitch";
            this.DPAccentSwitch.Ripple = true;
            this.DPAccentSwitch.Size = new System.Drawing.Size(195, 37);
            this.DPAccentSwitch.TabIndex = 1;
            this.DPAccentSwitch.Text = "Deep Purple Accent";
            this.DPAccentSwitch.UseVisualStyleBackColor = true;
            this.DPAccentSwitch.CheckedChanged += new System.EventHandler(this.DPAccentSwitch_CheckedChanged);
            // 
            // AmberAccentSwitch
            // 
            this.AmberAccentSwitch.AutoSize = true;
            this.AmberAccentSwitch.Depth = 0;
            this.AmberAccentSwitch.Location = new System.Drawing.Point(20, 149);
            this.AmberAccentSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.AmberAccentSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AmberAccentSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.AmberAccentSwitch.Name = "AmberAccentSwitch";
            this.AmberAccentSwitch.Ripple = true;
            this.AmberAccentSwitch.Size = new System.Drawing.Size(156, 37);
            this.AmberAccentSwitch.TabIndex = 2;
            this.AmberAccentSwitch.Text = "Amber Accent";
            this.AmberAccentSwitch.UseVisualStyleBackColor = true;
            this.AmberAccentSwitch.CheckedChanged += new System.EventHandler(this.AmberAccentSwitch_CheckedChanged);
            // 
            // GreyAccentSwitch
            // 
            this.GreyAccentSwitch.AutoSize = true;
            this.GreyAccentSwitch.Depth = 0;
            this.GreyAccentSwitch.Location = new System.Drawing.Point(20, 213);
            this.GreyAccentSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.GreyAccentSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.GreyAccentSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.GreyAccentSwitch.Name = "GreyAccentSwitch";
            this.GreyAccentSwitch.Ripple = true;
            this.GreyAccentSwitch.Size = new System.Drawing.Size(142, 37);
            this.GreyAccentSwitch.TabIndex = 3;
            this.GreyAccentSwitch.Text = "Grey Accent";
            this.GreyAccentSwitch.UseVisualStyleBackColor = true;
            this.GreyAccentSwitch.CheckedChanged += new System.EventHandler(this.GreyAccentSwitch_CheckedChanged);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 600);
            this.Controls.Add(this.TabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabControl;
            this.MaximizeBox = false;
            this.Name = "ProductsForm";
            this.Sizable = false;
            this.Text = "Billing System";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.BillPage.ResumeLayout(false);
            this.BillPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage BillPage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialLabel PNameLabel;
        private MaterialSkin.Controls.MaterialTextBox PriceTextBox;
        private MaterialSkin.Controls.MaterialLabel PriceLabel;
        private MaterialSkin.Controls.MaterialButton PAddButton;
        private MaterialSkin.Controls.MaterialButton PUpdateButton;
        private MaterialSkin.Controls.MaterialButton DeleteButton;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPrice;
        private BillingSystemDataSet billingSystemDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private BillingSystemDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private MaterialSkin.Controls.MaterialTextBox PNameTextBox;
        private MaterialSkin.Controls.MaterialLabel BillPNameLabel;
        private MaterialSkin.Controls.MaterialTextBox BillQtTB;
        private MaterialSkin.Controls.MaterialLabel BillQtLabel;
        private MaterialSkin.Controls.MaterialTextBox BillPriceTB;
        private MaterialSkin.Controls.MaterialLabel BillPriceLabel;
        private MaterialSkin.Controls.MaterialButton AddButton;
        private System.Windows.Forms.DataGridView BillDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillPNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillQtCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTotalCol;
        private MaterialSkin.Controls.MaterialTextBox CustNameTB;
        private MaterialSkin.Controls.MaterialLabel CustNameLabel;
        private MaterialSkin.Controls.MaterialTextBox BillDate;
        private MaterialSkin.Controls.MaterialLabel DateLabel;
        private MaterialSkin.Controls.MaterialTextBox BillTotalButton;
        private MaterialSkin.Controls.MaterialLabel TotalLabel;
        private MaterialSkin.Controls.MaterialButton FinishButton;
        private MaterialSkin.Controls.MaterialComboBox BillProductsCB;
        private MaterialSkin.Controls.MaterialSwitch BGSwitch;
        private MaterialSkin.Controls.MaterialSwitch GreyAccentSwitch;
        private MaterialSkin.Controls.MaterialSwitch AmberAccentSwitch;
        private MaterialSkin.Controls.MaterialSwitch DPAccentSwitch;
    }
}