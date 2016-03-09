namespace KartuStockAccess
{
    partial class ProductManagement
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
            System.Windows.Forms.Label iDProdukLabel;
            System.Windows.Forms.Label namaProdukLabel;
            System.Windows.Forms.Label jenisProdukLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label qtyGLabel;
            System.Windows.Forms.Label hargaJualLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagement));
            this.database2DataSet = new KartuStockAccess.Database2DataSet();
            this.produkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produkTableAdapter = new KartuStockAccess.Database2DataSetTableAdapters.ProdukTableAdapter();
            this.tableAdapterManager = new KartuStockAccess.Database2DataSetTableAdapters.TableAdapterManager();
            this.produkBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.produkBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.produkDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JenisProduk = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDProdukTextBox = new System.Windows.Forms.TextBox();
            this.namaProdukTextBox = new System.Windows.Forms.TextBox();
            this.jenisProdukTextBox = new System.Windows.Forms.TextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.qtyGTextBox = new System.Windows.Forms.TextBox();
            this.hargaJualTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            iDProdukLabel = new System.Windows.Forms.Label();
            namaProdukLabel = new System.Windows.Forms.Label();
            jenisProdukLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            qtyGLabel = new System.Windows.Forms.Label();
            hargaJualLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkBindingNavigator)).BeginInit();
            this.produkBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produkDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDProdukLabel
            // 
            iDProdukLabel.AutoSize = true;
            iDProdukLabel.Location = new System.Drawing.Point(16, 37);
            iDProdukLabel.Name = "iDProdukLabel";
            iDProdukLabel.Size = new System.Drawing.Size(55, 13);
            iDProdukLabel.TabIndex = 2;
            iDProdukLabel.Text = "IDProduk:";
            // 
            // namaProdukLabel
            // 
            namaProdukLabel.AutoSize = true;
            namaProdukLabel.Location = new System.Drawing.Point(16, 63);
            namaProdukLabel.Name = "namaProdukLabel";
            namaProdukLabel.Size = new System.Drawing.Size(75, 13);
            namaProdukLabel.TabIndex = 4;
            namaProdukLabel.Text = "Nama Produk:";
            // 
            // jenisProdukLabel
            // 
            jenisProdukLabel.AutoSize = true;
            jenisProdukLabel.Location = new System.Drawing.Point(16, 89);
            jenisProdukLabel.Name = "jenisProdukLabel";
            jenisProdukLabel.Size = new System.Drawing.Size(71, 13);
            jenisProdukLabel.TabIndex = 6;
            jenisProdukLabel.Text = "Jenis Produk:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(16, 115);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(90, 13);
            qtyLabel.TabIndex = 8;
            qtyLabel.Text = "Quantity Gudang:";
            // 
            // qtyGLabel
            // 
            qtyGLabel.AutoSize = true;
            qtyGLabel.Location = new System.Drawing.Point(16, 141);
            qtyGLabel.Name = "qtyGLabel";
            qtyGLabel.Size = new System.Drawing.Size(91, 13);
            qtyGLabel.TabIndex = 10;
            qtyGLabel.Text = "Quantity Exibition:";
            // 
            // hargaJualLabel
            // 
            hargaJualLabel.AutoSize = true;
            hargaJualLabel.Location = new System.Drawing.Point(16, 167);
            hargaJualLabel.Name = "hargaJualLabel";
            hargaJualLabel.Size = new System.Drawing.Size(61, 13);
            hargaJualLabel.TabIndex = 12;
            hargaJualLabel.Text = "Harga Jual:";
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produkBindingSource
            // 
            this.produkBindingSource.DataMember = "Produk";
            this.produkBindingSource.DataSource = this.database2DataSet;
            // 
            // produkTableAdapter
            // 
            this.produkTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DetailPembelianTableAdapter = null;
            this.tableAdapterManager.PembelianTableAdapter = null;
            this.tableAdapterManager.ProdukTableAdapter = this.produkTableAdapter;
            this.tableAdapterManager.UpdateOrder = KartuStockAccess.Database2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // produkBindingNavigator
            // 
            this.produkBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produkBindingNavigator.BindingSource = this.produkBindingSource;
            this.produkBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produkBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produkBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.produkBindingNavigatorSaveItem});
            this.produkBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produkBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produkBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produkBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produkBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produkBindingNavigator.Name = "produkBindingNavigator";
            this.produkBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produkBindingNavigator.Size = new System.Drawing.Size(796, 25);
            this.produkBindingNavigator.TabIndex = 0;
            this.produkBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // produkBindingNavigatorSaveItem
            // 
            this.produkBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produkBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produkBindingNavigatorSaveItem.Image")));
            this.produkBindingNavigatorSaveItem.Name = "produkBindingNavigatorSaveItem";
            this.produkBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produkBindingNavigatorSaveItem.Text = "Save Data";
            this.produkBindingNavigatorSaveItem.Click += new System.EventHandler(this.produkBindingNavigatorSaveItem_Click_1);
            // 
            // produkDataGridView
            // 
            this.produkDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.produkDataGridView.AutoGenerateColumns = false;
            this.produkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3,
            this.JenisProduk});
            this.produkDataGridView.DataSource = this.produkBindingSource;
            this.produkDataGridView.Location = new System.Drawing.Point(12, 49);
            this.produkDataGridView.Name = "produkDataGridView";
            this.produkDataGridView.Size = new System.Drawing.Size(752, 291);
            this.produkDataGridView.TabIndex = 1;
            this.produkDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.produkDataGridView_CellValueChanged);
            this.produkDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.produkDataGridView_EditingControlShowing);
            this.produkDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.produkDataGridView_KeyPress);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDProduk";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDProduk";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NamaProduk";
            this.dataGridViewTextBoxColumn2.HeaderText = "NamaProduk";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "qty";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity Gudang";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "qtyG";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity Exibition";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HargaJual";
            this.dataGridViewTextBoxColumn6.HeaderText = "HargaJual";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "JenisProduk";
            this.dataGridViewTextBoxColumn3.HeaderText = "JenisProduk";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // JenisProduk
            // 
            this.JenisProduk.DataPropertyName = "JenisProduk";
            this.JenisProduk.HeaderText = "JenisProduk";
            this.JenisProduk.Name = "JenisProduk";
            // 
            // iDProdukTextBox
            // 
            this.iDProdukTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produkBindingSource, "IDProduk", true));
            this.iDProdukTextBox.Enabled = false;
            this.iDProdukTextBox.Location = new System.Drawing.Point(128, 34);
            this.iDProdukTextBox.Name = "iDProdukTextBox";
            this.iDProdukTextBox.Size = new System.Drawing.Size(202, 20);
            this.iDProdukTextBox.TabIndex = 3;
            // 
            // namaProdukTextBox
            // 
            this.namaProdukTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produkBindingSource, "NamaProduk", true));
            this.namaProdukTextBox.Enabled = false;
            this.namaProdukTextBox.Location = new System.Drawing.Point(128, 60);
            this.namaProdukTextBox.Name = "namaProdukTextBox";
            this.namaProdukTextBox.Size = new System.Drawing.Size(202, 20);
            this.namaProdukTextBox.TabIndex = 5;
            // 
            // jenisProdukTextBox
            // 
            this.jenisProdukTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produkBindingSource, "JenisProduk", true));
            this.jenisProdukTextBox.Enabled = false;
            this.jenisProdukTextBox.Location = new System.Drawing.Point(128, 86);
            this.jenisProdukTextBox.Name = "jenisProdukTextBox";
            this.jenisProdukTextBox.Size = new System.Drawing.Size(202, 20);
            this.jenisProdukTextBox.TabIndex = 7;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produkBindingSource, "qty", true));
            this.qtyTextBox.Enabled = false;
            this.qtyTextBox.Location = new System.Drawing.Point(128, 112);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(202, 20);
            this.qtyTextBox.TabIndex = 9;
            // 
            // qtyGTextBox
            // 
            this.qtyGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produkBindingSource, "qtyG", true));
            this.qtyGTextBox.Enabled = false;
            this.qtyGTextBox.Location = new System.Drawing.Point(128, 138);
            this.qtyGTextBox.Name = "qtyGTextBox";
            this.qtyGTextBox.Size = new System.Drawing.Size(202, 20);
            this.qtyGTextBox.TabIndex = 11;
            // 
            // hargaJualTextBox
            // 
            this.hargaJualTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produkBindingSource, "HargaJual", true));
            this.hargaJualTextBox.Enabled = false;
            this.hargaJualTextBox.Location = new System.Drawing.Point(128, 164);
            this.hargaJualTextBox.Name = "hargaJualTextBox";
            this.hargaJualTextBox.Size = new System.Drawing.Size(202, 20);
            this.hargaJualTextBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(namaProdukLabel);
            this.groupBox1.Controls.Add(iDProdukLabel);
            this.groupBox1.Controls.Add(this.hargaJualTextBox);
            this.groupBox1.Controls.Add(this.iDProdukTextBox);
            this.groupBox1.Controls.Add(hargaJualLabel);
            this.groupBox1.Controls.Add(this.qtyGTextBox);
            this.groupBox1.Controls.Add(this.namaProdukTextBox);
            this.groupBox1.Controls.Add(qtyGLabel);
            this.groupBox1.Controls.Add(jenisProdukLabel);
            this.groupBox1.Controls.Add(this.qtyTextBox);
            this.groupBox1.Controls.Add(this.jenisProdukTextBox);
            this.groupBox1.Controls.Add(qtyLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 205);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Produk";
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.produkDataGridView);
            this.Controls.Add(this.produkBindingNavigator);
            this.Name = "ProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductManagement";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkBindingNavigator)).EndInit();
            this.produkBindingNavigator.ResumeLayout(false);
            this.produkBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produkDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource produkBindingSource;
        private Database2DataSetTableAdapters.ProdukTableAdapter produkTableAdapter;
        private Database2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produkBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton produkBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView produkDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn JenisProduk;
        private System.Windows.Forms.TextBox iDProdukTextBox;
        private System.Windows.Forms.TextBox namaProdukTextBox;
        private System.Windows.Forms.TextBox jenisProdukTextBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox qtyGTextBox;
        private System.Windows.Forms.TextBox hargaJualTextBox;
        private System.Windows.Forms.GroupBox groupBox1;



    }
}