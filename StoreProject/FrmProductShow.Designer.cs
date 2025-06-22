namespace StoreProject
{
    partial class FrmProductShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductShow));
            this.label1 = new System.Windows.Forms.Label();
            this.lvAllProduct = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFrmProductCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(751, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "บริหารจัดการข้อมูลสินค้า";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvAllProduct
            // 
            this.lvAllProduct.HideSelection = false;
            this.lvAllProduct.Location = new System.Drawing.Point(30, 79);
            this.lvAllProduct.Name = "lvAllProduct";
            this.lvAllProduct.Size = new System.Drawing.Size(746, 201);
            this.lvAllProduct.TabIndex = 1;
            this.lvAllProduct.UseCompatibleStateImageBehavior = false;
            this.lvAllProduct.ItemActivate += new System.EventHandler(this.lvAllProduct_ItemActivate);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(486, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "*เมื่อต้องการแก้ไข หรือ ลบข้อมูลสินค้า ให้ดับเบิ้ลคลิกที่สินค้า";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFrmProductCreate
            // 
            this.btnFrmProductCreate.Image = global::StoreProject.Properties.Resources.basket;
            this.btnFrmProductCreate.Location = new System.Drawing.Point(637, 295);
            this.btnFrmProductCreate.Name = "btnFrmProductCreate";
            this.btnFrmProductCreate.Size = new System.Drawing.Size(139, 38);
            this.btnFrmProductCreate.TabIndex = 2;
            this.btnFrmProductCreate.Text = "เพิ่มข้อมูลสินค้า";
            this.btnFrmProductCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFrmProductCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFrmProductCreate.UseVisualStyleBackColor = true;
            this.btnFrmProductCreate.Click += new System.EventHandler(this.btnFrmProductCreate_Click);
            // 
            // FrmProductShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFrmProductCreate);
            this.Controls.Add(this.lvAllProduct);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmProductShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "บริหารจัดการข้อมูลสินค้า";
            this.Load += new System.EventHandler(this.FrmProductShow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvAllProduct;
        private System.Windows.Forms.Button btnFrmProductCreate;
        private System.Windows.Forms.Label label2;
    }
}