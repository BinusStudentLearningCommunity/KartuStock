namespace KartuStockAccess
{
    partial class ReporthargaJual
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProdukBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database2DataSet = new KartuStockAccess.Database2DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProdukTableAdapter = new KartuStockAccess.Database2DataSetTableAdapters.ProdukTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProdukBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdukBindingSource
            // 
            this.ProdukBindingSource.DataMember = "Produk";
            this.ProdukBindingSource.DataSource = this.Database2DataSet;
            // 
            // Database2DataSet
            // 
            this.Database2DataSet.DataSetName = "Database2DataSet";
            this.Database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProdukBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KartuStockAccess.ReportHarga.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(735, 506);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProdukTableAdapter
            // 
            this.ProdukTableAdapter.ClearBeforeFill = true;
            // 
            // ReporthargaJual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 506);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporthargaJual";
            this.Text = "ReporthargaJual";
            this.Load += new System.EventHandler(this.ReporthargaJual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdukBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProdukBindingSource;
        private Database2DataSet Database2DataSet;
        private Database2DataSetTableAdapters.ProdukTableAdapter ProdukTableAdapter;
    }
}