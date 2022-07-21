namespace SIRMA_CARPET
{
    partial class Barkod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barkod));
            DevExpress.XtraPrinting.BarCode.UPCAGenerator upcaGenerator1 = new DevExpress.XtraPrinting.BarCode.UPCAGenerator();
            DevExpress.XtraPrinting.BarCode.EAN13Generator eaN13Generator1 = new DevExpress.XtraPrinting.BarCode.EAN13Generator();
            this.konfeksiyon_grid = new DevExpress.XtraGrid.GridControl();
            this.barcodes_view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.upca_text_edit = new DevExpress.XtraEditors.TextEdit();
            this.ean13_text_edit = new DevExpress.XtraEditors.TextEdit();
            this.UPCA_label = new DevExpress.XtraEditors.LabelControl();
            this.ean13_label = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.siparis_grid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barCodeControl1 = new DevExpress.XtraEditors.BarCodeControl();
            this.barCodeControl2 = new DevExpress.XtraEditors.BarCodeControl();
            ((System.ComponentModel.ISupportInitialize)(this.konfeksiyon_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodes_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upca_text_edit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ean13_text_edit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparis_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // konfeksiyon_grid
            // 
            this.konfeksiyon_grid.Location = new System.Drawing.Point(3, 202);
            this.konfeksiyon_grid.MainView = this.barcodes_view;
            this.konfeksiyon_grid.Name = "konfeksiyon_grid";
            this.konfeksiyon_grid.Size = new System.Drawing.Size(909, 429);
            this.konfeksiyon_grid.TabIndex = 1;
            this.konfeksiyon_grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.barcodes_view});
            // 
            // barcodes_view
            // 
            this.barcodes_view.GridControl = this.konfeksiyon_grid;
            this.barcodes_view.Name = "barcodes_view";
            this.barcodes_view.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.barcodes_view_FocusedRowChanged);
            // 
            // upca_text_edit
            // 
            this.upca_text_edit.Location = new System.Drawing.Point(283, 253);
            this.upca_text_edit.Name = "upca_text_edit";
            this.upca_text_edit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.upca_text_edit.Properties.Appearance.Options.UseFont = true;
            this.upca_text_edit.Size = new System.Drawing.Size(215, 34);
            this.upca_text_edit.TabIndex = 2;
            // 
            // ean13_text_edit
            // 
            this.ean13_text_edit.Location = new System.Drawing.Point(283, 318);
            this.ean13_text_edit.Name = "ean13_text_edit";
            this.ean13_text_edit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ean13_text_edit.Properties.Appearance.Options.UseFont = true;
            this.ean13_text_edit.Size = new System.Drawing.Size(215, 34);
            this.ean13_text_edit.TabIndex = 3;
            // 
            // UPCA_label
            // 
            this.UPCA_label.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UPCA_label.Appearance.Options.UseFont = true;
            this.UPCA_label.Location = new System.Drawing.Point(64, 259);
            this.UPCA_label.Name = "UPCA_label";
            this.UPCA_label.Size = new System.Drawing.Size(204, 28);
            this.UPCA_label.TabIndex = 4;
            this.UPCA_label.Text = "UPCA BRAKOD NO :";
            // 
            // ean13_label
            // 
            this.ean13_label.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ean13_label.Appearance.Options.UseFont = true;
            this.ean13_label.Location = new System.Drawing.Point(54, 321);
            this.ean13_label.Name = "ean13_label";
            this.ean13_label.Size = new System.Drawing.Size(223, 28);
            this.ean13_label.TabIndex = 5;
            this.ean13_label.Text = "EAN13 BARKOD NO : ";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.ean13_text_edit);
            this.groupControl1.Controls.Add(this.UPCA_label);
            this.groupControl1.Controls.Add(this.ean13_label);
            this.groupControl1.Controls.Add(this.upca_text_edit);
            this.groupControl1.Location = new System.Drawing.Point(918, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(554, 632);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Barkod Oluştur";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(283, 386);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(215, 39);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Oluştur";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, -1);
            this.gridControl1.MainView = this.siparis_grid;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(370, 197);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.siparis_grid});
            // 
            // siparis_grid
            // 
            this.siparis_grid.GridControl = this.gridControl1;
            this.siparis_grid.Name = "siparis_grid";
            this.siparis_grid.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.siparis_grid_FocusedRowChanged);
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.Location = new System.Drawing.Point(379, -1);
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControl1.Size = new System.Drawing.Size(257, 197);
            this.barCodeControl1.Symbology = upcaGenerator1;
            this.barCodeControl1.TabIndex = 8;
            this.barCodeControl1.Text = "169010000";
            // 
            // barCodeControl2
            // 
            this.barCodeControl2.Location = new System.Drawing.Point(655, -1);
            this.barCodeControl2.Name = "barCodeControl2";
            this.barCodeControl2.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControl2.Size = new System.Drawing.Size(257, 197);
            this.barCodeControl2.Symbology = eaN13Generator1;
            this.barCodeControl2.TabIndex = 9;
            this.barCodeControl2.Text = "869169010000";
            // 
            // Barkod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 633);
            this.Controls.Add(this.barCodeControl2);
            this.Controls.Add(this.barCodeControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.konfeksiyon_grid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Barkod";
            this.Text = "Barkod";
            this.Load += new System.EventHandler(this.Barkod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.konfeksiyon_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodes_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upca_text_edit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ean13_text_edit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparis_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl konfeksiyon_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView barcodes_view;
        private DevExpress.XtraEditors.TextEdit upca_text_edit;
        private DevExpress.XtraEditors.TextEdit ean13_text_edit;
        private DevExpress.XtraEditors.LabelControl UPCA_label;
        private DevExpress.XtraEditors.LabelControl ean13_label;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView siparis_grid;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl1;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl2;
    }
}