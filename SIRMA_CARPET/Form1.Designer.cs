namespace SIRMA_CARPET
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.siparisler_buton = new DevExpress.XtraBars.BarButtonItem();
            this.barkod_buton = new DevExpress.XtraBars.BarButtonItem();
            this.raporlar_buton = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            //this.ribbonControl1.SearchEditItem,
            this.siparisler_buton,
            this.barkod_buton,
            this.raporlar_buton});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1473, 189);
            // 
            // siparisler_buton
            // 
            this.siparisler_buton.Caption = "SİPARİŞLER";
            this.siparisler_buton.Id = 1;
            this.siparisler_buton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("siparisler_buton.ImageOptions.Image")));
            this.siparisler_buton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("siparisler_buton.ImageOptions.LargeImage")));
            this.siparisler_buton.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisler_buton.ItemAppearance.Normal.Options.UseFont = true;
            this.siparisler_buton.Name = "siparisler_buton";
            this.siparisler_buton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.siparisler_buton_ItemClick);
            // 
            // barkod_buton
            // 
            this.barkod_buton.Caption = "BARKOD";
            this.barkod_buton.Id = 2;
            this.barkod_buton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barkod_buton.ImageOptions.Image")));
            this.barkod_buton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barkod_buton.ImageOptions.LargeImage")));
            this.barkod_buton.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkod_buton.ItemAppearance.Normal.Options.UseFont = true;
            this.barkod_buton.Name = "barkod_buton";
            this.barkod_buton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barkod_buton_ItemClick);
            // 
            // raporlar_buton
            // 
            this.raporlar_buton.Caption = "RAPORLAR";
            this.raporlar_buton.Id = 3;
            this.raporlar_buton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("raporlar_buton.ImageOptions.Image")));
            this.raporlar_buton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("raporlar_buton.ImageOptions.LargeImage")));
            this.raporlar_buton.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporlar_buton.ItemAppearance.Normal.Options.UseFont = true;
            this.raporlar_buton.Name = "raporlar_buton";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "SIRMA ";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.ItemLinks.Add(this.siparisler_buton);
            this.ribbonPageGroup.ItemLinks.Add(this.barkod_buton);
            this.ribbonPageGroup.ItemLinks.Add(this.raporlar_buton);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 864);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem siparisler_buton;
        private DevExpress.XtraBars.BarButtonItem barkod_buton;
        private DevExpress.XtraBars.BarButtonItem raporlar_buton;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

